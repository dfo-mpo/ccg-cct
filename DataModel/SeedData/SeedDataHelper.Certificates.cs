﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<Certificate> Certificates = new List<Certificate>()
            {
                new Certificate { Id = 1, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master, 150 GT, Domestic", NameFre = "Capitaine, jauge brute de 150, navigation intérieure" },
                new Certificate { Id = 2, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master 500GT, Domestic", NameFre = "Capitaine, jauge brute de 500, navigation intérieure" },
                new Certificate { Id = 3, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Inter-Provincial Journeyman Certification; Heavy Duty Mechanic", NameFre = "Certificat interprovincial de compagnon, mécanicien de machinerie lourde" },
                new Certificate { Id = 4, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Inter-Provincial Journeyman Certification; Automotive Mechanic", NameFre = "Certificat interprovincial de compagnon, mécanicien d'automobile" },
                new Certificate { Id = 5, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine First Aid", NameFre = "Premiers soins en mer" },
                new Certificate { Id = 6, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine Certificate", NameFre = "Certificat de navigation" },
                new Certificate { Id = 7, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG Logistics Officer Certificate", NameFre = "Certificat d'officier de logistique de la GCC" },
                new Certificate { Id = 8, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Auditor Training Program", NameFre = "Programme de formation d'auditeur" },
                new Certificate { Id = 9, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Safety Management for Industrial Facilities Certificate", NameFre = "Certificat en gestion de la sécurité des installations industrielles" },
                new Certificate { Id = 10, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Occupational Health & Safety Certificate", NameFre = "Certificat de santé et de sécurité au travail" },
                new Certificate { Id = 11, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Accident Investigation Program", NameFre = "Programme d'enquête sur les accidents" },
                new Certificate { Id = 12, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Carpentry Certification", NameFre = "Certificat de charpenterie Sceau rouge" },
                new Certificate { Id = 13, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Fall Protection Certificate", NameFre = "Certificat de protection contre les chutes" },
                new Certificate { Id = 14, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "SPRAT or IRATA, Level 1", NameFre = "SPRAT ou IRATA, niveau 1" },
                new Certificate { Id = 15, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Inter-Provincial Journeyman Certification; Heavy Duty Mechanic or Automotive Mechanic", NameFre = "Certificat interprovincial de compagnon, mécanicien de machinerie lourde ou mécanicien d'automobile" },
                new Certificate { Id = 16, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Painter and Decorator Certificate", NameFre = "Certificat de peintre et décorateur" },
                new Certificate { Id = 17, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine Emergency Duties - Basic Safety", NameFre = "Fonctions d'urgence en mer - Sécurité élémentaire" },
                new Certificate { Id = 18, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine Emergency Duties - Survival Craft / Rescue Boats", NameFre = "Fonctions d'urgence en mer - Embarcations de sauvetage/bateaux de sauvetage" },
                new Certificate { Id = 19, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine Emergency Duties - Proficiency in Advanced Firefighting", NameFre = "Fonctions d'urgence en mer - Maîtrise avancée de la lutte anti-incendie" },
                new Certificate { Id = 20, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Restricted Operator Certificate-Maritime Commercial (ROC-MC)", NameFre = "Certificat restreint d’opérateur - commercial maritime (CRO-CM)" },
                new Certificate { Id = 21, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Diver Certification Board of Canada (DCBC) Restricted Surface Supplied Diver Certification", NameFre = "Conseil Canadien de certification en plongée – Système de distribution d’air restreinte en surface" },
                new Certificate { Id = 22, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "First Aid", NameFre = "Premiers soins" },
                new Certificate { Id = 23, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG Medic-A Certificate", NameFre = "Formation Medic-A GCC" },
                new Certificate { Id = 24, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "OEM Maintenance Qualification; Technician", NameFre = "Certification du maintenance du Fabricants d’équipement d’origine (FEO)" },
                new Certificate { Id = 25, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Food Safety Training", NameFre = "Formation en sécurité alementaire" },
                new Certificate { Id = 26, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Ship's Cook or Provincial Standard (Red Seal)", NameFre = "Cuisinier/cuisinère de navire ou Normes provinciales (Sceau roude)" },
                new Certificate { Id = 27, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Restricted Operator Certificate-Maritime Commerical (ROC-MC)", NameFre = "Certificat restreint d’opérateur - commercial maritime (CRO-CM)" },
                new Certificate { Id = 28, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Bridge Watch Certificate", NameFre = "Brevet de matelot de quart à la passerelle" },
                new Certificate { Id = 29, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Engine Room Rating", NameFre = "Matelot de la salle des machines" },
                new Certificate { Id = 30, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Fourth Class Engineer - Motor", NameFre = "Officier mécanicien de 4e classe, navire à moteur" },
                new Certificate { Id = 31, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Third Class Engineer - Motor", NameFre = "Officier mécanicien de 3e classe, navire à moteur" },
                new Certificate { Id = 32, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Second Class Engineer - Motor", NameFre = "Officier mécanicien de 2e classe, navire à moteur" },
                new Certificate { Id = 33, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "First Class Engineer - Motor", NameFre = "Officier mécanicien de 1re classe, navire à moteur" },
                new Certificate { Id = 34, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "General Operators Certificate (GOC)", NameFre = "Certificat général d'opérateur radio (CGO)" },
                new Certificate { Id = 35, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master Mariner", NameFre = "Capitaine au long cours" },
                new Certificate { Id = 36, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master 3000 GT", NameFre = "Capitaine, jauge brute de 3 000" },
                new Certificate { Id = 37, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Small Vessel Safety (MED A2)", NameFre = "Sécurité des petits bâtiments (FUM A2)" },
                new Certificate { Id = 38, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Watchkeeping Mate, Near Coastal", NameFre = "Officier de pont de quart, à proximité du littoral" },
                new Certificate { Id = 39, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master, Near Coastal", NameFre = "Capitaine, à proximité du littoral" },
                new Certificate { Id = 40, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Logistics Officer Certificate", NameFre = "Certificat d'officier de la logistique de la GCC" },
                new Certificate { Id = 41, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG Electrical Certificate", NameFre = "Certificat d’officier électricien GCC" },
                new Certificate { Id = 42, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Fishing Master, Third Class", NameFre = "Capitaine de pêche, troisième classe" },
                new Certificate { Id = 43, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Standard on Training, Certification and Watchkeeping (STCW)", NameFre = "Normes de formation des gens de mer, de délivrance des brevets et de veille (STCW)" },
                new Certificate { Id = 44, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Cardiopulmonary Resuscitation (CPR)", NameFre = "Réanimation cardiorespiratoire (RCR)" },
                new Certificate { Id = 45, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Automated External Defibrillator (AED)", NameFre = "Défibrillateur externe automatisé (DEA)" },
                new Certificate { Id = 46, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Advanced Marine First Aid", NameFre = "Premiers soins en mer avancés" },
                new Certificate { Id = 47, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Advance Cardiac Life Support; Valid ACLS", NameFre = "Soins avancés de réanimation cardiaque; valide SARC" },
                new Certificate { Id = 48, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Trauma Nursing Core Course (TNCC); Certification from Emergency Nursing Association", NameFre = "Cours de base en soins infirmiers en traumatologie (CBSIT); certification de l'Association des infirmières et infirmiers d'urgence" },
                new Certificate { Id = 49, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Certified Nurse Practitioner", NameFre = "Infirmière praticienne certifiée" },
                new Certificate { Id = 50, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Combitube Procedure Training Certification", NameFre = "Certification de la formation sur les procédures en tubes combinés" },
                new Certificate { Id = 51, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Material or Supply Chain Management Certification", NameFre = "Certification des matériaux ou de la chaîne d'approvisionnement" },
                new Certificate { Id = 52, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Certified Fitness Professional Program", NameFre = "Programme de conditionnement physique certifié" },
                new Certificate { Id = 53, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Food Handlers Certificate, Food Safe Level 1", NameFre = "Certificat de salubrité des aliments, niveau 1" },
                new Certificate { Id = 54, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Cook Certification", NameFre = "Certification Sceau rouge de cuisinier" },
                new Certificate { Id = 55, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Forklift Operator's Certification", NameFre = "Certificat de conducteur de chariot élévateur à fourche" },
                new Certificate { Id = 56, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Transportation of Dangerous Goods Air & Ground Certification", NameFre = "Certification du transport aérien et terrestre des marchandises dangereuses" },
                new Certificate { Id = 57, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Restricted Operator's Certificate (Maritime)", NameFre = "Certificat restreint d'opérateur-Maritime (CRO-M)" },
                new Certificate { Id = 58, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Basic First Aid", NameFre = "Premiers soins de base" },
                new Certificate { Id = 59, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine Communications and Traffic Services Certificate", NameFre = "Certificat de services de communications et de trafic maritimes" },
                new Certificate { Id = 60, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Inter-Provincial Journeyman Trade Certification; Welding (47.1 and/or 47.2)", NameFre = "Certification interprovinciale des compagnons compagnons ; soudage (47,1 et/ou 47,2)" },
                new Certificate { Id = 61, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Class 3 with Air Break Endorsement", NameFre = "Classe 3 avec l'Attestation de coupure d'air" },
                new Certificate { Id = 62, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Mobile Crane Certification (as per provincial requirements)", NameFre = "Certification des grues mobiles (selon les exigences provinciales)" },
                new Certificate { Id = 63, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Industrial Electrician Certification", NameFre = "Certification électricien industriel Sceau rouge" },
                new Certificate { Id = 64, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Diesel Mechanic Certification", NameFre = "Certification de mécanicien diesel Sceau rouge" },
                new Certificate { Id = 65, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Welder Certification", NameFre = "Certification de soudeur Sceau rouge" },
                new Certificate { Id = 66, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Welding Supervisory Certificate 47.2", NameFre = "Certificat de supervision en soudage 47,2" },
                new Certificate { Id = 67, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Crane Operator Certificate", NameFre = "Certificat d'opérateur de grue" },
                new Certificate { Id = 68, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Fall Arrest & Tower Rescue Certification", NameFre = "Certification d'arrêt des chutes et de sauvetage en tour" },
                new Certificate { Id = 69, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Inter-Provincial Journeyman Certification; Heavy Duty Mechanic, Automotive Mechanic or Fourth Class Engineer - Motor (or higher)", NameFre = "Certificat interprovincial de compagnon ; mécanicien de machinerie lourde, mécanicien d'automobile ou mécanicien-moteur de quatrième classe (ou plus)" },
                new Certificate { Id = 70, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Marine Service Technician Certificate", NameFre = "Certificat de technicien d'entretien maritime" },
                new Certificate { Id = 71, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Composites Technician Certification", NameFre = "Certification des techniciens en composites" },
                new Certificate { Id = 72, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Diesel Mechanic or Mechanical Technician or Outboard Motors Mechanical degree", NameFre = "Technicien mécanicien diesel ou mécanicien ou moteur hors-bord Diplôme en mécanique" },
                new Certificate { Id = 73, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Welder Fabricator Certificate", NameFre = "Certificat de soudeurs-fabricants" },
                new Certificate { Id = 74, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Heavy Duty Mechanic Certification", NameFre = "Certificat de mécanicien de machinerie lourde" },
                new Certificate { Id = 75, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Electrical Trade Certification or Marine Electrician", NameFre = "Certificat de compétence en électricité Sceau rouge ou électricien de marine" },
                new Certificate { Id = 76, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Protective Coating Technician (NACE) or Marine Coating Applicator", NameFre = "Technicien en revêtements de protection (NACE) ou applicateur de revêtements marins" },
                new Certificate { Id = 77, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Refrigeration and Air Conditioning Certificate", NameFre = "Certificat en réfrigération et climatisation" },
                new Certificate { Id = 78, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Certification; Painter and Decorator", NameFre = "Certification Sceau rouge; Peintre et décorateur" },
                new Certificate { Id = 79, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Spill Response Training Certificate", NameFre = "Certificat de formation en intervention en cas de déversement" },
                new Certificate { Id = 80, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Incident Command System Level 200 or higher", NameFre = "Système de commandement d'intervention de niveau 200 ou supérieur" },
                new Certificate { Id = 81, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG VOC Enforcement Designation", NameFre = "Désignation de la GCC pour l'application de la loi sur les VOC" },
                new Certificate { Id = 82, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG Pollution Response Officer", NameFre = "Agent d'intervention antipollution de la GCC" },
                new Certificate { Id = 83, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG Rescue Specialist Certification", NameFre = "Certification de spécialiste en sauvetage de la GCC" },
                new Certificate { Id = 84, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "CCG SAR Mission Coordinator Certification", NameFre = "Certification du coordonnateur de mission SAR de la GCC" },
                new Certificate { Id = 85, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Maritime Command Naval Officer Professional Qualification (NOPQ)", NameFre = "Qualification professionnelle d'officier de marine du Commandement maritime (NOPQ)" },
                new Certificate { Id = 86, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Watchkeeping Mate Certificate", NameFre = "Officier de pont de quart" },
                new Certificate { Id = 87, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Chief Mate, Near Coastal", NameFre = "Premier officier de pont, à proximité du littoral" },
                new Certificate { Id = 88, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Transport Canada Certificate of Competency, Marine Engineering: Third or Fourth Class", NameFre = "Transport Canada Certificate of Competency, Marine Engineering: Third or Fourth Class" },
                new Certificate { Id = 89, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Transport Canada Certificate of Engineering (including ACV Engineering Class 1 or 2 and Aircraft Maintenance)", NameFre = "Transport Canada Certificate of Engineering (including ACV Engineering Class 1 or 2 and Aircraft Maintenance)" },
                new Certificate { Id = 90, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Transport Canada Certificate of Competency, First or Second or Third Class Marine Engineering", NameFre = "Transport Canada Certificate of Competency, First or Second or Third Class Marine Engineering" },
                new Certificate { Id = 91, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Red Seal Technical Trade Certification or Fourth Class Marine Engineering", NameFre = "Red Seal Technical Trade Certification or Fourth Class Marine Engineering" },
                new Certificate { Id = 92, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Small Vessel Operator Proficiency (SVOP)", NameFre = "Certificat de formation de conducteur de petits bâtiments" },
                new Certificate { Id = 93, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "General Operators Certificate (GOC)", NameFre = "Certificat d'opérateur général (COG)" },
                new Certificate { Id = 94, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Project Management Professional, Certified", NameFre = "Professionnel de la gestion de projet, certifié" },
                new Certificate { Id = 95, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "IT Security Certification", NameFre = "Certification de sécurité informatique" },
                new Certificate { Id = 96, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "MELDEV Program, Entry Level", NameFre = "Programme PELM, niveau d’entrée" },
                new Certificate { Id = 97, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "MELDEV Program, Intermediate Level", NameFre = "Programme PELM, niveau intermédiaire" },
                new Certificate { Id = 98, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "MELDEV Program, Final Level", NameFre = "Programme PELM, dernier niveau" },
                new Certificate { Id = 99, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Electronic Technologist", NameFre = "Technologue en électronique" },
                new Certificate { Id = 100, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Project Management", NameFre = "Gestion de projet" },
                new Certificate { Id = 101, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Incident Command System (ICS-300)", NameFre = "Système de commandement d'intervention (SCI-300)" },
                new Certificate { Id = 102, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master, Near Coastal", NameFre = "Capitaine, à proximité du littoral" },
                new Certificate { Id = 103, DescEng = "lorem ipsum", DescFre = "lorem ipsum", NameEng = "Master 500 GT, Near Coastal", NameFre = "Capitaine, jauge brute de 500, à proximité du littoral" },
        };
    }
}