package LocationVoiture;

public class Voiture {
    private String marque;
    private String categorie;
    private int nombreChevaux;
    private boolean disponible;

    // Constructeur non param�tr�
    public Voiture() {
        this.marque = "Inconnue";
        this.categorie = "Inconnue";
        this.nombreChevaux = 0;
        this.disponible = true;
    }

    // Constructeur param�tr�
    public Voiture(String marque, String categorie, int nombreChevaux) {
        this.marque = marque;
        this.categorie = categorie;
        this.nombreChevaux = nombreChevaux;
        this.disponible = true; // Disponible � la cr�ation
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
        return "Voiture [marque=" + marque + ", cat�gorie=" + categorie + ", nombre de chevaux=" + nombreChevaux +
                ", disponible=" + disponible + "]";
    }
}