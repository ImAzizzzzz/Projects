#include <stdio.h>
#include <conio.h>
#include <ctype.h>
#include <stdlib.h>
#include <string.h>

void show_record();
void reset_score();
void help();
void edit_score(float, char[]);
void display_welcome_message();
void display_game_instructions(char playername[]);
void warmup_round(int *count);
void challenge_round(int *countr);
void play_game(char playername[]);

int main() {
    char choice;
    char playername[20];

    while (1) {
        display_welcome_message();
        choice = toupper(getch());

        if (choice == 'V') {
            show_record();
        } else if (choice == 'H') {
            help();
            getch();
        } else if (choice == 'R') {
            reset_score();
            getch();
        } else if (choice == 'Q') {
            exit(0);
        } else if (choice == 'S') {
            system("cls");
            printf("\n\n\n\n\n\n\n\n\n\n\t\t\tRegister your name: ");
            gets(playername);
            display_game_instructions(playername);
            play_game(playername);
        }
    }
}

void display_welcome_message() {
    system("cls");
    printf("\t\t\tC PROGRAM QUIZ GAME\n");
    printf("\n\t\t________________________________________");
    printf("\n\t\t\t   WELCOME ");
    printf("\n\t\t\t      to ");
    printf("\n\t\t\t   THE GAME ");
    printf("\n\t\t________________________________________");
    printf("\n\t\t   BECOME A MILLIONAIRE!!!!!!!!!!!    \n");
    printf("\n\t\t > Press S to start the game");
    printf("\n\t\t > Press V to view the highest score  ");
    printf("\n\t\t > Press R to reset score");
    printf("\n\t\t > Press H for help            ");
    printf("\n\t\t > Press Q to quit             ");
    printf("\n\t\t________________________________________\n\n");
}

void display_game_instructions(char playername[]) {
    system("cls");
    printf("\n ------------------  Welcome %s to C Program Quiz Game --------------------------", playername);
    printf("\n\n Here are some tips you might wanna know before playing:");
    printf("\n -------------------------------------------------------------------------");
    printf("\n >> There are 2 rounds in this Quiz Game, WARMUP ROUND & CHALLENGE ROUND");
    printf("\n >> In warmup round you will be asked a total of 3 questions to test your");
    printf("\n    general knowledge. You are eligible to play the game if you give at least 2");
    printf("\n    right answers, otherwise you can't proceed further to the Challenge Round.");
    printf("\n >> Your game starts with CHALLENGE ROUND. In this round you will be asked a");
    printf("\n    total of 10 questions. Each right answer will be awarded $100,000!");
    printf("\n    By this way you can win up to ONE MILLION cash prize!!!!!..........");
    printf("\n >> You will be given 4 options and you have to press A, B, C or D for the");
    printf("\n    right option.");
    printf("\n >> You will be asked questions continuously, till right answers are given");
    printf("\n >> No negative marking for wrong answers!");
    printf("\n\n\t!!!!!!!!!!!!! ALL THE BEST !!!!!!!!!!!!!");
    printf("\n\n\n Press Y to start the game!\n");
    printf("\n Press any other key to return to the main menu!");
}

void warmup_round(int *count) {
    int i;
    int r1;
    *count = 0;

    for (i = 1; i <= 3; i++) {
        system("cls");
        r1 = i;

        switch (r1) {
            case 1:
                printf("\n\nWhich of the following is a Palindrome number?");
                printf("\n\nA.42042\t\tB.101010\n\nC.23232\t\tD.01234");
                if (toupper(getch()) == 'C') {
                    printf("\n\nCorrect!!!");
                    (*count)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is C.23232");
                }
                getch();
                break;

            case 2:
                printf("\n\n\nThe country with the highest environmental performance index is...");
                printf("\n\nA.France\t\tB.Denmark\n\nC.Switzerland\t\tD.Finland");
                if (toupper(getch()) == 'C') {
                    printf("\n\nCorrect!!!");
                    (*count)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is C.Switzerland");
                }
                getch();
                break;

            case 3:
                printf("\n\n\nWhich animal laughs like human being?");
                printf("\n\nA.Polar Bear\t\tB.Hyena\n\nC.Donkey\t\tD.Chimpanzee");
                if (toupper(getch()) == 'B') {
                    printf("\n\nCorrect!!!");
                    (*count)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is B.Hyena");
                }
                getch();
                break;
        }
    }
}

void challenge_round(int *countr) {
    int i;
    int r;
    *countr = 0;

    for (i = 1; i <= 10; i++) {
        system("cls");
        r = i;

        switch (r) {
            case 1:
                printf("\n\nWhat is the National Game of England?");
                printf("\n\nA.Football\t\tB.Basketball\n\nC.Cricket\t\tD.Baseball");
                if (toupper(getch()) == 'C') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is C.Cricket");
                }
                getch();
                break;

            case 2:
                printf("\n\n\nStudy of Earthquake is called............,");
                printf("\n\nA.Seismology\t\tB.Cosmology\n\nC.Orology\t\tD.Etimology");
                if (toupper(getch()) == 'A') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is A.Seismology");
                }
                getch();
                break;

            case 3:
                printf("\n\n\nAmong the top 10 highest peaks in the world, how many lie in Nepal? ");
                printf("\n\nA.6\t\tB.7\n\nC.8\t\tD.9");
                if (toupper(getch()) == 'C') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is C.8");
                }
                getch();
                break;

            case 4:
                printf("\n\n\nThe Laws of Electromagnetic Induction were given by?");
                printf("\n\nA.Faraday\t\tB.Tesla\n\nC.Maxwell\t\tD.Coulomb");
                if (toupper(getch()) == 'A') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is A.Faraday");
                }
                getch();
                break;

            case 5:
                printf("\n\n\nIn what unit is electric power measured?");
                printf("\n\nA.Coulomb\t\tB.Watt\n\nC.Power\t\tD.Units");
                if (toupper(getch()) == 'B') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is B.Watt");
                }
                getch();
                break;

            case 6:
                printf("\n\n\nWhich element is found in Vitamin B12?");
                printf("\n\nA.Zinc\t\tB.Cobalt\n\nC.Calcium\t\tD.Iron");
                if (toupper(getch()) == 'B') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is B.Cobalt");
                }
                getch();
                break;

            case 7:
                printf("\n\n\nWhat is the National Name of Japan?");
                printf("\n\nA.Polska\t\tB.Hellas\n\nC.Drukyul\t\tD.Nippon");
                if (toupper(getch()) == 'D') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is D.Nippon");
                }
                getch();
                break;

            case 8:
                printf("\n\n\nHow many times a piece of paper can be folded at the most?");
                printf("\n\nA.6\t\tB.7\n\nC.8\t\tD.Depends on the size of paper");
                if (toupper(getch()) == 'B') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is B.7");
                }
                getch();
                break;

            case 9:
                printf("\n\n\nWhat is the capital of Denmark ?");
                printf("\n\nA.Copenhagen\t\tB.Helsinki\n\nC.Ajax\t\tD.Galatasaray");
                if (toupper(getch()) == 'A') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is A.Copenhagen");
                }
                getch();
                break;

            case 10:
                printf("\n\n\nWhich is the longest River in the world?");
                printf("\n\nA.Nile\t\tB.Koshi\n\nC.Ganga\t\tD.Amazon");
                if (toupper(getch()) == 'A') {
                    printf("\n\nCorrect!!!");
                    (*countr)++;
                } else {
                    printf("\n\nWrong!!! The correct answer is A.Nile");
                }
                getch();
                break;
        }
    }
}

void play_game(char playername[]) {
    int count = 0;
    int countr = 0;

    warmup_round(&count);

    if (count >= 2) {
        system("cls");
        printf("\n\n\t*** CONGRATULATION %s you are eligible to play the Game ***", playername);
        printf("\n\n\n\t!Press any key to Start the Game!");
        getch();
        challenge_round(&countr);
    } else {
        system("cls");
        printf("\n\nSORRY YOU ARE NOT ELIGIBLE TO PLAY THIS GAME, BETTER LUCK NEXT TIME");
        getch();
        return;
    }

    float score = (float)countr * 100000;

    if (score > 0.00 && score < 1000000) {
        printf("\n\n\t\t**************** CONGRATULATION *****************");
        printf("\n\t You won $%.2f", score);
    } else if (score == 1000000.00) {
        printf("\n\n\n \t\t**************** CONGRATULATION ****************");
        printf("\n\t\t\t\t YOU ARE A MILLIONAIRE!!!!!!!!!");
        printf("\n\t\t You won $%.2f", score);
        printf("\t\t Thank You!!");
    } else {
        printf("\n\n\t******** SORRY YOU DIDN'T WIN ANY CASH ********");
        printf("\n\t\t Thanks for your participation");
        printf("\n\t\t TRY AGAIN");
    }

    printf("\n\n Press Y if you want to play next game");
    printf("\n Press any other key if you want to go main menu");
    if (toupper(getch()) == 'Y') {
        play_game(playername);
    } else {
        edit_score(score, playername);
    }
}

void show_record() {
    system("cls");
    char name[20];
    float scr;
    FILE *f;
    f = fopen("score.txt", "r");
    fscanf(f, "%s%f", &name, &scr);
    printf("\n\n\t\t*************************************************************");
    printf("\n\n\t\t %s has secured the Highest Score %0.2f", name, scr);
    printf("\n\n\t\t*************************************************************");
    fclose(f);
    getch();
}

void reset_score() {
    system("cls");
    float sc;
    char nm[20];
    FILE *f;
    f = fopen("score.txt", "r+");
    fscanf(f, "%s%f", &nm, &sc);
    sc = 0;
    fprintf(f, "%s,%.2f", nm, sc);
    fclose(f);
}

void help() {
    system("cls");
    printf("\n\n                              HELP");
    printf("\n -------------------------------------------------------------------------");
    printf("\n ......................... C program Quiz Game...........");
    printf("\n >> There are two rounds in the game, WARMUP ROUND & CHALLANGE ROUND");
    printf("\n >> In warmup round you will be asked a total of 3 questions to test your general");
    printf("\n    knowledge. You will be eligible to play the game if you can give at least 2");
    printf("\n    right answers otherwise you can't play the Game...........");
    printf("\n >> Your game starts with the CHALLANGE ROUND. In this round you will be asked");
    printf("\n    total 10 questions each right answer will be awarded $100,000.");
    printf("\n    By this way you can win upto ONE MILLION cash prize in USD...............");
    printf("\n >> You will be given 4 options and you have to press A, B ,C or D for the");
    printf("\n    right option");
    printf("\n >> You will be asked questions continuously if you keep giving the right answers.");
    printf("\n >> No negative marking for wrong answers");

    printf("\n\n\t*********************BEST OF LUCK*********************************");
    printf("\n\n\t*****C PROGRAM QUIZ GAME is developed by CODE WITH C TEAM********");
    getch();
}

void edit_score(float score, char plnm[20]) {
    system("cls");
    float sc;
    char nm[20];
    FILE *f;
    f = fopen("score.txt", "r");
    fscanf(f, "%s%f", &nm, &sc);
    if (score >= sc) {
        sc = score;
        fclose(f);
        f = fopen("score.txt", "w");
        fprintf(f, "%s\n%.2f ", plnm, sc);
        fclose(f);
    }
}
