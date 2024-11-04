package Main;

import java.util.ArrayList;
import java.util.Scanner;

public class Ordonnance {
	// Déclaration des attributs
    private int identifiant; // Identifiant unique en lecture seule (pas de set)
    private String date;
    private String nomMedecin;
    private ArrayList<Prescription> prescriptions=new ArrayList<Prescription>();
    private Patient patient;
    
    public Ordonnance(int identifiant, Patient patient) {
    	Scanner sc=new Scanner(System.in);
    	this.identifiant=identifiant;
    	this.patient=patient;
    	System.out.println("Nom du médecin Traitant?");
    	this.nomMedecin=sc.nextLine();
    	System.out.println("Date de l'ordonnance?");
    	this.date=sc.nextLine();
    	
        	
    }

	public int getIdentifiant() {
		return identifiant;
	}

	//pas de setter pour l'identifiant pour qu'il soit accessible en lecture seulement

	public String getDate() {
		return date;
	}

	public void setDate(String date) {
		this.date = date;
	}

	public String getNomMedecin() {
		return nomMedecin;
	}

	public void setNomMedecin(String nomMedecin) {
		this.nomMedecin = nomMedecin;
	}

	public ArrayList<Prescription> getPrescriptions() {
		return prescriptions;
	}

	public void setPrescriptions(ArrayList<Prescription> prescriptions) {
		this.prescriptions = prescriptions;
	}

	public Patient getPatient() {
		return patient;
	}

	public void setPatient(Patient patient) {
		this.patient = patient;
	}

	@Override
	public String toString() {
		return "Ordonnance [identifiant=" + identifiant + ", date=" + date + ", nomMedecin=" + nomMedecin
				+ ", prescriptions=" + prescriptions + ", patient=" + patient + "]";
	}
	 // Méthode pour ajouter une prescription à la liste
    public void ajouterPrescription(Prescription prescription) {
        prescriptions.add(prescription);
    }

}
