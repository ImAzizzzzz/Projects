package Pharmacie;

import java.util.ArrayList;
import java.util.Scanner;

public class Gestionnaire {
    // Liste des médicaments
    private ArrayList<Medicament> listeMedicaments;

    // Constructeur
    public Gestionnaire() {
        listeMedicaments = new ArrayList<>();
    }

    // Méthode 1: Rechercher un médicament par son code
    public Medicament Rech_Med(String ref) {
        for (Medicament med : listeMedicaments) {
            if (med.getCode().equalsIgnoreCase(ref)) {
                return med;  // Médicament trouvé
            }
        }
        return null;  // Médicament non trouvé
    }

    // Méthode 2: Ajouter un nouveau médicament
    public void ajouter_Med() {
        Scanner sc = new Scanner(System.in);

        // Saisir les informations du médicament
        System.out.print("Entrez le code du médicament : ");
        String code = sc.nextLine();

        // Vérifier que le code est unique
        if (Rech_Med(code) != null) {
            System.out.println("Échec : Un médicament avec ce code existe déjà.");
            return;
        }

        System.out.print("Entrez le nom du médicament : ");
        String nom = sc.nextLine();

        System.out.print("Entrez le prix unitaire du médicament : ");
        double prix = sc.nextDouble();

        System.out.print("Entrez la quantité disponible : ");
        int quantite = sc.nextInt();

        // Créer et ajouter le nouveau médicament
        Medicament nouveauMed = new Medicament(code, nom, prix, quantite);
        listeMedicaments.add(nouveauMed);
        System.out.println("Succès : Médicament ajouté.");
    }

    // Méthode 3: Afficher la liste des médicaments
    public void afficher_Med() {
        if (listeMedicaments.isEmpty()) {
            System.out.println("Aucun médicament en stock.");
        } else {
            for (Medicament med : listeMedicaments) {
                System.out.println(med);
            }
        }
    }

    // Méthode 4: Vente de médicament
    public void vente_Med() {
        Scanner sc = new Scanner(System.in);

        System.out.print("Entrez le code du médicament à vendre : ");
        String code = sc.nextLine();

        Medicament med = Rech_Med(code);
        if (med == null) {
            System.out.println("Échec : Médicament non trouvé.");
            return;
        }

        System.out.print("Entrez la quantité à vendre : ");
        int quantite = sc.nextInt();

        // Vérifier si la quantité demandée est disponible
        if (quantite > med.getQuantite()) {
            System.out.println("Échec : Quantité insuffisante en stock.");
        } else {
            // Mise à jour de la quantité en stock
            med.setQuantite(med.getQuantite() - quantite);
            double total = quantite * med.getPrixUnitaire();
            System.out.println("Succès : Vente réalisée. Montant total : " + total + " DT");
        }
    }
}
