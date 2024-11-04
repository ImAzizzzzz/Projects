package LocationVoiture;

import java.util.Date;

public class Contrat {
    private Client client;
    private Voiture voiture;
    private Date dateDebut;
    private Date dateFin;

    // Constructeur paramétré
    public Contrat(Client client, Voiture voiture, Date dateDebut, Date dateFin) {
        this.client = client;
        this.voiture = voiture;
        this.dateDebut = dateDebut;
        this.dateFin = dateFin;
    }

    // Accesseurs
    public Client getClient() {
        return client;
    }

    public Voiture getVoiture() {
        return voiture;
    }

    public Date getDateDebut() {
        return dateDebut;
    }

    public Date getDateFin() {
        return dateFin;
    }

    @Override
    public String toString() {
        return "Contrat [client=" + client + ", voiture=" + voiture + ", date de début=" + dateDebut + ", date de fin=" + dateFin + "]";
    }
}