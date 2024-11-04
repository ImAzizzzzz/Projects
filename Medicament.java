package Pharmacie;

public class Medicament {
    // Attributs privés
    private String code;
    private String nom;
    private double prixUnitaire;
    private int quantite;

    // Constructeur
    public Medicament(String code, String nom, double prixUnitaire, int quantite) {
        this.code = code;
        this.nom = nom;
        this.prixUnitaire = prixUnitaire;
        this.quantite = quantite;
    }

    // Getters (accesseurs) + Setters (modificateurs)
    public String getCode() {
        return code;
    }
    public void setCode(String code) {
        this.code = code;
    }
    public String getNom() {
        return nom;
    }
    public void setNom(String nom) {
        this.nom = nom;
    }
    public double getPrixUnitaire() {
        return prixUnitaire;
    }
    public void setPrixUnitaire(double prixUnitaire) {
        this.prixUnitaire = prixUnitaire;
    }
    public int getQuantite() {
        return quantite;
    }
    public void setQuantite(int quantite) {
        this.quantite = quantite;
    }

    // Méthode pour afficher les informations du médicament
    @Override
    public String toString() {
        return "Medicament [Code=" + code + ", Nom=" + nom + ", Prix Unitaire=" + prixUnitaire + ", Quantité=" + quantite + "]";
    }
}
