package LocationVoiture;

import java.util.ArrayList;

public class Agence {
    private ArrayList<Client> clients;
    private ArrayList<Voiture> voitures;
    private ArrayList<Contrat> contrats;

    // Constructeur
    public Agence() {
        clients = new ArrayList<>();
        voitures = new ArrayList<>();
        contrats = new ArrayList<>();
    }

    // Ajouter un nouveau client
    public void ajouterClient(Client client) {
        clients.add(client);
    }

    // Ajouter une nouvelle voiture
    public void ajouterVoiture(Voiture voiture) {
        voitures.add(voiture);
    }

    // Ajouter un contrat de location
    public void ajouterContrat(Contrat contrat) {
        contrats.add(contrat);
        contrat.getVoiture().setDisponible(false); // Marquer la voiture comme non disponible
    }

    // Afficher les contrats
    public void afficherContrats() {
        for (Contrat contrat : contrats) {
            System.out.println(contrat);
        }
    }

    // Afficher les voitures non louées
    public void afficherVoituresNonLouees() {
        for (Voiture voiture : voitures) {
            if (voiture.isDisponible()) {
                System.out.println(voiture);
            }
        }
    }

    // Afficher les clients ayant des contrats en cours
    public void afficherClientsAvecContrats() {
        for (Contrat contrat : contrats) {
            System.out.println(contrat.getClient());
        }
    }

    // Getters pour les listes de clients et de voitures
    public ArrayList<Client> getClients() {
        return clients;
    }

    public ArrayList<Voiture> getVoitures() {
        return voitures;
    }
}