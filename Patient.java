package Main;

import java.util.Scanner;

public class Patient {
	 // Déclaration des attributs
    private int cin;
    private String nom;
    private String groupeSanguin; // A, B, AB, ou O
    private char rhesus; // '+' ou '-'
    private int age;
    private String statutMarital; // Marié, Célibataire, Divorcé ou Veuf
    private boolean diabetique;
	public int getCin() {
		return cin;
	}
	public void setCin(int cin) {
		this.cin = cin;
	}
	public String getNom() {
		return nom;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}
	public String getGroupeSanguin() {
		return groupeSanguin;
	}
	public void setGroupeSanguin(String groupeSanguin) {
		this.groupeSanguin = groupeSanguin;
	}
	public char getRhesus() {
		return rhesus;
	}
	public void setRhesus(char rhesus) {
		this.rhesus = rhesus;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getStatutMarital() {
		return statutMarital;
	}
	public void setStatutMarital(String statutMarital) {
		this.statutMarital = statutMarital;
	}
	public boolean isDiabetique() {
		return diabetique;
	}
	public void setDiabetique(boolean diabetique) {
		this.diabetique = diabetique;
	}
	@Override
	public String toString() {
		return "Patient [cin=" + cin + ", nom=" + nom + ", groupeSanguin=" + groupeSanguin + ", rhesus=" + rhesus
				+ ", age=" + age + ", statutMarital=" + statutMarital + ", diabetique=" + diabetique + "]";
	}
    
	// Constructeur avec seul paramètre le CIN
    public Patient(int cin) {
        this.cin = cin;
        saisirInfosPatient();
    }

    // éthode pour saisir les informations du patient depuis le clavier
    private void saisirInfosPatient() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Entrez le nom du patient : ");
        this.nom = scanner.nextLine();
        //flag pour la vérification
        boolean verif=false;
        
        // Saisie et vérification du groupe sanguin
        //on peut aussi utiliser le DO--while
        while (verif==false) {
            System.out.print("Entrez le groupe sanguin (A, B, AB, O) : ");
            this.groupeSanguin = scanner.nextLine().toUpperCase();
            if (groupeSanguin.equals("A") || groupeSanguin.equals("B") || 
                groupeSanguin.equals("AB") || groupeSanguin.equals("O")) {
                verif=true;
            } else {
                System.out.println("Groupe sanguin invalide. Veuillez entrer A, B, AB ou O.");
            }
        }
        verif=false;

        // Saisie et vérification du rhésus
        while (verif==false) {
            System.out.print("Entrez le rhésus (+ ou -) : ");
            this.rhesus = scanner.next().charAt(0);
            if (rhesus == '+' || rhesus == '-') {
                verif=true;
            } else {
                System.out.println("Rhésus invalide. Veuillez entrer + ou -.");
            }
        }

        // Saisie et vérification de l'âge
        verif=false;
        while (verif==false) {
            System.out.print("Entrez l'âge du patient : ");
            this.age = scanner.nextInt();
            if (age >= 0) {
                verif=true;
            } else {
                System.out.println("^Age invalide. Veuillez entrer un âge positif.");
            }
        }

        // Saisie et vérification du statut marital
        scanner.nextLine(); // Consomme le retour de ligne restant
        while (true) {
            System.out.print("Entrez le statut marital (MariÃ©, CÃ©libataire, DivorcÃ©, Veuf) : ");
            this.statutMarital = scanner.nextLine();
            if (statutMarital.equalsIgnoreCase("Marié") || 
                statutMarital.equalsIgnoreCase("Célibataire") || 
                statutMarital.equalsIgnoreCase("Divorcé") || 
                statutMarital.equalsIgnoreCase("Veuf")) {
                break;
            } else {
                System.out.println("Statut marital invalide. Veuillez entrer Marié, Célibataire, Divorcé ou Veuf.");
            }
        }

        // Saisie de l'état diabétique
        System.out.print("Le patient est-il diabétique ? (true/false) : ");
        this.diabetique = scanner.nextBoolean();
    }

    

}
