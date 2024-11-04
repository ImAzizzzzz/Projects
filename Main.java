package Pharmacie;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Gestionnaire gestionnaire = new Gestionnaire();
        Scanner sc = new Scanner(System.in);
        int choix;

        do {
            // Affichage du menu principal
            System.out.println("\n=== Menu Principal ===");
            System.out.println("1. Ajouter un médicament");
            System.out.println("2. Rechercher un médicament");
            System.out.println("3. Afficher la liste des médicaments");
            System.out.println("4. Vendre un médicament");
            System.out.println("0. Quitter");
            System.out.print("Entrez votre choix : ");
            choix = sc.nextInt();
            sc.nextLine();  // Consommer la nouvelle ligne

            // Gestion des choix de l'utilisateur
            switch (choix) {
                case 1:
                    gestionnaire.ajouter_Med();
                    break;
                case 2:
                    System.out.print("Entrez le code du médicament à rechercher : ");
                    String ref = sc.nextLine();
                    Medicament med = gestionnaire.Rech_Med(ref);
                    if (med != null) {
                        System.out.println(med);
                    } else {
                        System.out.println("Médicament non trouvé.");
                    }
                    break;
                case 3:
                    gestionnaire.afficher_Med();
                    break;
                case 4:
                    gestionnaire.vente_Med();
                    break;
                case 0:
                    System.out.println("Fermeture de l'application.");
                    break;
                default:
                    System.out.println("Choix non valide.");
            }
        } while (choix != 0);

        sc.close();
    }
}
