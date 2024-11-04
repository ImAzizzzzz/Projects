package Main;

import java.util.ArrayList;
import java.util.Scanner;

public class Gestionnaire {
	 private ArrayList<Patient> patients;
	    private ArrayList<Ordonnance> ordonnances;
	    private int numordonnance = 0; // compteur pour num�ro incr�mental d'ordonnance

	    // Constructeur
	    public Gestionnaire() {
	        this.patients = new ArrayList<>();
	        this.ordonnances = new ArrayList<>();
	    }

	    // M�thode 1 : Rechercher un patient par CIN
	    public Patient rechercherPatient(int cin) {
	        for (Patient patient : patients) {
	            if (patient.getCin() == cin) {
	                return patient;
	            }
	        }
	        return null; // Retourne null si le patient n'existe pas
	    }
	 // M�thode 2 : Ajouter un nouveau patient avec un CIN unique
	    public void ajouterPatient() {
	    	Scanner sc = new Scanner(System.in);
	    	//Demander le CIN du nouveau patient
	    	System.out.println("Donnez le CIN du nouveau Patient?");
	    	int cin=sc.nextInt();
	        if (rechercherPatient(cin) == null) {
	            patients.add(new Patient(cin));
	            System.out.println("Patient ajout� avec succ�s");
	        }
	        else{System.out.println("L'ajout n'a pas abouti");} 
	    }

	    // Méthode 3 : Afficher tous les patients ayant un groupe sanguin AB+
	    public void afficherPatientsGroupeSanguinABPlus() {
	        for (Patient patient : patients) {
	            if (patient.getGroupeSanguin().equals("AB") && patient.getRhesus() == '+') {
	                System.out.println(patient.toString());
	            }
	        }
	    }

	    // M�thode 4 : Cr�er une ordonnance avec identifiant incr�mental et ajouter des prescriptions
	    public void creerOrdonnance() {
	        Scanner sc = new Scanner(System.in);
	        //Rechercher un patient avec son cin
	        System.out.println("Donnez le CIN du nouveau Patient?");
	    	int cin=sc.nextInt();
	        if (rechercherPatient(cin) == null) {
	           
	            System.out.println("Patient inexistant");
	        }
	        else{
	        	//Incr�menter le num�ro de l'ordonnance
	        	this.numordonnance++;
	        	
	        	//Cr�er l'ordonnance
	        	Ordonnance ordonnance=new Ordonnance(this.numordonnance,rechercherPatient(cin));
	        	sc.nextLine(); // Consomme le retour de ligne
	        	// Ajout des prescriptions à l'ordonnance
	        	boolean continuer = true;
	        
	        	while (continuer) {
	        	
	            System.out.print("Entrez le nom du m�dicament : ");
	            String nomMedicament = sc.nextLine();
	            System.out.print("Entrez le nombre d'administration par jour : ");
	            int nombreAdministration = sc.nextInt();
	            System.out.print("Entrez le dosage : ");
	            double dosage = sc.nextDouble();
	            sc.nextLine(); // Consomme le retour de ligne

	            Prescription prescription = new Prescription(nomMedicament, nombreAdministration, dosage);
	            ordonnance.ajouterPrescription(prescription);

	            System.out.print("Souhaitez-vous ajouter une autre pr�scription ? (oui/non) : ");
	            continuer = sc.nextLine().equalsIgnoreCase("oui");
	        }
	        	//Ajouter l'ordonnance � la liste dedi�e
	        	this.ordonnances.add(ordonnance);
	        	}
	    }
	     // M�thode 5 : Afficher le nombre d'apparition d'un m�dicament dans les ordonnances
	        public void compterApparitionsMedicament(String nomMedicament) {
	            int compteur = 0;
	            for (Ordonnance ordonnance : ordonnances) {
	            	//R�cup�rer la liste des prescriptions de l'ordonnance
	            	ArrayList<Prescription> prescriptions=ordonnance.getPrescriptions();
	                for (Prescription prescription : prescriptions) {
	                    if (prescription.getNomMedicament().equalsIgnoreCase(nomMedicament)) {
	                        compteur++;
	                    }
	                }
	            }
	            System.out.println("le médicament "+ nomMedicament+" apparaît "+compteur+" fois");
	        }

	        // M�thode 6 : Afficher les d�tails d'une ordonnance via sa date et le CIN du patient
	        public void afficherDetailsOrdonnance(String date, int cinPatient) {
	            for (Ordonnance ordonnance : ordonnances) {
	                if (ordonnance.getDate().equals(date) && ordonnance.getPatient().getCin() == cinPatient) 
	                {
	                    System.out.println(ordonnance.toString());
	                }
	            }
	            }
	        
	    
}
