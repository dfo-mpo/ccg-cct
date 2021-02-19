﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<JobPosition> JobPositions = new List<JobPosition>()
        {
            new JobPosition
            {
                Id = 1,
                TitleEng =
                    "Administrative (Admin) or Project Assistant or Executive Assitant / Officer (Aids to Nav. Database, Financial Admin, Scheduling Coordination, Documentation Control, Publication, Technical Business",
                TitleFre =
                    "Assistant administratif ou de projet / Agent (Données d'aide à la navigation, Administratif financière, planification / Coordination contrôle de document, Publication, Affaires techniques"
            },
            new JobPosition
            {
                Id = 2, TitleEng = "Administrative / Information Officer",
                TitleFre = "Agent administratif Services de gestion intégrée des affaires (SGIA)"
            },
            new JobPosition
            {
                Id = 3, TitleEng = "Fleet Activity Information System (FAIS) Coordinator",
                TitleFre = "Coordinateur Système d’information sur les activités de la flotte (FAIS)"
            },
            new JobPosition
            {
                Id = 4, TitleEng = "Fleet Training Coordinator Assistant",
                TitleFre = "Officier de formation de la flotte"
            },
            new JobPosition
            {
                Id = 5,
                TitleEng =
                    "Officer (Business Services, Resources, Documentation & Management, Documentation & Systems Control, Resources Planning, Business Planning, Administrative)",
                TitleFre =
                    "Agent (services opérationnels, ressource/gestion des documents, système de contrôle des documents, planification des ressources, planification d'affaires, administratifs)"
            },
            new JobPosition
            {
                Id = 6,
                TitleEng =
                    "Analyst Public Affairs and International Relations (PAIR)/Strategic Business Mangement (SBM)",
                TitleFre =
                    "Analyste Affaires publiques et gestion internationale (PAIR)/Gestion stratégique des affaires (GSA)"
            },
            new JobPosition
            {
                Id = 7, TitleEng = "Human Resources (HR) Officer/ Workforce Development",
                TitleFre = "Agent des ressources humaines / développement de la main-d'œuvre"
            },
            new JobPosition
            {
                Id = 8, TitleEng = "Finance Officer (Strategic Planning & Finance)",
                TitleFre = "Agent financier (Planification stratégique et financière)"
            },
            new JobPosition
                {Id = 9, TitleEng = "Maritime Administrative Assistant", TitleFre = "Administrateur maritime"},
            new JobPosition {Id = 10, TitleEng = "Project Assistant", TitleFre = "Assistant de projet"},
            new JobPosition
            {
                Id = 11,
                TitleEng =
                    "Executive Assistant to the Director General (DG) / Administrative Assistant to the Deputy Commissioner / Administrative Assistant to the Director & Administrative Assistant to the Executive Director",
                TitleFre =
                    "Adjoint exécutif au Directeur Général / Adjoint administratif au commissaire adjoint / Adjoint administratif au directeur et adjoint administratif au directeur exécutif"
            },
            new JobPosition
            {
                Id = 12, TitleEng = "Staff Management Specialist & Front Desk Supervisor",
                TitleFre = "Spécialiste en gestion du personnel et superviseur à la réception"
            },
            new JobPosition
            {
                Id = 13, TitleEng = "Training Administrative Assistant & Linguistic Services Officer",
                TitleFre = "Administrateur de formation & Agent des services linguistiques"
            },
            new JobPosition
            {
                Id = 14, TitleEng = "Official Publications & Intranet Management",
                TitleFre = "Gestion de publication officielles et intranet"
            },
            new JobPosition
            {
                Id = 15,
                TitleEng =
                    "Officer (Regulatory Quality & Planning, Planning Consultation & Program Support, Plan & Special Projects, Planning, Document Control & Audit Coordinator, Planning & Coordination, Administration, Telecom Planning)",
                TitleFre =
                    "Officer (qualité et planification, support à la planification, consultation et programme, planification de projets spéciaux, planification, contrôle et vérification de documents, planification et de coordination, administratif, planification des télécommunications)"
            },
            new JobPosition {Id = 16, TitleEng = "Workforce Officer", TitleFre = "Agent de la main-d'œuvre"},
            new JobPosition {Id = 17, TitleEng = "Business Analyst", TitleFre = "Analyste d'affaires"},
            new JobPosition
            {
                Id = 18, TitleEng = "Recruitment / Workforce Development Officer",
                TitleFre = "Agent - recrutement et développement de la main-d'oeuvre"
            },
            new JobPosition
            {
                Id = 19,
                TitleEng = "Finance & Administration Officer / Capital Budget Analyst / Analyst / Research Analyst",
                TitleFre =
                    "Agent finance et administration / Analyste budget d'investissement / Analyste / Analyste de recherche"
            },
            new JobPosition {Id = 20, TitleEng = "Training Officer", TitleFre = "Agent de formation"},
            new JobPosition
            {
                Id = 21,
                TitleEng =
                    "Search and Rescue (SAR) System Specialist / Incident Control Systems (ICS) Operations Officer / Notices to Mariners Officers",
                TitleFre =
                    "Spécialiste du système Recharge et sauvetage (SAR) / Officier des opérations Système de commandement d'intervention (SCI) / Agent, avis aux navigateurs"
            },
            new JobPosition {Id = 22, TitleEng = "Crewing Officer", TitleFre = "Officier d'équipage"},
            new JobPosition
                {Id = 23, TitleEng = "Cadet Liaison Officer", TitleFre = "Officier de liaison des cadets"},
            new JobPosition
            {
                Id = 24,
                TitleEng = "Supervisor, Recorded Information Management / Databse Agent / Operations Data Support",
                TitleFre =
                    "Superviseur, gestion de l'information enregistrée / Agent des bases de données / Support des données opérationnelles"
            },
            new JobPosition
            {
                Id = 25,
                TitleEng =
                    "Officer (Business Services, Regulatory Coast Guard Planning, Investment, Project Planning & Control, Planning, Staff Management & Business Services) / Policy Analyst",
                TitleFre =
                    "Agent (Services aux entreprises, planification et règlement de la Garde côtière, Investissement, Planification de projets & Contrôle, Planification, Gestion du personnel & Services aux entreprises) / Analyste des politiques"
            },
            new JobPosition
            {
                Id = 26,
                TitleEng =
                    "Senior Analyst Public Affairs and International Management (PAIM)/Business Resource Management (BRM)",
                TitleFre =
                    "Affaires publiques et gestion internationale (PAIM) / Entreprise et gestion des ressources (EGR)"
            },
            new JobPosition
            {
                Id = 27, TitleEng = "Performance & Quality Assurance Officer",
                TitleFre = "Agent, assurance de la qualité et gestion du rendement"
            },
            new JobPosition
            {
                Id = 28,
                TitleEng =
                    "Executive Assistant to the Assistant Commissioner (AC), Deputy Commissioner (DC), Staff Officer to the Director General (DG)",
                TitleFre =
                    "Adjoint exécutif au Commissaire adjoint/associé, Commissaire, Chef de cabinet au Directeur génerale (DG)"
            },
            new JobPosition
            {
                Id = 29, TitleEng = "Workforce Development Manager",
                TitleFre = "Gestionnaire du perfectionnement de la main-d'œuvre"
            },
            new JobPosition
            {
                Id = 30, TitleEng = "Workforce Development Analyst",
                TitleFre = "Analyste du perfectionnement de la main-d'œuvre"
            },
            new JobPosition
            {
                Id = 31, TitleEng = "Fleet Resources Manager", TitleFre = "Gestionnaire des ressources de la flotte"
            },
            new JobPosition
            {
                Id = 32,
                TitleEng = "Public Affairs - Web Officer / Leader Communications (Comms) & Internet / PIO Manager",
                TitleFre =
                    "Affaires publiques - Agent de développement de site Web / Leader Communications et Internet"
            },
            new JobPosition
            {
                Id = 33, TitleEng = "Marine Security Operations Centre (MSOC) Operations Liaison Officer",
                TitleFre = "Agent de liaison des opérations des Centre des opérations de la sûreté maritime (COSM)"
            },
            new JobPosition
            {
                Id = 34, TitleEng = "Officer - Fleet (Exercise Planning, Staff Liaison, Standards & Training)",
                TitleFre =
                    "Agent - Flotte (planification des exercices, liaison avec le personnel, normes et formation)"
            },
            new JobPosition
            {
                Id = 35, TitleEng = "Manager Finance Admin. & Planning / Executive & Client Services Officer",
                TitleFre =
                    "Gestionnaire de l'admin. et de la planification des finances / Agent de la direction et des services à la clientèle"
            },
            new JobPosition
            {
                Id = 36,
                TitleEng =
                    "Officer (Occupational Health and Safety (OHS), Information Management and Physical Requirements)",
                TitleFre =
                    "Officier (Legislation de santé et sécurité, gestion de l'information et exigences matérielles)"
            },
            new JobPosition
            {
                Id = 37,
                TitleEng =
                    "Client Relations, Minister Correspondence & Project, Consultations, Planning and Performance",
                TitleFre =
                    "Relations les clients, Correspondance ministérielle et projets, Consultations, Planification et gestion du rendement"
            },
            new JobPosition {Id = 38, TitleEng = "Business Manager", TitleFre = "Gestionnaire des opérations"},
            new JobPosition
            {
                Id = 39,
                TitleEng =
                    "Analyst (Sr. Expenditure & Planning, Portfolio, Senior Business Operations & Analysis, Planning, Business, Service Delivery, Pricing, Senior Resource, Senior Policy, Regulations & Legislation) / Analyst Strategic Initiatives / Budget & Resource Allocation",
                TitleFre =
                    "Analyste (Dépenses et planification principales, Portefeuille, Opérations et analyse opérationnelles principales, Planification, Affaires, Prestation de services, Établissement des prix, Ressources principales, Politiques principales, Réglementation et législation) / Analystes initiatives stratégiques / Budget et répartition des ressources"
            },
            new JobPosition
            {
                Id = 40, TitleEng = "Manager Business Resource Management (BRM)",
                TitleFre = "Gestionnaire de Entreprise et gestion des ressources(EGR)"
            },
            new JobPosition
                {Id = 41, TitleEng = "Senior Business Analyst", TitleFre = "Analyste d'affaires principal"},
            new JobPosition
            {
                Id = 42, TitleEng = "Collective Bargaining & Human Resources (HR) Issues Officer",
                TitleFre = "Agent chargé des négociations collectives et des questions en ressources humaines"
            },
            new JobPosition
            {
                Id = 43, TitleEng = "Crewing Analyst & Human Resources (HR) Issues Officer",
                TitleFre = "Analyste d'équipage et responsable des ressources humaines"
            },
            new JobPosition
            {
                Id = 44, TitleEng = "Fleet Safety Security Compliance Officer",
                TitleFre = "Agent de la conformité et de la sécurité de la flotte"
            },
            new JobPosition
                {Id = 45, TitleEng = "Head of Student Affairs", TitleFre = "Chef des affaires étudiantes"},
            new JobPosition
            {
                Id = 46, TitleEng = "Campus Services Manager", TitleFre = "Gestionnaire des services sur le campus"
            },
            new JobPosition
            {
                Id = 47, TitleEng = "Supervisor Seagoing Personnel", TitleFre = "Superviseur, personnel naviguant"
            },
            new JobPosition
            {
                Id = 48, TitleEng = "Senior Fleet Logistics Policy Analyst",
                TitleFre = "Analyste principal des politiques logistiques de la flotte"
            },
            new JobPosition
            {
                Id = 49, TitleEng = "Coordinator Search and Rescue (SAR) Projects",
                TitleFre = "Coordinateur, projets Recherche et sauvetage (SAR)"
            },
            new JobPosition
            {
                Id = 50, TitleEng = "Business Intelligence Administrator", TitleFre = "Administrateur des affaires"
            },
            new JobPosition
            {
                Id = 51, TitleEng = "Leader Monitoring Communications and Information",
                TitleFre = "Chef de la surveillance des communications et de l'information"
            },
            new JobPosition
            {
                Id = 52, TitleEng = "Regional Supervisor Network Services",
                TitleFre = "Superviseur régionale services de réseau"
            },
            new JobPosition
            {
                Id = 53, TitleEng = "Desk Officer Technical Training",
                TitleFre = "Officier d'entrainement technique"
            },
            new JobPosition {Id = 54, TitleEng = "Compliance Auditor", TitleFre = "Auditeur de comformité"},
            new JobPosition
            {
                Id = 55,
                TitleEng = "Analyst (Senior Public Affairs, Senior Planning & Performance, Business Planning)",
                TitleFre =
                    "Analyste (principal - affaires publiques, principal - planification et rendement, planification d'affaires)"
            },
            new JobPosition
            {
                Id = 56,
                TitleEng = "Analyst - Fleet (Fleet Management, Exercise Planning Senior, Marine Operations)",
                TitleFre =
                    "Analyste - Flotte (Gestion de la flotte, analyste principal-planification d'exercice, opérations maritimes)"
            },
            new JobPosition {Id = 57, TitleEng = "Investment Analyst", TitleFre = "Analyste des investissements"},
            new JobPosition
            {
                Id = 58,
                TitleEng =
                    "Manager (Operations Data, Planning & Performance, Program Planning, Cost-Control Systems, Risk Management, Performance Management, International Safety Management (ISM) Code Compliance & Audit), & Performance Measurement Officer",
                TitleFre =
                    "Gestionnaire (Données opérationnelles, Planification et rendement, Planification des programmes, Systèmes de contrôle des coûts, Gestion du risque, Gestion du rendement, Code de conformité et de vérification), & Agent, mesure du rendement"
            },
            new JobPosition
            {
                Id = 59,
                TitleEng =
                    "Superintendent, Fleet Safety & Security / Marine Security Operations Centre (MSOC) Project Division",
                TitleFre =
                    "Surintendant, sûreté et sécurité de la flotte / Projet Centre des opérations de la sûreté maritime (COSM)"
            },
            new JobPosition
            {
                Id = 60, TitleEng = "Head Quality Assurance & Academic Excellence",
                TitleFre = "Chef de l'assurance de la qualité et du cadre d'enseignement"
            },
            new JobPosition
            {
                Id = 61, TitleEng = "Executive Advisor to the Deputy Commissioner",
                TitleFre = "Conseiller exécutif du commissaire adjoint"
            },
            new JobPosition
            {
                Id = 62, TitleEng = "Regional Director, Integrated Business Management Services (IBMS)",
                TitleFre = "Directeur régional Services de gestion intégrée des affaires (SGIA)"
            },
            new JobPosition
            {
                Id = 63, TitleEng = "Operations Personnel Manager",
                TitleFre = "Gestionnaire personnel des opérations"
            },
            new JobPosition
            {
                Id = 64, TitleEng = "Manager Policy and Standards Operations Personnel",
                TitleFre = "Gestionnaire politique et normes du personnel des opérations"
            },
            new JobPosition {Id = 65, TitleEng = "Chief Operating Officer", TitleFre = "Chef de l'exploitation"},
            new JobPosition
            {
                Id = 66, TitleEng = "Manager Professional Development and Certification",
                TitleFre = "Gestionnaire perfectionnement professionnel et certification"
            },
            new JobPosition
            {
                Id = 67, TitleEng = "Executive Assistant for Commissioner",
                TitleFre = "Adjoint exécutif du commissaire"
            },
            new JobPosition
            {
                Id = 69,
                TitleEng =
                    "Manager (Business Operations & Analysis, Resource Management, Service Delivery, Policy & Standards)",
                TitleFre =
                    "Gestionnaire (analyse et opération d'affaires, gestion des ressources, prestation de services, normes et politiques, etc.)"
            },
            new JobPosition
            {
                Id = 70, TitleEng = "Manager Workforce Development",
                TitleFre = "Gestionnaire développement de la main-d'oeuvre"
            },
            new JobPosition
            {
                Id = 71, TitleEng = "Manager, Performance Measurement",
                TitleFre = "Gestionnaire mesure du rendement"
            },
            new JobPosition
            {
                Id = 72, TitleEng = "Manager Operations & Finance Planning",
                TitleFre = "Gestionnaire planification des opérations et des finances"
            },
            new JobPosition
            {
                Id = 73, TitleEng = "Manager Public Affairs & Information Management",
                TitleFre = "Gestionnaire affaires publiques et gestion de l'information"
            },
            new JobPosition
            {
                Id = 74, TitleEng = "Manager Fleet Investment",
                TitleFre = "Gestionnaire investissement de la flotte"
            },
            new JobPosition
            {
                Id = 75, TitleEng = "Manager, Incident Management", TitleFre = "Gestionnaire gestion des incidents"
            },
            new JobPosition
            {
                Id = 76, TitleEng = "Senior Advisor Maritime Security",
                TitleFre = "Conseiller principal sécurité maritime"
            },
            new JobPosition
                {Id = 77, TitleEng = "Director, Safety and Security", TitleFre = "Directeur sûreté et sécurité"},
            new JobPosition {Id = 78, TitleEng = "Clerical Administrator", TitleFre = "Commis-administrateur"},
            new JobPosition {Id = 79, TitleEng = "Clerical Administrator", TitleFre = "Commis-administrateur"},
            new JobPosition {Id = 80, TitleEng = "Administrative Assistant", TitleFre = "Assistant administratif"},
            new JobPosition {Id = 81, TitleEng = "Administrative Assistant", TitleFre = "Assistant administratif"},
            new JobPosition {Id = 82, TitleEng = "Machine Operator", TitleFre = "Opérateur"},
            new JobPosition {Id = 83, TitleEng = "Machine Operator", TitleFre = "Opérateur"},
            new JobPosition {Id = 84, TitleEng = "Carpenter Apprentice", TitleFre = "Apprenti charpentier"},
            new JobPosition {Id = 85, TitleEng = "Carpenter", TitleFre = "Charpentier"},
            new JobPosition
            {
                Id = 86, TitleEng = "Vehicle and Heavy Equipment Maintainer",
                TitleFre = "Maintenance de véhicules et équipements lourds"
            },
            new JobPosition
            {
                Id = 87, TitleEng = "Painters and Construction Finishing",
                TitleFre = "Peintres et finition de construction"
            },
            new JobPosition
            {
                Id = 88, TitleEng = "Painters and Construction Finishing",
                TitleFre = "Peintres et finition de construction"
            },
            new JobPosition
            {
                Id = 89, TitleEng = "Painters and Construction Finishing",
                TitleFre = "Peintres et finition de construction"
            },
            new JobPosition
            {
                Id = 90, TitleEng = "Public Safety Diver-Deckhand",
                TitleFre = "Plongeur de la sécurité publique - matelot"
            },
            new JobPosition
            {
                Id = 91, TitleEng = "Public Safety Diver-Leading Deckhand",
                TitleFre = "Plongeur de la sécurité publique – matelot de 1re classe"
            },
            new JobPosition
            {
                Id = 92, TitleEng = "Operations Specialist-Air Cushioned Vehicle (ACV)",
                TitleFre = "Plongeur de la sécurité publique – matelot de 1re classe"
            },
            new JobPosition {Id = 93, TitleEng = "Steward", TitleFre = "Steward"},
            new JobPosition {Id = 94, TitleEng = "Second Cook", TitleFre = "Deuxième cuisinier"},
            new JobPosition {Id = 95, TitleEng = "Chief Cook", TitleFre = "Chef cuisinier"},
            new JobPosition {Id = 96, TitleEng = "Storekeeper", TitleFre = "Magasinier"},
            new JobPosition {Id = 97, TitleEng = "Chief Cook", TitleFre = "Chef cuisinier"},
            new JobPosition {Id = 98, TitleEng = "Deckhand", TitleFre = "Matelot de pont"},
            new JobPosition {Id = 99, TitleEng = "Leading Deckhand", TitleFre = "Chef de pont"},
            new JobPosition {Id = 100, TitleEng = "Twinehand", TitleFre = "Matelot des pêches"},
            new JobPosition {Id = 101, TitleEng = "Bosun's Mate", TitleFre = "Mate de Bosun"},
            new JobPosition {Id = 102, TitleEng = "Boatswain", TitleFre = "Maître d'équipage"},
            new JobPosition {Id = 103, TitleEng = "Coxwains", TitleFre = "Capitaine d'armes"},
            new JobPosition {Id = 104, TitleEng = "Coxwains", TitleFre = "Capitaine d'armes"},
            new JobPosition {Id = 105, TitleEng = "Oiler", TitleFre = "Huileur"},
            new JobPosition {Id = 106, TitleEng = "Oiler", TitleFre = "Huileur"},
            new JobPosition {Id = 107, TitleEng = "Senior Oiler", TitleFre = "Ingénieur en chef"},
            new JobPosition
            {
                Id = 108, TitleEng = "Supply Officer (Logistics)",
                TitleFre = "Agent d'approvisionnement (Logistique)"
            },
            new JobPosition
            {
                Id = 109, TitleEng = "3rd Engineers (Atlantic Region)",
                TitleFre = "3e ingénieurs (Région de l'Atlantique)"
            },
            new JobPosition
            {
                Id = 110, TitleEng = "3rd Officer (Atlantic Region)",
                TitleFre = "3e officiers (Région de l'Atlantique)"
            },
            new JobPosition
            {
                Id = 111, TitleEng = "Supply Officer (Logistics)",
                TitleFre = "Agent d'approvisionnement (Logistique)"
            },
            new JobPosition {Id = 112, TitleEng = "2nd Officer (Deck)", TitleFre = "2e officier (pont)"},
            new JobPosition {Id = 113, TitleEng = "3rd Officer (Deck)", TitleFre = "3e officier (pont)"},
            new JobPosition
            {
                Id = 114, TitleEng = "Engineering Officer (Engineering)", TitleFre = "Officier d'ingénierie (génie)"
            },
            new JobPosition
            {
                Id = 115, TitleEng = "Engineering Officer Motor Life Boat (MLB)",
                TitleFre = "Officier mécanicien Bateau de sauvetage (BDS)"
            },
            new JobPosition {Id = 116, TitleEng = "Fishing Officer", TitleFre = "Agent des pêches"},
            new JobPosition {Id = 117, TitleEng = "2nd Officer (Deck)", TitleFre = "2e officier (pont)"},
            new JobPosition
                {Id = 118, TitleEng = "Small Vessel Commanding Officer", TitleFre = "Commandant du petit bâtiment"},
            new JobPosition {Id = 119, TitleEng = "Engineer", TitleFre = "Ingénieur"},
            new JobPosition {Id = 120, TitleEng = "Fishing Officer", TitleFre = "Agent des pêches"},
            new JobPosition {Id = 121, TitleEng = "Logistics Officer", TitleFre = "Officier logistique"},
            new JobPosition
                {Id = 122, TitleEng = "Roving Logistics Officer", TitleFre = "Officier logistique itinérant"},
            new JobPosition {Id = 123, TitleEng = "Electrical Officer", TitleFre = "Officier électricien"},
            new JobPosition {Id = 124, TitleEng = "Engineer", TitleFre = "Ingénieur"},
            new JobPosition {Id = 125, TitleEng = "Engineering Officer", TitleFre = "Officier d'ingénierie"},
            new JobPosition
                {Id = 126, TitleEng = "Senior Engineering Officer", TitleFre = "Officier d'ingénierie sénior"},
            new JobPosition {Id = 127, TitleEng = "Chief Officer", TitleFre = "Chef officier"},
            new JobPosition
                {Id = 128, TitleEng = "Watchkeeping Chief Officer", TitleFre = "Officier en chef de quart"},
            new JobPosition {Id = 129, TitleEng = "Logistics Officer", TitleFre = "Officier logistique"},
            new JobPosition {Id = 130, TitleEng = "Chief Officer", TitleFre = "Chef officier"},
            new JobPosition {Id = 131, TitleEng = "Fishing Officer", TitleFre = "Agent des pêches"},
            new JobPosition
                {Id = 132, TitleEng = "Senior Engineering Officer", TitleFre = "Officier d'ingénierie sénior"},
            new JobPosition {Id = 133, TitleEng = "Chief Officer", TitleFre = "Chef officier"},
            new JobPosition
                {Id = 134, TitleEng = "Senior Engineering Officer", TitleFre = "Officier d'ingénierie sénior"},
            new JobPosition
                {Id = 135, TitleEng = "Senior Engineering Officer", TitleFre = "Officier d'ingénierie sénior"},
            new JobPosition {Id = 136, TitleEng = "Chief Engineer", TitleFre = "Ingénieur en chef"},
            new JobPosition {Id = 137, TitleEng = "Senior Engineer", TitleFre = "Ingénieur senior"},
            new JobPosition {Id = 138, TitleEng = "Chief Engineer", TitleFre = "Ingénieur en chef"},
            new JobPosition {Id = 139, TitleEng = "Commanding Officer", TitleFre = "Commandant"},
            new JobPosition {Id = 140, TitleEng = "Commanding Officer", TitleFre = "Commandant"},
            new JobPosition {Id = 141, TitleEng = "Chief Engineer", TitleFre = "Ingénieur en chef"},
            new JobPosition {Id = 142, TitleEng = "Commanding Officer", TitleFre = "Commandant"},
            new JobPosition {Id = 143, TitleEng = "Chief Engineer", TitleFre = "Ingénieur en chef"},
            new JobPosition {Id = 144, TitleEng = "Commanding Officer", TitleFre = "Commandant"},
            new JobPosition {Id = 145, TitleEng = "Chief Engineer", TitleFre = "Ingénieur en chef"},
            new JobPosition {Id = 146, TitleEng = "Commanding Officer", TitleFre = "Commandant"},
            new JobPosition {Id = 147, TitleEng = "Chief Engineer", TitleFre = "Ingénieur en chef"},
            new JobPosition {Id = 148, TitleEng = "Commanding Officer", TitleFre = "Commandant"},
            new JobPosition
                {Id = 149, TitleEng = "Sea Training Officer", TitleFre = "Officier de formation en mer"},
            new JobPosition
            {
                Id = 150, TitleEng = "Maritime Navigation Instructor",
                TitleFre = "Instructeur en navigation maritime"
            },
            new JobPosition {Id = 151, TitleEng = "Engineering Instructor", TitleFre = "Instructeur d'ingénierie"},
            new JobPosition
            {
                Id = 152, TitleEng = "Superintendent of Officer Cadets",
                TitleFre = "Surintendant des élèves-officiers"
            },
            new JobPosition {Id = 153, TitleEng = "Head of Navigation", TitleFre = "Chef de la navigation"},
            new JobPosition {Id = 154, TitleEng = "Assistant Librarian", TitleFre = "Bibliothécaire adjoint"},
            new JobPosition
            {
                Id = 155, TitleEng = "Manager, Library Services",
                TitleFre = "Gestionnaire, Services de bibliothèque"
            },
            new JobPosition
            {
                Id = 156, TitleEng = "Library Information Manager/Advisor",
                TitleFre = "Gestionnaire / conseiller en information de bibliothèque"
            },
            new JobPosition
            {
                Id = 157, TitleEng = "Manager, Library Policies/Services",
                TitleFre = "Gestionnaire, Politiques et services de bibliothèque"
            },
            new JobPosition {Id = 158, TitleEng = "Health Officer", TitleFre = "Agent de santé"},
            new JobPosition {Id = 159, TitleEng = "Nurse Practitoner", TitleFre = "Infirmière praticienne"},
            new JobPosition
            {
                Id = 160, TitleEng = "National Coordinator Canadian Coast Guard (CCG) Health Officer Program",
                TitleFre =
                    "Coordonnateur national Programme des agents de santé de la Garde côtière canadienne(GCC)"
            },
            new JobPosition
                {Id = 161, TitleEng = "Office Equipment Operator", TitleFre = "Conducteur d'équipement de bureau"},
            new JobPosition
            {
                Id = 162, TitleEng = "Duplicating Equipment Operator",
                TitleFre = "Opérateur d'équipement de reproduction"
            },
            new JobPosition
            {
                Id = 163, TitleEng = "Duplicating Equipment Operator",
                TitleFre = "Opérateur d'équipement de reproduction"
            },
            new JobPosition
                {Id = 164, TitleEng = "Warehouse clerk apprentice", TitleFre = "Apprenti commis d'entrepôt"},
            new JobPosition {Id = 165, TitleEng = "Warehouse clerk", TitleFre = "Commis d'entrepôt"},
            new JobPosition {Id = 166, TitleEng = "Warehouse clerk", TitleFre = "Commis d'entrepôt"},
            new JobPosition
                {Id = 167, TitleEng = "Physical Education Trainer", TitleFre = "Entraîneur d'éducation physique"},
            new JobPosition
            {
                Id = 168, TitleEng = "Physical Education Instructor", TitleFre = "Instructeur d'éducation physique"
            },
            new JobPosition {Id = 169, TitleEng = "Cooks", TitleFre = "Cuisiniers"},
            new JobPosition {Id = 170, TitleEng = "Cooks", TitleFre = "Cuisiniers"},
            new JobPosition {Id = 171, TitleEng = "Chief Cook", TitleFre = "Chef cuisinier"},
            new JobPosition
                {Id = 172, TitleEng = "Forklift Operator", TitleFre = "Conducteur de chariot élévateur à fourche"},
            new JobPosition
                {Id = 173, TitleEng = "Forklift Operator", TitleFre = "Conducteur de chariot élévateur à fourche"},
            new JobPosition
            {
                Id = 174, TitleEng = "Training & Quality Assurance Officer",
                TitleFre = "Agente de formation et d'assurance de la qualité"
            },
            new JobPosition
            {
                Id = 175, TitleEng = "Instructor, English as a Second Language",
                TitleFre = "Instructeur, anglais langue seconde"
            },
            new JobPosition
            {
                Id = 176, TitleEng = "Instructor, French as a Second Language",
                TitleFre = "Instructeur, français langue seconde"
            },
            new JobPosition {Id = 177, TitleEng = "Science Instructor", TitleFre = "Instructeur de science"},
            new JobPosition
                {Id = 178, TitleEng = "Head, Arts, Science & Language", TitleFre = "Chef, arts, science et langue"},
            new JobPosition {Id = 179, TitleEng = "Lightkeeper", TitleFre = "Gardien de phare"},
            new JobPosition {Id = 180, TitleEng = "Lightkeeper", TitleFre = "Gardien de phare"},
            new JobPosition {Id = 181, TitleEng = "Lightkeeper", TitleFre = "Gardien de phare"},
            new JobPosition {Id = 182, TitleEng = "Lightkeeper", TitleFre = "Gardien de phare"},
            new JobPosition {Id = 183, TitleEng = "Principal Lightkeeper", TitleFre = "Gardien de phare principal"},
            new JobPosition {Id = 184, TitleEng = "Principal Lightkeeper", TitleFre = "Gardien de phare principal"},
            new JobPosition {Id = 185, TitleEng = "Principal Lightkeeper", TitleFre = "Gardien de phare principal"},
            new JobPosition
            {
                Id = 186, TitleEng = "Marine Communications and Traffic Services (MCTS) Trainee",
                TitleFre = "Stagiaire services de communication et de trafic maritimes (SCTM)"
            },
            new JobPosition
            {
                Id = 187, TitleEng = "Marine Communications and Traffic Services (MCTS) Officer",
                TitleFre = "Officier services de communication et de trafic maritimes (SCTM)"
            },
            new JobPosition
            {
                Id = 188, TitleEng = "Marine Communications and Traffic Services (MCTS) Supervisor",
                TitleFre = "Superviseur services de communication et de trafic maritimes (SCTM)"
            },
            new JobPosition
                {Id = 189, TitleEng = "Regional Training Officer", TitleFre = "Agente régionale de formation"},
            new JobPosition
            {
                Id = 190, TitleEng = "Marine Communications and Traffic Services (MCTS) Instructor",
                TitleFre = "Instructeur services de communication et de trafic maritimes (SCTM)"
            },
            new JobPosition {Id = 191, TitleEng = "Officer in Charge", TitleFre = "Officier en charge"},
            new JobPosition
            {
                Id = 192, TitleEng = "Regional Program Specialist", TitleFre = "Spécialiste de programme régional"
            },
            new JobPosition
            {
                Id = 193, TitleEng = "National Program Specialist", TitleFre = "Spécialiste du programme national"
            },
            new JobPosition {Id = 194, TitleEng = "General Labourer", TitleFre = "Manœuvre général"},
            new JobPosition {Id = 195, TitleEng = "Maintenance", TitleFre = "Maintenance"},
            new JobPosition {Id = 196, TitleEng = "Driver/Operator", TitleFre = "Conducteur / opérateur"},
            new JobPosition
            {
                Id = 197, TitleEng = "Supervisor Field Work, Maintenance Assistant",
                TitleFre = "Superviseur des travaux sur le terrain, assistant d'entretien"
            },
            new JobPosition
                {Id = 198, TitleEng = "General Labourer/Operator", TitleFre = "Manœuvre / opérateur général"},
            new JobPosition {Id = 199, TitleEng = "Welder", TitleFre = "Soudeur"},
            new JobPosition {Id = 200, TitleEng = "Welder", TitleFre = "Soudeur"},
            new JobPosition {Id = 201, TitleEng = "Carpenter", TitleFre = "Charpentier"},
            new JobPosition
            {
                Id = 202, TitleEng = "Assistant Facility, Manager",
                TitleFre = "Adjointe à l'installation, gestionnaire"
            },
            new JobPosition
            {
                Id = 203, TitleEng = "Foreperson, Aids to Navigation (AtoN)",
                TitleFre = "Contremaître, Aides à la navigation (AtoN)"
            },
            new JobPosition
                {Id = 204, TitleEng = "Foreperson, Field Shop", TitleFre = "Contremaître, atelier de chantier"},
            new JobPosition
            {
                Id = 205, TitleEng = "Foreperson, Maritime and Civil Infrastructure (MCI)",
                TitleFre = "Contremaître, Infrastructures maritimes et civiles (MCI)"
            },
            new JobPosition {Id = 206, TitleEng = "Foreperson, Production", TitleFre = "Contremaître, Production"},
            new JobPosition {Id = 207, TitleEng = "Transportation Driver", TitleFre = "Conducteur de transport"},
            new JobPosition {Id = 208, TitleEng = "Driver", TitleFre = "Conducteur"},
            new JobPosition {Id = 209, TitleEng = "Equipment Operator", TitleFre = "Opérateur d'équipement"},
            new JobPosition
                {Id = 210, TitleEng = "Heavy Equipment Operator", TitleFre = "Opérateur d'équipement lourd"},
            new JobPosition
            {
                Id = 211, TitleEng = "Vessel and Equipment Operator",
                TitleFre = "Conducteur de navire et opérateur d'équipement"
            },
            new JobPosition {Id = 212, TitleEng = "Precision Working", TitleFre = "Travail en précision"},
            new JobPosition {Id = 213, TitleEng = "Precision Working", TitleFre = "Travail en précision"},
            new JobPosition {Id = 214, TitleEng = "Precision Working", TitleFre = "Travail en précision"},
            new JobPosition {Id = 215, TitleEng = "Precision Working", TitleFre = "Travail en précision"},
            new JobPosition
                {Id = 216, TitleEng = "Deisel Mechanic, Electrician", TitleFre = "Mécanicien diesel, électricien"},
            new JobPosition {Id = 217, TitleEng = "Lamp Technician", TitleFre = "Technicien de lampe"},
            new JobPosition {Id = 218, TitleEng = "Maintenance Mechanic", TitleFre = "Mécanicien d'entretien"},
            new JobPosition {Id = 219, TitleEng = "Painter", TitleFre = "Peintre"},
            new JobPosition
            {
                Id = 220, TitleEng = "Vessel Repair Technician, Mechanic",
                TitleFre =
                    "Technicien / technicienne en réparation de navires, Mécanicien / Mécanicienne de navires"
            },
            new JobPosition {Id = 221, TitleEng = "Welder", TitleFre = "Soudeur"},
            new JobPosition
                {Id = 222, TitleEng = "Refrigeration Technician", TitleFre = "Technicien en réfrigération"},
            new JobPosition {Id = 223, TitleEng = "Foreperson", TitleFre = "Contremaître"},
            new JobPosition {Id = 224, TitleEng = "Assistant Librarian", TitleFre = "Bibliothécaire adjoint"},
            new JobPosition {Id = 225, TitleEng = "Policy Assistant", TitleFre = "Adjoint chargé des politiques"},
            new JobPosition
            {
                Id = 226, TitleEng = "Economic and Policy Analyst", TitleFre = "Analyste des politiques économiques"
            },
            new JobPosition {Id = 227, TitleEng = "Researcher and Analyst", TitleFre = "Chercheur et analyste"},
            new JobPosition
                {Id = 228, TitleEng = "Policy/Economic Analyst", TitleFre = "Analyste politique / économique"},
            new JobPosition {Id = 229, TitleEng = "Negotiator/Analyst", TitleFre = "Négociateur / analyste"},
            new JobPosition
                {Id = 230, TitleEng = "Senior Negotiator/Advisor", TitleFre = "Négociateur principal / conseiller"},
            new JobPosition
            {
                Id = 231, TitleEng = "Senior Policy/Economic Advisor",
                TitleFre = "Conseiller politique / économique principal"
            },
            new JobPosition
            {
                Id = 232, TitleEng = "Manager/Lead Advisor Policy, Programs and Economic",
                TitleFre = "Gestionnaire / Conseiller principal politiques, programmes et économie"
            },
            new JobPosition {Id = 233, TitleEng = "Technical Inspector", TitleFre = "Inspecteur technique"},
            new JobPosition {Id = 234, TitleEng = "Technical Inspector", TitleFre = "Inspecteur technique"},
            new JobPosition {Id = 235, TitleEng = "Project Officer", TitleFre = "Agente de projet"},
            new JobPosition {Id = 236, TitleEng = "Analyst", TitleFre = "Analyste"},
            new JobPosition {Id = 237, TitleEng = "Project Officer/Manager", TitleFre = "Gestionnaire de projet"},
            new JobPosition
            {
                Id = 238, TitleEng = "Deputy Superintendent Search and Rescue (SAR)",
                TitleFre = "Surintendant adjoint Recherche et sauvetage (SAR)"
            },
            new JobPosition
                {Id = 239, TitleEng = "Superintendent Icebreaking", TitleFre = "Surintendant Déglaçage"},
            new JobPosition
            {
                Id = 240, TitleEng = "Marine Navigation Senior Analyst",
                TitleFre = "Analyste principal en navigation maritime"
            },
            new JobPosition
            {
                Id = 241, TitleEng = "Deputy Advisor Capability Management Organization (CMO)",
                TitleFre = "Conseiller adjoint Organisation de gestion des capacités (CMO)"
            },
            new JobPosition
                {Id = 242, TitleEng = "Engagement/Liaison Officer", TitleFre = "Agent d'engagement / liaison"},
            new JobPosition
            {
                Id = 243, TitleEng = "Superintendent Marine Communications and Traffic Services (MCTS)",
                TitleFre = "Surintendant Services de communication et de trafic maritimes (SCTM)"
            },
            new JobPosition
            {
                Id = 244, TitleEng = "Superintendent Search and Rescue (SAR)",
                TitleFre = "Surintendant Recherche et sauvetage (SAR)"
            },
            new JobPosition
            {
                Id = 245, TitleEng = "Manager, Strategic Services", TitleFre = "Gestionnaire, Services stratégiques"
            },
            new JobPosition
            {
                Id = 246, TitleEng = "Manager, Indigenous Relations",
                TitleFre = "Gestionnaire, Relations avec les Autochtones"
            },
            new JobPosition
            {
                Id = 247, TitleEng = "Superintendent Vessels of Concern (VOC)",
                TitleFre = "Surintendant Navires préoccupants (VOC)"
            },
            new JobPosition
            {
                Id = 248, TitleEng = "Superintendent Aids to Navigation (AToN)",
                TitleFre = "Surintendant Aides à la navigation (AtoN)"
            },
            new JobPosition
            {
                Id = 249, TitleEng = "Project Manager Electronic Navigation (E-Nav)",
                TitleFre = "Gestionnaire de projet, navigation électronique"
            },
            new JobPosition
            {
                Id = 250, TitleEng = "Manager Marine Navigation Policies",
                TitleFre = "Gestionnaire, Politiques de navigation maritime"
            },
            new JobPosition
            {
                Id = 251, TitleEng = "Air Cushioned Vehicle (ACV) Engineer Trainee",
                TitleFre = "Ingénieur stagiaire en véhicule à coussin d'air (VCA)"
            },
            new JobPosition
            {
                Id = 252, TitleEng = "Air Cushioned Vehicle (ACV) Engineer, Shore Based Marine Engineer",
                TitleFre = "Ingénieur en véhicule à coussin d'air (VCA), ingénieur maritime à terre"
            },
            new JobPosition
            {
                Id = 253, TitleEng = "Aids to Navigation (AtoN) Design",
                TitleFre = "Conception des aides à la navigation (AtoN)"
            },
            new JobPosition
            {
                Id = 254, TitleEng = "Configuration Management and Technical Data Management (CMTDM) Officer",
                TitleFre =
                    "Responsable de la gestion de la configuration et de la gestion des données techniques (CMTDM)"
            },
            new JobPosition
            {
                Id = 255, TitleEng = "Aids to Navigation (AtoN) Technician",
                TitleFre = "Technicien en aides à la navigation (AtoN)"
            },
            new JobPosition {Id = 256, TitleEng = "Geomatics Technician", TitleFre = "Technicien en géomatique"},
            new JobPosition {Id = 257, TitleEng = "Hydraulic Engineering", TitleFre = "Ingénierie hydraulique"},
            new JobPosition
            {
                Id = 258, TitleEng = "Quality Assurance Coordinator",
                TitleFre = "Coordonnateur de l'assurance qualité"
            },
            new JobPosition
            {
                Id = 259, TitleEng = "Configuration Management and Technical Data Management (CMTDM) Supervisor",
                TitleFre =
                    "Superviseur de la gestion de la configuration et de la gestion des données techniques (CMTDM)"
            },
            new JobPosition
                {Id = 260, TitleEng = "Civil Engineer Technician", TitleFre = "Technicien en génie civil"},
            new JobPosition
            {
                Id = 261, TitleEng = "Hydraulic Engineering Supervisor",
                TitleFre = "Superviseur en génie hydraulique"
            },
            new JobPosition {Id = 262, TitleEng = "Workshop Supervisor", TitleFre = "Surveillant d'atelier"},
            new JobPosition
            {
                Id = 263, TitleEng = "Senior Geomatics Technician", TitleFre = "Technicien principal en géomatique"
            },
            new JobPosition
            {
                Id = 264, TitleEng = "Technical Maintenance Planner Coordinator",
                TitleFre = "Coordonnateur du planificateur de la maintenance technique"
            },
            new JobPosition
            {
                Id = 265, TitleEng = "Chief Engineer Air Cushion Vehicle",
                TitleFre = "Véhicule à coussin d'air de l'ingénieur en chef"
            },
            new JobPosition
            {
                Id = 266, TitleEng = "Project Officer Marine Engineering",
                TitleFre = "Agent de projet génie maritime"
            },
            new JobPosition {Id = 267, TitleEng = "Area Supervisor", TitleFre = "Superviseur de secteur"},
            new JobPosition
            {
                Id = 268, TitleEng = "Senior Marine Engineer Project Officer",
                TitleFre = "Agent principal de projet ingénieur maritime"
            },
            new JobPosition
            {
                Id = 269, TitleEng = "Senior Project Officer, Technical Project Officer",
                TitleFre = "Agent principal de projet, agent technique de projet"
            },
            new JobPosition
            {
                Id = 270, TitleEng = "Marine Electrical and Electronic Technician",
                TitleFre = "Technicien électrique et électronique maritime"
            },
            new JobPosition {Id = 271, TitleEng = "Geomatics Manager", TitleFre = "Responsable géomatique"},
            new JobPosition
            {
                Id = 272, TitleEng = "Response Specialist Trainee, Print Shop Operator",
                TitleFre = "Stagière - spécialiste en intervention, opérateur d'atelier d'impression"
            },
            new JobPosition
            {
                Id = 273, TitleEng = "Assistant Marine Search and Rescue (SAR) Controller",
                TitleFre = "Assistant au controleur maritime recherche et sauvetage (SAR)"
            },
            new JobPosition
            {
                Id = 274, TitleEng = "Officer (Pilot Trainee, Handling Operations)",
                TitleFre = "Officer (pilote stagière, enseignement - opérations)"
            },
            new JobPosition
            {
                Id = 275, TitleEng = "Ice Operations, Arctic Field Operations",
                TitleFre = "Opérations de déglaçage, opération en champs arctique"
            },
            new JobPosition
            {
                Id = 276, TitleEng = "Asset Management and Technical Control",
                TitleFre = "Officer tech de gestion des biens"
            },
            new JobPosition {Id = 277, TitleEng = "Lightstations", TitleFre = "Les phares"},
            new JobPosition {Id = 278, TitleEng = "Research Analyst", TitleFre = "Analyste de recherche"},
            new JobPosition
            {
                Id = 279, TitleEng = "Coordinator Search and Rescue (SAR)",
                TitleFre = "Coordinateur recherche et sauvetage maritime (SAR)"
            },
            new JobPosition
                {Id = 280, TitleEng = "Marine Trades Instructor", TitleFre = "Instructeur de métiers maritimes"},
            new JobPosition
                {Id = 281, TitleEng = "Environmental (ER) Trainee", TitleFre = "Stagière réponse environmental"},
            new JobPosition
            {
                Id = 282, TitleEng = "Multimedia and Equipment Technician",
                TitleFre = "Technicien / technicienne en multimédia et en équipement"
            },
            new JobPosition
            {
                Id = 283, TitleEng = "Search and Rescue (SAR) Program Officer",
                TitleFre = "Officier de programme Recherche et sauvetage (SAR)"
            },
            new JobPosition
            {
                Id = 284, TitleEng = "Regional Operations Centre (ROC) Analyst (INNAV), Fleet Ops Support",
                TitleFre = "Analyste Centre d'opérations régional (COR) (INNAV), Soutien Opération de la flotte"
            },
            new JobPosition
            {
                Id = 285, TitleEng = "Air Cushioned Vehicle (ACV) First Officer",
                TitleFre = "Équipage Véhicule à coussin d'air (VCA)"
            },
            new JobPosition
            {
                Id = 286, TitleEng = "Rigid Hull Inflatable Operator Training (RHIOT) Instructor",
                TitleFre = "Enseignant canots pneumatiques coque rigide"
            },
            new JobPosition
            {
                Id = 287, TitleEng = "Aids to Navigation (AToN), Levels of Service, AIDS Review",
                TitleFre = "Aides à la navigation (AtoN), Niveaux de service, Révision des aides navigation"
            },
            new JobPosition
            {
                Id = 288, TitleEng = "Fleet Technology & Safety Training Officer",
                TitleFre = "Formation tech et sécurité de flotte"
            },
            new JobPosition
            {
                Id = 289, TitleEng = "Response Specialist - Environmental Response (ER)",
                TitleFre = "Spécialiste en réponse environnementale"
            },
            new JobPosition
            {
                Id = 290, TitleEng = "Fleet Delivery Planning", TitleFre = "Planification à la livraison de flotte"
            },
            new JobPosition
            {
                Id = 291, TitleEng = "Response Officer Vessels of Concern (VOC)",
                TitleFre = "Navires Préoccupants Officier responsable de la réponse"
            },
            new JobPosition {Id = 292, TitleEng = "Operations Officer", TitleFre = "Officier au opérations"},
            new JobPosition
            {
                Id = 293, TitleEng = "Senior Response Officer (ER)",
                TitleFre = "Officier sénior Réponse environnementale"
            },
            new JobPosition
            {
                Id = 294, TitleEng = "Maritime Search and Rescue (SAR) Coordinator",
                TitleFre = "Coordinateur Recherche et sauvetage (SAR) maritime"
            },
            new JobPosition
            {
                Id = 295, TitleEng = "Officer in Charge (Canso Canal Operations, Inflatable Craft Maintenance)",
                TitleFre = "Officier responsble (opérations canal Canso, Maint embarcations pneumatiques)"
            },
            new JobPosition
            {
                Id = 296, TitleEng = "Regional Incident Command System (ICS) Support Specialist",
                TitleFre = "Spécialiste soutien Système de commandement d'incident (SCI) régional"
            },
            new JobPosition
            {
                Id = 297, TitleEng = "Captain Air Cushioned Vehicle (ACV)",
                TitleFre = "Capitaine Véhicule à coussin d'air (VCA)"
            },
            new JobPosition
            {
                Id = 298,
                TitleEng =
                    "Small Craft / Rigid Hull Inflatable Operator Training (RHIOT) Supervisor / Vessel Disposal",
                TitleFre = "Petits navires/ Superviseur canots pneumatiques coque rigide / Aliénation de navires"
            },
            new JobPosition
            {
                Id = 299, TitleEng = "Supervisor Aids to Navigation (AToN), Lightstation Operations",
                TitleFre = "Superviseur Aides à la navigation (AtoN), Opérations aux phares"
            },
            new JobPosition
            {
                Id = 300, TitleEng = "Marine Security Operations Centres (MSOC) Maritime Security Officer",
                TitleFre = "Centre des opérations de la sûreté maritime (COSM) Officier Sûreté maritime"
            },
            new JobPosition
            {
                Id = 301, TitleEng = "Officer (Desk, Class Desk, Lead, Comm. Equipment, Senior Project)",
                TitleFre =
                    "Officier (Agent de bureau, Agent de bureau d'études aux catégories, Équipement de comm., Sénior de projet)"
            },
            new JobPosition
            {
                Id = 302, TitleEng = "Officer in Charge (OIC) (Small Craft, Air Cushioned Vehicle (ACV) Base)",
                TitleFre = "Agent responsable (petits navire, Base Véhicule à coussin d'air (VCA))"
            },
            new JobPosition
            {
                Id = 303,
                TitleEng =
                    "Head (Performance Management & Quality Assurance (QA), Continued Improvement & Investigation, Publication and Internet Management)",
                TitleFre =
                    "Chef (Gestion de performance et contrôle et assurance qualité, Amélioration continue, Gestion de publication et internet)"
            },
            new JobPosition
            {
                Id = 304,
                TitleEng =
                    "Deputy Superintendant (Marine, Regional Operations Centre (ROC), Search and Rescue (SAR), Environmental Response (ER)",
                TitleFre =
                    "Surintendant Adjoint (maritime, Centre d'opérations régional (COR), Recherche et sauvetage (SAR), Réponse environnementale)"
            },
            new JobPosition
            {
                Id = 305, TitleEng = "Deputy Superinten. Vessels of Concern (VOC)",
                TitleFre = "Surintendant Adjoint Navires Préoccupants"
            },
            new JobPosition
                {Id = 306, TitleEng = "Manager Safety and Security", TitleFre = "Gestionnaire sécurité et sûreté"},
            new JobPosition
            {
                Id = 307, TitleEng = "National Coordinator Asset Management System",
                TitleFre = "Coordinateur national Système de gestion des actifs"
            },
            new JobPosition
            {
                Id = 308, TitleEng = "Superintendent Arctic Field Operations",
                TitleFre = "Surintendant opération en champs arctique"
            },
            new JobPosition
                {Id = 309, TitleEng = "Supervisor INNAV Operations", TitleFre = "Superviseur aux opérations INNAV"},
            new JobPosition
                {Id = 310, TitleEng = "Manager Logistics Support", TitleFre = "Gestionnaire soutient logistique"},
            new JobPosition
                {Id = 311, TitleEng = "Leader Notices to Mariners", TitleFre = "Leader Avis aux navigateurs"},
            new JobPosition
            {
                Id = 312, TitleEng = "Technical Plannning Coordinator",
                TitleFre = "Coordinateur Planification technique"
            },
            new JobPosition
                {Id = 313, TitleEng = "Supervisor Small Vessels", TitleFre = "Superviseur petits navires"},
            new JobPosition
            {
                Id = 314, TitleEng = "Regional Operations Centre (ROC) Superintentendent",
                TitleFre = "Surintendant Centre d'opérations régional (COR)"
            },
            new JobPosition
                {Id = 315, TitleEng = "Operations Business Superintendent", TitleFre = "Surintendant Opérations"},
            new JobPosition
            {
                Id = 316, TitleEng = "Environmental Response (ER) Superintendent",
                TitleFre = "Surintendant Réponse Environnementale"
            },
            new JobPosition
            {
                Id = 317,
                TitleEng =
                    "Project Manager (Aids to Navigation (AToN), Ship Construct & Modification, Membrane Inlet Mass Spectrometer (MIMS), Service Delivery",
                TitleFre =
                    "Gestionnaire de projet (Aides à la navigation (AtoN), Construct & Mod navires, 32/5000 Spectromètre de masse à entrée membranaire (SMEM), Service de livraison)"
            },
            new JobPosition
            {
                Id = 318,
                TitleEng =
                    "Manager (Communications & Navigation System, Supply Chain Management, Configuration Management & Technical Data, National Asset Class, Navigational Aids)",
                TitleFre =
                    "Gestionnaire (Système de commande & navigation, Gestion chaîne logistique, Gestion Config & donées techniques, Classification biens national, Aides à la navigation (AtoN))"
            },
            new JobPosition
            {
                Id = 319, TitleEng = "Head Asset Management System", TitleFre = "Chef Système de gestion des actifs"
            },
            new JobPosition
            {
                Id = 320, TitleEng = "Senior Analyst Maritime Security",
                TitleFre = "Analyste sénior en sûreté maritime"
            },
            new JobPosition
            {
                Id = 321,
                TitleEng =
                    "Project Director (Mid-Shore Patrol Vessel, Hovercraft, Offshore Ship's Crew (SC) Vessel Procurement)",
                TitleFre =
                    "Directeur de projet (navires de patrouille semi-hauturier, Aéroglisseurs, navires hauturier de science)"
            },
            new JobPosition
            {
                Id = 322, TitleEng = "Marine Engineering Superintendent",
                TitleFre = "Surintendant mécanique maritime"
            },
            new JobPosition {Id = 323, TitleEng = "Marine Superintendent", TitleFre = "Surintendant maritime"},
            new JobPosition
            {
                Id = 324, TitleEng = "Maritime and Civil Infrastructure (MCI) Superintendent",
                TitleFre = "Infrastructure maritime et civile (ICM) Surintendant"
            },
            new JobPosition
            {
                Id = 325,
                TitleEng =
                    "Manager (Vessel Maintenance Program Evaluation, Vessel Life Extension (VLE), Helicopter Support, Icebreaking Project)",
                TitleFre =
                    "Gestionnaire (Évaluation programme d'entretien navire, Programme d'apprentissage virtuel navigatoire (PVN), Soutien Helicoptère, Projet en déglaçage)"
            },
            new JobPosition
            {
                Id = 326,
                TitleEng =
                    "National Manager (Search and Rescue (SAR), Aids to Navigation (AToN), Marine Communications and Traffic System (MCTS), Environmental Response (ER), Icebreaking, Maritime Security)",
                TitleFre =
                    "Gestionnaire national Recherche et sauvetage (SAR), Aides à la navigation (AtoN), Système de communication et de trafic maritime (CSTM), Réponse environnementale, Déglaçage, Sûreté maritime)"
            },
            new JobPosition
            {
                Id = 327, TitleEng = "Director Fleet Safety & Security",
                TitleFre = "Directeur sécurité et sûreté de la flotte"
            },
            new JobPosition
                {Id = 328, TitleEng = "Junior Project Engineer", TitleFre = "Ingénieur subalterne de projet"},
            new JobPosition
            {
                Id = 329, TitleEng = "Engineering Recruitment and Development",
                TitleFre = "Recrutement et développement en ingénierie"
            },
            new JobPosition {Id = 330, TitleEng = "Electronic Engineer", TitleFre = "Ingénieur électronique"},
            new JobPosition
            {
                Id = 331, TitleEng = "Vessel Life Extension Senior Engineer Quality Assurance",
                TitleFre =
                    "Assurance qualité de l'ingénieur principal en prolongation de la durée de vie des navires"
            },
            new JobPosition
            {
                Id = 332, TitleEng = "Project Engineer Quality Assurance",
                TitleFre = "Ingénieur projet assurance qualité"
            },
            new JobPosition
            {
                Id = 333, TitleEng = "Project Engineer Life Cycle Management",
                TitleFre = "Ingénieur projet gestion du cycle de vie"
            },
            new JobPosition {Id = 334, TitleEng = "Project Engineer", TitleFre = "Ingénieur de projet"},
            new JobPosition
            {
                Id = 335, TitleEng = "Electrical Life Cycle Management",
                TitleFre = "Gestion du cycle de vie électrique"
            },
            new JobPosition
            {
                Id = 336, TitleEng = "Propulsion Life Cycle Management",
                TitleFre = "Gestion du cycle de vie de la propulsion"
            },
            new JobPosition
            {
                Id = 337, TitleEng = "Naval Architect Life Cycle Management",
                TitleFre = "Gestion du cycle de vie de l'architecte naval"
            },
            new JobPosition
                {Id = 338, TitleEng = "ATON Lifecycle Manager", TitleFre = "Gestionnaire de cycle de vie ATON"},
            new JobPosition
            {
                Id = 339, TitleEng = "Engineering Manager Hydraulics",
                TitleFre = "Responsable ingénierie hydraulique"
            },
            new JobPosition
                {Id = 340, TitleEng = "Senior Project Engineer", TitleFre = "Ingénieur principal de projet"},
            new JobPosition
            {
                Id = 341, TitleEng = "Senior Engineer Vessel of Concern",
                TitleFre = "Navire préoccupant du génie principal"
            },
            new JobPosition {Id = 342, TitleEng = "MCI Senior Engineer", TitleFre = "Ingénieur senior MCI"},
            new JobPosition {Id = 343, TitleEng = "Engineering Manager", TitleFre = "Directeur de l'ingénierie"},
            new JobPosition
            {
                Id = 344, TitleEng = "IT Security Coordinator",
                TitleFre = "Coordonnateur de la sécurité de la technologie de l'information"
            },
            new JobPosition
                {Id = 345, TitleEng = "Senior Naval Architect", TitleFre = "Architecte naval principal"},
            new JobPosition
            {
                Id = 346,
                TitleEng = "Engineering Manager Aids to Navigation and Marine Communication Traffic Services",
                TitleFre =
                    "Directeur de l'ingénierie Aides à la navigation et services de trafic de communication maritime"
            },
            new JobPosition
            {
                Id = 347, TitleEng = "Engineering Manager Environmental Response Equipment",
                TitleFre = "Directeur de l'ingénierie, équipement d'intervention environnementale"
            },
            new JobPosition
            {
                Id = 348, TitleEng = "Manager of Ships Electronics",
                TitleFre = "Gestionnaire de l'électronique des navires"
            },
            new JobPosition
            {
                Id = 349, TitleEng = "Hull/Mechanical and Electrical Manager",
                TitleFre = "Responsable coque / mécanique et électrique"
            },
            new JobPosition
            {
                Id = 350, TitleEng = "Marine and Civil Infrastructure",
                TitleFre = "Infrastructure maritime et civile"
            },
            new JobPosition
                {Id = 351, TitleEng = "Manager Informatics", TitleFre = "Gestionnaire de l'informatique"},
            new JobPosition
            {
                Id = 352, TitleEng = "Executive Advisor to the Director General",
                TitleFre = "Conseiller exécutif du directeur général"
            },
            new JobPosition {Id = 353, TitleEng = "Programmer", TitleFre = "Programmeur"},
            new JobPosition {Id = 354, TitleEng = "Program Analysis", TitleFre = "Analyse de programme"},
            new JobPosition {Id = 355, TitleEng = "Technical Advisor", TitleFre = "Conseiller technique"},
            new JobPosition {Id = 356, TitleEng = "Business Analyst", TitleFre = "Analyste des activités"},
            new JobPosition
            {
                Id = 357, TitleEng = "Information Technology Security Specialist",
                TitleFre = "Spécialiste en sécurité des technologies de l'information"
            },
            new JobPosition {Id = 358, TitleEng = "Team Leader", TitleFre = "Chef d'équipe"},
            new JobPosition {Id = 359, TitleEng = "Project Leader", TitleFre = "Chef de projet"},
            new JobPosition
                {Id = 360, TitleEng = "Senior Technical Analysis", TitleFre = "Analyse technique senior"},
            new JobPosition {Id = 361, TitleEng = "Manager", TitleFre = "Gestionnaire"},
            new JobPosition {Id = 362, TitleEng = "MELDEV Entry", TitleFre = "PELM Entrée"},
            new JobPosition {Id = 363, TitleEng = "MELDEV Intermediate", TitleFre = "PELM Intermédiaire"},
            new JobPosition {Id = 364, TitleEng = "MELDEV Advanced", TitleFre = "PELM Avancé"},
            new JobPosition
                {Id = 365, TitleEng = "Electronic Technologist", TitleFre = "Technologue en électronique"},
            new JobPosition
            {
                Id = 366, TitleEng = "Senior Electronic Technologist",
                TitleFre = "Technologue principal en électronique"
            },
            new JobPosition
            {
                Id = 367, TitleEng = "Electronic Technologist, Engineering",
                TitleFre = "Technologue en électronique, Ingénierie"
            },
            new JobPosition
            {
                Id = 368, TitleEng = "Technical Instructor Electrical Systems",
                TitleFre = "Instructeur technique Systèmes électriques"
            },
            new JobPosition
            {
                Id = 369, TitleEng = "Technical Support Officer, INNAV",
                TitleFre = "Agent de soutien technique, INNAV"
            },
            new JobPosition
                {Id = 370, TitleEng = "Technologist INNAV System", TitleFre = "Technologue, système INNAV"},
            new JobPosition
            {
                Id = 371, TitleEng = "Engineering Design Technologist", TitleFre = "Technologue concepteur en génie"
            },
            new JobPosition
            {
                Id = 372, TitleEng = "Technical Maintenance Planner Coordinator",
                TitleFre = "Coordinateur et planificateur de l’entretien technique"
            },
            new JobPosition
            {
                Id = 373, TitleEng = "Area Supervisor, Engineering", TitleFre = "Superviseur de secteur Ingénierie"
            },
            new JobPosition
            {
                Id = 374, TitleEng = "Area Supervisor, Production", TitleFre = "Superviseur de secteur, Production"
            },
            new JobPosition
            {
                Id = 375, TitleEng = "Superintendent Electronics and Informatics Technical Training",
                TitleFre = "Surintendant, Formation technique en électronique et informatique"
            },
            new JobPosition
            {
                Id = 376, TitleEng = "Supervisor INNAV Technical Support",
                TitleFre = "Superviseur, Soutien technique, INNAV"
            },
            new JobPosition
            {
                Id = 377, TitleEng = "Project Manager, National Project Manager",
                TitleFre = "Gestionnaire de projet, Gestionnaire de projet national"
            },
            new JobPosition
            {
                Id = 378, TitleEng = "INNAV Systems Technologist, Technician Radar Display Systems",
                TitleFre = "Technologue en systèmes INNAV, Technicien en systèmes d’affichage radar"
            },
            new JobPosition
            {
                Id = 379, TitleEng = "Senior Technologist, Telecommunication Network",
                TitleFre = "Technologue principal, Réseau de télécommunications"
            },
            new JobPosition {Id = 380, TitleEng = "Production Manager", TitleFre = "Gestionnaire de la production"},
            new JobPosition {Id = 381, TitleEng = "Superintendent", TitleFre = "Surintendant"}
        };
    }
}