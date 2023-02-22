#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/wait.h>
#include <string.h>

int pidP, pid1, pid2;

void fils1(void){
	/* Dans le fils 1 */
	int i;
	pid1 = getpid(); // il est à 0 quand on entre dans le fils donc il faut le mettre à jour
	printf("PID %d - Debut du premier fils [PPID %d]\n", pid1, pidP);
	for (i = 1; i <= 10; i++) {
		printf("PID %d - Message %d du premier fils -\n", pid1, i);
		sleep(1);
	}
	printf("PID %d - Fin du premier fils\n", pid1);
	exit(EXIT_SUCCESS);
}

void fils2(void){
	/* Dans le fils 2 */
	int i;
	pid2 = getpid();// il est à 0 quand on entre dans le fils donc il faut le mettre à jour
	printf("PID %d - Debut du second fils [PPID %d]\n", pid2, pidP);
	for (i = 1; i <= 10; i ++) {
		printf("PID %d - Message %d du second fils --\n", pid2, i);
		sleep(2);
	}
	printf("PID %d - Fin du second fils\n", pid2);
	exit(EXIT_SUCCESS);
}

void pere(void){
	/* Dans le pere */
	int finishedPid;
	int status;
	printf("PID %d - Le PID du Fils 1 est %d\n", pidP, pid1);
	printf("PID %d - Le PID du Fils 2 est %d\n", pidP, pid2);
	printf("PID %d - Le Pere attend son Fils 1 [PID %d]\n", pidP, pid1);
	finishedPid = wait(&status);
	if (finishedPid < 0) {
		perror("Erreur lors du wait\n");
		exit(EXIT_FAILURE);
	}
	printf("PID %d - Le Fils 1 [PID %d] s'est termine avec le statut %04.4X\n",
	pidP, finishedPid, status);
	printf("PID %d - Le Pere attend son Fils 2 [PID %d]\n", pidP, pid2);
	finishedPid = wait(&status);
	if (finishedPid < 0) {
		perror("Erreur lors du wait\n");
		exit(EXIT_FAILURE);
	}
	printf("PID %d - Le Fils 2 [PID %d] s'est termine avec le statut %04.4X\n",
	pidP, finishedPid, status);
	printf("PID %d - Fin du Pere\n", pidP);
	exit (EXIT_SUCCESS);
}

int main(void) {
	int status;
	pidP = getpid();
	printf("PID %d - Debut du Pere\n", pidP);
	if ((pid1 = fork()) < 0){
		perror("Erreur lors du fork du fils 1");
		exit (EXIT_FAILURE);
	}
	if (pid1 == 0) 
		fils1();
	if ((pid2 = fork()) < 0) {
		perror("Erreur lors du fork du fils 2");
		exit(EXIT_FAILURE);
	}
	if (pid2 == 0) 
		fils2();

	// Suite du père.
	// Le fils n’exécute jamais ce code grâce à son exit
	pere();
}
