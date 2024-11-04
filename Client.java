package LocationVoiture;

public class Client {
    private String nom;
    private String numeroPermis;
    private String cin;
    private String adresse;
    private String numeroTelephone;

    // Constructeur non paramétré
    public Client() {
        this.nom = "Inconnu";
        this.numeroPermis = "Inconnu";
        this.cin = "Inconnu";
        this.adresse = "Inconnue";
        this.numeroTelephone = "Inconnu";
    }

    // Constructeur paramétré
    public Client(String nom, String numeroPermis, String cin, String adresse, String numeroTelephone) {
        this.nom = nom;
        this.numeroPermis = numeroPermis;
        this.cin = cin;
        this.adresse = adresse;
        this.numeroTelephone = numeroTelephone;
    }

    // Accesseurs
    public String getNom() {
        return nom;
    }

    public String getNumeroPermis() {
        return numeroPermis;
    }

    public String getCin() {
        return cin;
    }

    public String getAdresse() {
        return adresse;
    }

    public String getNumeroTelephone() {
        return numeroTelephone;
    }

    @Override
    public String toString() {
        return "Client [nom=" + nom + ", numéro de permis=" + numeroPermis + ", CIN=" + cin + ", adresse=" + adresse +
                ", numéro de téléphone=" + numeroTelephone + "]";
    }
}