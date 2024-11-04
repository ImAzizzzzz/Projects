package Main;

public class Prescription {
	// Déclaration des attributs
    private String nomMedicament;
    private int nombreAdministration; // Nombre d'administrations par jour, minimum 1
    private double dosage; // Dosage, minimum 1. Le type int est aussi accepté
    // Constructeur
    public Prescription(String nomMedicament, int nombreAdministration, double dosage) {
        this.nomMedicament = nomMedicament;
        
        // Assurer que nombreAdministration est au minimum 1
        if (nombreAdministration < 1) {
            this.nombreAdministration = 1;
        } else {
            this.nombreAdministration = nombreAdministration;
        }
        
        // Assurer que dosage est au minimum 1
        if (dosage < 1) {
            this.dosage = 1;
        } else {
            this.dosage = dosage;
        }
    }
	public String getNomMedicament() {
		return nomMedicament;
	}
	public void setNomMedicament(String nomMedicament) {
		this.nomMedicament = nomMedicament;
	}
	public int getNombreAdministration() {
		return nombreAdministration;
	}
	 public void setNombreAdministration(int nombreAdministration) {
	        if (nombreAdministration >= 1) {
	            this.nombreAdministration = nombreAdministration;
	        } else {
	            System.out.println("Le nombre d'administrations par jour doit être au minimum 1.");
	        }
	    }
	public double getDosage() {
		return dosage;
	}
	public void setDosage(double dosage) {
        if (dosage >= 1) {
            this.dosage = dosage;
        } else {
            System.out.println("Le dosage doit Ãªtre au minimum 1.");
        }
    }
	@Override
	public String toString() {
		return "Prescription [nomMedicament=" + nomMedicament + ", nombreAdministration=" + nombreAdministration
				+ ", dosage=" + dosage + "]";
	}

    

}
