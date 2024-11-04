package LocationVoiture;

public class Voiture {
    private String marque;
    private String categorie;
    private int nombreChevaux;
    private boolean disponible;

    // Constructeur non paramétré
    public Voiture() {
        this.marque = "Inconnue";
        this.categorie = "Inconnue";
        this.nombreChevaux = 0;
        this.disponible = true;
    }

    // Constructeur paramétré
    public Voiture(String marque, String categorie, int nombreChevaux) {
        this.marque = marque;
        this.categorie = categorie;
        this.nombreChevaux = nombreChevaux;
        this.disponible = true; // Disponible à la création
    }

    // Accesseurs
    public String getMarque() {
        return marque;
    }

    public String getCategorie() {
        return categorie;
    }

    public int getNombreChevaux() {
        return nombreChevaux;
    }

    public boolean isDisponible() {
        return disponible;
    }

    public void setDisponible(boolean disponible) {
        this.disponible = disponible;
    }

    @Override
    public String toString() {
        return "Voiture [marque=" + marque + ", catégorie=" + categorie + ", nombre de chevaux=" + nombreChevaux +
                ", disponible=" + disponible + "]";
    }
}