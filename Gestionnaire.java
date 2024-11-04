package Main;

import java.util.ArrayList;
import java.util.Scanner;

public class Gestionnaire {
	 private ArrayList<Patient> patients;
	    private ArrayList<Ordonnance> ordonnances;
	    private int numordonnance = 0; // compteur pour numéro incrémental d'ordonnance

	    // Constructeur
	    public Gestionnaire() {
	        this.patients = new ArrayList<>();
	        this.ordonnances = new ArrayList<>();
	    }

	    // Méthode 1 : Rechercher un patient par CIN
	    public Patient rechercherPatient(int cin) {
	        for (Patient patient : patients) {
	            if (patient.getCin() == cin) {
	                return patient;
	            }
	        }
	        return null; // Retourne null si le patient n'existe pas
	    }
	 // Méthode 2 : Ajouter un nouveau patient avec un CIN unique
	    public void ajouterPatient() {
	    	Scanner sc = new Scanner(System.in);
	    	//Demander le CIN du nouveau patient
	    	System.out.println("Donnez le CIN du nouveau Patient?");
	    	int cin=sc.nextInt();
	        if (rechercherPatient(cin) == null) {
	            patients.add(new Patient(cin));
	            System.out.println("Patient ajouté avec succès");
	        }
	        else{System.out.println("L'ajout n'a pas abouti");} 
	    }

	    // MÃ©thode 3 : Afficher tous les patients ayant un groupe sanguin AB+
	    public void afficherPatientsGroupeSanguinABPlus() {
	        for (Patient patient : patients) {
	            if (patient.getGroupeSanguin().equals("AB") && patient.getRhesus() == '+') {
	                System.out.println(patient.toString());
	            }
	        }
	    }

	    // Méthode 4 : Créer une ordonnance avec identifiant incrémental et ajouter des prescriptions
	    public void creerOrdonnance() {
	        Scanner sc = new Scanner(System.in);
	        //Rechercher un patient avec son cin
	        System.out.println("Donnez le CIN du nouveau Patient?");
	    	int cin=sc.nextInt();
	        if (rechercherPatient(cin) == null) {
	           
	            System.out.println("Patient inexistant");
	        }
	        else{
	        	//Incrémenter le numéro de l'ordonnance
	        	this.numordonnance++;
	        	
	        	//Créer l'ordonnance
	        	Ordonnance ordonnance=new Ordonnance(this.numordonnance,rechercherPatient(cin));
	        	sc.nextLine(); // Consomme le retour de ligne
	        	// Ajout des prescriptions Ã  l'ordonnance
	        	boolean continuer = true;
	        
	        	while (continuer) {
	        	
	            System.out.print("Entrez le nom du médicament : ");
	            String nomMedicament = sc.nextLine();
	            System.out.print("Entrez le nombre d'administration par jour : ");
	            int nombreAdministration = sc.nextInt();
	            System.out.print("Entrez le dosage : ");
	            double dosage = sc.nextDouble();
	            sc.nextLine(); // Consomme le retour de ligne

	            Prescription prescription = new Prescription(nomMedicament, nombreAdministration, dosage);
	            ordonnance.ajouterPrescription(prescription);

	            System.out.print("Souhaitez-vous ajouter une autre préscription ? (oui/non) : ");
	            continuer = sc.nextLine().equalsIgnoreCase("oui");
	        }
	        	//Ajouter l'ordonnance à la liste dediée
	        	this.ordonnances.add(ordonnance);
	        	}
	    }
	     // Méthode 5 : Afficher le nombre d'apparition d'un médicament dans les ordonnances
	        public void compterApparitionsMedicament(String nomMedicament) {
	            int compteur = 0;
	            for (Ordonnance ordonnance : ordonnances) {
	            	//Récupérer la liste des prescriptions de l'ordonnance
	            	ArrayList<Prescription> prescriptions=ordonnance.getPrescriptions();
	                for (Prescription prescription : prescriptions) {
	                    if (prescription.getNomMedicament().equalsIgnoreCase(nomMedicament)) {
	                        compteur++;
	                    }
	                }
	            }
	            System.out.println("le mÃ©dicament "+ nomMedicament+" apparaÃ®t "+compteur+" fois");
	        }

	        // Méthode 6 : Afficher les détails d'une ordonnance via sa date et le CIN du patient
	        public void afficherDetailsOrdonnance(String date, int cinPatient) {
	            for (Ordonnance ordonnance : ordonnances) {
	                if (ordonnance.getDate().equals(date) && ordonnance.getPatient().getCin() == cinPatient) 
	                {
	                    System.out.println(ordonnance.toString());
	                }
	            }
	            }
	        
	    
}
