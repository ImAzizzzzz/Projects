package LocationVoiture;

import java.util.Date;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Agence agence = new Agence();
        Scanner scanner = new Scanner(System.in);
        int choix;

        do {
            System.out.println("---------Menu---------");
            System.out.println("1. Ajouter un client");
            System.out.println("2. Ajouter une voiture");
            System.out.println("3. Ajouter un contrat de location");
            System.out.println("4. Afficher les contrats");
            System.out.println("5. Afficher les voitures non louées");
            System.out.println("6. Afficher les clients avec contrats");
            System.out.println("0. Quitter");
            System.out.print("Choisissez une option : ");
            choix = scanner.nextInt();
            scanner.nextLine();

            switch (choix) {
                case 1:
                    System.out.print("Nom du client : ");
                    String nom = scanner.nextLine();
                    System.out.print("Numéro de permis : ");
                    String numeroPermis = scanner.nextLine();
                    System.out.print("CIN : ");
                    String cin = scanner.nextLine();
                    System.out.print("Adresse : ");
                    String adresse = scanner.nextLine();
                    System.out.print("Numéro de téléphone : ");
                    String numeroTelephone = scanner.nextLine();
                    Client client = new Client(nom, numeroPermis, cin, adresse, numeroTelephone);
                    agence.ajouterClient(client);
                    System.out.println("Client ajouté.");
                    break;

                case 2:
                    System.out.print("Marque de la voiture : ");
                    String marque = scanner.nextLine();
                    System.out.print("Catégorie : ");
                    String categorie = scanner.nextLine();
                    System.out.print("Nombre de chevaux : ");
                    int nombreChevaux = scanner.nextInt();
                    Voiture voiture = new Voiture(marque, categorie, nombreChevaux);
                    agence.ajouterVoiture(voiture);
                    System.out.println("Voiture ajoutée.");
                    break;

                case 3:
                    System.out.print("CIN du client : ");
                    String cinClient = scanner.nextLine();
                    Client clientLoueur = null;
                    for (Client c : agence.getClients()) {
                        if (c.getCin().equals(cinClient)) {
                            clientLoueur = c;
                            break;
                        }
                    }

                    if (clientLoueur == null) {
                        System.out.println("Client non trouvé.");
                        break;
                    }

                    System.out.print("Marque de la voiture : ");
                    String marqueVoiture = scanner.nextLine();
                    Voiture voitureLouee = null;
                    for (Voiture v : agence.getVoitures()) {
                        if (v.getMarque().equalsIgnoreCase(marqueVoiture) && v.isDisponible()) {
                            voitureLouee = v;
                            break;
                        }
                    }

                    if (voitureLouee == null) {
                        System.out.println("Voiture non disponible.");
                        break;
                    }

                    System.out.print("Date de début (JJ/MM/AAAA) : ");
                    String[] dateDebutStr = scanner.nextLine().split("/");
                    Date dateDebut = new Date(Integer.parseInt(dateDebutStr[2]) - 1900, Integer.parseInt(dateDebutStr[1]) - 1, Integer.parseInt(dateDebutStr[0]));

                    System.out.print("Date de fin (JJ/MM/AAAA) : ");
                    String[] dateFinStr = scanner.nextLine().split("/");
                    Date dateFin = new Date(Integer.parseInt(dateFinStr[2]) - 1900, Integer.parseInt(dateFinStr[1]) - 1, Integer.parseInt(dateFinStr[0]));

                    Contrat contrat = new Contrat(clientLoueur, voitureLouee, dateDebut, dateFin);
                    agence.ajouterContrat(contrat);
                    System.out.println("Contrat ajouté.");
                    break;

                case 4:
                    agence.afficherContrats();
                    break;

                case 5:
                    agence.afficherVoituresNonLouees();
                    break;

                case 6:
                    agence.afficherClientsAvecContrats();
                    break;

                case 0:
                    System.out.println("Au revoir !");
                    break;

                default:
                    System.out.println("Option invalide.");
            }
        } while (choix != 0);

        scanner.close();
    }
}