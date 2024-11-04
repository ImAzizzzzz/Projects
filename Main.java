package Main;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Gestionnaire gestionnaire = new Gestionnaire();
        int choix;

        do {
            System.out.println("\n--- Menu Principal ---");
            System.out.println("1. Rechercher un patient par CIN");
            System.out.println("2. Ajouter un nouveau patient");
            System.out.println("3. Afficher tous les patients ayant un groupe sanguin AB+");
            System.out.println("4. Créer une ordonnance pour un patient");
            System.out.println("5. Afficher le nombre d'apparitions d'un médicament dans les ordonnances");
            System.out.println("6. Afficher les détails d'une ordonnance par date et CIN");
            System.out.println("0. Quitter");
            System.out.print("Veuillez choisir une option : ");
            
            choix = scanner.nextInt();
            scanner.nextLine(); // Consomme le retour de ligne

            switch (choix) {
                case 1:
                    System.out.print("Entrez le CIN du patient : ");
                    int cinRecherche = scanner.nextInt();
                    scanner.nextLine(); // Consomme le retour de ligne
                    Patient patientTrouve = gestionnaire.rechercherPatient(cinRecherche);
                    if (patientTrouve != null) {
                        System.out.println("Patient trouvé : " + patientTrouve);
                    } else {
                        System.out.println("Patient introuvable.");
                    }
                    break;

                case 2:
                    gestionnaire.ajouterPatient();
                    break;

                case 3:
                    gestionnaire.afficherPatientsGroupeSanguinABPlus();
                    break;

                case 4:
                    gestionnaire.creerOrdonnance();
                    break;

                case 5:
                    System.out.print("Entrez le nom du médicament : ");
                    String nomMedicament = scanner.nextLine();
                    gestionnaire.compterApparitionsMedicament(nomMedicament);
                    break;

                case 6:
                    System.out.print("Entrez la date de l'ordonnance (format JJ/MM/AAAA) : ");
                    String dateOrdonnance = scanner.nextLine();
                    System.out.print("Entrez le CIN du patient : ");
                    int cinOrdonnance = scanner.nextInt();
                    scanner.nextLine(); // Consomme le retour de ligne
                    gestionnaire.afficherDetailsOrdonnance(dateOrdonnance, cinOrdonnance);
                    break;

                case 0:
                    System.out.println("Merci d'avoir utilisé le gestionnaire. Au revoir !");
                    break;

                default:
                    System.out.println("Choix non valide. Veuillez réessayer.");
            }
        } while (choix != 0);

        scanner.close();
    }
}
