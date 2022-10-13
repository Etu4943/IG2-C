#include <unistd.h>
#include <stdio.h>
#include <stdlib.h>

void fils1 (void) {
        int pid = getpid();
        printf("PID %d - Debut du Fils 1[PPID %d]\n", pid, getppid());
        int i = 1;
        while(i <= 10){
                printf("Message %d du fils 1\n",i );
                sleep(1);
                i++;
        }
        printf("PID %d - Fin du Fils 1\n", pid);
        exit(EXIT_SUCCESS);
}

void fils2 (void) {
        int pid = getpid();
        printf("PID %d - Debut du Fils 1[PPID %d]\n", pid, getppid());
        int i = 1;
        while(i <= 10){
                printf("Message %d du fils 2\n",i );
                sleep(2);
                i++;
        }
        printf("PID %d - Fin du Fils 2\n", pid);
        exit(EXIT_SUCCESS);
}

int main (void) {
        int pid1;
        int pid2;
        int pidP = getpid();

        printf("PID %d - Debut du Pere\n", pidP);

        pid1 = fork();
        if(pid1 == 0)
                fils1();
        pid2 = fork();
        if(pid2 == 0)
                fils2();

        wait();
        wait();
        printf("PID %d - Fin du Pere\n", pidP);
}
