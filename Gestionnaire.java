package Pharmacie;

import java.util.ArrayList;
import java.util.Scanner;

public class Gestionnaire {
    // Liste des m�dicaments
    private ArrayList<Medicament> listeMedicaments;

    // Constructeur
    public Gestionnaire() {
        listeMedicaments = new ArrayList<>();
    }

    // M�thode 1: Rechercher un m�dicament par son code
    public Medicament Rech_Med(String ref) {
        for (Medicament med : listeMedicaments) {
            if (med.getCode().equalsIgnoreCase(ref)) {
                return med;  // M�dicament trouv�
            }
        }
        return null;  // M�dicament non trouv�
    }

    // M�thode 2: Ajouter un nouveau m�dicament
    public void ajouter_Med() {
        Scanner sc = new Scanner(System.in);

        // Saisir les informations du m�dicament
        System.out.print("Entrez le code du m�dicament : ");
        String code = sc.nextLine();

        // V�rifier que le code est unique
        if (Rech_Med(code) != null) {
            System.out.println("�chec : Un m�dicament avec ce code existe d�j�.");
            return;
        }

        System.out.print("Entrez le nom du m�dicament : ");
        String nom = sc.nextLine();

        System.out.print("Entrez le prix unitaire du m�dicament : ");
        double prix = sc.nextDouble();

        System.out.print("Entrez la quantit� disponible : ");
        int quantite = sc.nextInt();

        // Cr�er et ajouter le nouveau m�dicament
        Medicament nouveauMed = new Medicament(code, nom, prix, quantite);
        listeMedicaments.add(nouveauMed);
        System.out.println("Succ�s : M�dicament ajout�.");
    }

    // M�thode 3: Afficher la liste des m�dicaments
    public void afficher_Med() {
        if (listeMedicaments.isEmpty()) {
            System.out.println("Aucun m�dicament en stock.");
        } else {
            for (Medicament med : listeMedicaments) {
                System.out.println(med);
            }
        }
    }

    // M�thode 4: Vente de m�dicament
    public void vente_Med() {
        Scanner sc = new Scanner(System.in);

        System.out.print("Entrez le code du m�dicament � vendre : ");
        String code = sc.nextLine();

        Medicament med = Rech_Med(code);
        if (med == null) {
            System.out.println("�chec : M�dicament non trouv�.");
            return;
        }

        System.out.print("Entrez la quantit� � vendre : ");
        int quantite = sc.nextInt();

        // V�rifier si la quantit� demand�e est disponible
        if (quantite > med.getQuantite()) {
            System.out.println("�chec : Quantit� insuffisante en stock.");
        } else {
            // Mise � jour de la quantit� en stock
            med.setQuantite(med.getQuantite() - quantite);
            double total = quantite * med.getPrixUnitaire();
            System.out.println("Succ�s : Vente r�alis�e. Montant total : " + total + " DT");
        }
    }
}
