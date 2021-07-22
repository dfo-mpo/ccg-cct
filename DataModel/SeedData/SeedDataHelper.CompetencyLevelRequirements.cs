using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CompetencyLevelRequirement> CompetencyLevelRequirements = new List<CompetencyLevelRequirement>()
        {
            new CompetencyLevelRequirement
            {
                Id = 1,
                DescEng = "Basic understanding of the CCG and its role as a program facilitator.",
                DescFre = "Compréhension de base de la GCC et de son rôle en tant que facilitateur de programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 2,
                DescEng = "Understands the duties of the CCG and the roles and responsibilities of key contacts in the CCG’s regional organization. Has a good understanding of certain programs and assets.",
                DescFre = "Comprend les fonctions de la GCC ainsi que les rôles et les responsabilités des principales personnes ressources de l'organisation régionale de la GCC. A une bonne compréhension de certains programmes et actifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 3,
                DescEng = "Good understanding of programs within a regional or national organizational framework. Understands most programs and associated assets. Identifies contacts for other programs. Understands partners’ roles and responsibilities.",
                DescFre = "Bonne compréhension des programmes  dans un cadre organisationnel régional ou national. Comprend la plupart des programmes et des actifs associés. Identifie les personnes ressources pour d'autres programmes. Comprend les rôles et les responsabilités des partenaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 4,
                DescEng = "Advanced knowledge of programs and their impact on relations with the public and partners regionally and/or nationally. Extensive knowledge of all CCG programs, as well as regional and national capacity and asset condition. Participates in program planning.",
                DescFre = "Connaissance avancée des programmes et de leurs impacts sur les relations avec le public et les partenaires, au niveau régional et / ou national. Connaissance approfondie de tous les programmes de la GCC, ainsi que de la capacité et de l'état des actifs au niveau régional et national. Participe à la planification des programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 5,
                DescEng = "Extensive knowledge of all CCG programs, their delivery methods and timelines both regionally and nationally. Assesses stakeholder expectations and needs for the CCG and other departments in planning and exercises. Establishes internal and external relationships. Suggests potential improvements, changes or opportunities for program expansion.",
                DescFre = "Connaissance approfondie de tous les programmes de la GCC, de leurs modes de livraison et de leurs échéanciers aux niveaux régional et national. Évalue les attentes et les besoins des intervenants pour la GCC et les autres ministères dans la planification et les exercices. Établit des relations à l'interne et à l'externe. Suggère des améliorations potentielles, des changements ou des opportunités d'expansion des programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 6,
                DescEng = "Basic knowledge of the Coast Guard and its role as an enabler of various programs.",
                DescFre = "Connaissance de base de la Garde côtière et de son rôle en tant que facilitateur de divers programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 7,
                DescEng = "Limited knowledge of the Coast Guard's functions and the roles and responsibilities of key Coast Guard contacts within a regional organizational setting. Understands some programs and assets well.",
                DescFre = "Connaissance limitée des fonctions de la Garde côtière et des rôles et responsabilités des principaux contacts de la Garde côtière dans un cadre organisationnel régional. Comprend bien certains programmes et actifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 8,
                DescEng = "Practical knowledge of program deliveries in a regional or national organizational setting.  Understands most programs and associated assets. Knowledge of key contacts for other programs. Comprehends roles and responsibilities of client partners.",
                DescFre = "Connaissance pratique de l'exécution des programmes dans un cadre organisationnel régional ou national.  Comprend la plupart des programmes et les actifs associés. Connaissance des contacts clés pour d'autres programmes. Comprend les rôles et les responsabilités des partenaires clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 9,
                DescEng = "Advanced knowledge of programs and their impacts on public and partner relations, regionally and/or nationally. Extensive knowledge of all the Coast Guard's programs and the capability and status of Coast Guard assets regionally and/or nationally. Understands program planning exercises.",
                DescFre = "Connaissance avancée des programmes et de leurs impacts sur les relations publiques et les relations avec les partenaires, au niveau régional et/ou national. Connaissance approfondie de tous les programmes de la Garde côtière et de la capacité et du statut des biens de la Garde côtière au niveau régional et/ou national. Comprend les exercices de planification des programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 10,
                DescEng = "Expert knowledge of all the Coast Guard programs and delivery modes and timelines regionally and nationally. Understands expectations and needs of stakeholders for the Coast Guard and other government departments (OGDs) in planning and exercises. Understands the significance of potential program efficiencies, changes, or expansion opportunities.",
                DescFre = "Une connaissance approfondie de tous les programmes de la Garde côtière, ainsi que des modes et des délais de prestation à l'échelle régionale et nationale. Comprend les attentes et les besoins des parties prenantes pour la Garde côtière et les autres ministères dans le cadre de la planification et des exercices. Comprend l'importance de l'efficacité, des changements ou des possibilités d'expansion des programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 12,
                DescEng = "Understands basic administrative tasks and rules as they relate to a position. Recognizes the need to have supervisor approve requests where applicable.",
                DescFre = "Comprend les tâches et les règles administratives de base liées à un poste. Reconnaît la nécessité de faire approuver les demandes par le superviseur, s'il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 13,
                DescEng = "Recognizes when administration requirements are met. Understands systems and software pertaining to administrative functions and where applicable, the shipboard logistics functions in the performance of duties.",
                DescFre = "Reconnaît quand les exigences administratives sont satisfaites. Comprend les systèmes et les logiciels relatifs aux fonctions administratives et, s'il y a lieu, aux fonctions logistiques à bord du navire dans l'exécution des tâches."
            },
            new CompetencyLevelRequirement
            {
                Id = 14,
                DescEng = "Understands the full range of administration services such as expense forms, reimbursements (travel, stores, etc.) and where applicable items such as ex gratiapayments, timesheets, drafting correspondence and reports, training requests and authorizations, etc.",
                DescFre = "Comprend la gamme complète des services administratifs tels que les formulaires de dépenses, les remboursements (voyages, magasins, etc.) et, le cas échéant, les dépenses ex gratiapayments, les feuilles de temps, la rédaction de correspondance et de rapports, les demandes et autorisations de formation, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 15,
                DescEng = "Understands the full administration requirements of a sector or unit and how they interrelate with one another to effect efficient transactions throughout. Knowledge of all applicable policies, standards etc., to perform duties.",
                DescFre = "Comprend toutes les exigences administratives d'un secteur ou d'une unité et la façon dont elles sont reliées les unes aux autres pour effectuer des transactions efficaces tout au long du processus. Connaissance de toutes les politiques, normes, etc. applicables à l'exécution des tâches."
            },
            new CompetencyLevelRequirement
            {
                Id = 16,
                DescEng = "Expert knowledge in the administrative functions of multiple units working together and the needs of a work site, when and where applicable. Awareness of national and regional initiatives related to the administrative functions of a unit or units.",
                DescFre = "Connaissance approfondie des fonctions administratives de plusieurs unités travaillant ensemble et des besoins d'un lieu de travail, le cas échéant. Connaissance des initiatives nationales et régionales liées aux fonctions administratives d'une ou de plusieurs unités."
            },
            new CompetencyLevelRequirement
            {
                Id = 17,
                DescEng = "Basic understanding of the different Incident Command System (ICS) elements and incident levels. Understands the established and applicable operational procedures within ICS. Knowledge of associated computer software and hardware.",
                DescFre = "Compréhension de base des différents éléments du Système de commandement du lieu de l'incident (SCI) et des niveaux d'incident. Comprend les procédures opérationnelles établies et applicables au sein du SCI. Connaissance des logiciels et du matériel informatique connexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 18,
                DescEng = "Limited knowledge of the principles and working process of the Incident Command System (ICS). Knowledge of methodology for all Coast Guard incidents, emergency or contingency plans executed in environmental response, humanitarian assistance, maritime security, planned security events, Coast Guard internal incidents and major maritime incidents.",
                DescFre = "Connaissance limitée des principes et du processus de travail du Système de commandement du lieu de l'incident (SCI). Connaissance de la méthodologie pour tous les incidents de la Garde côtière canadienne, des plans d'urgence ou de contingence exécutés dans les domaines de l'intervention environnementale, de l'aide humanitaire, de la sécurité maritime, des événements de sécurité prévus, des incidents internes de la Garde côtière et des incidents maritimes majeurs."
            },
            new CompetencyLevelRequirement
            {
                Id = 19,
                DescEng = "Practical knowledge of the Incident Command System (ICS) during pollution incidents. Knowledge of the relationship between the Coast Guard Safety Management System (SMS) and the ICS. Understands how to determine optimum intervention options and determining the severity, sensitivity, and impact of an incident. Understands equipment specifications and maintenance requirements.",
                DescFre = "Connaissance pratique du Système de commandement des interventions (SCI) lors d'incidents de pollution. Connaissance de la relation entre le Système de gestion de la sécurité (SGS) de la Garde côtière et le SCI. Comprend comment déterminer les options d'intervention optimales et déterminer la gravité, la sensibilité et l'impact d'un incident. Comprend les spécifications de l'équipement et les exigences d'entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 20,
                DescEng = "Advanced knowledge of the management of an Incident Command System (ICS) command and control structure. Knowledge of interoperability with other organizations such as regional, federal, provincial, territorial, and international partners, and response organizations. Understands and applies life cycle management of equipment. Understands national exercise program (NEP) principles.",
                DescFre = "Connaissance approfondie de la gestion d'une structure de commandement et de contrôle du Système de commandement du lieu de l'incident (SCI). Connaissance de l'interopérabilité avec d'autres organisations comme les partenaires régionaux, fédéraux, provinciaux, territoriaux et internationaux, et les organismes d'intervention. Comprend et applique la gestion du cycle de vie de l'équipement. Comprend les principes du programme national d'exercices (PNE)."
            },
            new CompetencyLevelRequirement
            {
                Id = 21,
                DescEng = "Expert knowledge of the Incident Command System (ICS) and identifying new possibilities/capabilities to improve the existing systems and practices. Expertise in drafting/review of acts, regulations, and frameworks, and emergency management policies and directions.",
                DescFre = "Connaissance approfondie du Système de commandement du lieu de l'incident (SCI) et identification de nouvelles possibilités/capacités pour améliorer les systèmes et pratiques existants. Expertise dans la rédaction et l'examen des lois, des règlements et des cadres, ainsi que des politiques et des orientations en matière de gestion des urgences."
            },
            new CompetencyLevelRequirement
            {
                Id = 22,
                DescEng = "Basic knowledge of existing policies and documents related to seagoing personnel and where to locate them.",
                DescFre = "Connaissance de base des politiques et documents existants relatifs au personnel navigant et savoir où les trouver."
            },
            new CompetencyLevelRequirement
            {
                Id = 23,
                DescEng = "Limited knowledge of the Canadian Coast Guard's documentation covering policies and directives related to crewing profile, rotation regulations, leave, medical fitness and training, and certification for seagoing personnel.",
                DescFre = "Connaissance limitée de la documentation de la Garde côtière canadienne couvrant les politiques et directives relatives aux profils d'armements en équipage, aux règlements de rotation, aux congés, à l'aptitude médicale, à la formation et à la certification du personnel navigant."
            },
            new CompetencyLevelRequirement
            {
                Id = 24,
                DescEng = "Practical knowledge of the Coast Guard's seagoing dynamic environment. Understands applicable policies and directives when initiating administration processes related to seagoing personnel such as timesheet verification, scheduling and tracking medicals, using the crewing profiles, leave management, labour relations protocols, and using the MariTime system, etc.",
                DescFre = "Connaissance pratique de l'environnement maritime dynamique de la Garde côtière. Comprendre les politiques et directives applicables lors du lancement de processus administratifs liés au personnel navigant, tels que la vérification des feuilles de temps, la programmation et le suivi des examens médicaux, l'utilisation des profils d'armement en équipage, la gestion des congés, les protocoles de relations de travail et l'utilisation du système MariTime, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 25,
                DescEng = "Advanced knowledge of the regional/national approaches in the application of any required policies and regulations related to operational personnel management. Understands new concepts and processes to improve recruitment, retention, and sustainment of the Coast Guard's seagoing personnel and its management.",
                DescFre = "Connaissance avancée des approches régionales/nationales dans l'application de toutes les politiques et réglementations nécessaires liées à la gestion du personnel opérationnel. Comprend les nouveaux concepts et processus visant à améliorer le recrutement, la rétention et le soutien du personnel navigant de la Garde côtière et de sa gestion."
            },
            new CompetencyLevelRequirement
            {
                Id = 26,
                DescEng = "Expert knowledge in strategic guidance related to the seagoing personnel management doctrine. Expertise in recommending, drafting, and implementation of policies related to the management of seagoing personnel.",
                DescFre = "Connaissances spécialisées en matière d'orientation stratégique liée à la doctrine de gestion du personnel navigant. Expertise en matière de recommandation, de rédaction et de mise en œuvre de politiques liées à la gestion du personnel navigant."
            },
            new CompetencyLevelRequirement
            {
                Id = 27,
                DescEng = "Basic knowledge of coastal domain factors, working relations with other Canadian Coast Guard units, and equipment.",
                DescFre = "Connaissance de base des facteurs du domaine côtier, des relations de travail avec les autres unités de la Garde côtière canadienne et de l'équipement."
            },
            new CompetencyLevelRequirement
            {
                Id = 28,
                DescEng = "Limited knowledge in supporting Fisheries and Oceans Canada's (DFO) marine security programs and conducting analyses using surveillance equipment and working with internal partners.",
                DescFre = "Connaissances limitées en matière de soutien aux programmes de sûreté maritime de Pêches et Océans Canada (MPO) et de réalisation d'analyses à l'aide d'équipements de surveillance et de collaboration avec des partenaires internes."
            },
            new CompetencyLevelRequirement
            {
                Id = 29,
                DescEng = "Practical knowledge in the full range of the maritime security operations centres (MSOC),  its exercises, and its surveillance and analyses with internal partners.",
                DescFre = "Connaissance pratique de toute la gamme des Centres d'opérations de la sûreté maritime (COSM), de leurs exercices, de leur surveillance et de leurs analyses avec les partenaires internes."
            },
            new CompetencyLevelRequirement
            {
                Id = 30,
                DescEng = "Advanced knowledge of all facets of marine security operations, training, and analyses regionally or nationally, as well as training/consultation initiatives. Knowledge of Fisheries and Oceans Canada (DFO), Department of National Defence (DND), Royal Canadian Mounted Police (RCMP), Transport Canada (TC), and the Coast Guard's response systems, programs, and surveillance equipment (Long Range Identification and Tracking [LRIT], radars, cameras).",
                DescFre = "Connaissance avancée de toutes les facettes des opérations de sûreté maritime, formation et analyses au niveau régional ou national, ainsi que des initiatives de formation/consultation. Connaissance de Pêches et Océans Canada (MPO), du ministère de la Défense nationale (MDN), de la Gendarmerie royale du Canada (GRC), de Transports Canada (TC), ainsi que des systèmes d'intervention, des programmes et du matériel de surveillance de la Garde côtière (identification et suivi à grande distance [LRIT], radars, caméras)."
            },
            new CompetencyLevelRequirement
            {
                Id = 31,
                DescEng = "Expert knowledge of all facets of the marine security operations program and its relations with international and industrial stakeholders (e.g. United States Coast Guard [USCG], Ports). Expertise in providing insights to managers and stakeholders in advisory groups, the military, Canadian Security Intelligence Service (CSIS), and governments.",
                DescFre = "Connaissance experte de toutes les facettes du programme d'opérations de sûreté maritime et de ses relations avec les parties prenantes internationales et industrielles (par exemple, la Garde côtière américaine [USCG], les ports). Expertise dans la fourniture d'informations aux gestionnaires et aux parties prenantes des groupes consultatifs, aux militaires, au Service canadien du renseignement de sécurité (SCRS) et aux gouvernements."
            },
            new CompetencyLevelRequirement
            {
                Id = 32,
                DescEng = "Basic knowledge of the training needs analysis process in relation to the Canadian Coast Guard's training gaps and requirements.",
                DescFre = "Connaissance de base du processus d’analyse des besoins en formation en relation avec les lacunes et les exigences de la Garde côtière canadienne en matière de formation."
            },
            new CompetencyLevelRequirement
            {
                Id = 33,
                DescEng = "Limited knowledge of determining training elements including terminal objectives, training structure and outline, brief description of the training, and the method of delivery.",
                DescFre = "Connaissance limitée de la détermination des éléments de formation, y compris les objectifs de l'aérogare, la structure et le plan de la formation, une brève description de la formation et la méthode de prestation."
            },
            new CompetencyLevelRequirement
            {
                Id = 34,
                DescEng = "Practical knowledge in developing enabling objectives. Understands the development of course materials and curriculum including the instructor lesson plan, participant handouts, assessments, and selected media such as PowerPoint presentations, video, or audio, etc.",
                DescFre = "Connaissances pratiques dans l'élaboration d'objectifs habilitants. Comprend l'élaboration du matériel didactique et du programme d'études, y compris le plan de leçon de l'instructeur, les documents à distribuer aux participants, les évaluations et certains médias comme les présentations PowerPoint, la vidéo ou l'audio, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 35,
                DescEng = "Advanced knowledge in identifying methods and activities for presenting new information. Knowledge of setting aims and learning objectives. Understanding of the design strategy, for the development of new courses. Knowledge of making course modifications based on feedback.",
                DescFre = "Connaissances avancées dans l'identification de méthodes et d'activités pour la présentation de nouvelles informations. Connaissance de l'établissement des buts et des objectifs d'apprentissage. Compréhension de la stratégie de conception, pour le développement de nouveaux cours. Connaissance de la modification des cours en fonction des commentaires reçus."
            },
            new CompetencyLevelRequirement
            {
                Id = 36,
                DescEng = "Expert knowledge of evaluating training results to determine whether the sessions led to required changes in behaviour for the participants. Knowledge in redefining course development, materials, and instructional methods. Understanding of briefing senior management regarding issues, trends, suggestions, and areas of improvement based on evaluation, including trends related to diversity and generational issues.",
                DescFre = "Connaissance experte de l'évaluation des résultats de la formation afin de déterminer si les séances ont entraîné les changements de comportement requis pour les participants. Connaissance de la redéfinition de l'élaboration des cours, du matériel didactique et des méthodes d'enseignement. Compréhension de l'information donnée à la haute direction sur les enjeux, les tendances, les suggestions et les domaines à améliorer en fonction de l'évaluation, y compris les tendances liées à la diversité et aux questions générationnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 37,
                DescEng = "Basic knowledge of aspects of specialized fields to accomplish defined activities by applying methods, techniques, and established practices.",
                DescFre = "Connaissance de base des aspects des domaines spécialisés pour accomplir des activités définies en appliquant des méthodes, des techniques et des pratiques établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 38,
                DescEng = "Limited knowledge of theories and principles of a specialized field and the relevancy to their application.",
                DescFre = "Connaissance limitée des théories et des principes d'un domaine spécialisé et de leur pertinence pour leur application."
            },
            new CompetencyLevelRequirement
            {
                Id = 39,
                DescEng = "Practical knowledge of specialized methodologies of a field and comprehensive understanding of their underlying concepts, theories, and principles.",
                DescFre = "Connaissance pratique des méthodologies spécialisées d'un domaine et compréhension approfondie de leurs concepts, théories et principes sous-jacents."
            },
            new CompetencyLevelRequirement
            {
                Id = 40,
                DescEng = "Advanced knowledge in specialized methodologies of a field and of their underlying concepts. Extensive comprehension of the methodologies, theories, and applied principles of a specialized field.",
                DescFre = "Connaissance avancée des méthodologies spécialisées d'un domaine et de leurs concepts sous-jacents. Compréhension approfondie des méthodologies, théories et principes appliqués d'un domaine spécialisé."
            },
            new CompetencyLevelRequirement
            {
                Id = 41,
                DescEng = "Expert knowledge in specialized methodologies of a field or fields and of their underlying concepts, theories, and principles. Extensive knowledge in the provision of coaching/guidance to staff, peers, and senior management.",
                DescFre = "Connaissance approfondie des méthodologies spécialisées d'un ou de plusieurs domaines et de leurs concepts, théories et principes sous-jacents. Connaissances approfondies dans la prestation de services d'encadrement et d'orientation au personnel, aux pairs et aux cadres supérieurs."
            },
            new CompetencyLevelRequirement
            {
                Id = 42,
                DescEng = "Understands the fundamentals of program and/or project goals, participants’ roles and the importance of project management principles. Willingness to participate in program/project support activities.",
                DescFre = "Comprend les principes fondamentaux des objectifs du programme et/ou du projet, les rôles des participants et l'importance des principes de gestion. Volonté de participer à des activités de soutien."
            },
            new CompetencyLevelRequirement
            {
                Id = 43,
                DescEng = "Comprehends program and/or project goals, participants’ roles, and the importance of program/project management principles. Able to participate in program/project support activities (i.e. gathering needed information). Able to participate, under supervision, with others in small and well defined components of the program/project.",
                DescFre = "Comprend les objectifs du programme et/ou du projet, les rôles des participants et l'importance des principes de gestion du programme/projet. Capable de participer à des activités d’appui (c’est-à-dire la collecte des informations nécessaires). Participe, sous supervision, avec d’autres personnes à des composantes petites et bien définies du programme/projet.",
            },
            new CompetencyLevelRequirement
            {
                Id = 44,
                DescEng = "Knowledge of program and/or project goals, participants’ roles, and the importance of management principles, such as time, cost, and quality management. Participates, with minimal supervision, in individual programs or projects. Will seek advice and guidance for more complex components of the program/project.",
                DescFre = "Connaissance des objectifs du programme et/ou du projet, des rôles des participants et de l’importance des principes de gestion, tels que la gestion du temps, des coûts et de la qualité. Participe avec un minimum de supervision à des programmes ou projets individuels. Demandes conseil et avis pour des composants plus complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 45,
                DescEng = "Extensive practical experience in leading projects and/or programs. Leads program/project support activities, taking the initiative to gather additional information, keep documentation organized, and identify process improvements when needed. Actively participates in all projects and provides advice to others who seek assistance. Able to train and advise anyone seeking guidance on basic to complex projects.",
                DescFre = "Vaste expérience pratique de la direction d’un programme et/ou d’un projet. Dirige les activités de soutien des programmes/projets, en prenant l'initiative de rassembler des informations supplémentaires, de garder la documentation organisée et d'identifier les améliorations de processus au besoin. Participe activement à tous les projets et fournit des conseils à ceux qui cherchent de l'aide. Capable de former et de conseiller toute personne à la recherche de conseils sur des projets simples ou complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 46,
                DescEng = "Responsible for program and/or project delivery, directs teams to complete activities to current policies and practices. Interfaces with internal and external program/project clients, providing accurate information and managing the consultation.",
                DescFre = "Responsable de la livraison du programme et / ou du projet, dirige les équipes pour mener à bien les activités conformément aux politiques et pratiques en vigueur. Interfaces avec les clients internes et externes du programme/projet, fournissant des informations précises et gérant la consultation."
            },
            new CompetencyLevelRequirement
            {
                Id = 47,
                DescEng = "Understands basic techniques for planning and organizing his or her own activities. Willingness to clarify priorities as needed. Understands the importance of monitoring the quality and timeliness of his or her own work and using the resources immediately available to him or her.",
                DescFre = "Comprend les techniques de base pour planifier et organiser ses propres activités. Volonté de clarifier les priorités au besoin. Comprend l'importance de surveiller la qualité et la rapidité d'exécution de son propre travail et d'utiliser les ressources disponibles à sa disposition immédiate."
            },
            new CompetencyLevelRequirement
            {
                Id = 48,
                DescEng = "Ability to plan and organize his or her own activities to comply with predetermined standards or procedures. Seeks to clarify priorities as needed. Able to monitor the quality and timelines of his or her own work. Able to use the resources immediately available to him or her responsibly.",
                DescFre = "Aptitude à planifier et à organiser ses propres activités afin de respecter des normes ou des procédures prédéterminées. Cherche à clarifier les priorités au besoin. Capable de surveiller la qualité et la rapidité de son propre travail. Capable d'utiliser de manière responsable les ressources à sa disposition immédiate."
            },
            new CompetencyLevelRequirement
            {
                Id = 49,
                DescEng = "Strong ability to plan and organize activities effectively. Monitors the quality and timeliness of others’ work as well as his or her own. Uses available resources and seeks assistance to clarify priorities as needed. Reports results to promote accountability.",
                DescFre = "Capacité forte de planifier et organiser des activités efficacement. Surveille la qualité et la rapidité de son travail et de celui des autres. Utilise les ressources disponibles et demande de l'aide pour clarifier les priorités au besoin. Fait rapport des résultats pour promouvoir la responsabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 50,
                DescEng = "Experience in effectively planning and organizing activities for a department or unit. Sets goals and objectives and realistically anticipates obstacles. Determines priorities and allocates resources effectively. Effectively manages time to meet schedules and deadlines. Willingness to help others and give advice if asked.",
                DescFre = "Expérience dans la planification et l'organisation efficaces d'activités pour un département ou une unité. Établit les buts et objectifs et anticipe les obstacles de manière réaliste. Détermine les priorités et alloue les ressources efficacement. Gère efficacement le temps pour respecter les calendriers et les échéances. Volonté d'aider les autres et de donner des conseils si demandé."
            },
            new CompetencyLevelRequirement
            {
                Id = 51,
                DescEng = "Expert in planning and organization, can effectively manage several competing requests and priorities. Influences processes and actions. Is consulted on a complex project, provides advice and suggests directions.",
                DescFre = "Expert en planification et en organisation, peut efficacement gérer plusieurs demandes et priorités concurrentes. Influence sur les processus et les actions. Est consulté sur un projet complexe, fournit des conseils et propose des directions."
            },
            new CompetencyLevelRequirement
            {
                Id = 52,
                DescEng = "Reviews orders for accuracy and verifies that materials, equipment and stock are not available from current inventories. Procures quotes from catalogues and suppliers, obtains price quotations and prepares purchase orders. Calculates the cost of orders and charges or transfers invoices to the appropriate accounts. Processes purchases within the limits of purchasing power. Prepares and manages purchase files, reports and price lists.",
                DescFre = "Examine les commandes pour en vérifier l'exactitude et vérifier que le matériel, l'équipement et les stocks ne sont pas disponibles à partir des inventaires en cours. Procure des offres de prix auprès de catalogues et de fournisseurs, obtenir des offres de prix et préparer des commandes d'achat. Calcule le coût des commandes et charge ou transfère les factures aux comptes appropriés. Traite les achats dans les limites du pouvoir d'achat. Prépare et gère les fichiers d’achat, les rapports et les listes de prix."
            },
            new CompetencyLevelRequirement
            {
                Id = 53,
                DescEng = "Monitors inventory levels of materials, equipment and stock using manual or computerized inventory systems. Prepares orders to replenish materials, equipment and inventory. Maintains inventory turnover, disposes of and accounts for obsolete inventory. Enters data for production planning, replenishment/stock replenishment and inventory adjustments.",
                DescFre = "Surveille les niveaux de stocks de matériaux, d'équipements et de stocks à l'aide de systèmes d'inventaire manuels ou informatisés. Prépare les commandes pour réapprovisionner les matériaux, l'équipement et les stocks. Maintient la rotation des stocks, élimine et comptabilise les stocks obsolètes. Saisir des données pour la planification de la production, le réapprovisionnement / réapprovisionnement des stocks et les ajustements d’inventaire."
            },
            new CompetencyLevelRequirement
            {
                Id = 54,
                DescEng = "Purchases general and specialized equipment, materials, land or access rights, or commercial services for use or further processing by the CCG. Assesses client needs and develops specifications for equipment, materials and supplies to be purchased. Issues calls for tenders, consults suppliers and reviews quotes. Determines or negotiates contract terms and conditions, awards contracts to suppliers or recommends contract awards. Prepares and/or manages documents to procure goods and/or services contracts, including Requests for Proposals (RFPs) and/or Requests for Quotation (RFQs).",
                DescFre = "Achète de l'équipement général et spécialisé, du matériel, des terrains ou des droits d'accès, ou des services commerciaux, pour utilisation ou transformation ultérieure par la GCC. Évalue les besoins des clients et élabore des spécifications pour l'équipement, les matériaux et les fournitures à acheter. Invite à soumissionner, consulte les fournisseurs et examine les devis. Détermine ou négocie les termes et conditions des contrats, attribue les contrats des fournisseurs ou recommande des attributions de contrats. Préparer et / ou gérer des documents pour l’achat de marchés de biens et / ou de services, y compris des demandes de propositions (RFP) et / ou des demandes de devis (RFQ)."
            },
            new CompetencyLevelRequirement
            {
                Id = 55,
                DescEng = "Establishes the logistics of delivery schedules, monitors progress and contacts clients and suppliers to resolve issues. Negotiates land acquisition or access rights for the CCG’s use and may conduct field investigations of properties. Evaluates offers, costs and quality of goods or services. Review and process claims against suppliers. May provide training and advice to others.",
                DescFre = "Établit la logistique des calendriers de livraison, surveille les progrès et contacte les clients et les fournisseurs pour résoudre les problèmes. Négocie les droits d’acquisition des terres ou les droits d’accès à l’usage de la GCC et peut mener des enquêtes sur le terrain des propriétés. Évalue les offres, les coûts et la qualité des biens ou des services. Examiner et traiter les réclamations contre les fournisseurs. Peut fournir une formation et des conseils aux autres."
            },
            new CompetencyLevelRequirement
            {
                Id = 56,
                DescEng = "Plans, organizes, directs, oversees and evaluates the purchasing activities of the organizational unit. Develops purchasing policies and procedures and oversees the budget of the purchasing department. Identifies vendors of materials, equipment or supplies. Negotiates or supervises the negotiation of purchase contracts. Participates in developing specifications for alternative equipment, products or materials.",
                DescFre = "Planifie, organise, dirige, contrôle et évalue les activités d'achat du service organisationnel. Développe les politiques et procédures d'achat et contrôle le budget du département des achats. Identifie les vendeurs de matériel, d'équipement ou de fournitures. Négocie ou supervise la négociation des contrats d'achat. Participe à l'élaboration de spécifications pour l'équipement, les produits ou les matériaux de substitution."
            },
            new CompetencyLevelRequirement
            {
                Id = 57,
                DescEng = "Coordinates a variety of recruitment, training, performance evaluation, HR systems, and classification activities. Prepares and proofreads forms and documents for and between the workforce management team or clients. Runs reports. Ensures that workforce management-related material is signed, dated, distributed, maintained, and filed appropriately.",
                DescFre = "Coordonne diverses activités de recrutement, de formation, d'évaluation des performances, de systèmes RH et de classification. Prépare et corrige des formulaires et des documents pour et entre l'équipe de gestion du personnel ou les clients. Produit des rapports. S'assure que les documents relatifs à la gestion des effectifs sont signés, datés, distribués, mis à jour et classés de manière appropriée."
            },
            new CompetencyLevelRequirement
            {
                Id = 58,
                DescEng = "Compiles, maintains, and processes information relating to recruitment, training, performance evaluation, HR systems, or classification. Facilitates business line, workforce intelligence, succession planning, organizational awareness, and HR management practices. Arranges for advertising or posting job vacancies. Assists in screening of job applicants, and conducting of reference checks, when and where applicable.",
                DescFre = "Compile, tenir à jour et traiter les informations relatives au recrutement, à la formation, à l'évaluation des performances, aux systèmes de RH ou à la classification. Facilite les pratiques de gestion des lignes d'activité, des renseignements sur les effectifs, de la planification de la relève, de la sensibilisation à l'organisation et de la gestion des RH. Organise la publication ou l'affichage des offres d'emploi. Aide à la sélection des candidats et à la vérification des références, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 59,
                DescEng = "Identifies job vacancies and prospective recruiting requirements. Provides advice to managers related to recruitment, training, or HR systems. Interprets and applies legislation and policies related to workforce management functions. Determines eligibility to entitlements, arranges and delivers member training. Provides information or services such as employee assistance, counselling, and recognition programs, when and where applicable.",
                DescFre = "Identifie les offres d'emploi et les besoins de recrutement éventuels. Fournit des conseils aux gestionnaires en matière de recrutement, de formation ou de systèmes de ressources humaines. Interprète et applique la législation et les politiques relatives aux fonctions de gestion des effectifs. Détermine l'admissibilité aux droits, organise et dispense la formation des membres. Fournit des informations ou des services tels que l'aide aux employés, de councelling et des programmes de reconnaissance, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 60,
                DescEng = "Implements and evaluates workforce management policies, programs, and procedures. Working closely with clients or the workforce management team, collaborates in developing the merit criteria, assessment tools, and employment equity programs, offering strategic staffing ideas and assisting with performance management or disability files according to portfolio. Provides advice on the interpretation of policies, staffing, training, and benefits programs. Maintains workforce management information and related records systems. Hires and oversees training of staff. Co-ordinates employee performance appraisal programs.",
                DescFre = "Met en œuvre et évalue les politiques, programmes et procédures de gestion des effectifs. Travaille en étroite collaboration avec les clients ou l'équipe de gestion des effectifs, collabore à l'élaboration des critères de mérite, des outils d'évaluation et des programmes d'équité en matière d'emploi, propose des idées stratégiques de dotation en personnel et aide à la gestion des performances ou des dossiers d'invalidité selon le portefeuille. Fournit des conseils sur l'interprétation des politiques, la dotation en personnel, la formation et les programmes d'avantages sociaux. Tient à jour les informations sur la gestion des effectifs et les systèmes de dossiers connexes. Engage et supervise la formation du personnel. Coordonne les programmes d'évaluation de la performance des employés."
            },
            new CompetencyLevelRequirement
            {
                Id = 61,
                DescEng = "Directs, controls, and evaluates the operations of the Canadian Coast Guard's workforce management discipline. Develops and implements policies, programs and procedures regarding workforce management planning, recruitment, training and development, and classification. Negotiates settlements of appeals and disputes and co-ordinates the termination of employment process, when and where applicable. Directs the organization's quality management program in relation to workforce management.",
                DescFre = "Dirige, contrôle et évalue les opérations de la discipline de gestion des effectifs de la Garde côtière canadienne. Élabore et met en œuvre des politiques, des programmes et des procédures concernant la planification de la gestion des effectifs, le recrutement, la formation et le développement, et la classification. Négocie le règlement des appels et des différends et coordonne le processus de cessation d'emploi, le cas échéant. Diriger le programme de gestion de la qualité de l'organisation en ce qui concerne la gestion de la main-d'œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 62,
                DescEng = "Adheres to budget controls as assigned. Articulates a 'value for money' mindset. Provides correct financial information as required.",
                DescFre = "Respecte les contrôles budgétaires tels qu'ils ont été assignés. Il adopte un état d'esprit de l'optimisation des ressources. Fournir des informations financières correctes, comme demandé."
            },
            new CompetencyLevelRequirement
            {
                Id = 63,
                DescEng = "Monitors project/program expenditures and individual expenses for reporting purposes. Identifies wasteful financial practices or opportunities for greater efficiencies. Tracks and files variation reports.",
                DescFre = "Surveille les dépenses des projets/programmes et les dépenses individuelles à des fins d'établissement de rapports. Identifie les pratiques financières inutiles ou les possibilités d'amélioration de l'efficacité. Suivre et classer les rapports de variation."
            },
            new CompetencyLevelRequirement
            {
                Id = 64,
                DescEng = "Analyzes unit cash flow trends. Maintains financial records and compares trends by period and year. Prepares statistical, financial, and accounting reports. Verifies and evaluates procedures used for recording financial transactions, and makes recommendations for changes to procedures, systems, and other financial controls. Provides guidance to members.",
                DescFre = "Analyse les tendances de roulement de fonds des unités. Tient à jour les registres financiers et compare les tendances par période et par année. Prépare des rapports statistiques, financiers et comptables. Vérifie et évalue les procédures utilisées pour l'enregistrement des transactions financières, et fait des recommandations sur les changements à apporter aux procédures, systèmes et autres contrôles financiers. Fournir des conseils aux membres."
            },
            new CompetencyLevelRequirement
            {
                Id = 65,
                DescEng = "Analyzes broad accounting and financial records to ensure accuracy and compliance with established accounting standards and procedures. Plans, organizes, and administers financial tracking and reconciliation systems for Canadian Coast Guard programs and business lines. Prepares detailed reports and conducts audits to improve organizational financial management practices. Provides guidance to management. Designs, operates, and monitors rigorous systems for Financial Information Management, internal audit, and evaluation.",
                DescFre = "Analyse les documents comptables et financiers généraux afin de garantir l'exactitude et la conformité aux normes et procédures comptables établies. Planifie, organise et administre les systèmes de suivi et de rapprochement financier pour les programmes et les secteurs d'activité de la Garde côtière canadienne. Prépare des rapports détaillés et effectue des vérifications pour améliorer les pratiques de gestion financière de l'organisation. Fournir des conseils à la direction. Concevoir, exploiter et surveiller des systèmes rigoureux de gestion de l'information financière, de vérification interne et d'évaluation.",
            },
            new CompetencyLevelRequirement
            {
                Id = 66,
                DescEng = "Directs, controls, and evaluates the operation of financial and accounting departments. Reports on established trends with organizational recommendations for change. Ensures partner organizations, agencies, or governments understand the organization's complex fiscal issues. Develops and implements financial policies, establishes performance standards, and prepares various financial reports for senior management. Advises senior management on current and best practices in sound financial management practice and procedure.",
                DescFre = "Dirige, contrôle et évalue le fonctionnement des services financiers et comptables. Fait rapport sur les tendances établies avec des recommandations organisationnelles pour le changement. S'assure que les organisations, agences ou gouvernements partenaires comprennent les questions fiscales complexes de l'organisation. Élabore et met en œuvre des politiques financières, établit des normes de performance et prépare divers rapports financiers à l'intention de la haute direction. Conseille la haute direction sur les pratiques actuelles et les meilleures pratiques en matière de bonnes méthodes et procédures de gestion financière."
            },
            new CompetencyLevelRequirement
            {
                Id = 67,
                DescEng = "Conducts media monitoring and coverage analysis. Provides communication support services. Offers logistical support for media events and interviews.",
                DescFre = "Effectue un suivi des médias et une analyse de la couverture médiatique. Fournit des services de soutien à la communication. Offre un soutien logistique pour les événements médiatiques et les interviews."
            },
            new CompetencyLevelRequirement
            {
                Id = 68,
                DescEng = "Writes and edits a range of communications products. Supports social media and websites. Assists in the development and/or implementation of communications products. Contributes to implementing communication plans or projects in the digital environment.",
                DescFre = "Rédige et édite une série de produits de communication. Prend en charge les médias sociaux et les sites web. Aide à l'élaboration et/ou à la mise en œuvre de produits de communication. Contribue à la mise en œuvre de plans ou de projets de communication dans l'environnement numérique."
            },
            new CompetencyLevelRequirement
            {
                Id = 69,
                DescEng = "Produces communications products. Plans, coordinates, and/or implements announcements or special events such as town halls or media availabilities. Provides communication support to clients. Contributes to content of strategic communications plans. Monitors and analyzes multimedia coverage, providing tactical responses where requested. Uses social media to communicate in a government context.",
                DescFre = "Produit des produits de communication. Planifie, coordonne et/ou met en œuvre des annonces ou des événements spéciaux tels que les assemblées publiques ou les disponibilités des médias. Fournit un support de communication aux clients. Contribue au contenu des plans de communication stratégiques. Surveille et analyse la couverture multimédia, en fournissant des réponses tactiques si nécessaire. Utilise les médias sociaux pour communiquer dans un contexte gouvernemental."
            },
            new CompetencyLevelRequirement
            {
                Id = 70,
                DescEng = "Provides strategic communications advice to managers. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products, when and where required. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Extracts subject-matter experts while executing segmentation and audience analysis. Assists senior management in conveying messages on behalf of the Coast Guard in an appropriate manner that is consistent with established Acts, policies, and practices. Establishes networks with Fisheries and Oceans Canada (DFO) communications partners.",
                DescFre = "Fournit des conseils en communication stratégique aux gestionnaires. Élabore et met en œuvre des plans de marketing et/ou de publicité, des story-boards et des vidéos. Évalue les plans de communication et développe des produits de communication associés, quand et où cela est nécessaire. Coordonne et/ou travaille dans le cadre d'initiatives, de projets ou de stratégies de communication intergouvernementaux ou multiservices. Extrait des experts en la matière tout en effectuant une segmentation et une analyse d'audience. Aider la haute direction à transmettre les messages au nom de la Garde côtière d'une manière appropriée et conforme aux lois, politiques et pratiques établies. Établit des réseaux avec les partenaires de communication de Pêches et Océans Canada (MPO)."
            },
            new CompetencyLevelRequirement
            {
                Id = 71,
                DescEng = "Organizes and coordinates ministerial events. Leads the development, implementation, and evaluation of communications plans. Develops specialized communications products. In partnership with Fisheries and Oceans Canada (DFO) communications partners, leads or participates in external and internal stakeholder collaboration and major event responses. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies. Plans and executes extensive electronic (web and social media) communications initiatives.",
                DescFre = "Organise et coordonne les événements ministériels. Dirige l'élaboration, la mise en œuvre et l'évaluation des plans de communication. Élabore des produits de communication spécialisés. En partenariat avec les partenaires de communication de Pêches et Océans Canada (MPO), dirige ou participe à la collaboration des intervenants externes et internes et aux réponses aux événements majeurs. Gère les relations avec les médias pour les questions sensibles. Élabore et met en œuvre des stratégies proactives de sensibilisation des médias. Planifie et exécute des initiatives de communication électronique (web et médias sociaux) de grande envergure."
            },
            new CompetencyLevelRequirement
            {
                Id = 72,
                DescEng = "Applies real property and accommodation management’s key elements and policies and identifies where to find related information. Supports activities related to real property and accommodation maintenance and operations.",
                DescFre = "Applique les éléments clés et les politiques de la gestion des biens immobiliers et des locaux et indique où trouver les informations correspondantes. Soutient les activités liées à l'entretien et au fonctionnement des biens immobiliers et des locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 73,
                DescEng = "Assists in the writing of real property and/or accommodation management documents. Gathers information for planning, coordinating, and/or monitoring budgets. Assists in the search, analysis, and integration of information from different sources to formulate recommendations or action plans.",
                DescFre = "Aide à la rédaction des documents de gestion des biens immobiliers et/ou des locaux. Recueille des informations pour la planification, la coordination et/ou le suivi des budgets. Aide à la recherche, à l'analyse et à l'intégration d'informations provenant de différentes sources afin de formuler des recommandations ou des plans d'action."
            },
            new CompetencyLevelRequirement
            {
                Id = 74,
                DescEng = "Interprets policies, standards, directives, or codes related to office accommodations or real property construction projects. Plans, organizes, or implements office accommodation or real property construction projects and analyses information and provides recommendations to clients or management.",
                DescFre = "Interprète les politiques, les normes, les directives ou les codes relatifs aux locaux ou aux projets de construction de biens immobiliers. Planifie, organise ou met en œuvre des projets de construction de locaux ou de biens immobiliers, analyse des informations et fournit des recommandations aux clients ou à la direction."
            },
            new CompetencyLevelRequirement
            {
                Id = 75,
                DescEng = "Monitors marine structure projects, when and where applicable. Develops systems and/or processes, guidelines, and policies for identifying, collecting, maintaining, and evaluating real property and accommodations management information.",
                DescFre = "Surveille les projets de structures marines, le cas échéant. Élabore des systèmes et/ou des processus, des lignes directrices et des politiques pour identifier, recueillir, maintenir et évaluer les informations relatives à la gestion des biens immobiliers et des locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 76,
                DescEng = "Identifies and implements risk and performance management strategies in assessing and planning real property and/or accommodations management projects. Develops plans and strategies that address the variety and complexity of real property and accommodations management operations, use, and maintenance.",
                DescFre = "Identifie et met en œuvre des stratégies de gestion des risques et du rendement dans l'évaluation et la planification des projets de gestion des biens immobiliers et/ou des locaux. Élabore des plans et des stratégies qui tiennent compte de la variété et de la complexité des opérations, de l'utilisation et de l'entretien des biens immobiliers et de la gestion des locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 77,
                DescEng = "Describes the basic function of the business’s core systems. Defines objectives and success criteria of the specific role. Identifies sources of existing and potential information relating to the project. Documents consistently.",
                DescFre = "Décrit la fonction de base des systèmes centraux de l'entreprise. Définit les objectifs et les critères de succès de la fonction spécifique. Identifie les sources d'informations existantes et potentielles relatives au projet. Documente de manière systématique."
            },
            new CompetencyLevelRequirement
            {
                Id = 78,
                DescEng = "Identifies key project milestones and defines project scope. Derives project estimates and quantifies uncertainty. Stores, references, and locates information in an efficient manner appropriate to the role. Validates, refines, and optimizes solution option models. Communicates difficult issues concisely and effectively to supervisors. Identifies potential areas of conflict and works to aasync Task their occurrence or their impact.",
                DescFre = "Identifie les étapes clés du projet et définit la portée du projet. Dérive les estimations du projet et quantifie l'incertitude. Stocker, référencer et localiser les informations de manière efficace et adaptée au rôle. Valide, raffine et optimise les modèles d'options de solution. Communique les questions difficiles de manière concise et efficace aux superviseurs. Identifie les zones potentielles de conflit et s'efforce d'éviter leur apparition ou leur impact."
            },
            new CompetencyLevelRequirement
            {
                Id = 79,
                DescEng = "Identifies and minimizes risk to ongoing Coast Guard operations. Consistently identifies technology interfaces and focuses on integration aspects of projects. Identifies and defines proposed business benefits. Ensures planning tools and techniques are applied effectively. Through analysis of options, selects the option with the greatest business benefit bearing in mind the Coast Guard objectives. Articulates the vision, objectives, and benefits of a new initiative. Identifies current areas of conflict and seeks to understand apposing points of view.",
                DescFre = "Identifie et minimise les risques pour les opérations en cours de la Garde côtière. Identifie de manière cohérente les interfaces technologiques et se concentre sur les aspects d'intégration des projets. Identifie et définit les avantages opérationnels proposés. S'assure que les outils et les techniques de planification sont appliqués efficacement. Par l'analyse des options, sélectionne l'option présentant le plus grand avantage opérationnel en gardant à l'esprit les objectifs de la Garde côtière. Articuler la vision, les objectifs et les avantages d'une nouvelle initiative. Identifie les zones de conflit actuelles et cherche à comprendre les points de vue opposés."
            },
            new CompetencyLevelRequirement
            {
                Id = 80,
                DescEng = "Identifies and relays improvement opportunities and industry trends to the organization. Ensures a mechanism is in place to capture project risks, issues, and scope. Follows up with individuals and/or groups to clarify or complete the identified gaps and errors. Employees models to determine and communicate solution options. Makes recommendations with justifications to the appropriate decision making authority.",
                DescFre = "Identifie et transmet à l'organisation les opportunités d'amélioration et les tendances du monde industriel. S'assure qu'un mécanisme est en place pour saisir les risques, les problèmes et la portée du projet. Assurer un suivi avec des personnes et/ou des groupes pour clarifier ou compléter les lacunes et les erreurs identifiées. Les employés établissent des modèles pour déterminer et communiquer les options de solution. Fait des recommandations avec justifications à l'autorité décisionnelle appropriée."
            },
            new CompetencyLevelRequirement
            {
                Id = 81,
                DescEng = "Identifies risks and impacts associated with proposed business options. Forecasts the impact of change. Applies effective influencing strategies.",
                DescFre = "Identifie les risques et les impacts associés aux options opérationnelles proposées. Prévoit l'impact du changement. Applique des stratégies d'influence efficaces."
            },
            new CompetencyLevelRequirement
            {
                Id = 82,
                DescEng = "Employs a fair and non-partisan approach in the delivery of services. Supports others in managing their tasks/responsibilities by providing timely information or resources. Accurately determines where to direct inquiries.",
                DescFre = "Adopte une approche équitable et non partisane dans la prestation des services. soutient les autres dans la gestion de leurs tâches/responsabilités en leur fournissant des informations ou des ressources en temps utile. Détermine avec précision où diriger les demandes de renseignements."
            },
            new CompetencyLevelRequirement
            {
                Id = 83,
                DescEng = "Establishes and maintains electronic and paper filing systems so that information can be readily retrieved. Actively promotes services to existing and potential clients. Anticipates potential problems and initiates ways of improving standards. Complies with existing quality standards, procedures, guidelines, and service agreements. Asks questions in order to clarify the needs and requirements associated with initial client requests.",
                DescFre = "Établit et maintient des systèmes de classement électronique et papier afin que les informations puissent être facilement retrouvées. Promouvoir activement les services auprès des clients existants et potentiels. Anticipe les problèmes potentiels et met en place des moyens d'améliorer les normes. Respecte les normes de qualité, les procédures, les lignes directrices et les accords de service existants. Poser des questions afin de clarifier les besoins et les exigences associés aux demandes initiales des clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 84,
                DescEng = "Applies due diligence and sound judgment when responding to requests and dealing with confidential information. Quickly and effectively solves client’s problems including complaints. Serves Coast Guard clients with the understanding that service is a core principle of the organization.",
                DescFre = "Fait preuve de diligence et de discernement lorsqu'il répond aux demandes et traite des informations confidentielles. Résout rapidement et efficacement les problèmes des clients, y compris les plaintes. Sert les clients de la Garde côtière en sachant que le service est un principe fondamental de l'organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 85,
                DescEng = "Develops standards of service delivery beyond those generally accepted. Promotes innovative measures to address client service needs. Deals with stakeholders professionally while representing the Coastg Guard.",
                DescFre = "Développe des normes de prestation de services au-delà de celles généralement acceptées. Promeut des mesures innovantes pour répondre aux besoins des clients en matière de service. Traite avec les parties prenantes de manière professionnelle tout en représentant la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 86,
                DescEng = "Strategically and systematically evaluates opportunities within a sector, field, or area to improve client service in a non-partisan manner. Develops and implements creative and innovative ways of meeting client needs, whether in the regions or in headquarters.",
                DescFre = "Évalue de manière stratégique et systématique les possibilités d'améliorer le service à la clientèle dans un secteur, un domaine ou une région de manière non partisane. Développe et met en œuvre des moyens créatifs et innovants pour répondre aux besoins des clients, que ce soit dans les régions ou à l'administration centrale."
            },
            new CompetencyLevelRequirement
            {
                Id = 87,
                DescEng = "Identifies irregular workforce management practices. Seeks advice when workforce management issues arise.",
                DescFre = "Identifie les pratiques irrégulières de gestion de l'effectif. Demande des conseils lorsque des problèmes de gestion des effectifs se posent."
            },
            new CompetencyLevelRequirement
            {
                Id = 88,
                DescEng = "Provides basic HR-related information to colleagues, members, and others. Identifies deviations in applications of HR procedures or validates them with the competent authority. Supervises a small unit and conducts performance management input.",
                DescFre = "Fournit des informations de base sur les ressources humaines aux collègues, aux membres et à d'autres personnes. Identifie les écarts dans l'application des procédures de RH ou les valide auprès de l'autorité compétente. Supervise une petite unité et apporte sa contribution à la gestion des performances."
            },
            new CompetencyLevelRequirement
            {
                Id = 89,
                DescEng = "Experienced in identifying, defining, solving and prioritizing standard problems without causing other unanticipated problems. Identifies root causes, sets goals and identifies constraints. Conducts impact analysis and identifies possible consequences of actions/decisions.",
                DescFre = "Expérience de la détection, de la définition, de la résolution et de la hiérarchisation de problèmes courants sans générer d’autres problèmes imprévus. Définit les causes profondes des problèmes, fixe des objectifs et repère les contraintes. Réalise des analyses d’impact et détermine quelles sont les conséquences possibles des mesures ou des décisions prises."
            },
            new CompetencyLevelRequirement
            {
                Id = 90,
                DescEng = "Experienced in finding workable solutions to increasingly complex and multi-dimensional problems by either intuition or systematic approach. Generates and assesses alternative solutions and develops standards to evaluate different intended results offered by alternatives.  Provides training and advises on best practices. Conducts monitoring and testing of solutions after implementation.",
                DescFre = "Expérience de la recherche de solutions viables à des problèmes de plus en plus complexes et multidimensionnels, que ce soit de façon intuitive ou au moyen d’une approche systématique. Génère et évalue des solutions de rechange, et établit des normes pour évaluer les différents résultats escomptés desdites solutions. Donne de la formation et formule des conseils à l’égard des pratiques exemplaires. Effectue le suivi et la mise à l’essai des solutions après leur mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 91,
                DescEng = "Revises and amends problem solving models / flowcharts / cause and effect diagrams.  Advises on multiple alternatives and expected results based on extensive experience. Evaluates effectiveness and efficiency of solution after implementation.",
                DescFre = "Révise et modifie les modèles de résolution de problèmes, les organigrammes et les diagrammes cause-effet. Formule des conseils à l’égard des différentes solutions possibles et des résultats escomptés en s’appuyant sur une expérience approfondie. Évalue l’efficacité et l’efficience de la solution après sa mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 92,
                DescEng = "Prepares and processes bills, invoices, accounts payable and receivable. Enters data into financial tracking systems according to established procedures.",
                DescFre = "Prépare et traite les factures, les comptes fournisseurs et les comptes clients. Saisit les données dans les systèmes de suivi financier conformément aux procédures établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 93,
                DescEng = "Maintains Coast Guard unit assets and property (e.g. office equipment, vehicles, information databases, etc.). Updates budgets and projections. Purchases with credit cards when required. Runs salary and Operations and Maintenance (O&M) reports and statements for managers. Makes budget entries and reconciles accounts with rationales. Tracks and analyzes unit cash flow.",
                DescFre = "Gère les actifs et les biens de l'unité de la Garde côtière (par exemple, le matériel de bureau, les véhicules, les bases de données d'information, etc.). Il met à jour les budgets et les projections. Effectue les achats par carte de crédit lorsque cela est nécessaire. Gère les salaires et les rapports et relevés de fonctionnement et d'entretien (F&E) pour les gestionnaires. Effectue des entrées budgétaires et rapproche les comptes avec les justifications. Suivre et analyser les flux de trésorerie des unités."
            },
            new CompetencyLevelRequirement
            {
                Id = 94,
                DescEng = "Experienced in identifying, defining, solving and prioritizing standard problems without causing other unanticipated problems. Identifies root causes, sets goals and identifies constraints. Conducts impact analysis and identifies possible consequences of actions/decisions.",
                DescFre = "Expérience de la détection, de la définition, de la résolution et de la hiérarchisation de problèmes courants sans générer d’autres problèmes imprévus. Définit les causes profondes des problèmes, fixe des objectifs et repère les contraintes. Réalise des analyses d’impact et détermine quelles sont les conséquences possibles des mesures ou des décisions prises."
            },
            new CompetencyLevelRequirement
            {
                Id = 95,
                DescEng = "Experienced in finding workable solutions to increasingly complex and multi-dimensional problems by either intuition or systematic approach. Generates and assesses alternative solutions and develops standards to evaluate different intended results offered by alternatives. Provides training and advises on best practices. Conducts monitoring and testing of solutions after implementation.",
                DescFre = "Expérience de la recherche de solutions viables à des problèmes de plus en plus complexes et multidimensionnels, que ce soit de façon intuitive ou au moyen d’une approche systématique. Génère et évalue des solutions de rechange, et établit des normes pour évaluer les différents résultats escomptés desdites solutions. Donne de la formation et formule des conseils à l’égard des pratiques exemplaires. Effectue le suivi et la mise à l’essai des solutions après leur mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 96,
                DescEng = "Revises and amends problem solving models, flowcharts, and cause and effect diagrams. Advises on multiple alternatives and expected results based on extensive experience. Evaluates effectiveness and efficiency of solution after implementation.",
                DescFre = "Révise et modifie les modèles de résolution de problèmes, les organigrammes et les diagrammes cause-effet. Formule des conseils à l’égard des différentes solutions possibles et des résultats escomptés en s’appuyant sur une expérience approfondie. Évalue l’efficacité et l’efficience de la solution après sa mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 97,
                DescEng = "Recognizes relations between shipboard departments and how they interact and the role of the cooks and stewards. Actively learns meal planning and storage protocols.",
                DescFre = "Reconnaît les relations entre les services de bord et leur interaction, ainsi que le rôle des cuisiniers et des stewards. Apprend activement la planification des repas et les protocoles de stockage."
            },
            new CompetencyLevelRequirement
            {
                Id = 98,
                DescEng = "Manages the logistics department in the absence of a supply officer. Consults with the cook and steward in managing storage and purchasing protocols. Assists in menu planning.",
                DescFre = "Gère le service logistique en l'absence d'un responsable de l'approvisionnement. Consulte le cuisinier et le steward pour la gestion des protocoles de stockage et d'achat. Aide à la planification des menus."
            },
            new CompetencyLevelRequirement
            {
                Id = 99,
                DescEng = "Manages the logistics department in the absence of a logistics officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation. Establishes requirements for the requisition, receipt, storage, and distribution of supplies. Collaborates with the engine room department in the loading of stores.",
                DescFre = "Gère le service de la logistique en l'absence d'un responsable de la logistique. Consulte le chef cuisinier pour la préparation des menus. Consulte le steward sur les questions relatives au logement. Établit les exigences pour la réquisition, la réception, le stockage et la distribution des fournitures. Collabore avec le service de la salle des machines pour le chargement des magasins."
            },
            new CompetencyLevelRequirement
            {
                Id = 100,
                DescEng = "Manages the logistics department as a supply officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores and supplies.",
                DescFre = "Gère le département logistique en tant qu'agent d'approvisionnement. Consulte le chef cuisinier pour la préparation des menus. Consulte le steward sur les questions relatives à l'hébergement, aux installations sanitaires et aux buanderies. Établit les exigences et les procédures pour la réquisition, la réception, le stockage et la distribution des fournitures. Collabore avec les officiers du département de la salle des machines pour le chargement et le déplacement des magasins et des fournitures."
            },
            new CompetencyLevelRequirement
            {
                Id = 101,
                DescEng = "Manages the logistics department as a logistics officer. Consults with the chief cook and steward in all matters pertaining to shipboard hotel provisions and systems. Consults with shoreside stakeholders and conducts logistics audits and training at sea and ashore.",
                DescFre = "Gère le département logistique en tant qu'officier de logistique. Consulte le chef cuisinier et le steward pour tout ce qui concerne les dispositions et les systèmes hôteliers à bord du navire. Consulte les parties prenantes à terre et effectue des audits logistiques et des formations en mer et à terre."
            },
            new CompetencyLevelRequirement
            {
                Id = 102,
                DescEng = "Cites relevant sections of acts and regulations pertaining to maritime security operations centres (MSOC) (Privacy Act, Oceans Act, etc.). Identifies memoranda of understandings (MOUs) and service level agreements (SLAs) in place. Observes and records data for analysis from various sources.",
                DescFre = "Cite les articles pertinents des lois et règlements relatifs aux centres des opérations de sûreté maritime (COSM) (Loi sur la protection des renseignements personnels, Loi sur les océans, etc.) Identifie les protocoles d'entente (PE) et les accords sur les niveaux de service  en vigueur. Observe et enregistre les données de diverses sources pour analyse."
            },
            new CompetencyLevelRequirement
            {
                Id = 103,
                DescEng = "Identifies legal and regulatory limitations related to operations. Applies appropriate document classification to reports. Undertakes basic assignments in surveillance activities. Observes radar feeds and identifies basic trends, patterns, and anomalies.",
                DescFre = "Identifie les limites légales et réglementaires liées aux opérations. Applique la classification appropriée des documents aux rapports. Effectue des missions de base dans le cadre d'activités de surveillance. Observe les signaux radar et identifie les tendances de base, les motifs et les anomalies."
            },
            new CompetencyLevelRequirement
            {
                Id = 104,
                DescEng = "Applies various constraints imposed by legislation and agreements by considering information sharing limitations when distributing products and/or information. Provides regular vessel tracking updates to partners as required. Analyzes information to contribute to products such as threat/risk assessments. Compiles and filters data received from partners for duplicates and unknowns.",
                DescFre = "Applique diverses contraintes imposées par la législation et les accords en tenant compte des limites du partage des informations lors de la distribution des produits et/ou des informations. Fournit aux partenaires des mises à jour régulières sur le suivi des navires, selon les besoins. Analyse les informations pour contribuer aux produits tels que les évaluations des menaces/risques. Compile et filtre les données reçues des partenaires pour détecter les doublons et les inconnues."
            },
            new CompetencyLevelRequirement
            {
                Id = 105,
                DescEng = "Incorporates legal opinions into procedures and processes. Identifies new sources of information. Produces vessel movement analysis based on historical data from various sources. Identifies surveillance gaps to recommend new products to fill gaps. Advises management on potential maritime threats/risks when no obvious warning is present. Conceives new maritime security initiatives to expand services and products within Fisheries and Oceans Canada (DFO).",
                DescFre = "Intègre les avis juridiques dans les procédures et les processus. Identifie de nouvelles sources d'information. Produit une analyse des mouvements des navires basée sur des données historiques provenant de diverses sources. Identifie les lacunes en matière de surveillance afin de recommander de nouveaux produits pour combler les lacunes. Conseille la direction sur les menaces/risques maritimes potentiels lorsqu'il n'y a pas d'avertissement évident. Conçoit de nouvelles initiatives de sûreté maritime pour étendre les services et les produits au sein de Pêches et Océans Canada (MPO)."
            },
            new CompetencyLevelRequirement
            {
                Id = 106,
                DescEng = "Develops formalized collection plans. Provides advice on maritime security incidents. Identifies new products to assist partners and clients in identifying potential threats. Collaborates with partners to develop maritime security operations centres (MSOC) products. Recommends capability of Canadian Coast Guard assets to and works with other government departments (OGDs) during maritime security events. Influences Coast Guard maritime security policy utilizing knowledge of partners changing initiatives, policies, and mandates.",
                DescFre = "Élabore des plans de collecte formalisés. Fournit des conseils sur les incidents de sûreté maritime. Identifie de nouveaux produits pour aider les partenaires et les clients à identifier les menaces potentielles. Collabore avec les partenaires pour développer les produits des Centres des opérations de la sûreté maritime (COSM). Recommande la capacité des ressources de la Garde côtière canadienne à d'autres ministères et collabore avec eux lors d'événements de sûreté maritime. Influence la politique de sûreté maritime de la Garde côtière en utilisant la connaissance des initiatives, des politiques et des mandats changeants des partenaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 107,
                DescEng = "Understands the basic concept of the CCG’s quality assurance systems. The reports observed demonstrate non-compliance.",
                DescFre = "Comprend le concept de base des systèmes d’assurance de la qualité de la Garde côtière canadienne. Les rapports observé démontrent des non-conformités."
            },
            new CompetencyLevelRequirement
            {
                Id = 108,
                DescEng = "Participates in reviews and prepares quality assurance (QA) reports. Researches and compares results against standard operating procedures or design specifications.",
                DescFre = "Participer aux révisions et rédige des rapports d’assurance de la qualité (AQ). Recherche et compare les résultats par rapport aux procédures d’exploitation normalisées ou aux spécifications de conception."
            },
            new CompetencyLevelRequirement
            {
                Id = 109,
                DescEng = "Implements the CCG’s quality assurance system. Interprets a wide variety of data and makes recommendations. Makes recommendations or, when required, develops options for resolving instances of non-compliance. ",
                DescFre = "Met en œuvre le système d’assurance de la qualité de la Garde côtière canadienne. Interprète une grande variété de données et fait des recommandations. Formule des recommandations ou, le cas échéant, élabore des options pour résoudre les non-conformités."
            },
            new CompetencyLevelRequirement
            {
                Id = 110,
                DescEng = "Defines and articulates desired parameters and objectives, encouraging others to adopt and achieve them. Applies constraints within which information may or may not be shared. Fully grasps procedural and resource requirements. Strikes a balance between compliance and flexibility. Helps develop QA programs.",
                DescFre = "Définit et énonce les paramètres et les objectifs souhaités, en encourageant les autres à les adopter et à les atteindre. Applique les contraintes à l’intérieur desquelles l’information peut ou ne peut pas être partagée. Maîtrise les exigences en matière de procédures et de ressources. Équilibre entre conformité et flexibilité. Aide à élaborer des programmes d’AQ."
            },
            new CompetencyLevelRequirement
            {
                Id = 111,
                DescEng = "Champions the CCG’s QA systems. Anticipates potential challenges and opportunities through a detailed understanding of the internal and external environment as well as regional and national contexts. Develops creative and innovative programs, projects and activities.",
                DescFre = "Championne les systèmes d’AQ de la Garde côtière canadienne.  Anticipe les défis et les opportunités potentiels par une compréhension détaillée de l’environnement interne et externe, et des contextes régionaux et nationaux. Élaborer des programmes, des projets et des activités créatifs et novateurs."
            },
            new CompetencyLevelRequirement
            {
                Id = 112,
                DescEng = "Requests supplies based on demand. Ensures that proper receipt, identification, and inspection is carried out for all incoming materiel.",
                DescFre = "Demande des fournitures en fonction de la demande. S'assure que la réception, l'identification et l'inspection appropriées sont effectuées pour tout le matériel entrant."
            },
            new CompetencyLevelRequirement
            {
                Id = 113,
                DescEng = "Requests parts and supplies from internal stocks using approved classification system. Understands and follows the inventory management system (IMS). Processes special and emergency requirements of all clients.",
                DescFre = "Demande des pièces et des fournitures à partir des stocks internes en utilisant un système de classification approuvé. Comprend et suit le Système de gestion des stocks. Traite les besoins spéciaux et urgents de tous les clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 114,
                DescEng = "Receives, stores, issues, and records materiel according to approved inventory management system (IMS) and categories of materiel. Ensures that materiel held in stock is properly identified, catalogued, and incorporated in the centralized cataloguing files. Ensures that inventory is managed in accordance with Acts and regulations, when and where applicable. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items.",
                DescFre = "Reçoit, stocke, distribue et enregistre le matériel selon le système de gestion des stocks approuvé et les catégories de matériel. S'assure que le matériel en stock est correctement identifié, catalogué et incorporé dans les fichiers de catalogage centralisés. S'assure que l'inventaire est géré conformément aux lois et règlements, le cas échéant. Tient à jour les registres de contrôle des engagements pour le matériel demandé en stock et pour les articles non stockés."
            },
            new CompetencyLevelRequirement
            {
                Id = 115,
                DescEng = "Uses supplier classifications systems and cross-reference tables where available. Performs a full systematic process of developing, operating, maintaining, upgrading, and disposing, including commissioning and decommissioning of vessels as they relate to fleet operations, when and where applicable.",
                DescFre = "Utilise les systèmes de classification des fournisseurs et les tableaux de correspondance lorsqu'ils sont disponibles. Effectue un processus systématique complet de développement, d'exploitation, d'entretien, de mise à niveau et d'élimination, y compris la mise en service et le déclassement des navires en ce qui concerne les opérations de la flotte, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 116,
                DescEng = "Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches. Tests new software and innovative approaches within the field. Trains and guides employees within the materiel management field, when and where applicable.",
                DescFre = "Assiste aux réunions nationales et représente les intérêts régionaux dans le domaine de la gestion du matériel. Conseille et oriente la direction sur les approches rentables. Teste de nouveaux logiciels et des approches innovantes dans le domaine. Forme et guide les employés dans le domaine de la gestion du matériel, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 117,
                DescEng = "Provides input into basic exercise plans.",
                DescFre = "Fournit des informations sur les plans d'exercices de base."
            },
            new CompetencyLevelRequirement
            {
                Id = 118,
                DescEng = "Participates in and validates discussion-based exercises in talking through plan finalization.",
                DescFre = "Participe à des exercices basés sur la discussion et les valider en parlant de la finalisation du plan."
            },
            new CompetencyLevelRequirement
            {
                Id = 119,
                DescEng = "Produces and validates tabletop exercises, which stimulate the divisions between responders needing to communicate and be coordinated, where the participants are expected to know the plan and test it for procedural weaknesses.",
                DescFre = "Produit et valide des exercices sur table, qui stimulent les divisions entre les intervenants ayant besoin de communiquer et d'être coordonnés, où les participants sont censés connaître le plan et le tester pour les faiblesses de procédure."
            },
            new CompetencyLevelRequirement
            {
                Id = 120,
                DescEng = "Produces and validates live exercises in order to help participants develop skills  and confidence, testing logistics and physical capabilities, and providing experience of what it would be like to use a plan or procedure in real life.",
                DescFre = "Produit et valide des exercices en direct afin d'aider les participants à développer leurs compétences et leur confiance, en mettant à l'épreuve leurs capacités logistiques et physiques, et en leur donnant une expérience de ce que serait l'utilisation d'un plan ou d'une procédure dans la vie réelle."
            },
            new CompetencyLevelRequirement
            {
                Id = 121,
                DescEng = "Proposes, develops, trials, and validates all types of exercises, including discussion-based, table top, and live. Uses hotwash and lesson learned functions to propose changes and new exercises. Consults on developing testing exercises and training others.",
                DescFre = "Propose, développe, teste et valide tous les types d'exercices, y compris ceux basés sur des discussions, sur table et en direct. Utilise les fonctions de rétroaction immédiate et de leçons apprises pour proposer des changements et de nouveaux exercices. Consulte pour développer des exercices d'essai et former d'autres personnes."
            },
            new CompetencyLevelRequirement
            {
                Id = 122,
                DescEng = "Assesses learners’ prior knowledge, learning needs, and career and college readiness goals. Sets learning goals and a course of study. Monitors learning through summative and formative assessment.",
                DescFre = "Évalue les connaissances préalables des apprenants, leurs besoins d'apprentissage et leurs objectifs de carrière et de préparation au collège. Fixe des objectifs d'apprentissage et un programme d'études. Surveille l'apprentissage par le biais d'une évaluation sommative et formative."
            },
            new CompetencyLevelRequirement
            {
                Id = 123,
                DescEng = "Designs learner-centered classroom environments. Designs standards-based instructional units. Uses instructional techniques that are relevant and effective with adult learners.",
                DescFre = "Conçoit des cours centrés sur l'apprenant dans des environnements de classe. Conçoit des unités d'enseignement basées sur des normes. Utilise des techniques d'enseignement pertinentes et efficaces pour les apprenants adultes."
            },
            new CompetencyLevelRequirement
            {
                Id = 124,
                DescEng = "Communicates high expectations of learners on Coast Guard employment in motivating them to meet  goals. Delivers lessons in a professional, clear, and understandable way. Engages in active listening, dialogue, and questioning to facilitate and support learning.",
                DescFre = "Communique les attentes élevées des apprenants en matière d'emploi dans la Garde côtière en les motivant à atteindre leurs objectifs. Donne des cours de manière professionnelle, claire et compréhensible. S'engage dans une écoute active, un dialogue et un questionnement pour faciliter et soutenir l'apprentissage."
            },
            new CompetencyLevelRequirement
            {
                Id = 125,
                DescEng = "Participates in professional development networks and learning communities. Shares content and pedagogical resources with program staff in collaborative professional development projects. Refines instructional practices through reflection on experience, evidence, and data. Designs instruction to build learners’ subject matter of expertise skills (i.e. marine skills in the Coast Guard).",
                DescFre = "Participe à des réseaux de développement professionnel et à des communautés d'apprentissage. Partage le contenu et les ressources pédagogiques avec le personnel du programme dans le cadre de projets de développement professionnel collaboratifs. Raffine les pratiques pédagogiques par une réflexion sur l'expérience, les faits et les données. Conçoit l'enseignement de manière à renforcer les compétences des apprenants en matière d'expertise (c'est-à-dire les compétences maritimes de la Garde côtière)."
            },
            new CompetencyLevelRequirement
            {
                Id = 126,
                DescEng = "Champions a training environment featuring maximum flexibility, creativity, and passion, encouraging questions and discussion. Models an understanding of diversity in self and in students.",
                DescFre = "Championne un environnement de formation caractérisé par un maximum de flexibilité, de créativité et de passion, encourageant les questions et la discussion. Modélise une compréhension de la diversité en soi et chez les étudiants."
            },
            new CompetencyLevelRequirement
            {
                Id = 127,
                DescEng = "Reads the Government of Canada's Values and Ethics Code. Behaves consistently with the Values and Ethics Code and seeks appropriate guidance when required.",
                DescFre = "Lire le Code de valeurs et d'éthique du gouvernement du Canada. Se comporte conformément au Code de valeurs et d'éthique et cherche à obtenir des conseils appropriés au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 128,
                DescEng = "Uses government assets responsibly. Discusses ethical concerns with their supervisor or colleagues and, when necessary, seeks and follows appropriate disclosure procedures.",
                DescFre = "Utilise les biens du gouvernement de façon responsable. Discute des préoccupations d'ordre éthique avec son superviseur ou ses collègues et, au besoin, recherche et suit les procédures de divulgation appropriées."
            },
            new CompetencyLevelRequirement
            {
                Id = 129,
                DescEng = "Works in a manner that reflects a commitment to public service excellence. Assists peers respectfully when dealing with ethical concerns. Recognizes the importance of diversity, and bilingualism. Is well versed in the Government of Canada's Values and Ethics Code. Demonstrates respect for government property and policies.",
                DescFre = "Fonctionne d'une manière qui reflète un engagement envers l'excellence de la fonction publique. Aider ses pairs avec respect lorsqu'il s'agit de préoccupations d'ordre éthique. Reconnaît l'importance de la diversité et du bilinguisme. Connaît bien le Code de valeurs et d'éthique du gouvernement du Canada. Faire preuve de respect à l'égard des biens et des politiques du gouvernement."
            },
            new CompetencyLevelRequirement
            {
                Id = 130,
                DescEng = "Consistently balances national, regional, and site specific ethical priorities. Actively promotes integrity, diversity, bilingualism, and respect through work behaviour and the workplace.  ",
                DescFre = "Établir un équilibre constant entre les priorités éthiques nationales, régionales et propres au site. Promouvoir activement l'intégrité, la diversité, le bilinguisme et le respect par le comportement au travail et en milieu de travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 131,
                DescEng = "Models public service before self. Assists and advises on issues with national and/or legal implications. Champions diversity and bilingualism. Acts with transparency and fairness. Enforces the appropriate use of government assets and resources.",
                DescFre = "Donne l'exemple du service public avant soi-même. Aider et conseiller sur des questions ayant des implications nationales et/ou juridiques. Se fait le champion de la diversité et du bilinguisme. Agir avec transparence et équité. Appliquer l'utilisation appropriée des biens et des ressources du gouvernement."
            },
            new CompetencyLevelRequirement
            {
                Id = 132,
                DescEng = "Breaks down concrete problems into parts and organizes information. Recognizes pertinent facts and issues that make up a problem. Asks standard questions and follows first line of investigation to identify the key elements of a situation or problem. Uses known procedures and standard operating models.",
                DescFre = "Décomposer des problèmes concrets en composantes et structurer l’information. Reconnaître les faits et les enjeux pertinents qui constituent un problème. Poser des questions courantes et suivre la première piste d’enquête pour cerner les éléments clés d’une situation ou d’un problème. Utiliser des procédures connues et des modèles opérationnels normalisés."
            },
            new CompetencyLevelRequirement
            {
                Id = 133,
                DescEng = "Researches available options to recommend a solution. Understands the Coast Guard's operational and organizational goals and strategies, and aligns activities towards the vision and strategic imperatives. ",
                DescFre = "Recherche les options disponibles pour recommander une solution. Comprend les buts et les stratégies opérationnels et organisationnels de la Garde côtière et aligne les activités sur la vision et les impératifs stratégiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 134,
                DescEng = "Analyzes multiple causal relationships among several parts of a problem or situation. Anticipates the risks or implications inherent in a suggested plan of action and devises appropriate strategies to mitigate their impact. Makes a well-reasoned response even when faced with incomplete or contradictory information. Synthesizes complex ideas, issues, and observations into a clear understanding. Thinks beyond the work environment and makes decisions in the context of the bigger picture.",
                DescFre = "Analyse les relations causales multiples entre plusieurs parties d'un problème ou d'une situation. Anticiper les risques ou les implications inhérents à un plan d'action proposé et élaborer des stratégies appropriées pour en atténuer l'impact. Donne une réponse raisonnée, même lorsqu'elle est confrontée à des informations incomplètes ou contradictoires. Synthétise des idées, des questions et des observations complexes en une compréhension claire. Pense au-delà de l'environnement de travail et prend des décisions dans le contexte d'une vue d'ensemble."
            },
            new CompetencyLevelRequirement
            {
                Id = 135,
                DescEng = "Identifies several potential causes of events or multiple-part consequences. Analyzes complex, evolving circumstances and takes corrective action to avoid resource constraints and meet deadlines. Compares and contrasts evidence and information from various sources in a comprehensive and time sensitive manner. Understands program interdependencies and the need to integrate activities across functions/areas related to project planning, program implementation, and evaluation. Creates strategic alignment between cross-functional teams. Thinks laterally about business problems and opportunities; sees how the work and efforts of other Coast Guard teams/functions/operational centres intertwine to meet broad objectives.",
                DescFre = "Identifie plusieurs causes potentielles d'événements ou de conséquences en plusieurs parties. Analyser les circonstances complexes et changeantes et prendre des mesures correctives pour éviter les contraintes de ressources et respecter les échéances. Comparer et mettre en contraste les données et les renseignements provenant de diverses sources d'une manière exhaustive et dans des délais raisonnables. Comprend les interdépendances des programmes et la nécessité d'intégrer les activités entre les fonctions/domaines liés à la planification des projets, à la mise en œuvre des programmes et à l'évaluation. Crée un alignement stratégique entre les équipes interfonctionnelles. Réfléchit latéralement aux problèmes et aux possibilités d'affaires ; voit comment le travail et les efforts des autres équipes, fonctions et centres opérationnels de la Garde côtière s'entrecroisent pour atteindre les objectifs généraux."
            },
            new CompetencyLevelRequirement
            {
                Id = 136,
                DescEng = "Thinks strategically about the range of market and business issues likely to impact the Coast Guard's ability to fulfill its mandate. Uses a sound understanding of the organization's strengths and weaknesses, its key stakeholders, and its long-term organizational strategy to leverage decisions of varying scope.",
                DescFre = "Réfléchit de façon stratégique à l'éventail des enjeux commerciaux et commerciaux susceptibles d'avoir une incidence sur la capacité de la Garde côtière de remplir son mandat. Utilise une bonne compréhension des forces et des faiblesses de l'organisation, de ses principaux intervenants et de sa stratégie organisationnelle à long terme pour tirer parti des décisions de portée variable."
            },
            new CompetencyLevelRequirement
            {
                Id = 137,
                DescEng = "Encourages members of the team to contribute to a process. Listens and asks questions. Expresses appreciation to others who have provided information assistance or support. Deals proactively with interpersonal matters that could affect team performance.",
                DescFre = "Encourage les membres de l'équipe à contribuer à un processus. Écoute et pose des questions. Remercie les autres personnes qui lui ont fourni de l'information, de l'aide ou du soutien. Traite de façon proactive les questions interpersonnelles qui pourraient avoir une incidence sur le rendement de l'équipe."
            },
            new CompetencyLevelRequirement
            {
                Id = 138,
                DescEng = "Solicits opinions and viewpoints of team members. Cultivates personal bonds with colleagues in order to enhance performance throughout the organization. Discusses issues and exchanges information with partners to identify areas of mutual interest and benefit. Draws on other groups to facilitate project execution or persuade others. Manages personal work-life balance and respects the work-life balance of others.",
                DescFre = "Sollicite les opinions et les points de vue des membres de l'équipe. Cultive des liens personnels avec ses collègues afin d'améliorer la performance dans l'ensemble de l'organisation. Discute des enjeux et échange de l'information avec les partenaires afin de cerner les domaines d'intérêt et d'avantage mutuels. Fait appel à d'autres groupes pour faciliter l'exécution du projet ou en persuader d'autres. Gère l'équilibre travail-vie personnelle et respecte l'équilibre travail-vie personnelle des autres."
            },
            new CompetencyLevelRequirement
            {
                Id = 139,
                DescEng = "Effectively promotes a respectful and positive work environment. Recognizes diverse needs and perspectives (e.g. language differences, cultural differences, disabilities, and personal family circumstances). Recognizes individuals' achievements, knowledge, and capabilities. Monitors the work environment, successfully identifies underlying issues that impact negatively on people, and takes appropriate action, when and where applicable. Seeks and influences new relationships outside own unit and identifies new collaborative partnerships that better position of the Coast Guard's programs and services. Identifies and creates opportunities to partner through networking and participating in cross-functional, multi-stakeholder groups.",
                DescFre = "Favorise efficacement un milieu de travail respectueux et positif. Reconnaît la diversité des besoins et des perspectives (p. ex. les différences linguistiques, culturelles, les handicaps et les situations familiales personnelles). Reconnaît les réalisations, les connaissances et les capacités des individus. Surveille l'environnement de travail, identifie avec succès les problèmes sous-jacents qui ont un impact négatif sur les personnes et prend les mesures appropriées, le cas échéant. Recherche et influence de nouvelles relations à l'extérieur de sa propre unité et détermine de nouveaux partenariats de collaboration qui positionnent mieux les programmes et services de la Garde côtière. Identifie et crée des possibilités de partenariat grâce au réseautage et à la participation à des groupes multifonctionnels et multipartites."
            },
            new CompetencyLevelRequirement
            {
                Id = 140,
                DescEng = "Models and promotes a culture of respect, fairness, and trust. Proficient in capitalizing on the strengths of team members. Encourages members of the team to contribute to a process, and seeks consensus. Always actively works with other teams to ensure that broader common goals are met. Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders.",
                DescFre = "Donne l'exemple et fait la promotion d'une culture de respect, d'équité et de confiance. Capitaliser sur les forces des membres de l'équipe. Encourage les membres de l'équipe à contribuer à un processus et recherche le consensus. Travaille toujours activement avec d'autres équipes pour s'assurer que les objectifs communs plus larges sont atteints. Établit et entretient des réseaux et des relations de collaboration efficaces avec les communautés de pratique, les collègues et les intervenants."
            },
            new CompetencyLevelRequirement
            {
                Id = 141,
                DescEng = "Advises others in dealing with ethical dilemmas, displaying sensitivity to diversity, and diverse needs in all dealings and relationships, and in maintaining fairness, consistency, and equity. Challenges current organizational behaviours and methods of operating, when and where applicable. Sets direction in terms of ethical standards and values for the organization. Draws on internal and external networks to help ensure buy-in and ownership; enhances the visibility of the Coast Guard's operations in the broader public sphere.",
                DescFre = "Conseille les autres dans la gestion des dilemmes éthiques, en faisant preuve de sensibilité à la diversité et en répondant à des besoins divers dans toutes les transactions et relations, et en maintenant la justice, la cohérence et l'équité. Remet en question les comportements organisationnels et les méthodes de fonctionnement actuels, le cas échéant. Établit l'orientation en termes de normes et de valeurs éthiques pour l'organisation. Fait appel à des réseaux internes et externes pour assurer l'adhésion et l'appropriation ; améliore la visibilité des activités de la Garde côtière dans la sphère publique élargie."
            },
            new CompetencyLevelRequirement
            {
                Id = 142,
                DescEng = "Completes work assignments. Balances work to meet commitments and deadlines by being focused on goals.",
                DescFre = "Effectuer des affectations de travail. L'équilibre permet de respecter les engagements et les échéances en se concentrant sur les objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 143,
                DescEng = "Responds to issues and/or brings concerns forward rather than waiting for them to be reported by someone else. Looks for new opportunities and seizes them when they arise. Plans for contingencies to deal with unexpected events. Structures work in order to achieve required results.",
                DescFre = "Répondre aux questions ou aux préoccupations plutôt que d'attendre qu'elles soient signalées par quelqu'un d'autre. Cherche de nouvelles opportunités et les saisit lorsqu'elles se présentent. Des plans d'urgence pour faire face à des événements imprévus. Les structures fonctionnent de manière à obtenir les résultats escomptés."
            },
            new CompetencyLevelRequirement
            {
                Id = 144,
                DescEng = "Considers ideas from a variety of sources in order to solve problems. Remains flexible to find alternate ways around obstacles/barriers to achieve goals. Takes calculated risks to achieve goals/outcomes. Perseveres in seeking solutions despite obstacles. Regularly evaluate and challenges work processes. Establishes effective organizational methods for assigning, managing, and tracking work, when and where applicable. Solicits and/or provides information that could affect the planning, programs, and decision-making for the Canadian Coast Guard.",
                DescFre = "Tenir compte d'idées provenant de diverses sources afin de résoudre les problèmes. Reste flexible pour trouver d'autres moyens de contourner les obstacles/obstacles afin d'atteindre ses objectifs. Prend des risques calculés pour atteindre ses objectifs/résultats. Persévère dans la recherche de solutions malgré les obstacles. Évaluer et remettre en question régulièrement les processus de travail. Établir des méthodes organisationnelles efficaces pour l'attribution, la gestion et le suivi du travail, le cas échéant. Sollicite ou fournit de l'information qui pourrait influer sur la planification, les programmes et la prise de décisions de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 145,
                DescEng = "Offers expertise to resolve problems. Plans ahead to address future requirements without being asked. Anticipates and responds in a proactive manner to future needs of internal or external clients or groups. Coaches, supports, and encourages others to test limits, when and where applicable. Seeks new opportunities to improve outcomes using innovative approaches to overcome obstacles and surpass performance goals.",
                DescFre = "Offre une expertise pour résoudre les problèmes. Planifier à l'avance pour répondre aux besoins futurs sans qu'on le lui demande. Anticiper et répondre de façon proactive aux besoins futurs des clients ou des groupes internes ou externes. Entraîne, soutient et encourage les autres à tester les limites, le cas échéant. Cherche de nouvelles occasions d'améliorer les résultats en utilisant des approches novatrices pour surmonter les obstacles et dépasser les objectifs de rendement."
            },
            new CompetencyLevelRequirement
            {
                Id = 146,
                DescEng = "Sets standards and criteria for measuring success organizationally. Seizes opportunities and initiatives across organizational boundaries to achieve efficiencies consistent with the Coast Guard's vision. Creates an environment in which all systems and processes support high levels of efficiency. Champions the ongoing spirit of improvement and professional growth across the organization.",
                DescFre = "Établit des normes et des critères pour mesurer le succès de l'organisation. Saisit les occasions et les initiatives au-delà des frontières organisationnelles pour réaliser des gains d'efficience conformes à la vision de la Garde côtière. Crée un environnement dans lequel tous les systèmes et processus soutiennent des niveaux élevés d'efficacité. Se fait le champion de l'esprit d'amélioration continue et de croissance professionnelle à l'échelle de l'organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 147,
                DescEng = "Recognizes the importance of safety in the Canadian Coast Guard. Familiar with the orientation safety awareness training.",
                DescFre = "Reconnaît l'importance de la sécurité au sein de la Garde côtière canadienne. Familiarité avec la formation d'orientation et de sensibilisation à la sécurité."
            },
            new CompetencyLevelRequirement
            {
                Id = 148,
                DescEng = "Evaluates environment and adapts work to maintain safety. Ensures safety training is up to date. Uses appropriate personal protective equipment (PPE) when and where applicable. Applies proper safety procedures.",
                DescFre = "Évalue l'environnement et adapte le travail pour maintenir la sécurité. Veiller à ce que la formation en matière de sécurité soit à jour. Utilise l'équipement de protection individuelle (EPI) approprié, s'il y a lieu. Appliquer les procédures de sécurité appropriées."
            },
            new CompetencyLevelRequirement
            {
                Id = 149,
                DescEng = "Conducts operations consistent with the Coast Guard Safety Management System (SMS), national and regulatory safety procedures, and policy when and where applicable. Understands the risks and manages safety and health issues when and where applicable. May participate in occupational health and safety groups and audits.",
                DescFre = "Mène ses opérations conformément au Système de gestion de la sécurité (SGS) de la Garde côtière, aux procédures de sécurité nationales et réglementaires et à la politique, le cas échéant. Comprend les risques et gère les questions de sécurité et de santé, le cas échéant. participer, s'il y a lieu, à des groupes et à des vérifications sur la santé et la sécurité au travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 150,
                DescEng = "Promotes a culture of unit safety. Ensures required personnel under supervision are trained in first aid and safety procedures. Ensures personnel under supervision apply safety plans and principles. Integrates health and safety planning in conformity with Incident Command Systems (ICS) principles when and where applicable. Integrates health and safety considerations in post-incident and post-exercise reviews.",
                DescFre = "Favorise une culture de sécurité au sein de l'unité. Veiller à ce que le personnel nécessaire sous supervision soit formé aux premiers soins et aux procédures de sécurité. Veiller à ce que le personnel sous supervision applique les plans et les principes de sécurité. Intégrer la planification de la santé et de la sécurité conformément aux principes du Système de commandement des interventions (SCI), le cas échéant. Intégrer les considérations de santé et de sécurité dans les examens post-incident et post-exercice."
            },
            new CompetencyLevelRequirement
            {
                Id = 151,
                DescEng = "Promotes and integrates a culture of organizational safety. Develops risk analyses for responders and senior personnel regarding health and safety. Ensures required personnel are trained in first aid and safety procedures, as required. Leverages health and safety lessons learned from post-incident and post-exercise reviews in daily operations. ",
                DescFre = "Promouvoir et intégrer une culture de sécurité organisationnelle. Élabore des analyses des risques en matière de santé et de sécurité à l'intention des intervenants et des cadres supérieurs. Veiller à ce que le personnel requis soit formé aux premiers soins et aux procédures de sécurité, au besoin. Tire profit des leçons en matière de santé et de sécurité tirées des examens post-incident et post-exercice dans les opérations quotidiennes."
            },
            new CompetencyLevelRequirement
            {
                Id = 152,
                DescEng = "Listens to leaders and emulates positive behaviour through observation and imitation, when and where applicable. Recognizes personal limitations and is motivated to address and improve them.",
                DescFre = "Écouter les dirigeants et imiter les comportements positifs par l'observation et l'imitation, le cas échéant. Reconnaît ses limites personnelles et est motivé à y faire face et à les améliorer."
            },
            new CompetencyLevelRequirement
            {
                Id = 153,
                DescEng = "Adapts to change to help the team evolve in conjunction with the Coast Guard's evolving concerns. Seizes opportunities to increase skills and knowledge about operations, members, and stakeholders, when and where applicable.",
                DescFre = "S'adapte au changement pour aider l'équipe à évoluer en fonction de l'évolution des préoccupations de la Garde côtière. Saisit les occasions d'accroître les compétences et les connaissances sur les opérations, les membres et les intervenants, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 154,
                DescEng = "Demonstrates interest in team members' success and well-being by listening and actively viewing situations through others' perspectives. Identifies strengths, leverages them, and persuades others for the benefit of the Coast Guard. Routinely teaches and guides work, based on operational knowledge through direct and indirect means. Seeks solutions by charting opinions and options.",
                DescFre = "Démontre de l'intérêt pour le succès et le bien-être des membres de l'équipe en écoutant et en regardant activement les situations du point de vue des autres. Identifie les forces, les exploite et persuade les autres pour le bénéfice de la Garde côtière. Enseigne et guide régulièrement le travail, sur la base de connaissances opérationnelles, par des moyens directs et indirects. Cherche des solutions en dressant un tableau des opinions et des options."
            },
            new CompetencyLevelRequirement
            {
                Id = 155,
                DescEng = "Links members' individual development to organizational objectives and developing future leaders. Encourages innovation. Remains effective in the face of obstacles. Identifies and assesses risks in projects or decisions and produces realistic contingency plans to mitigate possible impacts. Exercises positive influence on the organization when needed. ",
                DescFre = "Liens entre le développement individuel des membres et les objectifs de l'organisation et le développement des futurs leaders. Favorise l'innovation. Reste efficace face aux obstacles. Cerner et évaluer les risques associés aux projets ou aux décisions et produire des plans d'urgence réalistes pour atténuer les répercussions possibles. Exerce une influence positive sur l'organisation au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 156,
                DescEng = "Sets and champions organizational directions. Recognizes the big picture and cultivates organizational vision. Prioritizes the creation of a work environment that propels teams to step up to new challenges. Seamlessly assumes next level responsibilities. Regularly exercises persuasive influence on the organization in a wide variety of tactical and strategic areas.",
                DescFre = "Établit et défend les orientations organisationnelles. Reconnaît l'ensemble de la situation et cultive la vision organisationnelle. Privilégie la création d'un environnement de travail qui incite les équipes à relever de nouveaux défis. Assume sans faille les responsabilités du niveau suivant. Exerce régulièrement une influence persuasive sur l'organisation dans une grande variété de domaines tactiques et stratégiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 157,
                DescEng = "Articulates pride in being a member of the Coast Guard. Wears and maintains the uniform properly, when and where applicable.",
                DescFre = "Exprime sa fierté d'être membre de la Garde côtière. Porte et entretient l'uniforme correctement, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 158,
                DescEng = "Expresses pride in the humanitarian and environmental nature of the Coast Guard's mission. Participates in organizational engagement activities. Wears the uniform proudly.",
                DescFre = "Exprime sa fierté quant à la nature humanitaire et environnementale de la mission de la Garde côtière. Participer aux activités d'engagement organisationnel. Il porte fièrement l'uniforme."
            },
            new CompetencyLevelRequirement
            {
                Id = 159,
                DescEng = "Expresses pride in the Coast Guard's regional and/or national achievements. Incorporates and models the Coast Guard's ambitious vision and motto in daily practice and supports it within units. Articulates the Coast Guard's vision when providing advice or instructions internally.",
                DescFre = "Exprime sa fierté à l'égard des réalisations régionales ou nationales de la Garde côtière. Intégrer et modeler la vision et la devise ambitieuse de la Garde côtière dans la pratique quotidienne et l'appuyer au sein des unités. Articuler la vision de la Garde côtière lorsqu'elle donne des conseils ou des instructions à l'interne."
            },
            new CompetencyLevelRequirement
            {
                Id = 160,
                DescEng = "Propagates the Coast Guard's vision, mission, mandate, and programs internally and externally as an example of deep pride in the organization. Conveys the importance of the Coast Guard's work to members and stakeholders. Celebrates organizational achievements.",
                DescFre = "Propager la vision, la mission, le mandat et les programmes de la Garde côtière à l'interne et à l'externe comme un exemple de fierté profonde envers l'organisation. Transmet l'importance du travail de la Garde côtière aux membres et aux intervenants. Célébrer les réalisations organisationnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 161,
                DescEng = "Models organizational pride in the Coast Guard's brand and the jobs it performs. Champions the organization when working collectively with internal and external stakeholders. Promotes organizational achievements and employee engagement events nationally. Strives to hone organizational excellence through celebration and pageantry.",
                DescFre = "Donne l'exemple de la fierté organisationnelle à l'égard de l'image de marque de la Garde côtière et des tâches qu'elle accomplit. Se fait le champion de l'organisation lorsqu'elle travaille collectivement avec les intervenants internes et externes. Fait la promotion des réalisations organisationnelles et des activités d'engagement des employés à l'échelle nationale. S'efforce d'affiner l'excellence organisationnelle par la célébration et l'apparat."
            },
            new CompetencyLevelRequirement
            {
                Id = 162,
                DescEng = "Understands primary coastal features, weather, tide, and charts.",
                DescFre = "Comprend les principales caractéristiques côtières, les conditions météorologiques, les marées et les cartes marines."
            },
            new CompetencyLevelRequirement
            {
                Id = 163,
                DescEng = "Understands basic traffic patterns for traffic aasync Taskance, observing and reporting weather conditions, and local tides in immediate surroundings.",
                DescFre = "Comprend les schémas de circulation de base pour éviter le trafic, observer et signaler les conditions météorologiques et les marées locales dans les environs immédiats."
            },
            new CompetencyLevelRequirement
            {
                Id = 164,
                DescEng = "Practical knowledge of a range of coastal domain factors including local weather predictability, vessel traffic aasync Taskance in a given charted area, and local tides and currents.",
                DescFre = "Connaissance pratique d'une gamme de facteurs du domaine côtier, y compris la prévisibilité des conditions météorologiques locales, l'évitement du trafic maritime dans une zone cartographiée donnée, et les marées et courants locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 165,
                DescEng = "Significant knowledge of a regional coastline including weather reporting and patterns, impacts on shipping, vessel traffic patterns and reporting, cartographic and oceanographic factors, and the search net. ",
                DescFre = "Connaissance approfondie d'un littoral régional, y compris les rapports et les tendances météorologiques, les répercussions sur la navigation, les tendances et les rapports du trafic maritime, les facteurs cartographiques et océanographiques, et le réseau de recherche."
            },
            new CompetencyLevelRequirement
            {
                Id = 166,
                DescEng = "Excellent knowledge of regional and/or national coastal factors including those likely to impact the coast, threats from offshore, natural disasters and their impacts, vessel traffic management, operations of other government vessels, detailed cartography, meteorology, hydrogeology, and oceanography.",
                DescFre = "Excellente connaissance des facteurs côtiers régionaux et/ou nationaux, y compris ceux susceptibles d'avoir une incidence sur la côte, les menaces provenant de la haute mer, les catastrophes naturelles et leurs répercussions, la gestion du trafic maritime, les opérations des autres navires gouvernementaux, la cartographie détaillée, la météorologie, l'hydrogéologie et l'océanographie"
            },
            new CompetencyLevelRequirement
            {
                Id = 167,
                DescEng = "Basic knowledge of how the movement of water generates gravity force to lift or lower a vessel in a canal lock.",
                DescFre = "Connaissance de base de la façon dont le mouvement de l’eau produit une force de gravité qui permet d’élever ou d’abaisser un navire dans une écluse de canal."
            },
            new CompetencyLevelRequirement
            {
                Id = 168,
                DescEng = "Limited knowledge of the major operational components of a canal, such as the bollard, gate, lock, reach, and valve.",
                DescFre = "Connaissance limitée des principaux composants opérationnels d’un canal, comme le bollard, la porte, l’écluse, le bief et la vanne."
            },
            new CompetencyLevelRequirement
            {
                Id = 169,
                DescEng = "Practical knowledge of how to signal a canal master, approach a lock reach, navigate a lock, and proceed safely clear of a canal.",
                DescFre = "Connaissance pratique de la façon d'indiquer son intention à un maître-éclusier, d'approcher un bief d'écluse, de naviguer dans une écluse et de sortir d'un canal de façon sécuritaire."
            },
            new CompetencyLevelRequirement
            {
                Id = 170,
                DescEng = "Advanced knowledge of canal lock operation from a canal master perspective, including receiving signals of transits, operating the gates, flooding the lock, and troublshooting for current or potential problems.",
                DescFre = "Connaissance approfondie de l’exploitation des écluses sous l’angle général des canaux, y compris la réception de signaux de passages, le fonctionnement des portes, le remplissage de l’écluse et le dépannage pour des problèmes actuels et possibles."
            },
            new CompetencyLevelRequirement
            {
                Id = 171,
                DescEng = "Expert knowledge of all facets of canal lock operating, as well as such maintenance functions as ordering and overseeing preventative maintenance of gates, and controls.",
                DescFre = "Connaissance spécialisée de toutes les facettes de l’exploitation des écluses, des activités d’entretien comme ordonner et superviser l’entretien préventif des portes ainsi que des contrôles."
            },
            new CompetencyLevelRequirement
            {
                Id = 172,
                DescEng = "Assists trades staff in performing basic labour activities, when and where applicable. Maintains clean and orderly conditions in all working areas, including shop, vehicle, vessel, and the Canadian Coast Guard's work sites.",
                DescFre = "Aide le personnel des métiers à exercer des activités de base, le cas échéant. Maintient des conditions propres et ordonnées dans tous les lieux de travail, y compris l'atelier, le véhicule, le navire et les sites de travail de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 173,
                DescEng = "Performs duties such as window mechanism repairs, lubricating doors, tile and carpet removal, painting, boiler tube cleaning, securing buildings, emergency water shut off, roof drain cleaning, ceiling tile replacement, air filter changing, removal of roof debris, replacement of lights, minor driveway and walkway repairs, catch basin maintenance. Loads, transports, and unloads planned furniture, equipment, books, risers and other material requested and approved within vessels and facilities of the Coast Guard. Uses power and hand tools.",
                DescFre = "S'acquitte de tâches telles que la réparation des mécanismes de fenêtres, la lubrification des portes, l'enlèvement des tuiles et des tapis, la peinture, le nettoyage des tubes de chaudière, la sécurisation des bâtiments, la coupure d'urgence de l'eau, le nettoyage des canalisations d'évacuation des eaux de toit, le remplacement des tuiles de plafond, le changement des filtres à air, l'enlèvement des débris de toit, le remplacement des lumières, les petites réparations des allées et des trottoirs, l'entretien des puisards. Charger, transporter et décharger le mobilier, l'équipement, les livres, les colonnes montantes et autres matériels prévus, demandés et approuvés dans les navires et les installations de la Garde côtière. Utilise des outils électriques et manuels."
            },
            new CompetencyLevelRequirement
            {
                Id = 174,
                DescEng = "Completes and documents work and/or inspection/test orders. Makes recommendations and determines potential work time for planned equipment moves and maintenance. Operates precision power hand tools, and cleans, maintains, and stores equipment after use.",
                DescFre = "Effectue et documente les travaux et/ou les ordres d'inspection/de test. Formule des recommandations et détermine le temps de travail potentiel pour les déplacements et l'entretien prévus de l'équipement. Utilise des outils à main électriques de précision, et nettoyer, entretenir et stocker l'équipement après utilisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 175,
                DescEng = "Performs risk assessment of all assigned projects and maintains risk management protocols at all times. Performs inspections and keeps maintenance records. Operates and maintains power and hand tools, and trains others.",
                DescFre = "Effectue l'évaluation des risques de tous les projets assignés et maintient des protocoles de gestion des risques à tout moment. Effectue des inspections et tient des registres de maintenance. Fait fonctionner et entretient les outils électriques et manuels, et forme d'autres personnes."
            },
            new CompetencyLevelRequirement
            {
                Id = 176,
                DescEng = "Maintains buildings and grounds. Performs minor construction and renovation projects. Implements vehicle, vessel, and/or building system practices and procedures. Inspects and conducts quality assurance functions.",
                DescFre = "Entretient les bâtiments et les terrains. Réalise des projets de construction et de rénovation mineurs. Mettre en œuvre des pratiques et des procédures relatives aux véhicules, aux navires et/ou aux systèmes de bâtiments. Inspecte et exerce des fonctions d'assurance qualité."
            },
            new CompetencyLevelRequirement {Id = 177, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 178, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 179, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 180,
                DescEng = "Works on a daily basis with documents such as labels on hazardous materials, signs, lists, operator’s manuals, inspection forms, hazard assessment forms, log books, and time sheets. Makes entries in daily equipment reports (logbooks) during pre- and post-operational inspections. Calculates the number of loads required to remove materials and the weight distribution of a load being lifted. Measures and calculates the slope and ratio of ditches. Uses computer-controlled equipment such as electronic scales, GPS, and advanced operating systems. Keep an equipment maintenance log to note repairs made and service schedules. Writes accident and incident reports describing details. Estimates distances between the machine and various obstacles, width of ramps for space on either side of a machine, and how many truckloads of fill are required. Converts between the imperial and metric systems of measurement.",
                DescFre = "Travailler quotidiennement avec des documents comme des étiquettes sur les matières dangereuses, des panneaux, des listes, des manuels d’utilisation, des formulaires d’inspection, des formulaires d’évaluation des dangers, des journaux de bord et des feuilles de temps. Effectuer la saisie de données dans les rapports quotidiens d’utilisation de l’équipement (journaux de bord) lors des inspections avant et après l’utilisation de l’équipement. Calculer le nombre de chargements nécessaires pour enlever les matières ainsi que la répartition du poids pour chaque chargement levé. Mesurer et calculer la pente et le rapport des fossés. Utiliser de l’équipement commandé par ordinateur comme des balances électroniques, des GPS et des systèmes d'exploitation spécialisés. Maintenir un journal d’entretien de l’équipement pour noter les réparations effectuées et les calendriers d’entretien. Rédiger des rapports d’accident et d’incident qui décrivent en détail les événements. Estimer les distances entre la machine et divers obstacles, la largeur des rampes pour connaître l’espace disponible de chaque côté de l’équipement et le nombre de chargements de camion complets qui sont nécessaires. Effectuer les conversions des mesures entre le système impérial et le système métrique."
            },
            new CompetencyLevelRequirement
            {
                Id = 181,
                DescEng = "Reads pamphlets explaining regulations and codes, bulletins from unions, employers or other regulatory bodies, and memos or work orders with information on the nature of the work to be performed. Reads or marks stakes with station numbers and slope ratios, mark off caution areas on maps, and make sketches or drawings. Consults surveyor charts and blueprints. Stays up to date with regulations, health and safety procedures and new technology. Advise and guide management in best practices, approaches, and strategies to resolve issues or define programs. Train staff to perform essential functions of the position and adhere to internal practices that have been established by self for the benefit of the shop or the Canadian Coast Guard.",
                DescFre = "Lire des brochures sur les règlements et les codes, des bulletins rédigés par les syndicats, les employeurs ou d’autres organismes de réglementation ainsi que des notes de service ou des bons de travail comprenant des renseignements sur la nature des travaux devant être effectués. Lire ou marquer des jalons avec les numéros des stations et la déclivité, délimiter les zones à restrictions sur des cartes et produire des esquisses ou des dessins. Consulter les cartes et les plans détaillés de l’arpenteur-géomètre. Se tenir au courant des règlements, des procédures de santé et de sécurité et des nouvelles technologies. Conseiller et orienter la direction à l’égard des pratiques exemplaires, des méthodes et des stratégies pour résoudre des problèmes ou définir des programmes. Former les membres du personnel pour qu’ils exécutent les fonctions essentielles de leur poste et adoptent des pratiques internes qu’ils ont eux-mêmes établies au profit de l’atelier ou de la GCC."
            },
            new CompetencyLevelRequirement
            {
                Id = 182,
                DescEng = "Assists carpenters. Interprets simple blueprints and drawings. Uses basic materials and techniques. Sets up and operates hand tools and equipment. Sets up framing using basic joining techniques. Maintains and cleans tools and the site.",
                DescFre = "Aide aux menuisiers. Interprète des plans et des dessins simples. Utilise des matériaux et des techniques de base. Installe et utilise des outils à main et du matériel. Met en place l'encadrement en utilisant les techniques d'assemblage de base. Entretient et nettoie les outils et le site."
            },
            new CompetencyLevelRequirement
            {
                Id = 183,
                DescEng = "Performs standard building construction and repair using sketches, working blueprints, and work plans. Uses and maintains tools according to standards. Selects appropriate materials and gear. Assembles items with standard joining, woodworking, and bonding techniques. Works independently on basic jobs.",
                DescFre = "Effectue la construction et la réparation de bâtiments standard à l'aide de croquis, de plans de travail et de plans d'exécution. Utilise et entretient les outils conformément aux normes. Sélectionne les matériaux et les équipements appropriés. Assemble des articles en utilisant des techniques d'assemblage, de menuiserie et de collage standard. Travaille de manière indépendante sur des travaux de base."
            },
            new CompetencyLevelRequirement
            {
                Id = 184,
                DescEng = "Performs intermediate heavy and light construction and repair. Manages cyclic preventive maintenance on a selected array of machinery, tools, and equipment. Works from sketches, orders, and standard blueprints to independently assemble and repair most basic structures.",
                DescFre = "Effectue des travaux de construction et de réparation intermédiaires, lourds et légers. Gère l'entretien préventif cyclique d'un ensemble sélectionné de machines, d'outils et d'équipements. Travaille à partir de croquis, de commandes et de plans standard pour assembler et réparer de manière indépendante la plupart des structures de base."
            },
            new CompetencyLevelRequirement
            {
                Id = 185,
                DescEng = "Performs complex construction and repair using the full range of woodworking tools, techniques, and machines. Interprets complex blueprints, drawings, and specifications. Determines layout and work sequence. Assembles items to close tolerance and fit with a wide variety of joining techniques.",
                DescFre = "Effectue des travaux de construction et de réparation complexes en utilisant toute la gamme des outils, techniques et machines de menuiserie. Interprète des plans, des dessins et des spécifications complexes. Détermine la disposition et la séquence de travail. Assemble des articles avec une tolérance étroite et les adapter à une grande variété de techniques d'assemblage."
            },
            new CompetencyLevelRequirement
            {
                Id = 186,
                DescEng = "Develops and implements work schedules. Uses advanced knowledge of wood and other materials and shop mathematics to compute and lay out arcs, tangents, and circles according to complex blueprints. Sets up and operates all precision carpentry and wood working tools and equipment. Finishes products with precise fit, accurate dimensions, and appearance. Determines grade, size and type of lumber.",
                DescFre = "Elabore et met en œuvre des programmes de travail. Utilise des connaissances avancées sur le bois et d'autres matériaux et faire des calculs mathématiques d'atelier pour calculer et tracer des arcs, des tangentes et des cercles selon des plans complexes. Met en place et utilise tous les outils et équipements de menuiserie et de travail du bois de précision. Finit les produits avec un ajustement précis, des dimensions et un aspect précis. Détermine la qualité, la taille et le type de bois d'œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 187,
                DescEng = "Aware of common electrical (or electronic) processes or any other area requiring technical expertise. Performs an analysis based on a standard flowchart.",
                DescFre = "Conscient des processus électriques (ou électroniques) courants ou de tout autre domaine requérant une expertise technique. Effectue une analyse basée sur un organigramme normalisé."
            },
            new CompetencyLevelRequirement
            {
                Id = 188,
                DescEng = "Makes recommendations on routine/technical designs and/or program/project specifications to comply with principles, standards, codes and electrical engineering design and statutes, as required.",
                DescFre = "Fait des recommandations sur les conceptions de routine/techniques et/ou les spécifications de programme/projet afin d'être conforme aux  principes, aux normes, aux codes et à la conception et statuts du génie électrique, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 189,
                DescEng = "Makes decisions on non-routine and/or program-related matters requiring technical expertise, as required. Provides technical analysis. Serves as a mentor/resource for lower-level employees for assignments, as required. Resolves conflicting design constraints, as required.",
                DescFre = "Prend des décisions sur des questions non routinières et/ou relatives au programme nécessitant une expertise technique, le cas échéant. Fournit une analyse technique. Sert de mentor/ressource aux employés de niveau inférieur dans le domaine des affectations, le cas échéant. Résout les contraintes de conception contradictoires, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 190,
                DescEng = "Approves complex or new electrical/technical designs and/or program/project specifications to comply with desired principles, standards, codes, design and statutes. Reviews equipment replenishment requests to ensure that the items currently in use and the quantities ordered are realistic.",
                DescFre = "Approuve les conceptions électriques/techniques complexes ou nouvelles et/ou les spécifications de programme/projet afin d'être conforme aux principes, aux normes, aux codes, à la conception et statuts souhaités. Examine les demandes de réapprovisionnement en matériel pour s'assurer que les articles actuellement utilisés et les quantités commandées sont réalistes."
            },
            new CompetencyLevelRequirement
            {
                Id = 191,
                DescEng = "Makes final recommendations in the specialized areas of electrical engineering and/or the program. Represents the CCG as an expert in electrical overhaul and design.",
                DescFre = "Fait des recommandations finales dans les domaines spécialisés du génie électrique et/ou du programme. Représente la GCC en tant qu'expert en révision et en conception électrique."
            },
            new CompetencyLevelRequirement {Id = 192, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 193, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 194, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 195,
                DescEng = "Interprets work orders and technical manuals, and drafts service reports and maintenance logs. Checks bulldozers, cranes, graders, and other heavy construction equipment for proper performance and inspects equipment to detect faults and malfunctions. Diagnoses faults or malfunctions using computerized and other testing equipment to determine extent of repair required. Cleans, lubricates, and performs other routine maintenance work on equipment. Adjusts equipment and repairs or replaces defective parts, components or systems, using hand and power tools. Tests repaired equipment for proper performance and to ensure that work meets manufacturers' specifications.",
                DescFre = "Interpréter des bons de travail et des manuels techniques ainsi que rédiger des rapports et des registres d’entretien. Vérifier les bouteurs, les grues, les niveleuses et tout autre équipement lourd afin d’en assurer le bon fonctionnement et inspecter l’équipement afin de déceler des défectuosités et des défaillances. Déceler les défectuosités ou les défaillances au moyen d’outils informatisés ou d’autre outillage d'essai afin de déterminer l’ampleur des réparations requises. Nettoyer et lubrifier l’équipement et exécuter d’autres travaux d’entretien courant. Mettre au point l’équipement et réparer ou remplacer les pièces, les composants ou les systèmes défectueux au moyen d’outils à main et d’outils électriques. Mettre à l’essai l’équipement réparé afin d’en assurer le bon fonctionnement et de veiller à ce que les réparations respectent les spécifications du fabricant."
            },
            new CompetencyLevelRequirement
            {
                Id = 196,
                DescEng = "Assists other mechanics with more challenging assignments. Maintains a schedule for preventative maintenance on all equipment. Ensures that equipment meets all government regulations and standards for safety. Stays current with regulations, health and safety procedures, and new technologies. Advises and guides management in best practices, approaches, and strategies to resolve issues or define programs. Provides instruction and training in the proper methods and processes necessary to perform equipment repair, inspection, and preventive maintenance.",
                DescFre = "Aider les autres mécaniciens pour les tâches plus difficiles. Tenir à jour un calendrier des travaux d’entretien préventif pour tout l’équipement. Veiller à ce que l’équipement soit conforme à tous les règlements et à toutes les normes de sécurité du gouvernement. Se tenir au courant des règlements, des procédures de santé et de sécurité et des nouvelles technologies. Conseiller et orienter la direction à l’égard des pratiques exemplaires, des méthodes et des stratégies pour résoudre des problèmes ou définir des programmes. Fournir des directives et de la formation sur les méthodes et les processus appropriés qui sont nécessaires pour la réparation, l’inspection et l’entretien préventif de l’équipement."
            },
            new CompetencyLevelRequirement {Id = 197, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 198, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 199, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 200, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 201,
                DescEng = "Reviews manuals, bulletins, and safety documents. Locates data such as classifications, product and material specifications, identification numbers, quantities, and costs. Completes workplace documents such as written explanations to the client, work orders, inspection reports, and incident reports. Analyzes pressure, power, torque, compression, and electrical readings to assess vehicle performance and troubleshoot faults. Takes a variety of measurements using digital and analog equipment. Evaluates the severity of vehicle defects and deficiencies and the quality of repairs. Uses computerized scanning equipment, onboard vehicle diagnostics and hand-held diagnostic tools to gain operational information about vehicles. Repairs damaged vehicles, vessels, including engine repair and body work.",
                DescFre = "Étudier les manuels, les bulletins et les documents portant sur la sécurité. Trouver des données comme les classifications, les spécifications sur les produits et le matériel, les numéros d’identification, les quantités et les coûts. Remplir les documents utilisés en milieu de travail comme des explications écrites à l’intention du client, des bons de travail, des rapports d’inspection et des rapports d’incident. Analyser la pression, la puissance, le couple, la compression et les mesures électriques en vue d’évaluer la performance des véhicules et de déceler la cause des défectuosités. Effectuer diverses mesures au moyen d’équipement numérique et analogique. Évaluer la gravité des défauts et des lacunes des véhicules ainsi que la qualité des réparations. Utiliser de l’équipement de balayage informatisé ainsi que des outils portatifs et des systèmes à bord des véhicules pour la détection des anomalies afin d’obtenir de l’information opérationnelle sur les véhicules. Réparer les véhicules et les navires endommagés, y compris la réparation des moteurs et le débosselage."
            },
            new CompetencyLevelRequirement {Id = 202, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 203, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 204,
                DescEng = "Sands and hydro blasts for cleaning, decorative or preparatory purposes steel, concrete, or wood. Installs rubber, fiberglass, acid resistant or metalized linings to tanks, pipes, or other vessels. Installs all wall coverings on buildings or structure surfaces, when and where applicable. Uses hand tools and measuring equipment. ",
                DescFre = "Procéder au ponçage ou au sablage par jet d’eau à des fins de nettoyage, de décoration ou de préparation de l’acier, du béton ou du bois. Installer du caoutchouc, de la fibre de verre ou des revêtements résistants aux acides ou métallisés sur les réservoirs, les tuyaux ou d’autres navires. Installer tous les revêtements muraux sur les surfaces des immeubles ou des structures, s’il y a lieu. Utiliser des outils à main et des instruments de mesure."
            },
            new CompetencyLevelRequirement
            {
                Id = 205,
                DescEng = "Cleans and sands surfaces. Applies drywall and plaster repair and finishing techniques. Applies chemical treatments and wood fillers to a given surface. Applies procedures or treatments to prepare a substrate. Strains, mixes, and thins coatings according to specifications including ratios and induction times. Applies a spray finish using airless equipment according to project specifications. Performs abrasive and hydro blasting. Corrects coating failures. Uses hoisting and lifting equipment.",
                DescFre = "Nettoyer et poncer des surfaces. Réparer les cloisons sèches et les plâtres et appliquer des techniques de finition. Appliquer des traitements chimiques et des bouche-pores sur une surface donnée. Appliquer les procédures ou les traitements pour préparer un subjectile. Allonger, mélanger et amincir les revêtements conformément aux spécifications, notamment les rapports et les temps d’induction. Appliquer une finition au pistolet-vaporisateur au moyen d’un équipement sans air comprimé, conformément aux spécifications du projet. Effectuer la projection abrasive et le sablage par jet d’eau. Réparer les défauts des revêtements. Utiliser du matériel de levage."
            },
            new CompetencyLevelRequirement
            {
                Id = 206,
                DescEng = "Manages workplace hazards while respecting fall protection systems, personal protective equipment (PPE), and fire safety procedures. Uses power, pneumatic tools, and access equipment. Prepares and repairs drywall, plaster, concrete, masonry, metal and wood surfaces. Applies and corrects paint/coating failures. Uses airless, specialty, and thermal spray equipment. Applies caulking, finishes, and graphics. Applies decorative finishes. Interprets drawings and specifications. Identifies standards for application of coatings to metal substrates. Provides guidance on the types and functions of abrasive blasting equipment, on the procedures involved in hydro blasting, the architectural, high performance, and industrial coatings, and on the causes and remedies for given coating failures.",
                DescFre = "Gérer les dangers en milieu de travail tout en respectant les procédures relatives aux dispositifs de protection contre les chutes, à l’équipement de protection individuelle (EPI) et à l’évacuation en cas d’incendie. Utiliser des outils électriques et pneumatiques ainsi que de l’équipement d’accès. Préparer et réparer les surfaces de cloison sèche, de plâtre, de béton, de maçonnerie, de métal et de bois. Appliquer de la peinture ou du revêtement et réparer les défauts. Utiliser de l’équipement sans air comprimé, spécialisé et de projection thermique. Appliquer du calfatage, des couches de finition et des éléments graphiques. Appliquer des couches de finition décoratives. Interpréter des dessins et des spécifications. Déterminer les normes d’application des revêtements sur des substrats de métal. Donner des conseils sur les types d’équipement de projection abrasive et leurs fonctions, sur les procédures concernant les peintures industrielles et les revêtements par projection abrasive, pour bâtiment, et à haute résistance ainsi que sur les causes des défauts d’un revêtement donné et les solutions."
            },
            new CompetencyLevelRequirement
            {
                Id = 207,
                DescEng = "Basic knowledge of the acts and regulations applicable to a given program area, based on education or training.",
                DescFre = "Connaissance de base des lois et règlements applicables à un domaine de programme donné, fondée sur l'éducation ou la formation."
            },
            new CompetencyLevelRequirement
            {
                Id = 208,
                DescEng = "Limited knowledge of acts and regulations based on training, researching, and limited experience in a given program setting.",
                DescFre = "Connaissance limitée des lois et des règlements fondée sur la formation, la recherche et l'expérience limitée dans un contexte de programme donné."
            },
            new CompetencyLevelRequirement
            {
                Id = 209,
                DescEng = "Practical knowledge of all acts and regulations pertinent to a program of expertise, being able to advise appropriately, link to rules, and contribute to instructions relating to these areas.",
                DescFre = "Connaissance pratique de toutes les lois et de tous les règlements pertinents à un programme d'expertise, capacité de conseiller adéquatement, d'établir des liens avec les règles et de contribuer aux instructions relatives à ces domaines."
            },
            new CompetencyLevelRequirement
            {
                Id = 210,
                DescEng = "Advanced knowledge in the acts and regulations pertinent to a program as well as its impacts on and relationships with other programs.  Participates in the clarification and creation of rules based in acts and regulations. Instructs in the subject, when and where applicable.",
                DescFre = "Connaissance approfondie des lois et règlements pertinents à un programme ainsi que de ses répercussions sur d'autres programmes et de ses relations avec eux.  Participer à la clarification et à la création de règles fondées sur des lois et des règlements. Enseigne le sujet, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 211,
                DescEng = "Expert knowledge in acts and regulations relating to several programs. Participates in joint sessions, and advises with internal and external stakeholders on how acts and regulations pertain to and relate among and between programs, industry, and the public.",
                DescFre = "Connaissance experte des lois et règlements relatifs à plusieurs programmes. Participer à des séances conjointes et donner des conseils aux intervenants internes et externes sur la façon dont les lois et les règlements se rapportent aux programmes, à l'industrie et au public, et entre eux."
            },
            new CompetencyLevelRequirement
            {
                Id = 212,
                DescEng = "Understands the operational and contingency plans for each diving operation. Can articulate the hazards that could be encountered in the underwater work site. ",
                DescFre = "Comprend les plans opérationnels et d'urgence pour chaque opération de plongée. Peut exprimer clairement les dangers qui pourraient survenir sur le site de travail sous-marin. "
            },
            new CompetencyLevelRequirement
            {
                Id = 213,
                DescEng = "Understands the nature of the work, procedures to be used, equipment and personnel required for the operation, places and timing. Aware of the code of practice to be used for each operation's specific tasking.",
                DescFre = "Comprend la nature du travail, les procédures à utiliser, l'équipement et le personnel requis pour l'opération, les lieux et le calendrier. Connaître le code de pratique à utiliser pour les tâches spécifiques à chaque opération. "
            },
            new CompetencyLevelRequirement
            {
                Id = 214,
                DescEng = "Knowledge of specifications for each operation: task evaluation, schedules, equipment selection. Understands the site specificities. Understands the importance appropriate dive teams to suit skills of available personnel. Understands dive profiles and planning, gas requirements calculations and contingency planning as indicated by Hazard Identification and Risk Assessment (HIRA).",
                DescFre = "Connaissance des spécifications de chaque opération : évaluation des tâches, horaires, choix des équipements. Comprend les spécificités du site. Comprend l'importance d'avoir des équipes de plongée adaptées aux compétences du personnel disponible. Comprend les profils et la planification des plongées, les calculs des besoins en gaz et la planification d'urgence tels qu'indiqués par l'Identification des dangers et évaluation des risques (HIRA)."
            },
            new CompetencyLevelRequirement
            {
                Id = 215,
                DescEng = "Advanced knowledge of emergency evacuation plan and the arrangements for evacuation of casualties. Understands and knows contact numbers and locations and frequencies for backup services. Understands accessibilities to emergency medical facilities and how to prepare a roadmap and/or list of directions for the driver.",
                DescFre = "Connaissance approfondie du plan d'évacuation d'urgence et des dispositions à prendre pour l'évacuation des blessés. Comprend et connaît les numéros de téléphone, les emplacements et les fréquences des personnes-ressources pour les services de relève. Comprend les possibilités d'accès aux installations médicales d'urgence et la façon de préparer une feuille de route et/ou une liste d'instructions pour le conducteur."
            },
            new CompetencyLevelRequirement
            {
                Id = 216,
                DescEng = "Expert knowledge in diving operations and policies. Stays updated on safety matters which may have changed such as changes in regulations, codes of practice, or the operations manual, safety procedures, equipment, personal protective equipment (PPE), and job assignments and responsibilities. Champions diving operations knowledge as a prevention mechanism.",
                DescFre = "Connaissances approfondies des opérations et des politiques de plongée. Se tient au courant des questions de sécurité qui peuvent avoir changé, comme les modifications apportées aux règlements, aux codes de pratique ou au manuel d'exploitation, aux procédures de sécurité, à l'équipement, à l'équipement de protection individuelle (EPI) et aux affectations de travail et responsabilités. Se fait le champion de la connaissance des opérations de plongée en tant que mécanisme de prévention."
            },
            new CompetencyLevelRequirement
            {
                Id = 217,
                DescEng = "Where assisted or trained, employs safe operating procedures in erecting a temporary jib or derrick for boats or painting or gangway uses. Learns splicing and rigging gear to make slings and tackle. Ties appropriate knots as required.",
                DescFre = "Appliquer, grâce à de l’aide ou à de la formation, des procédures opérationnelles sécuritaires pour ériger une flèche ou un mât temporaire qui sera utilisé par les bateaux, pour des travaux de peinture ou comme passerelle. Apprendre l’épissure et les apparaux de gréement pour créer des élingues et des palans. Faire les nœuds appropriés au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 218,
                DescEng = "Installs cables, pulleys, and tackle as directed. Identifies the components and characteristics of wire rope and synthetic slings. Uses safety harnesses and life lines when hoisting and rigging on deck and aloft. Conducts rigging for basic operations (e.g. safety lines, boat, painting, gangway). Performs routine inspections.",
                DescFre = "Installer des câbles, des poulies et des palans selon les directives. Définir les composants et les caractéristiques des câbles métalliques et des élingues en fibres synthétiques. Utiliser des harnais de sécurité et des lignes de sécurité lors du levage et du gréement sur un pont et en hauteur. Réaliser le gréement pour les opérations de base (p. ex. lignes de sécurité, bateau, travaux de peinture et passerelle). Réaliser des inspections régulières."
            },
            new CompetencyLevelRequirement
            {
                Id = 219,
                DescEng = "Calculates the load on a sling using the load angle factor for different loads. Identifies and employs various rigging equipment, slings, and hardware (wire rope, shackles, eyebolts, hooks, etc.). Conducts routine and periodic inspections and reports. Employs proper hand signals during lifting operations.",
                DescFre = "Calculer la charge accrochée à une élingue au moyen du facteur d’angle de charge pour différentes charges. Sélectionner et utiliser divers appareils de gréement, des élingues et du matériel (câbles métalliques, manilles, pitons à œil, crochets, etc.). Mener des inspections régulières et périodiques et produire des rapports. Utiliser les bons signaux manuels pendant les opérations de levage."
            },
            new CompetencyLevelRequirement
            {
                Id = 220,
                DescEng = "Handles, cares for, and stores mooring ropes and wires, rope stoppers. Handles mooring winches, windlesses, and capstans safely. Correctly fits wire grips. Slings a stage and bosun chair. Rigs overside ladders, gangways, and accommodation ladders. Rigs hydrostatic releases. Secures the deck for heavy weather, and anchors for sea. Employs emergency lights, rig, and steering using emergency gear, when and where applicable.",
                DescFre = "Manipuler, entretenir et entreposer les amarres, les câbles d’amarrage et les stoppeurs de câble. Manipuler de façon sécuritaire les treuils d’amarrage, les guindeaux et les cabestans. Ajuster correctement les serre-câbles. Élinguer une plateforme et une chaise de gabier. Effectuer le gréement d’échelles, de passerelles de débarquement et d’échelles de coupée. Effectuer le gréement de dispositifs de largage hydrostatique. Arrimer le pont en prévision de gros temps et jeter l’ancre. Utiliser les lampes d’éclairage de secours, le gréement et la direction au moyen du gouvernail de secours, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 221,
                DescEng = "Directs and performs rigging operations of all aspects directly or indirectly associated with removal, installation, repair, and/or construction of major shipboard components, at sea, while loading, and during refits. Champions and provides on the job training in rigging, splicing, and safety protocols.",
                DescFre = "Diriger et réaliser des opérations de gréement pour tous les aspects directement ou indirectement liés à l’enlèvement, à l’installation, à la réparation ou à la construction de composants majeurs à bord des navires, en mer, pendant le chargement et pendant le radoub. Défendre et offrir la formation en cours d’emploi sur le gréement, l’épissure et les protocoles de sécurité."
            },
            new CompetencyLevelRequirement
            {
                Id = 222,
                DescEng = "Conducts basic maintenance requirements on diving equipment as per owner's manual instructions. Extracts air samples for purity analyses.",
                DescFre = "Respecter les exigences relatives à l’entretien de base de l’équipement de plongée conformément aux directives du manuel d’utilisation. Procéder au prélèvement d’échantillons d’air aux fins d’analyse de la pureté."
            },
            new CompetencyLevelRequirement
            {
                Id = 223,
                DescEng = "Assembles and disassembles Compressed Air Breathing Apparatus (CABA) diving ensemble, diagnoses and repairs high pressure faults, and calibrates diving equipment.",
                DescFre = "Monter et démonter l’ensemble de plongée de l’appareil respiratoire à air comprimé (ARAC), déceler et réparer les défectuosités à haute pression et calibrer l’équipement de plongée."
            },
            new CompetencyLevelRequirement
            {
                Id = 224,
                DescEng = "Conducts advanced maintenance such as oxygen cleaning for high pressure parts and maintains diving life support equipment. Completes preventative maintenance on dive cylinders and dive cylinder valves, on buoyancy compensators, and 1st/2nd stage regulators.",
                DescFre = "Réaliser un entretien spécialisé, notamment le nettoyage à l’oxygène des pièces à haute pression, et entretenir l’équipement de plongée pour le maintien des fonctions vitales. Réaliser l’entretien préventif des bouteilles d’air comprimé et de leurs valves, des gilets de stabilisation et des détendeurs à un ou deux étages."
            },
            new CompetencyLevelRequirement
            {
                Id = 225,
                DescEng = "Plans technical maintenance requirements and maintains maintenance data base systems (air samples, inspection etc.). Takes corrective action on reported equipment recalls and deficiencies.",
                DescFre = "Planifier les exigences relatives à l’entretien technique et tenir à jour les systèmes de bases de données sur l’entretien (échantillons d’air, inspection, etc.). Appliquer des mesures correctives en ce qui concerne les rappels et les lacunes de l’équipement."
            },
            new CompetencyLevelRequirement
            {
                Id = 226,
                DescEng = "Manages the air and gas purity program. Liaises with outside agencies for 3rd line maintenance requirements. Conducts inspection of dive equipment.",
                DescFre = "Gérer le programme pour la pureté de l’air et des gaz comprimés. Assurer la liaison avec des organismes externes pour les exigences relatives à l’entretien de troisième échelon. Inspecter l’équipement de plongée."
            },
            new CompetencyLevelRequirement {Id = 227, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 228, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 229,
                DescEng = "Plans and attends all dives. Assesses the readiness of members prior to dives, including that each diver has a diving log book at the dive site and is available for inspection before dives. Conducts pre/post dive routines and mission briefs. Ensures warning devices are displayed to indicate the area around the dive site and where the diving operation is being carried out. Ensures equipment checks. Controls divers' depth and duration of dives. Responds to diving emergencies. Identifies diving related ailments not requiring recompression.",
                DescFre = "Planifier toutes les plongées et y assister. Évaluer la préparation de chaque membre avant la plongée en s’assurant qu’il a un carnet de plongeur au site de plongée et qu’il est disponible pour une inspection avant la plongée. Diriger la marche à suivre avant et après la plongée et donner des instructions pour les missions. S’assurer que des dispositifs d’avertissement sont disposés pour indiquer la zone qui entoure le site de plongée et l’endroit où celle-ci a lieu. Procéder à des vérifications de l’équipement. Contrôler la profondeur des plongeurs et la durée de leur plongée. Intervenir en cas d’urgence lors des plongées. Déterminer les maux liés à la plongée qui ne nécessitent pas de recompression."
            },
            new CompetencyLevelRequirement
            {
                Id = 230,
                DescEng = "Briefs teams and ensures that the operational and contingency plans for diving operations are followed. Reviews and briefs on hazards that could be encountered in the underwater site. Ensures that any diving equipment to be used in the diving operation is examined, tested, and repaired before its use by a competent person at least once on the day of a dive. Ensures that the dive area is kept clear of equipment that is not associated with the diving operation. Ensures that no diver exceeds a depth longer than the maximum time allowed for a dive. Supervises all decompressions and therapeutic recompressions, in strict accordance with procedures and tables.",
                DescFre = "Informer les équipes et s’assurer que les plans opérationnels et d’urgence relatifs aux opérations de plongée sont suivis. Examiner les dangers possibles du site sous l’eau et communiquer des renseignements sur ceux-ci. S’assurer que tout équipement destiné à une opération de plongée soit examiné, mis à l’essai et réparé avant son utilisation par une personne compétente, et ce, au moins une fois le jour de la plongée. S’assurer que la zone de la plongée est libérée de tout équipement non lié à l’opération de plongée. S’assurer qu’aucun plongeur ne dépasse la profondeur possible en fonction de la durée maximale impartie pour une plongée. Superviser toutes les décompressions et les recompressions thérapeutiques, en respectant rigoureusement les procédures et les tables de plongée."
            },
            new CompetencyLevelRequirement
            {
                Id = 231,
                DescEng = "Establishes dive supervision parameters using the Compressed Air Breathing Apparatus (CABA) or the Light Weight Surface Supply (LWSS) dive equipment. Manages diving plans and schedules. Recommends and attends training for divers. Manages and directs all dive emergencies. Collects evidence on incident/accident reports. Conducts incident reviews and implements corrective actions. Champions diving safety protocols and practices.",
                DescFre = "Établir les paramètres de la supervision de la plongée lors de l’utilisation d’un appareil respiratoire à air comprimé (ARAC) ou d’un système de plongée non autonome léger. Gérer les plans et les calendriers de plongée. Recommander de la formation pour les plongeurs et y assister. Gérer et diriger toutes les urgences lors des plongées. Consigner des éléments probants dans les rapports d’incident ou d’accident. Mener des examens des incidents et mettre en œuvre des mesures correctives. Défendre les protocoles et les pratiques de sécurité liés à la plongée."
            },
            new CompetencyLevelRequirement
            {
                Id = 232,
                DescEng = "Paints and stores small vessels and lifesaving equipment. Participates in cargo stowage, cleaning/sanding, and paint evolutions.",
                DescFre = "Peinturer et entreposer les petites embarcations et l’équipement de sauvetage. Participer aux activités d’arrimage, de nettoyage, de ponçage et de peinture liées aux navires de charge."
            },
            new CompetencyLevelRequirement
            {
                Id = 233,
                DescEng = "Participates as a hand in refit operations. Employs safe standards in small vessel maintenance and operations in most sea states, including pre and post sailing checks, drills, and evolutions. Participates as lookout and quartermaster, when required.",
                DescFre = "Participer comme ouvrier aux opérations de radoub. Utiliser des normes sécuritaires pour le fonctionnement et l’entretien des petites embarcations dans la plupart des états de la mer, y compris les vérifications, les exercices et les activités avant et après la navigation. Participer à titre de personne qui tient la garde ou de timonier, au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 234,
                DescEng = "Operates as lead hand in various operations, including small vessel use and maintenance in all conditions, lookout duties, and tackle stowage and maintenance. Conducts safety checks on equipment. Participates, when and where required, as a hand in helicopter operations, regarding clearing equipment while following protocols including participating in fire and emergency teams. Steers the ship in all conditions, when and where required.",
                DescFre = "Agir à titre de chef d’équipe pour diverses opérations, y compris l’utilisation et l’entretien des petites embarcations de tous les états, les tâches de vigie ainsi que l’arrimage et l’entretien de l’outillage de chargement. Procéder aux vérifications de sécurité de l’équipement. Participer, s’il y a lieu, à titre d’ouvrier aux opérations des hélicoptères en ce qui concerne le dégagement de l’équipement, dans le respect des protocoles, y compris faire partie des équipes d’incendie et d’urgence. Gouverner le navire dans tous les états de la mer, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 235,
                DescEng = "Handles cargo, operates lifting appliances, conducts tackle/lifting machinery maintenance, and checks and operates lifesaving equipment. Participates as lead hand in helicopter operations and on fire and emergency team parties, when and where applicable. Recognizes irregularities in the use and/or appearance of equipment and recommends action. Participates in all small vessel operations and maintenance in all conditions, when and where required.",
                DescFre = "Manutentionner les cargaisons, faire fonctionner les appareils de levage, réaliser l’entretien de l’outillage de chargement ou des machines de levage, ainsi que vérifier et faire fonctionner l’équipement de sauvetage. Participer à titre de chef d’équipe aux opérations des hélicoptères et aux équipes d’incendie et d’urgence, s’il y a lieu. Reconnaître les anomalies dans l’utilisation et l’aspect extérieur de l’équipement et recommander des mesures. Participer à toutes les activités de fonctionnement et d’entretien des petites embarcations de tous les états, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 236,
                DescEng = "Directs cargo handling, tackle/lifting machinery maintenance and operation, lifesaving operation, and hull inspections while enforcing regulations. Handles small boats under all sea states and advises on optimized operating practices. Supervises deck and cargo crews in all seagoing operations, at sea in all conditions, or in refit, when and where required.",
                DescFre = "Diriger la manutention des cargaisons, le fonctionnement et l'entretien de l’outillage de chargement ou des machines de levage, les opérations de sauvetage et les inspections des coques dans le respect des règlements. Manipuler les petites embarcations dans tous les états de la mer et donner des conseils sur l’optimisation des pratiques d’exploitation. Superviser les équipages de pont et ceux de navires de charge lors de toutes les opérations maritimes dans tous les états de la mer ou lors du radoub, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 237,
                DescEng = "Uses the of basics of the life cycle asset management program in daily activities. Performs routine asset management tasks. Manages the life cycle of tackle books, safety equipment, charts, etc. when and where applicable.",
                DescFre = "Utilise les bases du programme de gestion du cycle de vie des actifs dans les activités quotidiennes. Effectue des tâches de routine de gestion des actifs. Gère le cycle de vie des carnets de pêche, des équipements de sécurité, des cartes, etc. le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 238,
                DescEng = "Advises and follows the Government of Canada's Controlled Goods Directive, directives on fleet management, the Policy on Management of Materiel, and the Directive on Disposal of Surplus Materiel, when and where applicable.",
                DescFre = "Conseille et suit la Directive sur les marchandises contrôlées du gouvernement du Canada, les directives sur la gestion de la flotte, la Politique sur la gestion du matériel et la Directive sur l'aliénation du matériel en surplus, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 239,
                DescEng = "Performs all four phases of life cycle materiel management, including assessing and planning materiel requirements, acquiring materiel resources, operating and using, maintaining, and disposing of materiel. Implements the concepts of the Policy Framework for the Management of Assets and Acquired Services.",
                DescFre = "Effectue les quatre phases de la gestion du cycle de vie du matériel, y compris l'évaluation et la planification des besoins en matériel, l'acquisition des ressources matérielles, l'exploitation et l'utilisation, l'entretien et l'élimination du matériel. Met en œuvre les concepts du Cadre de politique sur la gestion des actifs et services acquis. S’il y a lieu, en tant que responsable de l’entretien, gère les biens matériels à l’aide du Système de gestion des actifs (SGA) afin de s’assurer que les tâches sont effectuées correctement, de façon sécuritaire et aux intervalles requis. Gère également tout le matériel et la main-d’œuvre associés à l’entretien des biens et consigne les mesures correctives."
            },
            new CompetencyLevelRequirement
            {
                Id = 240,
                DescEng = "Manages a risk-based and complexity-based approach to processes, systems, capacity, resourcing, oversight, and reporting to promote the attainment of program outcomes. Advises and guides decisions on life cycle asset management within their area of concern.",
                DescFre = "Gère une approche fondée sur le risque et la complexité des processus, des systèmes, des capacités, des ressources, de la surveillance et des rapports afin de promouvoir l'obtention des résultats du programme. Conseille et oriente les décisions sur la gestion du cycle de vie des actifs dans leur domaine de responsabilité. S’il y a lieu, en tant que responsable ou superviseur de l’entretien, gère les biens matériels à l’aide du Système de gestion des actifs (SGA) afin de s’assurer que les tâches sont effectuées correctement, de façon sécuritaire et aux intervalles requis. Gère également tout le matériel et la main-d’œuvre associés à l’entretien des biens et consigne les mesures correctives."
            },
            new CompetencyLevelRequirement
            {
                Id = 241,
                DescEng = "Implements an effective management framework, including departmental procedures, processes, and systems. Manages based on the principles of value for money acquisition of assets, effective management and usage of these assets, and effective disposal of such assets. Advises and guides decisions on life cycle asset management within the Coast Guard from a regional and/or national perspective.",
                DescFre = "Met en œuvre un cadre de gestion efficace, y compris des procédures, des processus et des systèmes ministériels. Gère sur la base des principes de l'optimisation des ressources pour l'acquisition de biens, de la gestion et de l'utilisation efficaces de ces biens et de leur cession efficace. Conseille et oriente les décisions sur la gestion du cycle de vie des biens au sein de la Garde côtière dans une perspective régionale et/ou nationale.",
            },
            new CompetencyLevelRequirement
            {
                Id = 242,
                DescEng = "Observes an issue or problem, gathers information, and reports on its expected versus actual functionality.",
                DescFre = "Observe une question ou un problème, recueille des informations et rend compte de sa fonctionnalité prévue par rapport à sa fonctionnalité réelle."
            },
            new CompetencyLevelRequirement
            {
                Id = 243,
                DescEng = "Gathers information on an observed issue or problem. Considers the difference between expected and actual functionality, looks at special circumstances to diagnose it, and attempts various fixes and tests for confirmation before reporting.",
                DescFre = "Recueille des informations sur un problème ou une question observés. Examine la différence entre la fonctionnalité attendue et la fonctionnalité réelle, examine les circonstances particulières pour la diagnostiquer, et tente diverses corrections et tests pour confirmation avant de faire un rapport."
            },
            new CompetencyLevelRequirement
            {
                Id = 244,
                DescEng = "Interprets data and accurately determines essential elements of an issue or problem. Applies various problem isolation techniques to determine causes. Tests equipment under multiple settings to confirm it is restored to working state.",
                DescFre = "Interprète les données et détermine avec précision les éléments essentiels d'une question ou d'un problème. Applique diverses techniques d'isolement des problèmes pour en déterminer les causes. Teste l'équipement sous plusieurs paramètres pour confirmer qu'il est remis en état de marche."
            },
            new CompetencyLevelRequirement
            {
                Id = 245,
                DescEng = "Interprets data from many sources to determine essential elements of a problem. Recognizes a problem at the earliest stages, pinpoints problem sources, and uses corrective actions to restore a system to working state. Uses data interpretation to recommend preventative measures that will prevent further failure.",
                DescFre = "Interprète des données provenant de nombreuses sources pour déterminer les éléments essentiels d'un problème. Reconnaît un problème dès les premières étapes, identifie les sources du problème et utilise des actions correctives pour rétablir un système en état de fonctionnement. Utilise l'interprétation des données pour recommander des mesures préventives qui empêcheront toute nouvelle défaillance."
            },
            new CompetencyLevelRequirement
            {
                Id = 246,
                DescEng = "Uses data interpretation and accuracy in determining essential elements of an issue or problem. Consults, and provides training on, trends to prevent future issues and presents these and related items to units and stakeholders.",
                DescFre = "Utilise l'interprétation et la précision des données pour déterminer les éléments essentiels d'une question ou d'un problème. Consulte et fournit une formation sur les tendances afin de prévenir les problèmes futurs et présente ces éléments et d'autres éléments connexes aux unités et aux parties prenantes."
            },
            new CompetencyLevelRequirement
            {
                Id = 247,
                DescEng = "Able to recognize a problem. Able to solve basic problems by following a set of standard rules and practices. Understands how to find alternative solutions based on precedents.",
                DescFre = "Capable de reconnaître un problème. Capable de résoudre des problèmes de base en suivant un ensemble de règles et de pratiques normalisées. Comprend comment trouver d’autres solutions, en se fondant sur les précédents."
            },
            new CompetencyLevelRequirement
            {
                Id = 248,
                DescEng = "Recognizes and identifies a problem based on a clear set of factors. Able to identify, with some assistance, optimal solutions based on weighing the advantages and disadvantages of alternative approaches.",
                DescFre = "Reconnaît et identifie un problème sur la base d’une série de facteurs clairs. Capable d’identifier, avec une certaine assistance, les solutions optimales basées sur la pondération des avantages et des inconvénients des  approches alternatives."
            },
            new CompetencyLevelRequirement
            {
                Id = 249,
                DescEng = "Experienced in identifying, defining, solving and prioritizing standard problems without causing other unanticipated problems. Identifies root causes, sets goals and identifies constraints. Conducts impact analysis and identifies possible consequences of actions/decisions.",
                DescFre = "Expérimenté dans l’identification, la définition, la résolution et le classement par ordre de priorité des problèmes standard sans causer d’autres problèmes imprévus. Identifie les causes profondes, fixe des objectifs et identifie les contraintes. Effectue une analyse d’impact et identifie les conséquences possibles des actions ou des décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 250,
                DescEng = "Experienced in finding workable solutions to increasingly complex and multi-dimensional problems by either intuition or systematic approach. Generates and assesses alternative solutions and develops standards to evaluate different intended results offered by alternatives. Provides training and advises on best practices. Conducts monitoring and testing of solutions after implementation.",
                DescFre = "Expérimenté dans la recherche de solutions réalisables à des problèmes de plus en plus complexes et multidimensionnels soit par intuition ou par approche systématique. Génère et évalue des solutions de rechange et élabore des normes pour évaluer les différents résultats visés par les solutions de rechange.  Offre une formation et des conseils sur les pratiques exemplaires. Effectue la surveillance et met à l’essai les solutions après leur mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 251,
                DescEng = "Revises and amends problem solving models, flowcharts, and cause and effect diagrams. Advises on multiple alternatives and expected results based on extensive experience. Evaluates effectiveness and efficiency of solution after implementation.",
                DescFre = "Révise et modifie les modèles de résolution de problèmes, les organigrammes et les diagrammes de cause à effet.  Donne des conseils sur de multiples solutions de rechange et sur les résultats escomptés sur la base d'une vaste expérience. Évalue l’efficacité et l’efficience de la solution après sa mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 252,
                DescEng = "Basic knowledge of uses of cooking and cleaning utensils, storage protocols, cutlery, cleaning gear, and machinery used in the galley, refrigeration and laundry spaces, and cleaning lockers.",
                DescFre = "Connaissances de base sur l'utilisation des ustensiles de cuisine et de nettoyage, les protocoles d'entreposage, la coutellerie, le matériel de nettoyage et les machines utilisées dans la cuisine, les espaces de réfrigération et de lavage, et les casiers de nettoyage."
            },
            new CompetencyLevelRequirement
            {
                Id = 253,
                DescEng = "Knowledge of methods, tools and combinations of ingredients to improve the flavour or digestibility of food. Knowledge of the selection, measurement and combining of ingredients in an ordered procedure in an effort to achieve the desired result. Knowledge of raw and cooked food, expirations, cooking methods and types of cuisine.",
                DescFre = "Connaissance des méthodes, des outils et des combinaisons d'ingrédients pour améliorer la saveur ou la digestibilité des aliments. Connaissance de la sélection, de la mesure et de la combinaison d'ingrédients dans une procédure ordonnée afin d'atteindre le résultat souhaité. Connaissance des aliments crus et cuits, des expirations, des méthodes de cuisson et des types de cuisine."
            },
            new CompetencyLevelRequirement
            {
                Id = 254,
                DescEng = "Significant knowledge of dietary needs, allergies, and intolerances, cooking and storing modes and preferences. Knowledge of key recipes, preservation, food guide recommendations and requirements. Basic knowledge of menu preparation and logistics.",
                DescFre = "Connaissance approfondie des besoins alimentaires, des allergies et des intolérances, des modes de cuisson et de conservation et des préférences. Connaissance des recettes clés, de la conservation, des recommandations et des exigences du guide alimentaire. Connaissances de base de la préparation des menus et de la logistique."
            },
            new CompetencyLevelRequirement
            {
                Id = 255,
                DescEng = "Advanced knowledge of cookery from experience and inputs, by considering and planning a variety of types of cuisine in an effective and efficient manner.",
                DescFre = "Connaissance avancée de la cuisine grâce à l'expérience et aux intrants, en considérant et en planifiant une variété de types de cuisine d'une manière efficace et efficiente."
            },
            new CompetencyLevelRequirement
            {
                Id = 256,
                DescEng = "Expert knowledge as a chef in industrial settings, with an emphasis on meal, snack, and menu planning based on guidelines and inputs. Knowledge of preparation methods and sanitation requirements.",
                DescFre = "Connaissances spécialisées en tant que chef cuisinier en milieu industriel, avec une emphase sur la planification des repas, des collations et des menus en fonction des directives et des intrants. Connaissance des méthodes de préparation et des exigences sanitaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 257,
                DescEng = "Basic knowledge in requesting supplies, logging receipts at issue, and assisting with storage.",
                DescFre = "Connaissance de base de la demande de matériel, de l’enregistrement des données des récépissés lors de la fourniture et de la contribution à l’entreposage."
            },
            new CompetencyLevelRequirement
            {
                Id = 258,
                DescEng = "Limited knowledge of proper stowage protocols. Understands safe handling, labeling, and preserving government assets.",
                DescFre = "Connaissance limitée des protocoles appropriés d’arrimage. Compréhension de la manutention sécuritaire, de l’étiquetage et de la protection des biens gouvernementaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 259,
                DescEng = "Practical knowledge of recording material management (MM) actions in the approved inventory management system (IMS). Understands how to perform, control, and maintain inventories as directed. Awareness of asset disposal protocols.",
                DescFre = "Connaissance pratique de l’enregistrement des services de gestion du matériel dans le système de gestion des stocks (SGS) approuvé. Compréhension de la façon de procéder aux dénombrements des stocks, de gérer ceux-ci et de les tenir à jour selon les directives. Connaissance des protocoles d’élimination des biens."
            },
            new CompetencyLevelRequirement
            {
                Id = 260,
                DescEng = "Advanced knowledge in the management of all inventory management system (IMS) processes, including receipt, tracking, storage, and disposal mechanisms.",
                DescFre = "Connaissance approfondie de la gestion de tous les processus relatifs au SGS, y compris les mécanismes de réception, de suivi, d’entreposage et d’élimination."
            },
            new CompetencyLevelRequirement
            {
                Id = 261,
                DescEng = "Expert knowledge in inventory management system (IMS) and in the training of others. Understands the IMS process including large acquisitions or disposal projects, regionally or nationally.",
                DescFre = "Connaissance spécialisée relative au SGS et à la formation des autres. Compréhension du processus relatif au SGS, notamment les grands projets d’acquisition ou d’élimination, aux échelles régionale et nationale."
            },
            new CompetencyLevelRequirement
            {
                Id = 262,
                DescEng = "Reviews supplies, inventories food and supplies, including the rate of usage. Manages galley cleaning of equipment, utensils, and gear. Preps and lays out snacks, prepares and arranges salads, and makes and serves food and beverages hot and cold. Makes beds and rotates laundry. Ensures safe and clean workstations and food preparation areas before and after each use.",
                DescFre = "Examiner les provisions et inventorier les aliments et les vivres, y compris le taux d’utilisation. Gérer le nettoyage de l’équipement, des ustensiles et du matériel de cuisine. Préparer et disposer les collations et les salades ainsi que préparer et servir les aliments et les boissons chaudes et froides. Faire les lits et s’occuper de la laverie à tour de rôle. S’assurer que les espaces de travail et les aires de préparation des aliments sont sécuritaires et propres avant et après chaque utilisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 263,
                DescEng = "Does cooking preparations for major dishes by following menus and recipes. Prepares soup stocks and dessert materials. Assembles supplies for and mixes salads.",
                DescFre = "Préparer les ingrédients pour les repas principaux en suivant les menus et les recettes. Préparer les bouillons des soupes et les ingrédients pour les desserts. Réunir les ingrédients des salades et les mélanger."
            },
            new CompetencyLevelRequirement
            {
                Id = 264,
                DescEng = "Does general duty cooking, following menus and recipes by preparing roasting, grilling and frying meat as required, by cooking vegetables, by baking pies, cakes, cookies and desserts, by preparing and packing lunches for field use, and by slicing meat and cutting cakes and pies.",
                DescFre = "Effectuer des tâches générales de cuisine selon les menus et les recettes, y compris la préparation de la viande à rôtir, à griller et à frire, au besoin, la cuisson des légumes, des tartes, des gâteaux, des biscuits et des desserts, la préparation et l’emballage des dîners pour le personnel sur le terrain ainsi que la coupe de la viande, des gâteaux et des tartes."
            },
            new CompetencyLevelRequirement
            {
                Id = 265,
                DescEng = "Manages the full range of cooking and cleaning requirements for all ships' crews and clients. Provides feedback and input to ordering supplies for approval, as well as recommendations for new uses for equipment and cooking ideas.",
                DescFre = "Gérer l’ensemble des exigences en matière de cuisine et de nettoyage pour les membres des équipages et les clients de tous les navires. Formuler une rétroaction et des commentaires sur la commande de provisions aux fins d’approbation ainsi que des recommandations à l’égard de nouvelles utilisations de l’équipement et idées de recettes."
            },
            new CompetencyLevelRequirement
            {
                Id = 266,
                DescEng = "Manages and oversees the planning, preparation, cooking, and presentation of all meals and snacks in the unit. Conducts all planning in concert with mates, logistics officers, or managers. Provides training and guidance to galley and steward staff.",
                DescFre = "Gérer et superviser la planification, la préparation, la cuisson et la présentation de tous les repas et collations de l’unité. S’occuper de l’ensemble de la planification avec les seconds, les officiers de logistique ou les gestionnaires. Former et orienter le personnel de cuisine et les stewards."
            },
            new CompetencyLevelRequirement
            {
                Id = 267,
                DescEng = "Basic knowledge of the different stakeholders and authorities in the Search and Rescue (SAR) system. Understands where to seek full awareness of the system.",
                DescFre = "Connaissance de base des différents intervenants et différentes autorités dans le système de R-S. Compréhension de ce qu’il faut pleinement comprendre du système."
            },
            new CompetencyLevelRequirement
            {
                Id = 268,
                DescEng = "Limited knowledge of each part of the Search and Rescue (SAR) system, how each works and works together, and how a local incident plays out in exercises and real life scenarios.",
                DescFre = "Connaissance limitée de chaque élément du système de R-S, de la manière dont chacun d’eux fonctionne et dont ils fonctionnent ensemble et du déroulement d’un incident local dans le cadre d’exercices et de situations concrètes."
            },
            new CompetencyLevelRequirement
            {
                Id = 269,
                DescEng = "Practical knowledge of the development of incidents and tactical responses between and among all participants in a number of real incidents of varying size and complexity, and exercises.",
                DescFre = "Connaissance pratique de l’élaboration d’interventions en cas d’incident et d’ordre tactique par l’ensemble des participants dans le cadre d’un certain nombre d’incidents réels d’envergure et de complexité variées et d’exercices."
            },
            new CompetencyLevelRequirement
            {
                Id = 270,
                DescEng = "Advanced knowledge of all elements of the Search and Rescue (SAR) system, the tactical responses by all the participants, strategic elements in long term searches and search planning, and instructing others in SAR systems roles and responsibilities.",
                DescFre = "Connaissance approfondie de tous les éléments du système de R-S, des réponses tactiques de tous les participants, des éléments stratégiques des recherches à long terme et de la planification des recherches, et formation des autres sur les rôles et les responsabilités des systèmes de R-S."
            },
            new CompetencyLevelRequirement
            {
                Id = 271,
                DescEng = "Expert knowledge of all elements of the Search and Rescue (SAR) system, strategic planning regionally and nationally, exploring and redefining roles with horizon technologies. Understands how to mentor others, and provide information and insights to stakeholders internally and externally in SAR networks.",
                DescFre = "Connaissance spécialisée de tous les éléments du système de R-S, de la planification stratégique aux échelles régionale et nationale ainsi que de l’étude et de la nouvelle définition des rôles grâce à des technologies émergentes. Compréhension de la manière d’offrir du mentorat et de fournir de l’information et des indications aux intervenants à l’intérieur et à l’extérieur des réseaux de R-S."
            },
            new CompetencyLevelRequirement
            {
                Id = 272,
                DescEng = "Participates in search and rescue (SAR) activities,  tactical searches, and in exercises and simulations. Provides on scene first-aid services and reports, when and where applicable.",
                DescFre = "Participer aux activités de R-S, aux recherches tactiques et aux exercices et simulations. Offrir des services de premiers soins sur place et produire les rapports connexes, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 273,
                DescEng = "Provides first-aid and rescue specialist training. Recruits, trains, and supervises Inshore Rescue Boat (IRB) crews. Provides training on the search and rescue program. Develops and delivers Search and Rescue (SAR) presentations for stakeholders. Researches best practices in the search and rescue domain.",
                DescFre = "Offrir de la formation spécialisée en matière de premiers soins et de sauvetage. Recruter, former et superviser des membres d’équipage d’embarcations de sauvetage côtier (ESC). Offrir de la formation sur le programme de R-S. Élaborer et réaliser des présentations en matière de R-S à l’intention des intervenants. Chercher des pratiques exemplaires dans le domaine de la recherche et du sauvetage."
            },
            new CompetencyLevelRequirement
            {
                Id = 274,
                DescEng = "Initiates, coordinates, and terminates local area marine incidents under supervision. Coordinates stricken vessel responses using the local search and rescue net, including the coastal area’s incident categories and classifications. Identifies search types, patterns, and techniques best suited to the search mission.",
                DescFre = "Initier et coordonner, sous supervision, des incidents maritimes locaux et y mettre fin. Coordonner des interventions auprès de navires en détresse au moyen du filet de sécurité local de R-S, y compris les catégories et les classifications d’incidents de la zone côtière locale. Cibler les types de recherche, les tendances et les techniques qui conviennent le mieux à la mission de recherche."
            },
            new CompetencyLevelRequirement
            {
                Id = 275,
                DescEng = "Applies entire range of search and rescue (SAR) regional responses, analyzing current and past incidents, conducting simulations, providing training, and managing a large variety of incidents to conclusions tactically and strategically. Identifies and communicates hazards to team members. Assesses risks and provides insights to program managers and stakeholders.",
                DescFre = "Appliquer l’éventail complet des interventions régionales de R-S, analyser les incidents actuels et passés, réaliser des simulations, offrir de la formation et gérer un large éventail d’incidents afin d’y mettre fin de manière tactique et stratégique. Relever et communiquer les dangers potentiels pour les membres de l’équipe. Évaluer les risques et formuler des conseils à l’intention des gestionnaires de programme et des intervenants."
            },
            new CompetencyLevelRequirement
            {
                Id = 276,
                DescEng = "Reviews regional and national search and rescue incidents and reviews program coordination strategies for effectiveness and efficiencies. Analyzes program metadata, conducts studies, develops service standards and needs analyses and risk mitigation measures, and provides information and feedback to stakeholders. Drafts national directives and policies.",
                DescFre = "Examiner les incidents de R-S régionaux et nationaux ainsi que les stratégies de coordination de programme sur les plans de l’efficacité et l’efficience. Analyser des métadonnées de programme, mener des études, élaborer des analyses des normes de service, des besoins et des mesures d’atténuation des risques ainsi que fournir de l’information et de la rétroaction aux intervenants. Rédiger des directives et des politiques nationales."
            },
            new CompetencyLevelRequirement
            {
                Id = 277,
                DescEng = "Maintains continuous lookout and reports hazards to the officer of the watch (OOW) that can be an obstacle to navigation such as other ships, debris, and/or floating objects. In case of a person overboard, continuously points out in the direction of the person's location.",
                DescFre = "Effectuer une vigie continue et faire rapport à l’officier de quart (OQ) des dangers qui pourraient constituer un obstacle à la navigation comme d’autres navires, des débris ou des objets flottants. Pointer continuellement dans la direction de la personne à la mer, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 278,
                DescEng = "Steers a vessel in open waters. Maintains a steady course, properly executes all rudder and speed orders, and communicates to the officer of the watch (OOW) using navigational terms relating to a vessel's heading. Completes any course change or critical maneuver that is in progress before handing over the helm or turning over the watch. Recognizes irregularities in the ship's maneuvering responses.",
                DescFre = "Gouverner un navire en mer libre. Maintenir le cap, exécuter correctement tous les ordres liés au gouvernail et à la vitesse et communiquer avec l’OQ en termes nautiques qui s’appliquent au cap d’un navire. Exécuter tout changement de cap ou manœuvre critique en cours avant de céder la barre ou de confier le quart à une autre personne. Reconnaître les anomalies de la réaction du navire aux manœuvres."
            },
            new CompetencyLevelRequirement
            {
                Id = 279,
                DescEng = "Steers a vessel in open and closed waters under various sea states. Reaches set course based on a vessel's maneuvering characteristics. Anticipates the delay between when the helm is applied and when the ship responds to the rudder. Recognizes navigation rules and aids.",
                DescFre = "Conduire un navire en mer libre et dans des eaux fermées, et ce, dans divers états de la mer. Atteindre le cap ordonné en fonction des caractéristiques de manœuvre d’un navire. Prévoir le retard entre le moment où la barre est tournée et celui où le navire réagit à ce mouvement du gouvernail. Reconnaître les règles de navigation et les aides à la navigation."
            },
            new CompetencyLevelRequirement
            {
                Id = 280,
                DescEng = "Steers a vessel in any sea conditions including during emergencies. Aasync Tasks overcompensating for a ship's movement caused by local conditions, such as wind, swells, currents, or rough seas and recommends different course of action.",
                DescFre = "Gouverner un navire dans tous les états de la mer, y compris lors de cas d’urgence. Désynchroniser des tâches qui surcompensent les mouvements d’un navire causés par les conditions locales comme le vent, la houle, le courant ou la mer agitée et recommander une autre façon de faire."
            },
            new CompetencyLevelRequirement
            {
                Id = 281,
                DescEng = "Steers various classes of vessels precisely under all sea state conditions. Trains others in performing those duties using best practices.",
                DescFre = "Gouverner diverses classes de navires de façon précise dans tous les états de la mer. Former les autres à effectuer ces tâches en utilisant les pratiques exemplaires."
            },
            new CompetencyLevelRequirement {Id = 282, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 283,
                DescEng = "Limited knowledge of common mechanical tools and instruments use, and function of marine engine major systems like ignition, exhaust, cooling and lubricating.",
                DescFre = "Connaissance limitée de l’utilisation des outils et des instruments mécaniques communs ainsi que de la fonction des principaux systèmes des moteurs marins, notamment les systèmes d’allumage, d’échappement, de refroidissement et de graissage."
            },
            new CompetencyLevelRequirement
            {
                Id = 284,
                DescEng = "Practical knowledge of minor repair and first line maintenance of marine engines, electrical systems, transmissions, and fuel systems.",
                DescFre = "Connaissance pratique de la réparation mineure et de l’entretien de première ligne des moteurs marins, des systèmes électriques, des transmissions et des circuits d’alimentation."
            },
            new CompetencyLevelRequirement
            {
                Id = 285,
                DescEng = "Advanced practical knowledge of maintenance and repair of shipboard machinery and equipment including pumps, valves, air compressors, heat exchangers, and deck machinery. Understands diagrams, drafts, flow-charts, and other information contained in technical data packages (TDP).",
                DescFre = "Connaissance pratique approfondie de l’entretien et de la réparation des machines et du matériel embarqués, notamment les pompes, les valves, les compresseurs d’air, les échangeurs de chaleur et les machines de pont. Compréhension des schémas, des dessins, des ordinogrammes et des autres renseignements compris dans les jeux de documents techniques (TDP)."
            },
            new CompetencyLevelRequirement
            {
                Id = 286,
                DescEng = "Expert understanding of internal combustion engines operation, maintenance requirements, inspection, and overhaul of all propulsion and auxiliary equipment and systems.",
                DescFre = "Compréhension spécialisée du fonctionnement des moteurs à combustion interne, des exigences relatives à l’entretien, de l’inspection et de la remise en état de l’ensemble du matériel et des systèmes auxiliaires et de propulsion."
            },
            new CompetencyLevelRequirement
            {
                Id = 287,
                DescEng = "Monitors equipment, check gauges and dials, records readings on equipment. Cleans leaks on machinery and in engine room spaces. Reports observations as needed.",
                DescFre = "Surveiller l’équipement, vérifier les jauges et les cadrans et consigner les mesures sur l’équipement. Nettoyer les fuites sur les machines et dans la salle des machines. Signaler les observations au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 288,
                DescEng = "Starts up and shuts down engine room and propulsion auxiliaries and ancillaries equipment. Maintains temperatures, pressures, and proper oil and water levels in engine room equipment and ensure the equipment is working in normal parameters. Reviews indicating instruments reading. Assists in minor repairs.",
                DescFre = "Mettre en service et arrêter l’équipement de la salle des machines, les auxiliaires de propulsion ainsi que l’équipement auxiliaire. Conserver des niveaux appropriés de température, de pression, d’huile et d’eau pour l’équipement de la salle des machines et s’assurer que l’équipement fonctionne selon des paramètres normaux. Examiner les valeurs des appareils indicateurs. Apporter son aide lors de réparations mineures."
            },
            new CompetencyLevelRequirement
            {
                Id = 289,
                DescEng = "Participates in fueling, lube oil transfer, and waste oil products handling, and the production, transfer, testing and treatment of potable water. Performs minor repairs and assists in assembling, maintaining and repairing mechanical components according to required specifications.",
                DescFre = "Participer au ravitaillement, au transfert d’huiles de graissage, à la manipulation de produits d’huiles usées ainsi qu’à la production, au transfert, à l’analyse et au traitement de l’eau potable. Exécuter des réparations mineures et apporter son aide pour l’assemblage, l’entretien et la réparation de composants mécaniques conformément aux spécifications exigées."
            },
            new CompetencyLevelRequirement
            {
                Id = 290,
                DescEng = "Reviews engine room logs and collects, and/or analyzes information/data which contributes to making engineering decision. Updates machinery maintenance records. Assists in planning the maintenance of the ships main and auxiliary equipment and systems. Troubleshoots equipment and effects minor and major repairs.",
                DescFre = "Examiner les journaux de la salle des machines et recueillir ou analyser les renseignements ou les données qui contribuent à la prise de décisions techniques. Mettre à jour les dossiers d’entretien des machines. Apporter son aide pour la planification de l’entretien de l’équipement et des systèmes principaux et auxiliaires des navires. Rechercher la cause des pannes de l’équipement et effectuer des réparations mineures et majeures."
            },
            new CompetencyLevelRequirement
            {
                Id = 291,
                DescEng = "Expert in diagnostic capabilities, advises senior engineer on status of engine room machinery. Collaborates with others in finding solutions to more complex engineering matters. Reviews stock replenishment requisitions with user departments to ensure the items are in current use, that quantities ordered are realistic and pertinent.",
                DescFre = "Apporter son savoir-faire en matière de capacités de détection et informer l’ingénieur principal de l’état des machines de la salle des machines. Collaborer avec les autres pour trouver des solutions à des questions techniques plus complexes. Examiner les demandes de réapprovisionnement du stock avec les ministères utilisateurs afin de veiller à ce que les articles soient en cours d’utilisation et que les quantités commandées soient réalistes et pertinentes."
            },
            new CompetencyLevelRequirement
            {
                Id = 292,
                DescEng = "Basic understanding of deck layout and stowage. Understands emergency stations. Asks questions of deck crew and officers concerning knots and work parties.",
                DescFre = "Compréhension de base du plan de pont et de l'arrimage. Comprend les stations d'urgence. Poser des questions à l'équipage de pont et aux officiers au sujet des nœuds et des groupes de travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 293,
                DescEng = "Working understanding of some rigging and tackle procedures and manuals, including logging. Understands small boat principles, use, towing, and mooring.",
                DescFre = "Compréhension pratique de certains manuels et procédures de gréement et d'accastillage, y compris l'exploitation forestière. Comprend les principes, l'utilisation, le remorquage et l'amarrage des petites embarcations."
            },
            new CompetencyLevelRequirement
            {
                Id = 294,
                DescEng = "Practical knowledge of small boat operations of most types, rigging and lifting gear and uses, tackle and tackle registry and stowage, and basic helicopter procedures. Understands hand signals in working with deck crew.",
                DescFre = "Connaissance pratique de la plupart des types d'opérations de petits bateaux, du gréement et des engins de levage et de levage, de l'immatriculation et de l'arrimage du matériel, ainsi que des procédures de base pour les hélicoptères. Comprend les signaux de la main lorsqu'il travaille avec l'équipage de pont."
            },
            new CompetencyLevelRequirement
            {
                Id = 295,
                DescEng = "Advanced practical knowledge of tackle and maintenance, lifting appliances of all types and procedures, practical refit management, damage control management, and helicopter operations.",
                DescFre = "Connaissances pratiques avancées en matière d'outillage et d'entretien, d'appareils de levage de tous types et procédures, de gestion pratique du carénage, de gestion des dommages et d'exploitation des hélicoptères."
            },
            new CompetencyLevelRequirement
            {
                Id = 296,
                DescEng = "Expert practical knowledge of all elements, practical and theoretical, concerning deck and deck crew management, including safe rigging, lifting, tackle, small craft, cargo loading, and helicopter operations, plans, and procedures.",
                DescFre = "Connaissance pratique experte de tous les éléments, pratiques et théoriques, concernant la gestion du pont et de l'équipage de pont, y compris le gréement, le levage, l'accastillage, les petits bateaux, le chargement de la cargaison et les opérations, plans et procédures par hélicoptère."
            },
            new CompetencyLevelRequirement
            {
                Id = 297,
                DescEng = "Basic knowledge of fishing locations, the marine physical environments, and fish habitats.",
                DescFre = "Connaissance de base des lieux de pêche, des milieux physiques marins et des habitats du poisson."
            },
            new CompetencyLevelRequirement
            {
                Id = 298,
                DescEng = "Limited knowledge of standing watches on the Canadian Coast Guard bridge overseeing some fishing operations. Knowledge of fishing techniques, grounds, nets, etc.",
                DescFre = "Connaissance limitée des quarts de quart sur le pont de la Garde côtière canadienne qui surveille certaines opérations de pêche. Connaissance des techniques de pêche, des fonds, des filets, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 299,
                DescEng = "Practical knowledge of fishing master bridge and deck oversight duties on a small to medium sized Coast Guard science fishing vessels, including biomass location, consultation with scientists, and rig choice, design, and deployment.",
                DescFre = "Connaissance pratique des fonctions de surveillance du capitaine de pêche à la passerelle et du pont à bord d'un navire de pêche scientifique de petite et moyenne taille de la Garde côtière, y compris l'emplacement de la biomasse, la consultation des scientifiques et le choix, la conception et le déploiement des appareils."
            },
            new CompetencyLevelRequirement
            {
                Id = 300,
                DescEng = "Advanced knowledge in managing the range of fishing master bridge and deck watch duties in all Coast Guard science fishing vessels, including locating fishing spots for each species; determining, adjusting, and positioning fishing gear for optimal catch; and classifying and identifying species.",
                DescFre = "Connaissances avancées dans la gestion de l'éventail des fonctions de quart à la passerelle et au pont de tous les navires de pêche scientifiques de la Garde côtière, y compris la localisation des lieux de pêche pour chaque espèce, la détermination, l'ajustement et le positionnement des engins de pêche pour des prises optimales et la classification et l'identification des espèces."
            },
            new CompetencyLevelRequirement
            {
                Id = 301,
                DescEng = "Expert knowledge of bridge management of all fishing deck crews on Coast Guard science fishing vessels, including stock assessment and location, determination of gear and gear adjustment, building trust and relationships with science stakeholders, and providing training to fishing masters and fishing crews.",
                DescFre = "Connaissances spécialisées de la gestion des ponts de tous les membres d'équipage des bateaux de pêche scientifiques de la Garde côtière, y compris l'évaluation et l'emplacement des stocks, la détermination de l'ajustement des engins et des engins, l'établissement d'une relation de confiance avec les intervenants scientifiques et l'établissement de relations avec eux et la formation des maîtres pêcheurs et des équipes de pêche."
            },
            new CompetencyLevelRequirement
            {
                Id = 302,
                DescEng = "A rudimentary understanding of engineering principles as they relate to marine engineering both theoretical and practical in naval architecture, engineering drawing, marine engineering, electro technology, applied mechanics, strength of materiels, thermodynamics, fluid mechanics, and theory of machines subjects.",
                DescFre = "Compréhension rudimentaire des principes d'ingénierie dans la mesure où ils ont trait à l'ingénierie maritime théorique et pratique en architecture navale, dessin technique, génie maritime, électrotechnique, mécanique appliquée, résistance des matériaux, thermodynamique, mécanique des fluides, et théorie des machines."
            },
            new CompetencyLevelRequirement
            {
                Id = 303,
                DescEng = "Basic understanding and application of engineering principles as they relate to marine engineering both theoretical and practical. Demonstrates the ability to read and interpret engineering data while conducting watchkeeping duties. Assists in the conduct of preventive and corrective maintenance of various systems. Seeks opportunities to improve occupational and technological knowledge.",
                DescFre = "Compréhension de base et application des principes d'ingénierie dans la mesure où ils se rapportent au génie maritime, tant sur le plan théorique que pratique. Démontre sa capacité de lire et d'interpréter des données techniques dans l'exercice de ses fonctions de quart. Participer à l'entretien préventif et correctif de divers systèmes. Cherche des occasions d'améliorer ses connaissances professionnelles et technologiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 304,
                DescEng = "Good application of engineering principles as they relate to marine engineering both theoretical and practical. Ability to analyze test data, compare and contrast information, and draw rational conclusions improving productivity. Differentiates between critical and non-critical defects, can quickly diagnose equipment problems, and execute necessary repairs. Ability to solve problems and recommend amendments to processes or procedures.",
                DescFre = "Bonne application des principes d'ingénierie dans la mesure où ils se rapportent au génie maritime, tant sur le plan théorique que pratique. Capacité d'analyser les données d'essai, de comparer et de contraster les informations et de tirer des conclusions rationnelles pour améliorer la productivité. Distingue les défauts critiques des défauts non critiques, peut diagnostiquer rapidement les problèmes d'équipement et effectuer les réparations nécessaires. Capacité de résoudre des problèmes et de recommander des modifications aux processus ou aux procédures."
            },
            new CompetencyLevelRequirement
            {
                Id = 305,
                DescEng = "Ensures machinery and systems operate safely, reliably, and efficiently. Oversees the operation, maintenance, and repair of the marine engineering systems. Applies statistical, cost, lifecycle, and related management principles to standard operating principles.",
                DescFre = "S'assure que les machines et les systèmes fonctionnent de façon sécuritaire, fiable et efficace. Superviser l'exploitation, l'entretien et la réparation des systèmes de génie maritime. Applique les principes statistiques, de coût, de cycle de vie et les principes de gestion connexes aux principes d'exploitation normalisés."
            },
            new CompetencyLevelRequirement
            {
                Id = 306,
                DescEng = "Strategic in approach, understands and addresses inter-dependencies and real issues. Ability to make timely decisions within engineering constraints and direct actions to mitigate impact on mission.",
                DescFre = "Approche stratégique, comprend et aborde les interdépendances et les problèmes réels. Capacité de prendre des décisions en temps opportun en tenant compte des contraintes techniques et de prendre des mesures directes pour atténuer l'impact sur la mission."
            },
            new CompetencyLevelRequirement
            {
                Id = 307,
                DescEng = "Basic knowledge of equipment operating procedures including propulsion generation, ancillary and auxiliary equipment, power distribution, heating and ventilation, refrigeration,  bilge and ballast, and steering systems.",
                DescFre = "Connaissance de base des procédures d'utilisation de l'équipement, y compris la production de la propulsion, l'équipement auxiliaire et auxiliaire, la distribution de l'énergie, le chauffage et la ventilation, la réfrigération, la cale et le ballast, et les systèmes de direction."
            },
            new CompetencyLevelRequirement
            {
                Id = 308,
                DescEng = "Limited working knowledge of equipment operating procedures in semi-automatic and manual modes. Understands basic prerequisites for systems start up and operations.",
                DescFre = "Connaissance pratique limitée des procédures de fonctionnement de l'équipement en mode semi-automatique et manuel. Comprend les conditions de base pour la mise en service et l'exploitation des systèmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 309,
                DescEng = "Practical knowledge of equipment operating procedures. Understands systems redundancies and their operating efficiencies. Intricate knowledge of established safety procedures for operation and maintenance.",
                DescFre = "Connaissance pratique des procédures d'utilisation de l'équipement. Comprend les redondances des systèmes et leur efficacité opérationnelle. Connaissance approfondie des procédures de sécurité établies pour l'exploitation et l'entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 310,
                DescEng = "Advanced knowledge of equipment operating procedures. Sufficient understanding of procedures to be able to assist in drafting new procedures. Knowledge of established emergency operating procedures and limitations.",
                DescFre = "Connaissance approfondie des procédures d'utilisation de l'équipement. Compréhension suffisante des procédures pour être en mesure d'aider à la rédaction de nouvelles procédures. Connaissance des procédures et des limites établies en cas d'urgence."
            },
            new CompetencyLevelRequirement
            {
                Id = 311,
                DescEng = "Expert knowledge of equipment operating procedures and the development of new or revised standard operating procedures in varying engineering and environmental situations.",
                DescFre = "Connaissance approfondie des procédures d'utilisation de l'équipement et de l'élaboration de procédures d'utilisation normalisées nouvelles ou révisées dans diverses situations techniques et environnementales."
            },
            new CompetencyLevelRequirement
            {
                Id = 312,
                DescEng = "Basic knowledge of a unit's role in an operational context.",
                DescFre = "Connaissance de base du rôle d’une unité dans un contexte opérationnel."
            },
            new CompetencyLevelRequirement
            {
                Id = 313,
                DescEng = "Limited understanding of the roles and responsibilities in an operational context to provide services to clients and stakeholders. Understands departmental policies, standards, directives, and guidelines relevant to operations.",
                DescFre = "Compréhension limitée des rôles et des responsabilités dans un contexte opérationnel relativement à la prestation des services aux clients et aux intervenants.  Compréhension des politiques, des normes, des directives et des lignes directrices ministérielles en ce qui concerne les opérations."
            },
            new CompetencyLevelRequirement
            {
                Id = 314,
                DescEng = "Practical knowledge of the methods, techniques, practices, and procedures associated with various types of operations. Understands appropriate methods and procedures for dealing with marine operations, exercises, and emergencies.",
                DescFre = "Connaissance pratique des méthodes, des techniques, des pratiques et des procédures liées à différents types d’opérations. Compréhension des méthodes et des procédures appropriées pour faire face aux opérations, aux exercices et aux urgences maritimes."
            },
            new CompetencyLevelRequirement
            {
                Id = 315,
                DescEng = "Advanced knowledge of operational capabilities and adaptive processes. Understands how an approaches or procedure should work and how changes in conditions, operations, and the environment will affect outcomes. Knowledge of best practices and processes for asset use and performance recommendations. Understands operational interoperabilities with internal and external stakeholders (including international).",
                DescFre = "Connaissance approfondie des capacités opérationnelles et des processus d’adaptation. Compréhension de la manière dont une approche ou une procédure devrait fonctionner et de la façon dont des changements dans le contexte, les opérations et l’environnement auront une incidence sur les résultats. Connaissance des pratiques exemplaires et des processus sur le chapitre de l’utilisation des actifs et des recommandations en matière de rendement. Compréhension des interopérabilités opérationnelles avec les intervenants internes et externes (y compris les intervenants internationaux)."
            },
            new CompetencyLevelRequirement
            {
                Id = 316,
                DescEng = "Expert knowledge of operational capabilities and decision making to complete the mandate effectively and efficiently. Understands emerging and best practices in the management of regional and/or national operations. Expertise in reviewing policies, regulations, directives, and guidelines.",
                DescFre = "Connaissance spécialisée des capacités opérationnelles et des processus décisionnels pour exécuter le mandat de manière efficace et efficiente. Compréhension des pratiques émergentes et exemplaires en matière de gestion des opérations régionales et nationales. Savoir­faire en matière d’examen de politiques, de règlements, de directives et de lignes directrices."
            },
            new CompetencyLevelRequirement
            {
                Id = 317,
                DescEng = "Basic knowledge of equipment operating procedures including global navigation satellite systems and other equipment used as a source of positional information. Understands how to report errors and issues.",
                DescFre = "Connaissance de base des procédures opérationnelles de l’équipement, notamment les systèmes mondiaux de navigation par satellite et tout autre équipement utilisé à titre de source de renseignements sur la position. Compréhension de la façon de déclarer des erreurs et des problèmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 318,
                DescEng = "Limited understanding of equipment operating procedures including global navigation satellite systems, electronic charts, steering and propulsion systems and warnings, and other equipment used as a source of positional information. Ability to solve basic problems independently and more complex ones with some assistance. Capable of identifying problems based on a limited number of clear and basic factors. Actively engages in errors/issues identification and resolution where appropriate.",
                DescFre = "Connaissance limitée des procédures opérationnelles de l’équipement, notamment les systèmes mondiaux de navigation par satellite, les cartes électroniques, les avertissements et systèmes de commande de gouvernail et de propulsion, ainsi que tout autre équipement utilisé à titre de source de renseignements sur la position. Capacité de résoudre par soi-même des problèmes de base ainsi que des problèmes plus complexes avec un peu d’aide. Capacité à cerner les problèmes en fonction d’un nombre limité de facteurs clairs et élémentaires. Participation active dans la détermination d’erreurs ou de problèmes ainsi que dans leur résolution, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 319,
                DescEng = "Good understanding/knowledge of equipment operating procedures. Experienced in solving basic and more complex problems. Skillful in identifying problems based on a limited number of clear factors. Diligent in verifying the problem has been solved. Proactively resolves errors/issues and seeks to prevent them from occurring.",
                DescFre = "Bonne compréhension ou connaissance des procédures opérationnelles de l’équipement. Expérience dans la résolution de problèmes de base et plus complexes. Capacité à cerner les problèmes en fonction d’un nombre limité de facteurs clairs. Montrer de la diligence à vérifier si le problème a été résolu. Résolution en amont d’erreurs ou de problèmes et recherche de mesures pour les empêcher de survenir."
            },
            new CompetencyLevelRequirement
            {
                Id = 320,
                DescEng = "Advanced understanding of equipment operating procedures. Extensive experience in solving various degrees of errors/issues/problems and providing effective guidance and advice to others seeking assistance. Effective in identifying problems with minimal information or clear factors.",
                DescFre = "Compréhension approfondie des procédures opérationnelles de l’équipement. Vaste expérience dans la résolution d’erreurs, d’enjeux ou de problèmes de divers niveaux et dans la présentation d’avis et de conseils efficaces à ceux qui demandent de l’aide. Efficacité dans la détection de problèmes malgré le nombre minime de renseignements ou de facteurs clairs."
            },
            new CompetencyLevelRequirement
            {
                Id = 321,
                DescEng = "Extensive experience in managing serious problems/issues/errors and implementing viable and practical solutions to address the situation. Effective in identifying problems with minimal information or clear factors and managing other persons and resources in the implementation of a solution.",
                DescFre = "Vaste expérience dans la gestion de problèmes, d’enjeux ou d’erreurs graves et dans la mise en œuvre de solutions viables et pragmatiques pour remédier à la situation. Efficacité dans la détection de problèmes malgré le nombre minime de renseignements ou de facteurs clairs et dans la gestion d’autres personnes ou ressources pour la mise en œuvre d’une solution."

            },
            new CompetencyLevelRequirement
            {
                Id = 322,
                DescEng = "Basic understanding of the Environmental Response (ER) program, mission, and mandate.",
                DescFre = "Compréhension de base du programme, de la mission et du mandat d'intervention environnementale (IE)"
            },
            new CompetencyLevelRequirement
            {
                Id = 323,
                DescEng = "Limited knowledge of the Environmental Response (ER) program's resources such as, spill equipment, maintenance, storage; clean up gear; and containment boom operation.",
                DescFre = "Connaissance limitée des ressources du programme d'intervention environnementale (IE) telles que l'équipement en cas de déversement, l'entretien, l'entreposage, le nettoyage de l'équipement et le fonctionnement de la flèche de confinement."
            },
            new CompetencyLevelRequirement
            {
                Id = 324,
                DescEng = "Practical understanding of the Canadian Coast Guard's Environmental Response (ER) response capabilities in a variety of moderately complex situations. Understands the roles and responsibilities of direct partners, other government departments (OGDs), and external partners collaborating with the ER program. Knowledge of contingency planning and exercise execution.",
                DescFre = "Compréhension pratique des capacités d'intervention de la Garde côtière canadienne - Intervention environnementale (IE) dans une variété de situations modérément complexes. Comprend les rôles et les responsabilités des partenaires directs, des autres ministères et des partenaires externes qui collaborent au programme d'IE. Connaissance de la planification d'urgence et de l'exécution des exercices."
            },
            new CompetencyLevelRequirement
            {
                Id = 325,
                DescEng = "Extensive knowledge of capability and status of Coast Guard assets. Advanced knowledge of international intervention agencies (such as the United States Coast Guard and the Environmental Protection Agency of United States) roles and the state of preparation of the adjacent and circumpolar countries. Knowledge of the enforcement of pollution prevention plans between vessel operators and governments. Knowledge of roles and mandates of key stakeholders in the provincial, municipal and private communities. Knowledge of national and international regulations concerning environmental protection.",
                DescFre = "Connaissance approfondie de la capacité et de l'état des biens de la Garde côtière. Connaissance approfondie des organismes d'intervention internationaux (comme la Garde côtière des États-Unis et  l'Environnement Agence de protection des États-Unis) et l'état de préparation des pays voisins et circumpolaires. Connaissance de l'application des plans de prévention de la pollution entre les exploitants de navires et les gouvernements. Connaissance des rôles et des mandats des principaux intervenants dans les collectivités provinciales, municipales et privées.  Connaissance des réglementations nationales et internationales en matière de protection de l'environnement."
            },
            new CompetencyLevelRequirement
            {
                Id = 326,
                DescEng = "Expert knowledge of the full range of the Coast Guard's Environmental Response (ER) program and its relations with industry and governments within Canada and abroad.",
                DescFre = "Connaissance approfondie de la gamme complète du programme d'intervention environnementale (IE) de la Garde côtière et de ses relations avec l'industrie et les gouvernements au Canada et à l'étranger."
            },
            new CompetencyLevelRequirement
            {
                Id = 327,
                DescEng = "Understands the established and applicable operational procedures within Icebreaking (IB). Knowledge of basic computer software related to icebreaking. Understands charts and maps, and knows their specific characteristics.",
                DescFre = "Comprend les procédures opérationnelles établies et applicables en matière de déglaçage. Connaissance des logiciels informatiques de base liés au déglaçage. Comprend les graphiques et les cartes et connaît leurs caractéristiques spécifiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 328,
                DescEng = "Understanding of concentration, stages of development, and forms of ice (Egg Code).  Knowledge of assets’ communication equipment and capabilities. Understands meteorological processes, such as air masses, weather, and atmospheric structures. Understands ice analyses and charts. Understands iceberg formation and tracking.",
                DescFre = "Compréhension de la concentration, des stades de développement et des formes de glace (Egg Code).  Connaissance de l'équipement et des capacités de communication des biens. Comprend les processus météorologiques, comme les masses d'air, les conditions météorologiques et les structures atmosphériques. Comprend les analyses et les cartes des glaces. Comprend la formation et le suivi des icebergs."
            },
            new CompetencyLevelRequirement
            {
                Id = 329,
                DescEng = "Practical knowledge of navigation, ship construction, and ship handling principles as they relate to navigation in ice infested waters. Knowledge of reporting (such as the Icebreaking Operations Data Information System [IODIS]) and mapping (such as Information System on Marine Navigation [INNAV] and Exact Earth) systems and other related software in daily operations. Understands oceanographic processes: waves, currents, and shoreline dynamics as they relate to ice. Understands navigation protocols, such as course plotting, in order to evaluate the safety of an ice route.",
                DescFre = "Connaissance pratique des principes de navigation, de construction et de manœuvre des navires en ce qui a trait à la navigation dans les eaux recouvertes de glace. Connaissance des systèmes d'établissement de rapports (comme le Système d'information sur les données des opérations de déglaçage[SIDOD]) et de cartographie (Système d'information sur la gestion du trafic maritime [SIGTM] et Exact Earth) et d'autres logiciels connexes dans les opérations quotidiennes. Comprend les processus océanographiques : les vagues, les courants et la dynamique des rives par rapport aux glaces. Comprend les protocoles de navigation, comme le tracé de route, afin d'évaluer la sécurité d'une route de glace."
            },
            new CompetencyLevelRequirement
            {
                Id = 330,
                DescEng = "Advanced knowledge of alternate or emerging strategies that may fall outside standard operating procedures in order to resolve a situation. Has detailed knowledge of areas of responsibility characteristics which play a role in Icebreaking (IB) operations or influence the outcome of the program.",
                DescFre = "Connaissance approfondie des stratégies de rechange ou des stratégies émergentes qui peuvent ne pas faire partie des procédures d'exploitation normalisées afin de résoudre une situation. A une connaissance détaillée des caractéristiques des secteurs de responsabilité qui jouent un rôle dans les opérations de déglaçage ou qui influencent les résultats du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 331,
                DescEng = "Expert program knowledge in implementing new possibilities/capabilities to improve the existing systems and practices. Knowledge of creating program procedures.",
                DescFre = "Connaissance experte du programme dans la mise en œuvre de nouvelles possibilités/capacités pour améliorer les systèmes et les pratiques existants. Connaissance de la création des procédures du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 332,
                DescEng = "Reads and interprets diagrams and schematics. Starts and stops main propulsion, auxillary and ancillary machinery. Monitors and reports equipment performance. Assists in scheduling equipment maintenance. Performs repair by replacement.",
                DescFre = "Lit et interprète des diagrammes et des schémas. Mettre en marche et arrêter la propulsion principale, les machines auxiliaires et auxiliaires. Surveille et signale les performances de l'équipement. Aide à planifier l'entretien de l'équipement. Effectue la réparation par remplacement."
            },
            new CompetencyLevelRequirement
            {
                Id = 333,
                DescEng = "Perform first and second line maintenance as per watch instructions. Maintains list of parts. Directs fuel transfers. Analyzes engineering reports. Directs configuration changes in propulsion plant and machinery. Advises bridge officers on machinery status, liquid cargo transfers, and ongoing maintenance issues. Responds to ancillary and auxiliary breakdowns.",
                DescFre = "Effectue la maintenance de première et de deuxième ligne selon les instructions de la surveillance. Tient à jour la liste des pièces. Dirige les transferts de carburant. Analyse les rapports techniques. Dirige les changements de configuration des installations et des machines de propulsion. Conseille les officiers de pont sur l'état des machines, les transferts de cargaisons liquides et les questions d'entretien courant. Réponds aux pannes des équipements auxiliaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 334,
                DescEng = "Provides information and advice to bridge officers and chief engineers. Peforms engine overhaul at sea and ashore. Establishes trends in machinery performance and future maintenance requirements based on logs. Makes recommendations, and may make decisions on engineering matters or other areas requiring technical engineering expertise.",
                DescFre = "Fournit des informations et des conseils aux officiers de pont et aux chefs mécaniciens. Effectue la révision des moteurs en mer et à terre. Établit les tendances en matière de performance de la machinerie et les besoins futurs d'entretien basés sur les journaux de bord. Fait des recommandations et peut prendre des décisions sur des questions d'ingénierie ou d'autres domaines nécessitant une expertise technique en ingénierie."
            },
            new CompetencyLevelRequirement
            {
                Id = 335,
                DescEng = "Advises commanding officers on all shipboard engineering matters, including fuel consumption best practices, maintenance status and requirements, speed restrictions, and stability configurations and environmental considerations. Oversees the completion of all engineering logs and reports. Manages engineering docking procedures. Liaises and directs contractors.",
                DescFre = "Conseille les commandants sur toutes les questions relatives à l'ingénierie à bord des navires, y compris les meilleures pratiques en matière de consommation de carburant, l'état et les exigences d'entretien, les restrictions de vitesse, les configurations de stabilité et les considérations environnementales. Supervise la tenue de tous les journaux et rapports techniques. Gére les procédures d'accostage technique. Assure la liaison avec les entrepreneurs et les diriger."
            },
            new CompetencyLevelRequirement
            {
                Id = 336,
                DescEng = "Manages all shipboard and/or shoreside engineering matters, operations, maintenance, and reporting. Manages engineering docking procedures. Liaises with and directs contractors. Provides engineering expertise to units at sea and ashore regionally and nationally. Develops vessel class engineering procedures for operation under normal and emergency situations. Participates in regional and national working groups on refit scheduling best practices, engineering change proposals, and new platform acquisition.",
                DescFre = "Gère toutes les questions d'ingénierie à bord des navires et/ou à terre, les opérations, la maintenance et les rapports. Gère les procédures d'accostage technique. Assure la liaison avec les entrepreneurs et les diriger. Fournit une expertise technique aux unités en mer et à terre, au niveau régional et national. Élabore des procédures d'ingénierie de classe navire pour l'exploitation dans des situations normales et d'urgence. Participe aux groupes de travail régionaux et nationaux sur les meilleures pratiques en matière de planification du radoub, les propositions de modifications techniques et l'acquisition de nouvelles plates-formes."
            },
            new CompetencyLevelRequirement {Id = 337, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 338, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 339,
                DescEng = "Operates and monitors a ship's electrical distribution system. Conducts system configuration changes. Provides limited advise to bridge officers on electical issues.",
                DescFre = "Faire fonctionner et surveiller le système de distribution électrique d’un navire. Apporter des modifications à la configuration de système. Donner des conseils limités aux officiers de la passerelle à l’égard des problèmes électriques."
            },
            new CompetencyLevelRequirement
            {
                Id = 340,
                DescEng = "Reads and interprets diagrams and schematics. Applies basic circuit analysis methods to solve electrical problems. Operates the electrical plant, monitors parameters and reports on electrical components and equipment status. Installs, tests, and repairs ship electrical and electronic equipment, in collaboration with the engineering department.",
                DescFre = "Lire et interpréter des schémas et des esquisses. Appliquer des méthodes de base d’analyse des circuits afin de résoudre des problèmes électriques. Exploiter la centrale électrique, surveiller les paramètres et faire rapport sur les composants électriques et l’état de l’équipement. Installer, mettre à l’essai et réparer l’équipement électrique et électronique du navire, en collaboration avec le service de la salle des machines."
            },
            new CompetencyLevelRequirement
            {
                Id = 341,
                DescEng = "Manages all shipboard electrical matters, operations, maintenance, and reporting. Liaises with and directs electrical contractors. Provides electrical expertise to units at sea and ashore, regionally and nationally. Develops vessel class electrical procedures for operation under normal and emergency situations. Participates in regional and national working groups on electrical best practices.",
                DescFre = "Gérer l’ensemble des questions, du fonctionnement, de l’entretien et des rapports en matière d’électricité à bord d’un navire. Assurer la liaison avec les entrepreneurs en électricité et les diriger. Offrir un savoir-faire en électricité aux unités régionales et nationales en mer et à terre. Élaborer des procédures électriques en fonction des classes de navires quant au fonctionnement dans des conditions normales et en cas d’urgence. Participer à des groupes de travail régionaux et nationaux sur les pratiques exemplaires en matière d’électricité."
            },
            new CompetencyLevelRequirement
            {
                Id = 342,
                DescEng = "Basic use of navigational principles. Stands a steering watch and plots speed, distance, and time calculations, along pre-established routes. Studies charts and corrections. Researches weather and tide information. Observes traffic.",
                DescFre = "Utiliser les principes nautiques de base. Effectuer un quart au gouvernail et pointer la vitesse, la distance, les calculs d’heure et les routes préétablies. Étudier les cartes et les corrections. Chercher des renseignements météorologiques et des renseignements sur la marée. Observer la circulation."
            },
            new CompetencyLevelRequirement
            {
                Id = 343,
                DescEng = "Stands bridge watches, including using most bridge equipment. Routinely plots courses. Manages safety and/or chart correction portfolios. Handles radio traffic and logs. Gathers domain awareness relevant to passage planning. Observes and reports collision risks.",
                DescFre = "Effectuer des quarts à la passerelle et utiliser la plupart de l’équipement de la passerelle. Pointer régulièrement le cap. Gérer les dossiers de correction en matière de sécurité et de cartes. Gérer le trafic et les journaux du radiotéléphone. Accroître sa connaissance du domaine en ce qui concerne la préparation de traversée. Observer et signaler les risques de collision."
            },
            new CompetencyLevelRequirement
            {
                Id = 344,
                DescEng = "Manages a range of bridge watch duties in most conditions, including using all bridge gear (Electronic Chart Display System (ECDIS), radar, etc.), course plotting and correction, handling safety portfolios, radio communications, logging, and giving helm orders, including collision avoidance. Participates in various program operations including search and rescue.",
                DescFre = "Gérer un éventail de tâches de quart à la passerelle dans la plupart des états de la mer, y compris l’utilisation de tout l’équipement de la passerelle (système électronique de visualisation de cartes marines[SEVCM], radar, etc.), le pointage de caps et les corrections, la gestion des dossiers en matière de sécurité, les communications du radiotéléphone, l’enregistrement ainsi que la formulation de commandements à la barre, dont l’évitement des collisions. Participer à diverses opérations de programme dont la recherche et le sauvetage."
            },
            new CompetencyLevelRequirement
            {
                Id = 345,
                DescEng = "Manages bridge watches in all types of vessel operations, passage and station keeping, including bridge team management through acting command. Manages most program supports, including handling searches, risk analyses, emergencies. Oversees the training of junior watchkeeping officers and crew.",
                DescFre = "Gérer les quarts à la passerelle pour tous les types d’opérations des navires, de traversées et de maintien en position, y compris la gestion de l’équipe de la passerelle au moyen de commandement intérimaire. Gérer la plupart des tâches du programme, y compris la gestion des recherches, des analyses des risques et des urgences. Superviser la formation des officiers de quart et des membres de l’équipage qui sont peu expérimentés."
            },
            new CompetencyLevelRequirement
            {
                Id = 346,
                DescEng = "Manages all bridge teams and watch scenarios including pilotage and program supports, risk and emergency management from a command perspective. Recommends and tests new gear and procedures. Provides advice on lessons learned through sightings, bearings, land and sea features, meteorological and oceanographic trends, and electronic aids and their limitations.",
                DescFre = "Gérer toutes les équipes de la passerelle et observer des scénarios comprenant la gestion des tâches, des risques et des cas d’urgence liés au pilotage et au programme d’un point de vue du commandement. Recommander et mettre à l’essai du nouveau matériel et de nouvelles procédures. Donner des conseils sur les leçons retenues grâce aux observations, aux relèvements, aux caractéristiques des terres et de la mer, aux tendances météorologiques et océanographiques ainsi qu’aux aides électroniques et leurs limites."
            },
            new CompetencyLevelRequirement
            {
                Id = 347,
                DescEng = "Requests supplies, ensuring that proper receipt, identification, and inspection is carried out for incoming shipboard materiel. Performs routine asset management tasks. Conducts the life cycle of tackle books, safety equipment, charts, etc., when and where applicable.",
                DescFre = "Demander des fournitures, veiller à la réception, à la détermination et à l’inspection adéquates du matériel reçu et embarqué. Exécuter des tâches régulières de gestion des actifs. Mener à bien le cycle de vie des registres de l’outillage de chargement, de l’équipement de sécurité et des cartes, entre autres, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 348,
                DescEng = "Requests parts and supplies from internal stocks using the approved classification system. Adheres to the inventory management system (IMS) as it relates to a position. Applies proper stowage, ensures safe handling, and preserves assets. Reviews incoming standing offer agreements, purchase orders, and maintains a central file of agreements for monthly/annual contracts. Manages special and emergency requirements of departments by determining the best means of purchase, contacting regional suppliers and managers, and ensuring that materiel is received within the deadline required.",
                DescFre = "Demander des pièces et des fournitures des stocks internes en utilisant le système de classification approuvé. Adopter le SGS lorsqu’il s’applique à un poste. Assurer l’arrimage adéquat, la manipulation sécuritaire et la protection des actifs. Examiner les conventions d'offre à commandes et les bons de commande reçus et tenir à jour un fichier central des ententes pour les contrats mensuels et annuels. Gérer les besoins particuliers et urgents des ministères en déterminant la meilleure méthode d’achat, en communiquant avec des fournisseurs et des gestionnaires régionaux et en veillant à ce que le matériel soit reçu dans le délai prescrit."
            },
            new CompetencyLevelRequirement
            {
                Id = 349,
                DescEng = "Receives, stores, issues, and records materiel according to the approved classification system. Categorizes materiel (i.e. equipment, controllable, and expendable). Requisitions types and quantities of materiel to meet authorized allowances or specified requirements of provisions, general stores, spare parts, controllable items, uniforms, and protective clothing, pharmaceutical and medical supplies, canteen and bonded stores. Ensures the proper stowage, care, preservation, and security of materiel stocked in central stores or in use by the logistics department, that materiel is properly identified, catalogued, and incorporated in the centralized cataloguing files. Implements the concepts of the Policy Framework for the Management of Assets and Acquired Services in daily routines.",
                DescFre = "Recevoir, entreposer, fournir et consigner le matériel en fonction du système de classification approuvé. Catégoriser le matériel (c.-à-d. équipement, contrôlable et consommable). Demander les types et les quantités de matériel nécessaire pour se conformer aux allocations autorisées ou aux exigences précises quant aux provisions, aux magasins généraux, aux pièces de rechange, aux articles contrôlables, aux uniformes, aux vêtements de protection, aux fournitures pharmaceutiques et médicales, à la cantine et aux entrepôts de stockage. Assurer l’arrimage, l’entretien, la protection et la sécurité adéquats du matériel entreposé dans les magasins centraux ou utilisé par le service de la logistique et veiller à ce que le matériel soit correctement répertorié, catalogué et intégré dans les fichiers de catalogage centralisés. Mettre en œuvre les concepts du Cadre de politique sur la gestion des actifs et services acquis dans les activités quotidiennes régulières."
            },
            new CompetencyLevelRequirement
            {
                Id = 350,
                DescEng = "Enables and promotes the management of the approved materiel classification system. Uses supplier classifications systems and cross-reference tables where available. Performs a full function of asset management processes. Follows the life cycle management regime for all trackable assets. Follows the process of commissioning and decommissioning of vessels as they relate to fleet operations. Ensures security of assets. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items.",
                DescFre = "Faciliter et encourager la gestion du système approuvé de classification du matériel. Utiliser les systèmes de classement des fournisseurs et les tables de références croisées, lorsqu’ils sont disponibles. Exécuter l’ensemble des processus de gestion des actifs. Se conformer au système de gestion du cycle de vie de tous les actifs vérifiables. Se conformer au processus de mise en service et de mise hors service des navires lorsqu’ils sont liés aux opérations de la flotte. Assurer la sécurité des actifs. Tenir à jour les dossiers de contrôle des engagements pour le matériel réquisitionné en stock et l’équipement qui n’est pas en stock."
            },
            new CompetencyLevelRequirement
            {
                Id = 351,
                DescEng = "Partners with Corporate Services, Shared Services, and other personnel. Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches to managing shipboard logistics. Trains and guides employees within the materiel management field, when and where applicable.",
                DescFre = "Créer des partenariats avec Services intégrés, Services partagés Canada et d’autres membres du personnel. Assister aux réunions nationales et représenter les intérêts régionaux dans le domaine de la gestion de matériel. Fournir des conseils et de l’orientation à la direction à l’égard des approches rentables pour gérer la logistique à bord des navires. Former et guider les employés du domaine de la gestion du matériel, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 352,
                DescEng = "Logs basic project/program needs, prepares orders, schedules delivery times, and receives and stores material as directed.",
                DescFre = "Enregistrer les besoins de base du projet ou du programme, préparer les commandes, planifier les délais de livraison et effectuer la réception et l’entreposage du matériel selon les directives."
            },
            new CompetencyLevelRequirement
            {
                Id = 353,
                DescEng = "Prepares list of required items. Assembles orders. Sorts merchandise, maintains supplies, verifies inventory, and processes return materials authorizations.",
                DescFre = "Préparer la liste des articles requis. Rassembler les commandes. Trier les marchandises, tenir à jour l’approvisionnement, vérifier l’inventaire et traiter les ARM."
            },
            new CompetencyLevelRequirement
            {
                Id = 354,
                DescEng = "Controls purchasing, transportation, inventory, and site storage protocols. Uses appropriate equipment, facilities, and materials to conduct unit work. Controls inventory levels by conducting physical counts and reconciling with data storage system.",
                DescFre = "Contrôler les protocoles d’approvisionnement, de transport, des stocks et d’entreposage sur le site. Utiliser les matières, les installations et le matériel adéquats pour réaliser les travaux de l’unité. Contrôler les niveaux de stock par l’exécution de dénombrements et de rapprochements avec les systèmes de stockage de données."
            },
            new CompetencyLevelRequirement
            {
                Id = 355,
                DescEng = "Enters commitment and contracts for goods and services. Receives and distributes raw materials and finished goods. Forecasts requirements and planning for the future. Identifies complex problems and reviewing related information to develop and evaluate options and implement solutions. Designs strategies to minimize the cost or time. Develops and implements site inventory monitoring procedures.",
                DescFre = "Prendre des engagements et conclure des marchés pour l’acquisition de biens et de services. Recevoir et distribuer les matières premières et les produits finis. Prévoir les besoins et préparer l’avenir. Déterminer des problèmes complexes et examiner les renseignements connexes afin d'élaborer et d'évaluer les options et de mettre en œuvre des solutions. Élaborer des stratégies pour réduire autant que possible le coût ou les délais. Élaborer et mettre en œuvre des procédures de surveillance du stock sur le site."
            },
            new CompetencyLevelRequirement
            {
                Id = 356,
                DescEng = "Initiates, manages, and follows through on unit or shared units large contracts for goods and services. Resolves complex unit or site logistical issues and their impacts on other units or operations. Develops and implements business process initiatives to optimize logistical operations. Follows strict controls according to policies and procedures related to material handling, and shipping requirements.",
                DescFre = "Mettre en place et gérer des contrats importants de l’unité ou des unités communes et y donner suite pour la fourniture de biens et de services. Résoudre des problèmes complexes de logistique de l’unité ou du site et leurs répercussions sur d’autres unités ou opérations. Élaborer et mettre en œuvre des initiatives concernant les processus opérationnels afin d’optimiser les opérations liées à la logistique. Respecter des contrôles stricts conformément aux politiques et procédures liées à la manutention du matériel et aux exigences relatives à l’expédition."
            },
            new CompetencyLevelRequirement
            {
                Id = 357,
                DescEng = "Locates aids to navigation, logs and files records. Asks pertinent questions related to the Aids to Navigation (AtoN) program.",
                DescFre = "Localiser les aides à la navigation, les registres et les dossiers. Poser des questions pertinentes à propos du PAN."
            },
            new CompetencyLevelRequirement
            {
                Id = 358,
                DescEng = "Plans first-line maintenance for existing aids to navigation, logging information appropriately, and reporting outages where necessary for further action.",
                DescFre = "Planifier l’entretien de première ligne des aides à la navigation en place, consigner l’information adéquatement et produire des rapports sur les pannes lorsque des mesures doivent être prises."
            },
            new CompetencyLevelRequirement
            {
                Id = 359,
                DescEng = "Coordinates the range of aids services, including  aids maintenance planning, inspections, maintenance, and replacement operations with Fleet partners. Drafts reports and notices to shipping (NOTSHIP). Provides on-the-job training.",
                DescFre = "Coordonner l’éventail des services liés aux aides, y compris la planification de l’entretien, les inspections, l’entretien et les activités de remplacement des aides avec les partenaires de la flotte. Rédiger des rapports et des avis à la navigation (NOTSHIP). Offrir de la formation en cours d’emploi."
            },
            new CompetencyLevelRequirement
            {
                Id = 360,
                DescEng = "Manages the entire range of Aids to Navigation (AtoN) program activities. Identifies, analyzes, and prioritizes risks related to aids to navigation for the management of notices to shipping (NOTSHIP), aids requests, failures, replacement, and maintenance according to life cycles, in co-operation with Canadian Coast Guard's Integrated Technical Services (ITS) and Fleet partners. Provides inputs and recommendations into levels of service and operational requirements and updates to data systems. Assesses navigational risks.",
                DescFre = "Gérer l’éventail complet des activités du PAN. Cibler et analyser les risques liés aux aides à la navigation et les classer par ordre de priorité en vue de la gestion des NOTSHIP, des demandes d’aides, des échecs, des remplacements et de l’entretien conformément aux cycles de vie, et ce, en collaboration avec les Services techniques intégrés (STI) de la GCC et les partenaires de la flotte. Fournir des données et des recommandations à l’égard des niveaux de service requis et des exigences opérationnelles et mettre à jour les systèmes de données. Évaluer les risques liés à la navigation."
            },
            new CompetencyLevelRequirement
            {
                Id = 361,
                DescEng = "Oversees the planning of regional and national Aids to Navigation (AtoN) program activities, including analyzing program metadata, conducting studies, developing service standards and needs analyses and risk mitigation measures. Provides information and feedback to and from partners and stakeholders internally and externally. Explores opportunities for program improvement. Drafts national directives and/or policies.",
                DescFre = "Superviser la planification des activités régionales et nationales du PAN, y compris l’analyse des métadonnées de programme, la réalisation d’études ainsi que l’élaboration d’analyses des normes de service et des besoins et de mesures d’atténuation des risques. Fournir de l’information et de la rétroaction aux partenaires et aux intervenants internes et externes et communiquer l’information et la rétroaction reçues de ces derniers. Étudier les possibilités d’amélioration du programme. Rédiger des directives ou des politiques nationales."
            },
            new CompetencyLevelRequirement
            {
                Id = 362,
                DescEng = "Conducts information searches, organizes, reviews, and processes information and performs directed, routine analysis. Ensures the accuracy and completeness of the information.",
                DescFre = "Effectue des recherches d'informations, organise, examine et traite les informations et effectue des analyses de routine dirigées. Veille à l'exactitude et à l'exhaustivité des informations."
            },
            new CompetencyLevelRequirement
            {
                Id = 363,
                DescEng = "Determines and selects information relevant to a particular area of study, compiles and verifies information and performs directed, non-routine analyses. Ensures consistency, coherence, and information integrity.",
                DescFre = "Détermine et sélectionne les informations pertinentes pour un domaine d'étude particulier, compile et vérifie les informations et effectue des analyses dirigées et non routinières. Veille à la cohérence et à l'intégrité des informations."
            },
            new CompetencyLevelRequirement
            {
                Id = 364,
                DescEng = "Studies a range of information and identifies and interprets trends and patterns, determines gaps in research, and develops comprehensive background material for further analysis. Assesses information and evaluates and compares current approaches and practices for the gathering, dissemination, or analysis of information. Identifies possible modifications or alternative approaches when deeming current methodology as inadequate or inaccurate.",
                DescFre = "Étudie une série d'informations et identifie et interprète les tendances et les modèles, détermine les lacunes dans la recherche et élabore des documents de référence complets pour une analyse plus approfondie. Évalue les informations et évalue et compare les approches et les pratiques actuelles en matière de collecte, de diffusion ou d'analyse des informations. Identifie les modifications possibles ou les approches alternatives lorsque la méthodologie actuelle est jugée inadéquate ou inexacte."
            },
            new CompetencyLevelRequirement
            {
                Id = 365,
                DescEng = "Synthesizes and interprets complex information from diverse sources and identifies the conceptual frameworks related to areas of study. Accounts for interrelationships among variables or determines the need for new analytical methodologies, systems, or approaches.",
                DescFre = "Synthétiser et interpréter des informations complexes provenant de diverses sources et identifier les cadres conceptuels liés aux domaines d'étude. Tient compte des interrelations entre les variables ou détermine le besoin de nouvelles méthodes, systèmes ou approches analytiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 366,
                DescEng = "Investigates and challenges existing conceptual frameworks. Examines multiple variables from distinct sources within a subject matter area and reaches conclusions and/or generates solutions. Integrates distinct broad-based qualitative or quantitative analyses. Creates/adapts conceptual frameworks for the development, application, interpretation, and evaluation of studies, methodologies, strategies, and policies for the Canadian Coast Guard.",
                DescFre = "Examine et remet en question les cadres conceptuels existants. Examine de multiples variables provenant de sources distinctes au sein d'un même domaine et aboutit à des conclusions et/ou génère des solutions. Intègre des analyses qualitatives ou quantitatives distinctes et de grande envergure. Crée/adapte des cadres conceptuels pour l'élaboration, l'application, l'interprétation et l'évaluation d'études, de méthodologies, de stratégies et de politiques pour la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 367,
                DescEng = "Makes recommendations for decision on technical engineering matters.",
                DescFre = "Fait des recommandations de décision sur des questions d'ingénierie technique."
            },
            new CompetencyLevelRequirement
            {
                Id = 368,
                DescEng = "Makes recommendations to approve routine engineering/technical designs and/or project/program specifications of other engineers to meet desired compliance with engineering principles, standards, codes, designs, and statutes.",
                DescFre = "Fait des recommandations pour approuver les conceptions techniques régulières et/ou les spécifications de projets/programmes d'autres ingénieurs afin de respecter les principes, normes, codes, conceptions et statuts d'ingénierie."
            },
            new CompetencyLevelRequirement
            {
                Id = 369,
                DescEng = "Makes recommendations, and may make decisions on non-engineering and/or program matters or other areas requiring technical engineering expertise. May make final decisions. Provides technical analysis. May serve as a mentor/resource to lower level employees in the area of assignment. May approve moderately complex engineering/technical designs and/or project/program specificiations of other engineers to meet desired compliance with engineering principles, standards, codes, designs, and statutes. May address conflicting design constraints.",
                DescFre = "Fait des recommandations et peut prendre des décisions sur des questions autres que l'ingénierie et/ou les programmes ou d'autres domaines nécessitant une expertise technique en ingénierie. Peut prendre des décisions finales. Fournit des analyses techniques. Peut servir de mentor/ressource pour les employés de niveau inférieur dans la zone d'affectation. Peut approuver des conceptions techniques modérément complexes et/ou des spécificités de projets/programmes d'autres ingénieurs afin d'assurer la conformité souhaitée aux principes, normes, codes, conceptions et statuts en matière d'ingénierie. Peut traiter des contraintes de conception contradictoires."
            },
            new CompetencyLevelRequirement
            {
                Id = 370,
                DescEng = "Approves complex or novel engineering/technical designs and/or project/program specifications of other engineers, to meet desired compliance with engineering principles, standards, codes, designs, and statutes. Addresses conflicting design constraints.",
                DescFre = "Approuve les conceptions techniques complexes ou inhabituelles et/ou les spécifications de projets/programmes d'autres ingénieurs, afin de respecter les principes, normes, codes, conceptions et statuts d'ingénierie. Traite les contraintes de conception contradictoires."
            },
            new CompetencyLevelRequirement
            {
                Id = 371,
                DescEng = "Makes final recommendations and may make decisions that require specialized engineering and/or program knowledge. Decisions may not be technically reviewed. Collaborates with others in finding solutions to controversial or sensitive matters that establish precendents. Technical expert in the area of assignment and may represent the Canadian Coast Guard as an expert.",
                DescFre = "Fait des recommandations finales et peut prendre des décisions qui nécessitent des connaissances spécialisées en ingénierie et/ou en programmes. Les décisions ne peuvent pas faire l'objet d'un examen technique. Collabore avec d'autres personnes pour trouver des solutions à des questions controversées ou sensibles qui établissent des précendents. Expert technique dans le domaine d'affectation et peut représenter la Garde côtière canadienne en tant qu'expert."
            },
            new CompetencyLevelRequirement
            {
                Id = 372,
                DescEng = "Applies engineering sciences to assist in the design of engineering projects. Solves or assists in solving defined problems in drafting an engineering project proposal.",
                DescFre = "Appliquer les sciences du génie pour appuyer la conception de projets techniques. Résoudre ou aider à résoudre des problèmes définis dans le cadre de la rédaction d’une proposition de projet technique."
            },
            new CompetencyLevelRequirement
            {
                Id = 373,
                DescEng = "Applies engineering sciences to moderately complex services or creative work such as consultations, investigations, evaluation, plans, and designs of engineering projects. Provides drawing input and reviews. Defines problems, conducts research, plans methods, and identifies resources.",
                DescFre = "Appliquer les sciences du génie à des services moyennement complexes ou à des créations intellectuelles comme les consultations, les investigations, les évaluations, les plans et les avant-projets de projets techniques. Fournir un avis sur les dessins et les examiner. Définir des problèmes, mener des travaux de recherche, planifier des méthodes et déterminer des ressources."
            },
            new CompetencyLevelRequirement
            {
                Id = 374,
                DescEng = "Develops engineering designs and/or project/program specifications to meet desired compliance with engineering principles, standards, statutes, codes, regulations. Researches, collects, and/or analyzes information/data which contributes to making engineering decisions. Monitors and ensures projects meet specifications and/or design standards.",
                DescFre = "Élaborer des avant-projets techniques ou des spécifications techniques pour un projet ou un programme afin de se conformer aux principes, aux normes, aux lois, aux codes et aux règlements techniques. Rechercher, recueillir ou analyser les renseignements ou les données qui contribuent à la prise de décisions techniques. Surveiller les projets et s’assurer que ceux-ci respectent les spécifications ou les normes de conception."
            },
            new CompetencyLevelRequirement
            {
                Id = 375,
                DescEng = "Approves engineering designs, program, and project specifications. Researches new procedures and products for current and future projects. Improves manufacturing processes.",
                DescFre = "Approuver des avant-projets, des programmes et des spécifications de projets techniques. Rechercher de nouvelles procédures et de nouveaux produits pour les projets actuels et ultérieurs. Améliorer les procédés de fabrication."
            },
            new CompetencyLevelRequirement
            {
                Id = 376,
                DescEng = "Approves all designs, design modifications, and engineering projects. Reviews and/or analyzes information/data which contributes to making engineering decisions. Monitors and ensures projects meet specifications and/or design standards. Develops client relations by continually improving the level of service provided in accordance with the provision of service agreement and industry standard practices.",
                DescFre = "Approuver tous les avant-projets et projets techniques ainsi que toutes les modifications apportées à la conception. Examiner ou analyser les renseignements ou les données qui contribuent à la prise de décisions techniques. Surveiller les projets et s’assurer que ceux-ci respectent les spécifications ou les normes de conception. Créer des relations avec la clientèle en améliorant sans cesse le niveau de service offert conformément à la disposition sur les accords de service et aux pratiques courantes de l’industrie."
            },
            new CompetencyLevelRequirement
            {
                Id = 377,
                DescEng = "Performs introductory collection, organization, preservation, and dissemination of information resources functions. Answers routine informational/directional questions. Explains and upholds policies & procedures, handles routine complaints. Enters basic data, manipulates software for information (e.g. adding barcodes, keying orders, Innopac records).",
                DescFre = "Procéder à la collection, à l’organisation, à la protection et à la diffusion préliminaires des fonctions liées aux ressources d’information. Répondre à des questions courantes d’information et d’orientation. Expliquer et respecter les politiques et procédures et gérer les plaintes courantes. Effectuer la saisie de données de base et manipuler le logiciel pour gérer l’information (p. ex. ajout de codes à barres, saisie de commandes et dossiers Innopac)."
            },
            new CompetencyLevelRequirement
            {
                Id = 378,
                DescEng = "Collects, preserves, and disseminates information items using established guidelines, identifying useable copy of categories of material which can be cataloged online or in print. Keys records into systems. Sorts and distributes incoming materials to appropriate workflows. Performs basic processing of notices and sources of information. Performs stack maintenance per established guidelines.",
                DescFre = "Recueillir, protéger et diffuser des éléments d’information au moyen des lignes directrices établies et déterminer l’exemplaire utilisable des catégories de documents qui peut être catalogué en ligne ou en version imprimée. Saisir des dossiers dans les systèmes. Trier et répartir les documents reçus dans les flux de travail appropriés. Exécuter le traitement de base des avis et des sources d’information. Procéder à la mise à jour du magasin des livres selon les lignes directrices établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 379,
                DescEng = "Collects, preserves, and disseminates information resources for database maintenance and added copy tasks in local database. Updates lower level records in local databases. Creates records in databases. Trains others in stack maintenance. Serves at a reference desk or general service desk providing routine information to members using the library’s catalogs and resources.",
                DescFre = "Recueillir, protéger et diffuser des ressources d’information pour la mise à jour des bases de données et les tâches liées à l’ajout d’exemplaires dans la base de données locale. Mettre à jour les dossiers de niveau inférieur dans les bases de données locales. Créer des dossiers dans les bases de données. Former les autres sur la mise à jour du magasin des livres. Occuper un poste au Bureau des renseignements ou au Service d’emprunt général et fournir des renseignements de caractère courant aux membres qui utilisent les catalogues et les ressources de la bibliothèque."
            },
            new CompetencyLevelRequirement
            {
                Id = 380,
                DescEng = "Performs difficult collection, organization, preservation, and dissemination tasks and records management in all formats. Creates new records on national or local database based on existing records. Performs and is responsible for more difficult database maintenance. Performs authority record creation and/or editing in local database. Interprets and applies policy, or assists unit head in creating and developing local and national library policies and procedures.",
                DescFre = "Effectuer des tâches difficiles de collecte, d’organisation, de protection et de diffusion et assurer la gestion des dossiers sur tous les supports. Créer de nouveaux dossiers dans la base de données nationale ou locale en s’appuyant sur des dossiers existants. Effectuer et assumer une mise à jour plus difficile des bases de données. Créer des notices d’autorité ou les modifier dans la base de données locale. Interpréter et appliquer les politiques ou appuyer le chef d’unité dans la création et l’élaboration de politiques et procédures locales et nationales en matière de bibliothéconomie."
            },
            new CompetencyLevelRequirement
            {
                Id = 381,
                DescEng = "Plans, organizes, directs, controls, and evaluates the activities of a library or library system, archive or archive system, museum or art gallery or a technical department within such an institution in the Canadian Coast Guard. Performs standard collection of materials, filing, tracking, and cataloguing. Develops, promotes, and implements public relations and promotional programs. Conducts library information and orientation training programs and tours. Collects and compiles statistics. Codifies and classifies archival materiels and puts archival materiels on microfilm or in databases. Purges, sorts, reduces, and samples archives.",
                DescFre = "Planifier, organiser, diriger, contrôler et évaluer les activités d’une bibliothèque ou d’un réseau de bibliothèques, de l’archivage ou d’un système d’archivage, d’un musée ou d’une galerie d'art ou encore d’un service technique dans ce type d’institution dans la GCC. Effectuer la collecte normale, le dépôt, le suivi et le catalogage des documents. Élaborer, faciliter et mettre en œuvre des programmes de relations publiques et de promotion. Diriger des programmes d’information et de formation initiale sur les bibliothèques ainsi que des visites guidées. Recueillir et compiler des statistiques. Codifier et classer des documents d’archives et enregistrer ceux-ci sur microfilm ou dans des bases de données. Éliminer, trier, élaguer et échantillonner les archives."
            },
            new CompetencyLevelRequirement
            {
                Id = 382,
                DescEng = "Basic knowledge of the structure of the human body and the function of organisms and their parts, conditions typically observed during a disease state. Understanding of concepts related to the diagnosis of psychopathology. Knowledge of how to access various pharmacology resource documentation.",
                DescFre = "Connaissance de base de la structure du corps humain et de la fonction des organismes et de leurs parties, conditions typiques d'un état pathologique. Compréhension des concepts liés au diagnostic de la psychopathologie. Connaissance de la façon d'accéder à la documentation de diverses ressources pharmacologiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 383,
                DescEng = "Limited knowledge of the structure of the human body and the function of organisms and their parts, physical and biological abnormalities occurring within the body as a result of disease, concepts related to the diagnosis of psychopathology, process to preform physical exams and obtaining medical/health histories, and how to access various pharmacology resource documentation.",
                DescFre = "Connaissance limitée de la structure du corps humain et de la fonction des organismes et de leurs parties, des anomalies physiques et biologiques survenant dans le corps à la suite d'une maladie, des concepts liés au diagnostic de psychopathologie, du processus de préformation des examens physiques et de l'obtention des antécédents médicaux et sanitaires, et de l'accès à divers documents de pharmacologie."
            },
            new CompetencyLevelRequirement
            {
                Id = 384,
                DescEng = "Practical knowledge of signs and symptoms that warrant further examination, ordering diagnostic tests, treating acute and chronic illnesses, managing medications, and managing general health care and disease prevention. Understanding of how drugs work, their sides effects and possible drug interactions. Knowledge of diseases that are caused by immune system dysfunction. Understands the interaction of nutrients related to food intake, absorption, assimilation, biosynthesis, catabolism, and excretion. Experience in providing primary and preventative care.",
                DescFre = "Connaissance pratique des signes et des symptômes qui justifient un examen plus approfondi, la demande de tests diagnostiques, le traitement des maladies aiguës et chroniques, la gestion des médicaments, la gestion des soins de santé généraux et la prévention des maladies. Compréhension du fonctionnement des médicaments, de leurs effets secondaires et des interactions médicamenteuses possibles. Connaissance des maladies causées par un dysfonctionnement du système immunitaire. Comprend l'interaction des nutriments liés à l'ingestion, l'absorption, l'assimilation, la biosynthèse, le catabolisme et l'excrétion. Expérience dans la prestation de soins primaires et préventifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 385,
                DescEng = "Advanced knowledge in consultation with other healthcare providers, monitor patients, educate individuals, and family. Understanding of the coordination of timely nursing care for clients with various co-morbidities, complexity, and rapidly changing health statuses. Knowledge of providing care to clients with acute, chronic, and/or persistent health challenges (e.g. stroke, cardiovascular conditions, mental health and addiction, dementia, arthritis, diabetes). Advanced knowledge of workplace health and safety principles.",
                DescFre = "Connaissances avancées en consultation avec d'autres fournisseurs de soins de santé, surveiller les patients, éduquer les individus et la famille. Compréhension de la coordination des soins infirmiers en temps opportun pour les clients ayant des comorbidités, des complexités et des états de santé qui changent rapidement. Connaissance de la prestation de soins aux clients ayant des problèmes de santé aigus, chroniques ou persistants (p. ex., accident vasculaire cérébral [AVC], maladies cardiovasculaires, santé mentale et toxicomanie, démence, arthrite, diabète). Connaissance approfondie des principes de santé et de sécurité au travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 386,
                DescEng = "Expert knowledge in emerging therapies and treatments, and the provision of acute care. Knowledge of diet formulation in relation to special needs situations. Knowledge of current, and the development of new policies and directives related to the health and welfare of members.",
                DescFre = "Connaissances spécialisées dans les thérapies et les traitements émergents et dans la prestation de soins aigus. Connaissance de la formulation d'un régime alimentaire en relation avec des situations de besoins spéciaux. Connaissance des politiques et des directives actuelles et nouvelles en matière de santé et de bien-être des membres."
            },
            new CompetencyLevelRequirement
            {
                Id = 387,
                DescEng = "Applies principles of population health to implement strategies that promote health and disease prevention (e.g. promoting hand washing, immunization, helmet safety etc.). Provides timely information or resources.",
                DescFre = "Appliquer les principes de la santé de la population afin de mettre en œuvre des stratégies qui favorisent la santé et la prévention des maladies (p. ex. encourager le lavage des mains, l’immunisation, le port de casques, etc.). Fournir en temps opportun des renseignements ou des ressources."
            },
            new CompetencyLevelRequirement
            {
                Id = 388,
                DescEng = "Determines and implements preventive, therapeutic, and safety strategies based on ongoing client assessments, to prevent injury and the development of client complications. Proactively seeks and shares new information, knowledge and best practices for use in the provision of nursing care.",
                DescFre = "Définir et mettre en œuvre des stratégies préventives, thérapeutiques et de sécurité qui sont fondées sur des évaluations continues des clients, afin d’éviter les blessures et les complications chez les clients. Rechercher et faire part, en amont, de nouvelles connaissances et pratiques exemplaires ainsi que de nouveaux renseignements destinés à la prestation de soins infirmiers."
            },
            new CompetencyLevelRequirement
            {
                Id = 389,
                DescEng = "Provides nursing care based on critical inquiry and evidence-informed decision making. Performs therapeutic interventions safely (e.g. positioning, skin, and wound care, management of intravenous therapy and drainage tubes, and psychosocial interaction). Implements safe and evidence-informed medication practices. Informs others on the progress or unpreventable delays related to the delivery of services.",
                DescFre = "Offrir des soins infirmiers reposant sur l’esprit critique et la prise de décision fondée sur des données probantes. Effectuer des interventions thérapeutiques en toute sécurité (p. ex. positionnement, soins de la peau et des plaies, gestion des traitements par intraveineuse et des drains et interaction psychosociale). Mettre en place une utilisation sécuritaire des médicaments, fondée sur des données probantes. Informer les autres des progrès réalisés ou des retards inévitables en ce qui concerne la prestation des services."
            },
            new CompetencyLevelRequirement
            {
                Id = 390,
                DescEng = "Applies workplace health and safety principles, including bio-hazard prevention, and infection control practices, and appropriate protective devices when providing nursing care to prevent harm to clients, self, other health care workers and the public. Implements evidence-informed practices of pain prevention and pain management with clients while using pharmacological and non-pharmacological measures.",
                DescFre = "Appliquer des principes de santé et de sécurité au travail lors de la prestation de soins infirmiers, comme la prévention des risques biologiques, les pratiques en matière de lutte contre les infections et les dispositifs de protection appropriés, afin d’éviter de porter préjudice aux clients, à soi-même, aux autres travailleurs de la santé et aux citoyens.  Mettre en œuvre avec les clients des pratiques fondées sur des données probantes en matière de prévention et de traitement de la douleur tout en utilisant des méthodes pharmacologiques et non pharmacologiques."

            },
            new CompetencyLevelRequirement
            {
                Id = 391,
                DescEng = "Contributes to a culture that supports involvement in nursing or health care research through collaboration with others in conducting, participating in, and implementing research findings into practice. Exercises professional judgment when using organizational policies and procedures, or when practicing in the absence of organizational policies and procedures in relation to best practices. Continuously integrates quality improvement principles and activities into nursing practice.",
                DescFre = "Contribuer à une culture qui appuie la participation à la recherche en sciences infirmières ou en soins de santé grâce à la collaboration avec les autres dans la réalisation de travaux de recherche, la participation à ceux-ci et la mise en pratique des constatations. Exercer son jugement professionnel en ce qui concerne les pratiques exemplaires lors de l’utilisation de politiques et procédures organisationnelles ou lors de l’exercice de la profession en l'absence de celles-ci. Intégrer continuellement les principes et les activités d’amélioration de la qualité dans la pratique des sciences infirmières."
            },
            new CompetencyLevelRequirement
            {
                Id = 392,
                DescEng = "Establishes and maintains appropriate professional boundaries with clients and the health care team, including the distinction between social interaction and therapeutic relationships.",
                DescFre = "Établir et conserver des limites professionnelles appropriées avec les clients et l’équipe des soins de santé, notamment la distinction entre les interactions sociales et les relations thérapeutiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 393,
                DescEng = "Acts to minimize the potential influence of personal values, beliefs, and positional power on client assessment and care. Promotes a safe environment for clients, self, health care workers, and the public that addresses the unique needs of clients within the context of care.",
                DescFre = "Agir pour réduire au minimum l’influence possible des valeurs personnelles, des croyances et du pouvoir lié à un poste sur l’évaluation et le soin des clients. Favoriser un environnement sécuritaire pour les clients, soi-même, les autres travailleurs de la santé et les citoyens qui correspond aux besoins particuliers des clients dans un contexte de soins."
            },
            new CompetencyLevelRequirement
            {
                Id = 394,
                DescEng = "Acts in a way that demonstrates the distinction between ethical responsibilities and legal obligations and their relevance when providing nursing care. Engages in relational practice through a variety of approaches that demonstrate caring behaviours appropriate for clients. Shows consideration for the spiritual and religious beliefs and practices of clients. Makes informed decisions  about clients' health care, and respects their decisions.",
                DescFre = "Agir d’une manière qui montre la distinction entre les responsabilités déontologiques et les obligations légales ainsi que leur pertinence lors de la prestation de soins infirmiers. Établir des relations au moyen de diverses approches qui témoignent de comportements appropriés aux yeux des clients en matière de soins. Faire preuve de respect à l’égard des croyances et des pratiques religieuses et spirituelles des clients. Prendre des décisions éclairées sur les soins de santé des clients et respecter leurs décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 395,
                DescEng = "Respects and preserves clients’ rights based on the values in the Canadian Nurses Association (CNA) Code of Ethics for registered nurses and an ethical framework. Respects the principles of informed consent as it applies in multiple contexts (e.g. consent for care, refusal of treatment, release of health information, and consent for participation in research). Employs an ethical reasoning and decision-making process to address ethical dilemmas and situations of ethical distress. Accepts and provides care for all clients, regardless of gender, age, health status, lifestyle, sexual orientation, beliefs, and health practices. Advocates for safe, competent, compassionate, and ethical care for clients or their representatives, especially when they are unable to advocate for themselves.",
                DescFre = "Respecter et protéger les droits des clients en s’appuyant sur les valeurs du code de déontologie de l’Association des infirmières et infirmiers du Canada (AIIC) à l’intention des infirmiers autorisés ainsi que sur un cadre éthique. Respecter les principes du consentement éclairé puisqu’il s’applique à divers contextes (p. ex. consentement aux soins, refus de traitement, divulgation de renseignements médicaux et consentement à participer à la recherche). Appliquer un raisonnement et un processus décisionnel éthiques afin de régler des dilemmes éthiques et des situations de désarroi éthique. Accepter d’offrir des soins à tous les clients, sans égard à leur genre, leur âge, leur état de santé, leur mode de vie, leur orientation sexuelle, leurs croyances et leur hygiène de vie. Défendre une offre de soins sécuritaires empreints de compétence, de compassion et d’éthique pour les clients ou leurs représentants, surtout lorsqu’ils ne peuvent pas se défendre."
            },
            new CompetencyLevelRequirement
            {
                Id = 396,
                DescEng = "Honours ethical responsibilities and legal obligations related to maintaining client privacy, confidentiality, and security in all forms of communication, including social media. Engages in relational practice and uses ethical principles with the health care team to maximize collaborative client care.",
                DescFre = "Respecter ses responsabilités déontologiques et ses obligations légales en ce qui a trait à la protection de la vie privée, à la confidentialité et à la sécurité des clients dans toutes les formes de communication, y compris les médias sociaux. Établir des relations et utiliser des principes éthiques avec l’équipe des soins de santé afin d’optimiser les soins offerts en collaboration aux clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 397,
                DescEng = "Forecasts inventory, orders materials, and monitors and audits inventory.",
                DescFre = "Prévoir les stocks, commander les matières et assurer la surveillance et l’audit des stocks."
            },
            new CompetencyLevelRequirement
            {
                Id = 398,
                DescEng = "Employs the basics of supply-chain management.  Works with production systems, lead and cycle time, change orders, bills of material, and work orders. Packages and distributes products including labeling product inventory tags and bar codes.",
                DescFre = "Se servir des bases de la gestion de la chaîne d’approvisionnement. Travailler avec les systèmes de production, les délais de mise en production et le temps de cycle, les autorisations de modification, les bordereaux matières et les bons de travail. Emballer et distribuer des produits, ce qui comprend leur étiquetage à l’aide d’étiquettes d’inventaire et de codes à barres."
            },
            new CompetencyLevelRequirement
            {
                Id = 399,
                DescEng = "Employs warehouse management systems. Applies transportation methods, customs rules and regulations, export control, and the completion of paperwork.",
                DescFre = "Utiliser les systèmes de gestion d’entrepôt. Appliquer les méthodes de transport, la réglementation douanière, le contrôle des exportations et la production de documents."
            },
            new CompetencyLevelRequirement
            {
                Id = 400,
                DescEng = "Forecasts and plans resource needs. Employs E-business and direct shipments, automated materiel handling and distribution systems, and integrated supply chain information technology. Manages master scheduling and most paperwork.",
                DescFre = "Prévoir et planifier les besoins en ressources. Utiliser des expéditions directes et par entreprises électroniques, des systèmes de manutention et de distribution automatisés du matériel et des technologies de l’information intégrées à la chaîne d’approvisionnement. Gérer les plans directeurs et la plupart des documents."
            },
            new CompetencyLevelRequirement
            {
                Id = 401,
                DescEng = "Executes procurement operations from external supply sources. Prioritizes and sequences work. Executes plans and implements controls. Develops sharing and collaboration across the supply chain, with an eye to taxes and duties, shipping, freight, and legal aspects of customs and controls.  Maintains and protects the Canadian Coast Guard's intellectual property.",
                DescFre = "Effectuer des opérations d’approvisionnement à partir de sources d’approvisionnement externes. Établir l’ordre de priorité et l’ordre chronologique des travaux. Exécuter des plans et mettre en œuvre des contrôles. Développer les notions de partage et de collaboration dans la chaîne d’approvisionnement, tout en gardant un œil sur les taxes et droits, l’expédition, le fret et les aspects juridiques du contrôle douanier.  Conserver et protéger la propriété intellectuelle de la GCC."
            },
            new CompetencyLevelRequirement {Id = 402, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 403, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 404, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement
            {
                Id = 405,
                DescEng = "Prepares subject material for presentation to students according to an approved curriculum. Teaches students using a systematic plan of lectures, discussions, audio-visual presentations, and sports, games, and exercise regimes. Evaluates progress, determines individual needs of students, and discusses results with students and officials. Prepares and implements remedial programs for students requiring extra help. Participates in staff meetings, educational conferences, and teacher training workshops.",
                DescFre = "Préparer les sujets à présenter aux étudiants selon un programme d'études approuvé. Enseigne aux étudiants en utilisant un plan systématique de cours, de discussions, de présentations audiovisuelles, et de sports, de jeux et d'exercices. Évalue les progrès, détermine les besoins individuels des étudiants et discute des résultats avec les étudiants et les responsables. Prépare et met en œuvre des programmes de rattrapage pour les étudiants qui ont besoin d'une aide supplémentaire. Participe aux réunions du personnel, aux conférences éducatives et aux ateliers de formation des enseignants."
            },
            new CompetencyLevelRequirement
            {
                Id = 406,
                DescEng = "Plans, organizes, directs, controls, and evaluates the operations of recreation, sports, and fitness programs, and services. Provides technical and professional advice on recreation, sports, and fitness matters. Prepares budget estimates and develops policies and procedures to implement programs. Organizes and administers national and regional training, coaching, officiating, and other programs associated with physical education programs at the Canadian Coast Guard.",
                DescFre = "Planifie, organise, dirige, contrôle et évalue les activités des programmes et services de loisirs, de sport et de mise en forme. Fournit des conseils techniques et professionnels sur les questions de loisirs, de sports et de mise en forme. Prépare les prévisions budgétaires et élabore des politiques et des procédures pour la mise en œuvre des programmes. Organise et administre les programmes nationaux et régionaux de formation, d'entraînement, d'arbitrage et autres programmes associés aux programmes d'éducation physique de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement {Id = 407, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 408, DescEng = "N/A", DescFre = "v"},
            new CompetencyLevelRequirement {Id = 409, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement
            {
                Id = 410,
                DescEng = "Performs pre-operational checks, start-up and shut-down, general operation, stopping, starting, turning, driving forward and in reverse, parking, operating around personnel. Selects and secures  loads, picks-up and places, stacks and restocks, loads and unloads, and works with lifting crew. Performs operational maintenance such as refueling,  recharging (where appropriate), troubleshooting, and basic repairs. Hauls and dumps materials and equipment.",
                DescFre = "Assurer les vérifications avant l’utilisation, la mise en service et l’arrêt, le fonctionnement général, les manœuvres d’arrêt, de démarrage et de virage, la marche avant et la marche arrière, le stationnement et l’utilisation près de membres du personnel. Assurer la sélection et l’arrimage des chargements, la cueillette et le rangement, l’empilage et la reconstitution des stocks, les chargements et les déchargements et les travaux avec l’équipe de levage. Procéder à l’entretien en cours d’exploitation comme le ravitaillement, la recharge (le cas échéant), le dépannage et les réparations de base. Transporter et vider les matières et le matériel."
            },
            new CompetencyLevelRequirement
            {
                Id = 411,
                DescEng = "Supervises operational checks, loading protocols, stacking practices, confined space maneuvering, and maintenance efforts to ensure accuracy and safety. Provides training and scheduling for new forklift operators.",
                DescFre = "Superviser les vérifications du fonctionnement, les protocoles de chargement, les pratiques d’empilage, les manœuvres dans des espaces restreints et les efforts d’entretien afin d’en assurer la précision et la sécurité. Offrir de la formation et des échéanciers aux nouveaux conducteurs de chariots élévateurs à fourche."
            },
            new CompetencyLevelRequirement
            {
                Id = 412,
                DescEng = "Responds to basic information requests from principal lightkeepers and management.",
                DescFre = "Répondre aux demandes de renseignements de base formulées par les principaux gardiens de phare et la direction."
            },
            new CompetencyLevelRequirement
            {
                Id = 413,
                DescEng = "Uses basic gear to observe and report local phenomena to the organization.",
                DescFre = "Utiliser l’équipement de base pour observer et faire rapport des phénomènes locaux à l’organisme."
            },
            new CompetencyLevelRequirement
            {
                Id = 414,
                DescEng = "Selects appropriate collection equipment and methodology. Observes and reports on information within the maritime environment to forecast physical states like weather, ocean currents, or wave conditions. Offers on-site advice and support to internal stakeholders, when and where applicable.",
                DescFre = "Sélectionner la méthodologie et le matériel appropriés pour la collecte. Observer et produire des rapports sur des renseignements du milieu marin afin de prévoir des états physiques comme les conditions météorologiques, les courants océaniques ou la houle. Offrir des conseils et du soutien sur place aux intervenants internes, s’il y a lieu."
            },
            new CompetencyLevelRequirement
            {
                Id = 415,
                DescEng = "Provides the full range of observation and reporting services of local phenomena of all types. Develops and delivers training for lightkeepers. Predicts area weather and sea conditions based on past patterns.",
                DescFre = "Offrir l’ensemble des services d’observation et de signalement de tous les types de phénomènes locaux. Élaborer et offrir de la formation aux gardiens de phare. Prévoir les conditions météorologiques et les états de la mer d’une région en s’appuyant sur les tendances antérieures."
            },
            new CompetencyLevelRequirement
            {
                Id = 416,
                DescEng = "Reports on all aspects of lighthouse domain, including observed trends in meteorology, oceanography, and area shipping. Coordinates with others lightkeepers, managers, and boaters on area conditions. Provides options and suggestions to management on program improvement.",
                DescFre = "Faire rapport sur tous les aspects du domaine des phares, y compris les tendances observées dans la météorologie, l’océanographie et la navigation d’une région. Assurer la coordination avec d’autres gardiens de phare, gestionnaires et plaisanciers en ce qui a trait aux conditions d’une région. Fournir à la direction des options et des suggestions d’amélioration du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 417,
                DescEng = "Learns how to operate and maintain front line maintenance equipment.",
                DescFre = "Apprendre à faire fonctionner et à entretenir le matériel d’entretien de première ligne."
            },
            new CompetencyLevelRequirement
            {
                Id = 418,
                DescEng = "Operates and maintains front line gear at light stations.",
                DescFre = "Faire fonctionner et entretenir le matériel de première ligne aux stations de phares."
            },
            new CompetencyLevelRequirement
            {
                Id = 419,
                DescEng = "Operates and maintains mechanical and electrical equipment grounds, buildings, aerials, derricks, and equipment used to power light station equipment.",
                DescFre = "Faire fonctionner et entretenir les mises à la terre du matériel mécanique et électrique, les bâtiments, les antennes, les mâts de charge et le matériel servant à alimenter l’équipement des stations de phares."
            },
            new CompetencyLevelRequirement
            {
                Id = 420,
                DescEng = "Operates and maintains all lighthouse equipment. Trains assistant lightkeepers in equipment operation and maintenance.",
                DescFre = "Faire fonctionner et entretenir tout l’équipement des phares. Former les assistants des gardiens de phare en ce qui a trait au fonctionnement et à l’entretien de l’équipement."
            },
            new CompetencyLevelRequirement
            {
                Id = 421,
                DescEng = "Makes recommendations for maintenance of lighthouse equipment to management. Trains other light keepers. Advises management on light keeping protocols and procedures.",
                DescFre = "Présenter des recommandations à la direction des concernant l’entretien de l’équipement des phares. Former les autres gardiens de phare. Conseiller la direction sur les protocoles et procédures liés au métier de gardien de phare."
            },
            new CompetencyLevelRequirement
            {
                Id = 422,
                DescEng = "Basic knowledge on the use of equipment relative to the immediate task.",
                DescFre = "Connaissances de base de l’utilisation de l’équipement requis pour exécuter la tâche immédiate."
            },
            new CompetencyLevelRequirement
            {
                Id = 423,
                DescEng = "Limited knowledge in using a range of operational equipment in a given area of expertise.",
                DescFre = "Connaissance limitée de l’utilisation d’une gamme d’équipements opérationnels dans un domaine d’expertise donné."
            },
            new CompetencyLevelRequirement
            {
                Id = 424,
                DescEng = "Practical knowledge of the full range of operational equipment provided to perform operational tasks that demonstrate and are linked to understanding and impacting the marine domain.",
                DescFre = "Connaissance pratique de toute la gamme des équipements opérationnels fournis pour effectuer des tâches opérationnelles qui démontrent la compréhension du domaine maritime et qui ont une incidence sur le domaine maritime."
            },
            new CompetencyLevelRequirement
            {
                Id = 425,
                DescEng = "Advanced knowledge in the use of various types of operational equipment and surveillance gear in an operations center and instructing others in its use.",
                DescFre = "Connaissance avancée de l’utilisation de divers types d’équipements opérationnels et de matériel de surveillance dans un centre d’opérations et de la formation d’autres personnes sur cette utilisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 426,
                DescEng = "Expert knowledge in all the operational and surveillance gear in an operations center, their range of characteristics, including the development of instructions and procedures. Expert knowledge of the troubleshooting, preventative and corrective maintenance procedures.",
                DescFre = "Connaissance approfondie de tous les équipements opérationnels et équipements de surveillance d’un centre d’opérations, de leur gamme de caractéristiques, ce qui comprend l’élaboration d’instructions et de procédures. Connaissance approfondie des procédures de dépannage et d’entretien préventif et correctif."
            },
            new CompetencyLevelRequirement
            {
                Id = 427,
                DescEng = "Selects the right tool for the job. Uses basic hand and portable power tools, and their attachments correctly. Inspect tools for defects before use. Keeps tools clean and dry, and stores them properly after each use.",
                DescFre = "Sélectionner l’outil approprié pour la tâche à effectuer. Utiliser adéquatement des outils à main et électriques portatifs de base ainsi que leurs accessoires. Inspecter les outils avant de les utiliser pour s’assurer qu’ils ne sont pas défectueux. Garder les outils propres et secs et bien les ranger après chaque utilisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 428,
                DescEng = "Operates pneumatic hammers, vibrators and tampers as directed. Performs basic maintenance such as sharpening and lubricating. Tags damaged and defective tools to be removed from service.",
                DescFre = "Faire fonctionner des marteaux, des dispositifs vibreurs et des pilons pneumatiques selon les directives. Procéder à l’entretien de base comme l’aiguisage et la lubrification. Étiqueter les outils endommagés et défectueux pour qu’ils soient mis hors service."
            },
            new CompetencyLevelRequirement
            {
                Id = 429,
                DescEng = "Uses precision tools for work that requires high accuracy of shape, dimension and precise tolerances. Calibrates precision machine tools for dynamic balance as required.",
                DescFre = "Utiliser des outils de précision pour des travaux qui nécessitent une grande exactitude quant à la forme et à la dimension ainsi que des tolérances précises. Étalonner les machines-outils de précision pour l’équilibre dynamique, au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 430,
                DescEng = "Oversees equipment maintenance, tool inventories and, keeps records. Trains others in the use and maintenance of tools.",
                DescFre = "Superviser l’entretien de l’équipement ainsi que les stocks d’outils et tenir des registres. Former les autres sur l’utilisation et l’entretien des outils."
            },
            new CompetencyLevelRequirement
            {
                Id = 431,
                DescEng = "Defines and manages the maintenance and inspection program for tools in accordance with manufacturers recommendations.",
                DescFre = "Définir et gérer le programme d’entretien et d’inspection des outils en conformité avec les recommandations des fabricants."
            },
            new CompetencyLevelRequirement
            {
                Id = 432,
                DescEng = "Applies workplace safety procedures including the proper use and inspection of personal protective equipment (PPE). Safely interacts with all welding systems, including equipment, supplies, tools, and power sources.",
                DescFre = "Applique les procédures de sécurité sur le lieu de travail, y compris l'utilisation et l'inspection correctes des équipements de protection individuelle (EPI). Interagit en toute sécurité avec tous les systèmes de soudage, y compris l'équipement, les fournitures, les outils et les sources d'énergie."
            },
            new CompetencyLevelRequirement
            {
                Id = 433,
                DescEng = "Identifies, selects, uses, and maintains basic welding tools and accessories. Identifies and stores electrodes and filler materials. Interprets welding symbols, abbreviations, and joint designs. Reads and interprets basic prints. Fabricates parts from a shop print using both standard and metric linear measurements. Employs basic shielded metal arc welding procedures.",
                DescFre = "Identifie, sélectionne, utilise et entretient les outils et accessoires de soudure de base. Identifie et stocke les électrodes et les matériaux d'apport. Interprète les symboles de soudage, les abréviations et les dessins de joints. Lit et interprète les impressions de base. Fabrique des pièces à partir d'une impression d'atelier en utilisant des mesures linéaires standard et métriques. Emploie des procédures de base de soudage à l'arc métallique blindé."
            },
            new CompetencyLevelRequirement
            {
                Id = 434,
                DescEng = "Makes layout of materials (e.g. plate, structural, and pipe fabrication). Prepares material for weld procedure specifications (welding procedures specifications). Identifies, selects, and sets up oxyfuel equipment (e.g. cylinders, regulators, flame cutting apparatus). Makes fillet and groove welds in all positions on carbon steel.",
                DescFre = "Fait la disposition des matériaux (par exemple, fabrication de plaques, de structures et de tuyaux). Prépare les matériaux pour les spécifications des procédures de soudage (spécifications des procédures de soudage). Identifie, sélectionne et met en place l'équipement d'oxycombustion (par exemple, les cylindres, les régulateurs, les appareils d'oxycoupage). Effectue des soudures d'angle et des soudures en rainure dans toutes les positions sur l'acier au carbone."
            },
            new CompetencyLevelRequirement
            {
                Id = 435,
                DescEng = "Creates shielded metal arc welds on carbon steel plates, gas metal arc welds on plates and structural members, flux cored arc welds, and gas tungsten arc welds consistent with industry and safety standards. Lays out and cuts materials using plasma arc cutting procedures. Manipulates material using carbon arc gouging consistent with industry and safety standards. Employs metallurgy concepts and skills in the welding laboratory. Inspects and test welds (non-destructive and destructive).",
                DescFre = "Réalise des soudures à l'arc blindé sur des plaques d'acier au carbone, des soudures à l'arc sous gaz sur des plaques et des éléments de structure, des soudures à l'arc avec flux et des soudures à l'arc sous gaz tungstène, conformément aux normes industrielles et de sécurité. Découpe et pose de matériaux en utilisant des procédures de découpe au plasma. Manipule les matériaux en utilisant le gougeage à l'arc au carbone conformément aux normes industrielles et de sécurité. Emploie des concepts et des compétences métallurgiques dans le laboratoire de soudage. Inspecte et test les soudures (non destructives et destructives)."
            },
            new CompetencyLevelRequirement
            {
                Id = 436,
                DescEng = "Advises and trains on use and maintenance of tools, equipment, material handling, and safety equipment. Directs tasks related to welding activities on work sites and the storage of welding equipment and supplies. Establishes quality control for the quality of welding.  Advises senior leadership and stakeholders on best practices, processes, and strategies.",
                DescFre = "Conseille et forme sur l'utilisation et l'entretien des outils, des équipements, de la manutention et des équipements de sécurité. Dirige les tâches liées aux activités de soudage sur les sites de travail et au stockage du matériel et des fournitures de soudage. Établit le contrôle de la qualité du soudage. Conseille la haute direction et les parties prenantes sur les meilleures pratiques, les processus et les stratégies."
            },
            new CompetencyLevelRequirement
            {
                Id = 437,
                DescEng = "Basic knowledge of location and types of navigational aids in regions.",
                DescFre = "Connaissance de base de l'emplacement et des types d'aides à la navigation dans les régions."
            },
            new CompetencyLevelRequirement
            {
                Id = 438,
                DescEng = "Limited knowledge in supporting aids design and review regarding locations of aids, their operating characteristics, and maintenance scheduling.",
                DescFre = "Connaissances limitées en matière de soutien à la conception et à l'examen des aides en ce qui a trait à leur emplacement, à leurs caractéristiques de fonctionnement et à leur calendrier d'entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 439,
                DescEng = "Practical knowledge in the full range and type of all aids regionally and/or nationally, planning, and training functions in support of design review and scheduling maintenance with fleet partners.",
                DescFre = "Connaissance pratique de la gamme complète et du type de toutes les fonctions d'aide à l'échelle régionale et/ou nationale, de planification et de formation à l'appui de l'examen de la conception et de l'établissement du calendrier de maintenance avec les partenaires de la flotte."
            },
            new CompetencyLevelRequirement
            {
                Id = 440,
                DescEng = "Significant knowledge of all elements of the Aids to Navigation (AtoN) program, its operating and maintenance cost domain factors, horizon technologies, and training/consultation initiatives with local internal and external stakeholders.",
                DescFre = "Connaissance approfondie de tous les éléments du programme des aides à la navigation (AtoN), de ses facteurs de coûts d'exploitation et d'entretien, des technologies de l'horizon et des initiatives de formation/consultation avec les intervenants locaux internes et externes."
            },
            new CompetencyLevelRequirement
            {
                Id = 441,
                DescEng = "Excellent knowledge and awareness of all facets of the program and its relations internally and externally. Routinely provides insights to managers and stakeholders in advisory groups and with the media, First Nations, other government departments, industry, and the military.",
                DescFre = "Excellente connaissance et conscience de toutes les facettes du programme et de ses relations à l'interne et à l'externe. Fournit régulièrement de l'information aux gestionnaires et aux intervenants des groupes consultatifs ainsi qu'aux médias, aux Premières nations, aux autres ministères, à l'industrie et à l'armée."
            },
            new CompetencyLevelRequirement
            {
                Id = 442,
                DescEng = "Performs routine electrical and/or electronic maintenance. Conducts analysis based on standardized flowchart.",
                DescFre = "Effectue la maintenance électrique et/ou électronique de routine. Effectue des analyses sur la base d'un organigramme standardisé."
            },
            new CompetencyLevelRequirement
            {
                Id = 443,
                DescEng = "Recommends approaches on routine technical work, designs, and engineering change proposals (ECP) to meet desired compliance with electrical engineering principles, standards, codes, designs, and statutes, when and where applicable.",
                DescFre = "Recommande des approches pour les travaux techniques de routine, les conceptions et les propositions de modifications mécanique afin d'atteindre la conformité souhaitée avec les principes, les normes, les codes, les conceptions et les statuts du génie électrique, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 444,
                DescEng = "Makes decisions on non-routine and/or program matters requiring electrical and/or electronic technical expertise. Provides technical analysis. Mentors lower level members in the area of assignment. Reviews stock replenishment requisitions to ensure the items in current use and quantities ordered are realistic.",
                DescFre = "Prend des décisions sur des questions non routinières et/ou de programme nécessitant une expertise technique électrique et/ou électronique. Fournit une analyse technique. Encadre les membres de niveau inférieur dans la zone d'affectation. Examine les demandes de réapprovisionnement des stocks pour s'assurer que les articles utilisés et les quantités commandées sont réalistes."
            },
            new CompetencyLevelRequirement
            {
                Id = 445,
                DescEng = "Approves complex or new electrical engineering/technical designs and/or project/program specifications to meet desired compliance with principles, standards, codes, designs, and statutes. Addresses conflicting design constraints, when and where applicable.",
                DescFre = "Approuve les conceptions techniques ou d'ingénierie électrique complexes ou nouvelles et/ou les spécifications de projets/programmes pour répondre à la conformité souhaitée aux principes, normes, codes, conceptions et statuts. Traite les contraintes de conception contradictoires, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 446,
                DescEng = "Approves final proposals for large scale electrical engineering and/or program areas. Represents the Canadian Coast Guard as an expert in electrical review and design.",
                DescFre = "Approuve les propositions finales pour l'ingénierie électrique à grande échelle et/ou les domaines de programme. Représente la Garde côtière canadienne en tant qu'expert en matière d'examen et de conception électrique."
            },
            new CompetencyLevelRequirement
            {
                Id = 447,
                DescEng = "Basic knowledge of radio frequency system and components that enables the propagation of radio waves.",
                DescFre = "Connaissance de base du système de fréquence radioélectrique et de ses composants qui permettent la propagation des ondes radioélectriques."
            },
            new CompetencyLevelRequirement
            {
                Id = 448,
                DescEng = "Limited knowledge of radio waves attributes such as amplitudes with units of watts, phases, modulations, spread spectrum. Knowledge of antenna parameters including desired frequency, gain, bandwidth, impedance, and polarization.",
                DescFre = "Connaissance limitée des caractéristiques des ondes radioélectriques comme l’amplitude en watts, les phases, les modulations et le spectre étalé. Connaissance des paramètres d’antenne, notamment la fréquence visée, le gain, la largeur de bande, l’impédance et la polarisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 449,
                DescEng = "Practical knowledge of radio waves attributes such as waveforms (continuous range of frequencies) and alteration of attributes output/input by orthogonal frequency-division multiplexing, amplitude-shift keying, frequency-shift keying, phase-shift keying, quadrature amplitude modulation. Knowledge of what affects propagation of radio waves and process to select the appropriate propagation model necessary.",
                DescFre = "Connaissance pratique des caractéristiques des ondes radioélectriques, comme les formes d’ondes (gamme continue de fréquences), ainsi que de la modification des caractéristiques à la sortie et à l’entrée par l’entremise du multiplexage par répartition orthogonale de la fréquence, de la modulation par déplacement d’amplitude, de la modulation par déplacement de phase et de la modulation d’amplitude en quadrature. Connaissance de ce qui touche la propagation des ondes radioélectriques et du processus de sélection du modèle de propagation approprié et nécessaire."
            },
            new CompetencyLevelRequirement
            {
                Id = 450,
                DescEng = "Advanced knowledge of losses and dispersion features of radio waves and main compensation scheme including fast fading, signal fading, extension of radio waves delay, diffraction loss and penetration loss. Advanced knowledge in testing transmitting platform including the transmitting antenna, feeder, high-frequency signal source, and antenna support as well as the receiving subsystem including the test receiver, global positioning system (GPS) receiver, test software, and portable computer.",
                DescFre = "Connaissance approfondie des caractéristiques d’atténuation et de dispersion des ondes radioélectriques ainsi que du principal mécanisme de compensation, y compris l’évanouissement radioélectrique rapide, l’évanouissement de signal, la prolongation du retard des ondes radioélectriques, l’affaiblissement par diffraction et la perte de pénétration. Connaissance approfondie de la mise à l’essai de la plateforme de transmission, y compris l’antenne d’émission, la ligne d’alimentation, la source du signal haute fréquence et le support d’antenne, ainsi que du sous-système de réception dont le récepteur d’essai, le récepteur du système mondial de localisation (GPS), le logiciel d’essai et l’ordinateur portable."
            },
            new CompetencyLevelRequirement
            {
                Id = 451,
                DescEng = "Expert knowledge in major electrical and mechanical specifications of antenna and selection of antenna pattern. Knowledge of processes resolution strategies to complex problems not readily solved by other means. Intricate knowledge of emerging network technology.",
                DescFre = "Connaissance spécialisée des principales spécifications électriques et mécaniques de l’antenne et de la sélection d’un diagramme de gain d’antenne. Connaissance de stratégies de résolution des processus pour des problèmes complexes qui n’ont pas été résolus facilement par d’autres moyens. Connaissance approfondie des nouvelles technologies du réseau."
            },
            new CompetencyLevelRequirement {Id = 452, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 453, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement {Id = 454, DescEng = "N/A", DescFre = "S. O."},
            new CompetencyLevelRequirement
            {
                Id = 455,
                DescEng = "Interprets drawings, blueprints, schematics and electrical code specifications to determine the layout of industrial electrical equipment installations. Installs, examines, replaces, or repairs electrical wiring, receptacles, switch boxes, conduits, feeders, fibre-optic and coaxial cable assemblies, lighting fixtures and other electrical components. Tests electrical and electronic equipment and components for continuity, current, voltage, and resistance. Maintains, repairs, tests, and installs electrical motors, generators, alternators, industrial storage batteries, and hydraulic and pneumatic electrical control systems. Troubleshoots, maintains, and repairs industrial, electrical, and electronic control systems and other related devices.",
                DescFre = "Interpréter les dessins, les plans détaillés, les schémas et les prescriptions du code de l’électricité pour déterminer la disposition des installations industrielles d’équipement électrique. Installer, vérifier, remplacer ou réparer le câblage électrique, les prises de courant, les boîtes d’interrupteur, les tubes isolants, les artères d’alimentation, les montages de câbles à fibres optiques et coaxiaux, les appareils d'éclairage et autres composants électriques. Procéder aux essais de matériel et de composants électriques et électroniques pour en vérifier la continuité, le courant, la tension et la résistance. Entretenir, réparer, installer et procéder aux essais des moteurs électriques, générateurs, alternateurs, batteries d'accumulateurs industriels et systèmes hydrauliques et pneumatiques de commande électrique. Rechercher la cause des pannes, entretenir et réparer les systèmes d’électronique industrielle, de commande électrique et électronique et autres dispositifs connexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 456,
                DescEng = "Directs the electrical maintenance activities and managing work assignments. Inspects and reports on work performed. Recommends updating maintenance guidelines, procedures, standard work orders, preventative maintenance tasks, materials, parts, and labor estimates. Collaborates in the development and validation of maintenance procedures.",
                DescFre = "Diriger les activités d’entretien électrique et gérer les affectations de travail. Inspecter les travaux réalisés et produire des rapports. Recommander la mise à jour des lignes directrices, des procédures, des bons de travail courants, des tâches d’entretien préventif et des estimations concernant les matériaux, les pièces et la main-d'œuvre en matière d’entretien. Collaborer à l’élaboration et à la validation des procédures d’entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 457,
                DescEng = "Performs pre-start checks, starts and stops equipment in automatic, semi-automatic and manual modes. Adjusts temperature controls as required. Monitors equipment to ensure operation within established parameters.",
                DescFre = "Effectuer les vérifications avant le démarrage et démarrer et arrêter l’équipement en mode automatique, semi-automatique ou manuel. Mettre au point la régulation de la température au besoin. Surveiller l’équipement pour qu’il fonctionne selon les paramètres établis."
            },
            new CompetencyLevelRequirement
            {
                Id = 458,
                DescEng = "Performs preventative maintenance on climate-control systems by following a checklist of parts and operations that need to be tested such as compressors, condensers, electrical connections and motor operations.",
                DescFre = "Effectuer l’entretien préventif des systèmes de régulation de climatisation en suivant des listes de vérification concernant les pièces et opérations qui doivent être mises à l’essai, notamment les compresseurs, les condenseurs, les raccordements électriques et le fonctionnement des moteurs."
            },
            new CompetencyLevelRequirement
            {
                Id = 459,
                DescEng = "Diagnoses malfunctions and defects in equipment by applying troubleshooting methods. Replaces parts and runs tests to ensure the systems is working properly following repairs. Recharges systems with refrigerant, checks and test regulators and, calibrates systems.",
                DescFre = "Déceler les défaillances et les défauts de l’équipement en appliquant des méthodes de dépannage. Remplacer des pièces et procéder à des essais pour s’assurer que les systèmes fonctionnent correctement après les réparations. Recharger les systèmes en frigorigènes, vérifier et mettre à l’essai les régulateurs et échelonner les systèmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 460,
                DescEng = "Assembles and installs climate-control systems including components such as motors, controls, gauges, valves, circulating pumps, condensers, humidifiers, evaporators and compressors. Reads and interprets blueprints, drawings and sketches to determine specifications and calculate requirements.",
                DescFre = "Monter et installer les systèmes de régulation de climatisation, y compris des composants comme les moteurs, les commandes, les jauges, les valves, les pompes de circulation, les condenseurs, les humidificateurs, les évaporateurs et les compresseurs. Lire et interpréter des plans détaillés, des schémas et des esquisses pour définir les spécifications et calculer les besoins."
            },
            new CompetencyLevelRequirement
            {
                Id = 461,
                DescEng = "Upgrades systems to satisfy new regulations or meet new standards. Reviews designs and makes recommendations for considerations such as optimal temperature control and energy efficiency.",
                DescFre = "Mettre à niveau les systèmes pour respecter les nouveaux règlements ou les nouvelles normes. Examiner les plans et formuler des recommandations quant aux facteurs à considérer, notamment la régulation optimale de la température et l’efficacité énergétique."
            },
            new CompetencyLevelRequirement
            {
                Id = 462,
                DescEng = "Prepares reports, plans, and forecasts. Liaises with managers to understand and develop explanations that ensures alignment of the Canadian Coast Guard's workforce with the government’s priorities, and the organization’s mission, strategic plan, and budgetary resources.",
                DescFre = "Prépare des rapports, des plans et des prévisions. Assurer la liaison avec les gestionnaires pour comprendre et élaborer des explications qui permettent d'aligner l'effectif de la Garde côtière canadienne sur les priorités du gouvernement, ainsi que sur la mission, le plan stratégique et les ressources budgétaires de l'organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 463,
                DescEng = "Develops specialized reports. Explains program variances and implications. Analyzes operational performance and evaluates alternative outcomes of business strategies. Identifies the critical points in the Government of Canada's budget planning cycle and how they are used to devise strategy for the Coast Guard.",
                DescFre = "Élabore des rapports spécialisés. Explique les écarts et les implications des programmes. Analyse les performances opérationnelles et évalue les résultats alternatifs des stratégies opérationnelles. Identifie les points critiques du cycle de planification budgétaire du gouvernement du Canada et la façon dont ils sont utilisés pour concevoir la stratégie de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 464,
                DescEng = "Builds and presents new analytical approaches. Analyzes financial implications of policy, program, and project proposals, and alternative strategies. Researches and prepares the groundwork for partnering agreements. Determines expenditure and cost requirements based on the three parliamentary supply periods, the main estimates, and the supplementary estimates process.",
                DescFre = "Construit et présente de nouvelles approches analytiques. Analyse les implications financières des propositions de politiques, de programmes et de projets, ainsi que des stratégies alternatives. Effectue des recherches et prépare le terrain pour des accords de partenariat. Détermine les dépenses et les coûts nécessaires en fonction des trois périodes de crédits parlementaires, des prévisions budgétaires principales et du processus des prévisions supplémentaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 465,
                DescEng = "Assesses budgets and ensures alignment with the organization’s goals. Plays a challenge role in assessing the financial implications of program and project proposals and the quality of related financial information. Compiles data and recommendations of current supply and expenditure and future needs based on program requirements within the Coast Guard.",
                DescFre = "Évalue les budgets et s'assure qu'ils sont conformes aux objectifs de l'organisation. Joue un rôle de défi en évaluant les implications financières des propositions de programmes et de projets et la qualité des informations financières qui s'y rapportent. Compile des données et des recommandations sur l'offre et les dépenses actuelles et les besoins futurs en fonction des exigences des programmes au sein de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 466,
                DescEng = "Advises on, and implements, government-wide standards for control to promote a sound management framework. Guides, advises, and makes recommendations to senior management on expenditure results and future needs based on the government's expenditure plan and budgetary allocations.",
                DescFre = "Conseille et met en œuvre des normes de contrôle à l'échelle du gouvernement afin de promouvoir un cadre de gestion saine. Guide, conseille et fait des recommandations à la haute direction sur les résultats des dépenses et les besoins futurs en fonction du plan de dépenses et des allocations budgétaires du gouvernement."
            },
            new CompetencyLevelRequirement
            {
                Id = 467,
                DescEng = "Identifies and applies relevant cost accounting techniques (e.g. activity-based costing).",
                DescFre = "Identifie et applique les techniques de comptabilité analytique pertinentes (par exemple, la comptabilité par activités)."
            },
            new CompetencyLevelRequirement
            {
                Id = 468,
                DescEng = "Develops cost-accounting techniques to specifically address departmental/organizational needs. Applies generally accepted accounting principles, including accrual accounting and the financial information strategy.",
                DescFre = "Développe des techniques de comptabilité analytique pour répondre spécifiquement aux besoins des départements et des organisations. Applique les principes comptables généralement reconnus, y compris la comptabilité d'exercice et la stratégie d'information financière."
            },
            new CompetencyLevelRequirement
            {
                Id = 469,
                DescEng = "Participates with senior management in strategic decision-making as a result of cost-accounting information.",
                DescFre = "Participe avec la haute direction à la prise de décisions stratégiques grâce aux informations de la comptabilité analytique."
            },
            new CompetencyLevelRequirement
            {
                Id = 470,
                DescEng = "Accounts for expenditures (e.g. line objects, standard objects for sound expenditure management). Presents and discusses applicability of, and arguments for and against, alternative accounting principles.",
                DescFre = "Comptabilise les dépenses (par exemple, les articles d'exécution, les articles standard pour la bonne gestion des dépenses). Présente et examine l'applicabilité de principes comptables alternatifs et les arguments pour et contre ceux-ci."
            },
            new CompetencyLevelRequirement
            {
                Id = 471,
                DescEng = "Provides information and advice in the development of expenditure reports (within department, Parliament and Public Accounts). Anticipates the effect of new accounting principles on the organization and assists in the transition. Represents the Canadian Coast Guard to the Chief Financial Officer at Fisheries and Oceans Canada (DFO), the Auditor General, Public Accounts, Treasury Board, etc.",
                DescFre = "Fournit des informations et des conseils pour l'élaboration des rapports de dépenses (au sein du ministère, du Parlement et des comptes publics). Anticipe l'effet des nouveaux principes comptables sur l'organisation et aide à la transition. Représente la Garde côtière canadienne auprès du dirigeant principal des finances de Pêches et Océans Canada (MPO), du vérificateur général, des comptes publics, du Conseil du Trésor, etc."
            },
            new CompetencyLevelRequirement {Id = 472, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 473, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 474, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement
            {
                Id = 475,
                DescEng = "Participates in relationship building exercises. Researches community interests, Government of Canada policies on Indigenous relations. Records inputs. Maintains open communication lines with the bands. Provides recommendation on strategic approaches. Liaises with Canadian Coast Guard programs.",
                DescFre = "Participe à des exercices de renforcement des relations. Effectue des recherches sur les intérêts des communautés et sur les politiques du gouvernement du Canada en matière de relations avec les Autochtones. Enregistre les contributions. Entretient des lignes de communication ouvertes avec les bandes. Fournir des recommandations sur les approches stratégiques. Assure la liaison avec les programmes de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 476,
                DescEng = "Establishes relations with all concerned bands on a given agenda. Clarifies community interest. Develops strategies that provide interest based outcomes and consistencies of approach, by considering all inputs over time and communicating clearly. Monitors and clarifies consultation specificities and sensitivities between Indigenous bands and Canadian Coast Guard programs and initiatives. Follows up on negotiated deliverables with the overall goal to establish lasting trust. Provides key information on Indigenous files to management.",
                DescFre = "Etablit des relations avec tous les groupes concernés sur un agenda donné. Clarifie les intérêts de la communauté. Développe des stratégies qui fournissent des résultats basés sur les intérêts et une approche cohérente, en considérant tous les apports au fil du temps et en communiquant clairement. Surveille et clarifie les spécificités et les sensibilités des consultations entre les bandes autochtones et les programmes et initiatives de la Garde côtière canadienne. Assure le suivi des résultats négociés dans le but général d'établir une confiance durable. Fournit des informations clés sur les dossiers autochtones à la direction."
            },
            new CompetencyLevelRequirement {Id = 477, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 478, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement {Id = 479, DescEng = "N/A", DescFre = "S.O."},
            new CompetencyLevelRequirement
            {
                Id = 480,
                DescEng = "Inspects and evaluates quality assurance systems, processes, equipment, products, materials, and associated components including electronic equipment used in shipbuilding trade measurement. Recommends enforcement of statutes, regulations, standards, specifications, or quality assurance policies, procedures and techniques. Investigates accidents, defects, and/or disputes.",
                DescFre = "Inspecter et évaluer les systèmes, les processus, l’équipement, les produits, les matériaux et les composantes connexes d’assurance de la qualité, notamment le matériel électronique utilisé pour les mesures commerciales de la construction navale. Recommander l’application de lois, de règlements, de normes, de spécifications ou de politiques, procédures et techniques d’assurance de la qualité. Enquêter sur les accidents, les défauts ou les litiges."
            },
            new CompetencyLevelRequirement
            {
                Id = 481,
                DescEng = "Writes standards, specifications, procedures, or manuals related to inspection and evaluation of shipbuilding activities. Liaises with shipbuilding representatives on enforcing inspection items, defects, and deficiencies and offers recommendations for improvement. Plans, develops, and conducts training in these activities.",
                DescFre = "Rédiger des normes, des spécifications, des procédures ou des manuels liés à l’inspection et à l’évaluation des activités de construction navale. Assurer la liaison avec des représentants de la construction navale à l’égard de l’application des éléments d’inspection ainsi que des défauts et lacunes et présenter des recommandations d’amélioration. Planifier, élaborer et offrir de la formation sur ces activités."
            },
            new CompetencyLevelRequirement
            {
                Id = 482,
                DescEng = "Basic knowledge of the Vessels of Concern Program area and how it is a part of the Oceans Protection Plan (OPP) mandate, based on training.",
                DescFre = "Connaissance de base du secteur du programme des navires préoccupants et de la façon dont il fait partie du mandat du PPO, en s’appuyant sur la formation."
            },
            new CompetencyLevelRequirement
            {
                Id = 483,
                DescEng = "Knowledge of the elements within the Vessels of Concern program area. Knowledge of DFO’s Small Craft Harbours Abandoned and Wrecked Vessels Removal Program and some of the stakeholders to be consulted prior to decisions being made. Knowledge of the different roles and responsibilities of the DFO, Transport Canada, and Coast Guard in the implementation of the Vessels of Concern Program. Awareness of the established enforcement regime. Knowledge of the program issues and challenges related to the hundreds of problem vessels in Canadian waters.",
                DescFre = "Connaissance des composantes du secteur du programme des navires préoccupants. Connaissance du programme d’élimination des épaves et des navires abandonnés de ports pour petits bateaux du MPO et de certains intervenants qui devront être consultés avant la prise de décisions. Connaissance des divers rôles et responsabilités du MPO, de Transports Canada et de la Garde côtière canadienne (GCC) dans la mise en œuvre du programme des navires préoccupants. Connaissance du régime d’application de la loi en place. Connaissance des enjeux et des défis du programme en ce qui concerne les centaines de navires problématiques dans les eaux canadiennes."
            },
            new CompetencyLevelRequirement
            {
                Id = 484,
                DescEng = "Practical knowledge of the Inventory and Assessments of Vessels of Concern, the Abandoned Boats Program, and the Small Craft Harbours Abandoned and Wrecked Vessels Removal Program. Knowledge of key internal partners, to be consulted with prior to decisions being taken. Detailed knowledge of the process for the removal of dilapidated vessels left on property for which DFO/CCG are responsible and actions to be taken directly. Detailed knowledge of the established enforcement regime that authorizes the monetary penalties, creates regulatory offences (summary convictions and indictments), and sets out a penalty regime to deter non-compliance.",
                DescFre = "Connaissance pratique de l’inventaire et des évaluations du programme des navires préoccupants, du programme de bateaux abandonnés et du programme d’élimination des épaves et des navires abandonnés des ports pour petits bateaux. Connaissance des principaux partenaires internes qui devront être consultés avant la prise de décisions. Connaissance approfondie du processus d’élimination des navires délabrés situés sur des propriétés qui sont sous la responsabilité  du MPO et de la GCC ainsi que des mesures à prendre directement. Connaissance approfondie du régime d’application de la loi en place qui autorise les sanctions pécuniaires, crée des infractions réglementaires (déclarations sommaires de culpabilité et actes d’accusation) et établit un régime de sanctions pour prévenir la non-conformité."
            },
            new CompetencyLevelRequirement
            {
                Id = 485,
                DescEng = "Advanced knowledge of all internal and external stakeholders involved in the decision and resolution processes related to Vessels of Concern. In-depth knowledge of coastal and shoreline communities. In-depth awareness on the offenses and punishments possible and impacts related to offense enforcement in relation to the Vessels of Concern Program. Familiarity with the program employed within Federal and State jurisdictions within the United States and how they may be leveraged for program needs.",
                DescFre = "Connaissance approfondie de tous les intervenants internes et externes qui participent aux processus de décision et de résolution relatifs au programme des navires préoccupants. Connaissance approfondie des collectivités côtières et riveraines. Connaissance approfondie des infractions et sanctions possibles ainsi que des répercussions liées à l’application de la loi en matière d’infraction dans le contexte du programme des navires préoccupants. Bonne connaissance du programme utilisé dans les administrations fédérales et les États des États-Unis et de la façon dont il serait possible d’en tirer profit pour les besoins du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 486,
                DescEng = "Expert knowledge of the Inventory and Assessments of Vessels of Concern, the Abandoned Boats Program, and the Small Craft Harbours Abandoned and Wrecked Vessels Removal Program. Extensive knowledge of the duty to consult stipulations per legislation.",
                DescFre = "Connaissance spécialisée de l’inventaire et des évaluations du programme des navires préoccupants, du programme de bateaux abandonnés et du programme d’élimination des épaves et des navires abandonnés des ports pour petits bateaux. Vaste connaissance des dispositions de l’obligation de consulter en vertu de la loi."
            },
            new CompetencyLevelRequirement
            {
                Id = 487,
                DescEng = "Provides SITREPS on icebreakers’ position. Understand the established and applicable operational procedures within IB. Applies knowledge of basic computer software and hardware in a productive way. Understands charts and maps, and knows their specific characteristics.",
                DescFre = "Fournir des rapports de situation (RAPSIT) sur la position des brise-glaces. Comprendre les procédures opérationnelles établies et applicables en matière de déglaçage. Appliquer de manière productive des connaissances sur les logiciels et le matériel informatique de base. Comprendre les graphiques et les cartes et connaître leurs caractéristiques respectives."
            },
            new CompetencyLevelRequirement
            {
                Id = 488,
                DescEng = "Follows transit of vessels through ice within AOR. Calculates AIRSS data. Monitors ice conditions using ice charts. Receives icebreakers assistance requests directly from ships owners, ship operators or by MCTS. Uses IODIS as required. Receives requests for ice routing from VTS and ships; asks for all necessary information in order to action them, consolidates it in a standardized way and forwards the requests to the ISS. Uses appropriate email templates for ship’s tasking’s. Prepares the daily SitRep of CCG assets’ location for internal partners. General understanding the ice Egg code.",
                DescFre = "Suivre le passage des navires dans les glaces d’une zone de responsabilité (AOR). Calculer les données du système des régimes de glaces pour la navigation dans l’Arctique (SRGNA). Surveiller l’état des glaces au moyen de cartes des glaces. Recevoir les demandes d’aide des brise-glaces directement de la part des propriétaires ou exploitants des navires ou encore des Services de communication et de trafic maritimes (SCTM). Utiliser le système d’information et de données pour les opérations de déglaçage (SIDOD), au besoin. Recevoir les demandes de conseil sur la navigation dans les glaces de la part des Service du trafic maritime (STM) et des navires, demander tous les renseignements nécessaires pour y donner suite, en faire la synthèse de façon normalisée et transmettre les demandes aux spécialistes du service des glaces (SSG). Utiliser les modèles appropriés de courriels pour l’affectation des navires. Préparer le RAPSIT quotidien sur la position des actifs de la GCC pour les partenaires internes. Comprendre le code de l'œuf en général."
            },
            new CompetencyLevelRequirement
            {
                Id = 489,
                DescEng = "Monitors progress and behaviour of vessels in ice in order to detect problematic situations. Assesses effectiveness of response. Uses appropriate software (such as Exact Earth) to track ships and verify if following given ice routing. Verifies the validity of received AIRSS data from ship by comparing to own calculation. Tasks CCG icebreakers through ROC. Monitors ice conditions using a variety of tools (satellite pictures, ship messages, overflights, etc.). Prepares and delivers written tasking’s to icebreakers, through ROC. Verifies the navigational safety aspect of the general ice route produced by the ISS. Coordinates requests for specific ice routing with ISS, verifies safety, and delivers information directly to ship or through MCTS. Fills required information in IODIS system when initiating ice tasking’s for CCG ships. Answers clients and stakeholders questions, by phone or email. Applies knowledge of reporting systems (such as IODIS), mapping systems (such as INNAV and Exact Earth) and other related software in daily operations.",
                DescFre = "Surveiller la progression et le comportement des navires dans les glaces afin de déceler les situations problématiques. Évaluer l’efficacité des interventions. Utiliser le logiciel approprié (comme Exact Earth) pour surveiller les navires et vérifier s’ils suivent une voie navigable dans les glaces donnée. Vérifier la validité des données du SRGNA qui ont été reçues de navires en les comparant à ses propres calculs. Affecter des brise-glaces de la GCC par l’entremise du Centre des opérations régionales (COR). Surveiller l’état des glaces au moyen de divers outils (images satellites, messages de navires, survols, etc.). Préparer et présenter par écrit les affectations aux brise-glaces par l’entremise du COR. Vérifier la sécurité de navigation de la voie navigable générale dans les glaces qui a été produite par les SSG. Assurer la coordination des demandes de voies navigables précises dans les glaces avec les SSG, vérifier la sécurité de celles-ci et fournir de l’information directement aux navires ou par l’entremise des SCTM. Effectuer la saisie des renseignements requis dans le SIDOD au début de l’affectation des navires de la GCC à briser la glace. Répondre aux questions des clients et des intervenants par téléphone ou courriel. Appliquer ses connaissances des systèmes de production de rapports (comme le SIDOD), des systèmes cartographiques (comme le système intégré d’information sur la navigation maritime [INNAV] et Exact Earth) et d’autres logiciels connexes dans les activités quotidiennes."
            },
            new CompetencyLevelRequirement
            {
                Id = 490,
                DescEng = "Monitors for changes in ice conditions, weather and other environmental factors, and liaises with EC ISS appropriately, in order to detect potential problems well in advance. Initiates the issuance of the NOTSHIPs as required for Ice control zone. Creates seasonal, periodic and post-incidents report for internal partner and/or industry. Is able to develop alternate or new strategies that may fall outside SOPs in order to resolve a situation. Has detailed knowledge of AOR characteristics which play a role in IB operations or influence the outcome of the program. Identifies new possibilities /capabilities to improve the existing systems and practices. Evaluates impacts of changes to regulations, orders and standards on work practices. Provides departmental interpretation of key IB legislation, orders and standards to personnel, partners, and clients.",
                DescFre = "Surveiller les changements dans l’état des glaces, les conditions météorologiques et les autres facteurs du milieu et assurer la liaison appropriée avec les SSG d'Environnement Canada afin de déceler des problèmes possibles bien avant qu’ils ne surviennent. Amorcer la publication des NOTSHIP, au besoin, pour les zones de contrôle de la navigation dans les glaces. Créer des rapports saisonniers, périodiques et après incidents pour les partenaires internes ou l’industrie. Être en mesure d’élaborer d’autres stratégies ou de nouvelles stratégies qui peuvent dépasser le cadre des procédures opérationnelles normalisées (PON) afin de régler une situation. Avoir des connaissances approfondies des caractéristiques des AOR qui jouent un rôle dans les opérations de déglaçage ou qui influencent les résultats du programme. Définir de nouvelles possibilités ou capacités pour améliorer les pratiques et systèmes actuels. Évaluer l’incidence des modifications apportées aux règlements, aux ordonnances et aux normes sur les pratiques de travail. Offrir au personnel, aux partenaires et aux clients une interprétation ministérielle des principales lois, ordonnances et normes concernant le déglaçage."
            },
            new CompetencyLevelRequirement
            {
                Id = 491,
                DescEng = "Implements new possibilities/capabilities to improve the existing systems and practices. Reviews and creates SOPs. Provides official advice regarding regulation for the department. Provides recommendations to legislative texts.",
                DescFre = "Mettre en œuvre de nouvelles possibilités ou capacités pour améliorer les pratiques et systèmes actuels. Examiner et créer des PON. Formuler des avis officiels en ce qui concerne la réglementation pour le Ministère. Formuler des recommandations en ce qui a trait aux textes législatifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 492,
                DescEng = "Maintains an ongoing Inventory and Assessments  of wrecked and abandoned vessels, including updated risk assessments to help prioritize future actions on high risk vessels.",
                DescFre = "Tenir à jour un inventaire permanent et des évaluations continues des épaves et des navires abandonnés, y compris la mise à jour des évaluations des risques, afin d’établir un ordre de priorité des mesures ultérieures concernant les navires à risque élevé."
            },
            new CompetencyLevelRequirement
            {
                Id = 493,
                DescEng = "Responds to area queries about and reports of wrecked and abandoned vessels. Establishes contacts with other government departments and the public. Participates in exercises. Conducts some site investigations.",
                DescFre = "Répondre aux demandes de renseignements de la région sur les épaves et les navires abandonnés et en faire rapport. Établir des relations avec les autres ministères et les citoyens. Participer aux exercices. Mener certaines enquêtes sur les lieux."
            },
            new CompetencyLevelRequirement
            {
                Id = 494,
                DescEng = "Conducts in-depth investigations of regional reports of wrecked and abandoned vessels, including, where possible, contacting vessel owners and logging all information. Liaises with operational stakeholders where necessary. Drafts reports and recommendations.",
                DescFre = "Mener des enquêtes approfondies à l’égard des rapports régionaux portant sur des épaves et des navires abandonnés, y compris communiquer avec les propriétaires des navires, si possible, et enregistrer tous les renseignements. Assurer la liaison avec les intervenants opérationnels, le cas échéant. Rédiger des rapports et des recommandations."
            },
            new CompetencyLevelRequirement
            {
                Id = 495,
                DescEng = "Conducts risk assessments and reports on investigative findings and trends, regionally and/or nationally. Improves and increases contact with coastal communities with respect to vessels of concern. Educates on the offences and punishments associated with wrecked and abandoned vessels and the roles of government departments and the Coast Guard.",
                DescFre = "Réaliser des évaluations des risques et faire rapport des conclusions des enquêtes et des tendances, à l’échelle régionale ou nationale. Améliorer et renforcer les relations avec les collectivités côtières en ce qui concerne le programme des navires préoccupants. Sensibiliser la population aux infractions et aux sanctions liées aux épaves et aux navires abandonnés ainsi qu’aux rôles des ministères et de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 496,
                DescEng = "Advises internal and external stakeholders, including the private sector(s), on how the program is to be advanced with knowledge of financial and personnel resources allocation. Champions the program nationally with the public and senior management. Recommends mandate or scope changes.",
                DescFre = "Informer les intervenants internes et externes, y compris le secteur privé, de la façon dont le programme devra progresser compte tenu de l’affectation des ressources financières et humaines. Défendre le programme à l’échelle nationale auprès de la population et de la haute direction. Recommander des modifications au mandat ou à la portée."
            },
            new CompetencyLevelRequirement
            {
                Id = 497,
                DescEng = "Conducts daily media monitoring and coverage analysis. Provides administrative support services. Offers logistical support for media events and interviews.",
                DescFre = "Assurer quotidiennement la surveillance des reportages des médias et l’analyse de la couverture médiatique. Offrir des services de soutien administratif. Offrir du soutien logistique pour les événements médiatiques et les entrevues avec les médias."
            },
            new CompetencyLevelRequirement
            {
                Id = 498,
                DescEng = "Familiar with the Government of Canada Communications Policy. Can write or edit a broad range of communications products. Supports websites. Provides advice and recommendations to clients. Assists in the development and/or implementation of communications products. Contributes to implementation of communication plans or projects in the digital environment. Uses social media to communicate on the web in a government context.",
                DescFre = "Connaître la politique de communication du gouvernement du Canada. Être en mesure d’écrire ou de modifier un large éventail de produits de communication. Appuyer les sites Web. Donner des conseils et des recommandations aux clients. Contribuer à l’élaboration ou à la mise en œuvre de produits de communication. Contribuer à la mise en œuvre de plans ou de projets de communication dans l’environnement numérique. Utiliser les médias sociaux pour communiquer sur le Web dans un contexte gouvernemental."
            },
            new CompetencyLevelRequirement
            {
                Id = 499,
                DescEng = "Knowledge of the Government of Canada Communications Policy. Knowledge of emerging trends in communications in a federal government context. Plans, coordinates, and/or implements announcements or events. Develops and implements communications products. Develops communications to support managers. Monitors and analyzes media coverage. Ability to generate tactical media response. Organizes the logistics associated with special events, such as town halls or media availabilities.",
                DescFre = "Connaître la politique de communication du gouvernement du Canada. Connaître les nouvelles tendances en matière de communication dans le contexte du gouvernement fédéral. Planifier, coordonner ou mettre en œuvre des annonces ou des événements. Élaborer et mettre en œuvre des produits de communication. Rédiger des communications pour aider les gestionnaires. Surveiller et analyser la couverture médiatique. Être en mesure de produire des réponses tactiques aux médias. Organiser les aspects logistiques liés aux événements spéciaux, comme les assemblées publiques ou les points de presse."
            },
            new CompetencyLevelRequirement
            {
                Id = 500,
                DescEng = "Knowledge of project management methodologies in a communications context. Provides strategic communications advice to management/senior officials. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Meets and works with subject matter and methodology experts while executing segmentation and audience analysis. Leads meetings and works with clients or stakeholders.",
                DescFre = "Connaître les méthodes de gestion de projet dans le contexte de la communication. Conseiller la direction et les hauts fonctionnaires sur les communications stratégiques. Élaborer et mettre en œuvre des plans, des scénarimages et des vidéos de marketing ou de publicité. Évaluer les plans de communication et élaborer les produits de communication connexes. Assurer la coordination d’initiatives, de projets ou de stratégies de communications intergouvernementales ou interministérielles ou y collaborer. Rencontrer des experts en la matière et en méthodologie, collaborer avec eux, puis effectuer une analyse par segmentation et une analyse de l’audience. Diriger des réunions et collaborer avec des clients ou des intervenants."
            },
            new CompetencyLevelRequirement
            {
                Id = 501,
                DescEng = "Organizes and coordinates ministerial events. Leads the development and implementation, and evaluation of communications plans and develops associated communications products. Leads on behalf of the CCG, the collaboration with external partners, stakeholders, other levels of government, and/or other departments in the communications sector. Plans and executes extensive electronic (web and social media) communications initiatives. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies.",
                DescFre = "Organiser et assurer la coordination des activités ministérielles. Diriger l’élaboration, la mise en œuvre et l’évaluation des plans de communication et élaborer les produits de communication connexes. Diriger pour le compte de la GCC la collaboration avec les partenaires externes, les intervenants, les autres ordres de gouvernement ou les autres ministères du secteur des communications. Planifier et mettre en œuvre des initiatives d’envergure en matière de communication électronique (sur le Web et dans les médias sociaux). Gérer les relations avec les médias pour les questions délicates. Élaborer et mettre en œuvre des stratégies en amont pour les relations avec les médias."
            },
            new CompetencyLevelRequirement
            {
                Id = 502,
                DescEng = "Understands ICS command hierarchy. Executes tasks in incident action plan (IAP). Identifies and describes own AOR characteristics.   Identifies and uses proper planning formats and templates.",
                DescFre = "Comprendre la hiérarchie de commandement du système de commandement d’intervention (SCI). Exécuter les tâches des plans d’action en cas d’incident (PAI). Définir et décrire les caractéristiques de sa zone de responsabilité. Définir et utiliser les formats et les modèles de planification appropriés."
            },
            new CompetencyLevelRequirement
            {
                Id = 503,
                DescEng = "Conducts initial assessment. Identifies the pollutant released. Uses appropriate methods or tactics, to minimize the impacts of the pollutant on the population, environment and the economy. Operates the appropriate interventions equipment when applicable. Understands ICS structure as it pertains to ER incidents. Uses appropriate ICS terminology. Assumes role in ICS structure and understands responsibilities. Identifies geographic particularities that impact ER. Conducts area assessments with partners to identify threats and opportunities. Provides advice on tactical matters for the purpose of local area planning. Identifies equipment capabilities and gives recommendations for local area response planning. Identifies plans weaknesses pertaining to own role during exercises and incidents. Designs internal exercises.",
                DescFre = "Réaliser des évaluations initiales. Définir le polluant rejeté. Utiliser des méthodes ou des tactiques appropriées afin de réduire autant que possible l’incidence d’un polluant sur la population, l’environnement et l’économie. Utiliser le matériel d’intervention approprié, le cas échéant. Comprendre la structure du SCI concernant les incidents nécessitant une IE. Employer la terminologie appropriée liée au SCI. Assumer son rôle dans la structure du SCI et comprendre ses responsabilités. Définir les particularités géographiques qui ont une incidence sur les IE. Réaliser des analyses de la zone avec les partenaires afin de relever les menaces et les possibilités. Formuler des conseils à l’égard des questions tactiques aux fins de planification locale. Déterminer les capacités de l’équipement et formuler des recommandations pour la planification de l’intervention locale. Définir les faiblesses des plans en ce qui concerne son rôle pendant les exercices et les incidents. Concevoir les exercices internes."
            },
            new CompetencyLevelRequirement
            {
                Id = 504,
                DescEng = "Acts as Duty Officer. Conducts spill assessment. Contracts service providers as required. Applies the PRO powers, acts as OSC and provides advice and guidance to polluter as FMO in simple situations. Conducts pollutants sampling and fills relevant documentation. Predicts the behavior of pollutants release in the marine environment. Uses wastes storage equipment and techniques appropriately. Uses shoreline clean-up assessment techniques (SCAT). Inputs marine pollution incident data in relevant systems. Uses appropriate ICS forms. Provides advice and guidance to command staff within scope of expertise. Understands roles within IAP and how they relate to each other and the overall mission. Identifies resident capacity in own AOR and integrates data in planning. Preplans response strategies adapted to area particularities and expected scenarios. Designs communication plan based on capabilities and area characteristics. Maintains safety, medical and communication plans, during pre-planning or incidents.",
                DescFre = "Agir à titre d’officier de service. Réaliser les analyses des déversements. Avoir recours à des fournisseurs de services au besoin. Appliquer les pouvoirs de l’agent d'intervention environnementale (AIE), agir à titre de commandant sur place (OSC) et présenter au pollueur des conseils et des directives à titre d’agent de surveillance fédéral (ASF) en cas de situations simples. Procéder à l’échantillonnage des polluants et remplir les documents pertinents. Prévoir le comportement du rejet de polluants dans le milieu marin. Utiliser l’équipement et les techniques de stockage des déchets de manière appropriée. Utiliser les techniques d’évaluation pour la restauration des rives (TERR). Saisir les données sur l’incident de pollution marine dans les systèmes pertinents. Utiliser les formulaires appropriés du SCI. Donner des conseils et des directives au personnel de commandement selon son champ de compétence. Comprendre les rôles dans le cadre des PAI et la façon dont ils sont interreliés ainsi que la mission globale. Déterminer la capacité des résidents dans sa zone de responsabilité et intégrer ces données dans la planification. Effectuer la planification préalable des stratégies d’intervention qui conviennent aux particularités de la zone et aux situations prévues. Concevoir le plan de communication en fonction des capacités et des caractéristiques de la zone. Tenir à jour les plans en matière de sécurité, de soins médicaux et de communication durant l’étape de planification préalable ou les incidents."
            },
            new CompetencyLevelRequirement
            {
                Id = 505,
                DescEng = "Applies the PRO powers, acts as OSC, and provides advice and guidance to polluter as FMO in moderate complexity situations. Prepares investigation and cost-recovery documentation. Develops strategic response objectives. Identifies and implements alternate response strategies. Determines the impacts of a pollutant in the marine environment with help of specialized resources. Determines response priorities and optimum response option. Integrates and uses the science table. Initiates and coordinates wildlife protection and rehabilitation process. Selects best storage option for residues and wastes. Recommends appropriate ICS structure in relation to incident; considers appropriateness of unified command. Assesses and integrates stakeholder’s concerns. Assumes role in planning process. Communicates and briefs Incident Action Plan. Applies principles laid out in collaboration agreements. Manages resources appropriately according to incident level. Adapts Response plans in new situations. Sets priorities with stakeholders for local area response planning. Makes recommendations about sector and regional plans. Designs logistics plans, during pre-planning or incidents.",
                DescFre = "Appliquer les pouvoirs de l’AIE, agir à titre d’OSC et présenter au pollueur des conseils et des directives à titre d’ASF en cas de situations moyennement complexes. Préparer les documents d’enquête et de recouvrement de coûts. Élaborer des objectifs d’intervention stratégique. Définir et mettre en œuvre d’autres stratégies d’intervention. Déterminer les répercussions d’un polluant sur le milieu marin à l’aide de ressources spécialisées. Déterminer les priorités d’intervention et l’option optimale d’intervention. Intégrer et utiliser la table ronde scientifique. Lancer et coordonner le processus de protection et de rétablissement de la faune. Choisir la meilleure solution de stockage des résidus et des déchets. Recommander une structure appropriée de SCI relative aux incidents et étudier le caractère adéquat d’un commandement unifié. Évaluer et intégrer les préoccupations des intervenants. Assumer son rôle dans le processus de planification. Communiquer les PAI et donner des renseignements sur ceux-ci. Mettre en pratique les principes énoncés dans les accords de collaboration. Gérer les ressources de manière appropriée selon le niveau d’incident. Adapter les plans d’intervention aux nouvelles situations. Établir les priorités avec les intervenants en ce qui concerne la planification de l’intervention locale. Formuler des recommandations sur les plans sectoriels et régionaux. Concevoir les plans logistiques durant l’étape de planification préalable ou les incidents."
            },
            new CompetencyLevelRequirement
            {
                Id = 506,
                DescEng = "Applies the PRO powers, acts as OSC, and provides advice and guidance to polluter as FMO in high complexity situations. Assesses strategies and tactics and ensures regulatory compliance. Establishes Unified Command when in the best interest of the response effectiveness. Acts as IC during a high-complexity incident. Integrates legal, territorial, media, public and organizational expectations in planning process. Evaluates players’ expectations and integrates relevant stakeholders in command structure. Makes recommendations to improve the ICS philosophy and structure to National headquarters. Sets strategies and goals. Provides relevant advice and input for national and international planning. Maintains and coordinates sector and regional plans. Ensures that identified improvements to plans are implemented. Manages overall exercise program and provides input to national exercise planning team.",
                DescFre = "Appliquer les pouvoirs de l’AIE, agir à titre d’OSC et présenter au pollueur des conseils et des directives à titre d’ASF en cas de situations très complexes. Évaluer les stratégies et les tactiques et veiller au respect de la réglementation. Établir un commandement unifié dans l’intérêt de l’efficacité des interventions. Agir à titre de commandant d’intervention (CI) lors d’un incident très complexe. Intégrer les attentes juridiques, territoriales, médiatiques, publiques et organisationnelles dans le processus de planification. Évaluer les attentes des participants et intégrer les intervenants concernés dans la structure de commandement. Présenter des recommandations à l’administration centrale pour améliorer la philosophie et la structure du SCI. Établir les stratégies et les objectifs. Offrir des données et des conseils pertinents pour la planification aux échelles nationale et internationale. Tenir à jour et coordonner les plans sectoriels et régionaux. Veiller à ce que les améliorations à apporter aux plans soient mises en œuvre. Gérer le programme général d’exercices et donner des commentaires à l’équipe nationale de planification des exercices."
            },
            new CompetencyLevelRequirement
            {
                Id = 507,
                DescEng = "Basic understanding of the fundamental principles of hydraulic engineering including fluid mechanics, fluid flow, real-fluid behaviour, hydrology, pipelines, open channel hydraulics, sediment transport mechanics, physical modeling, hydraulic machinery and hydraulic drainage.",
                DescFre = "Compréhension de base des principes fondamentaux du génie hydraulique, y compris la mécanique des fluides, l'écoulement des fluides, le comportement des fluides réels, l'hydrologie, les pipelines, l'hydraulique à canal ouvert, la mécanique du transport des sédiments, la modélisation physique, les machines hydrauliques et le drainage hydraulique."
            },
            new CompetencyLevelRequirement
            {
                Id = 508,
                DescEng = "Limited knowledge of the application of equations developed from the principles of fluid dynamics and fluid mechanics in relation to water flowing in an isolated environment (pipe, pump) and/or in an open channel (river, lake, ocean).",
                DescFre = "Connaissance limitée de l'application des équations développées à partir des principes de la dynamique des fluides et de la mécanique des fluides en relation avec l'eau s'écoulant dans un environnement isolé (conduite, pompe) et/ou dans un canal ouvert (rivière, lac, océan)."
            },
            new CompetencyLevelRequirement
            {
                Id = 509,
                DescEng = "Working knowledge of the design of hydraulic structures including but not limited to dams, dykes, water distribution networks, water collection networks, wastewater collection networks, stormwater management and sediment transport.",
                DescFre = "Connaissance pratique de la conception d'ouvrages hydrauliques tels que barrages, digues, réseaux de distribution d'eau, réseaux de collecte d'eau, réseaux de collecte d'eaux usées, gestion des eaux pluviales et transport de sédiments, entre autres."
            },
            new CompetencyLevelRequirement
            {
                Id = 510,
                DescEng = "Advanced knowledge of the application of hydrological statistics and risk analysis, reservoir system analysis, planning analysis and real-time water control management. Knowledge of new and emerging technologies, flood risk management and ecohydraulics.",
                DescFre = "Connaissance avancée de l'application des statistiques hydrologiques et de l'analyse des risques, de l'analyse des systèmes de réservoirs, de l'analyse de la planification et de la gestion en temps réel du contrôle de l'eau. Connaissance des technologies nouvelles et émergentes, de la gestion des risques d'inondation et de l'écohydraulique."
            },
            new CompetencyLevelRequirement
            {
                Id = 511,
                DescEng = "Specialized knowledge to support decision-making at all levels, from governance and policy to operations management. Knowledge of sustainable development and optimization of water resource management and flow processes. ",
                DescFre = "Connaissances spécialisées en matière de soutien à la prise de décisions à tous les niveaux, y compris la gouvernance et les politiques, jusqu'à la gestion des opérations. Connaissance du développement durable et de l'optimisation de la gestion des ressources en eau et des processus d'écoulement."
            },
            new CompetencyLevelRequirement
            {
                Id = 512,
                DescEng = "Understands basic circuit elements (source, ground, resistor, capacitor). Applies basic circuit analysis methods to solve electrical design problems.",
                DescFre = "Comprendre les éléments de base d’un circuit (source, mise à la terre, résistance et condensateur). Appliquer des méthodes de base d’analyse des circuits afin de résoudre des problèmes de conception électrique."
            },
            new CompetencyLevelRequirement
            {
                Id = 513,
                DescEng = "Applies electrical engineering sciences to moderately complex services or creative work as consultation, investigation, evaluation, planning, and design of engineering projects. Provides drawing input and reviews. Defines problems, conducts research, plans methods, and identifies resources.",
                DescFre = "Appliquer les sciences du génie électrique à des services moyennement complexes ou à des créations intellectuelles comme les consultations, les investigations, les évaluations, les plans et les avant-projets de projets techniques. Fournir un avis sur les dessins et les examiner. Définir des problèmes, mener des travaux de recherche, planifier des méthodes et déterminer des ressources."
            },
            new CompetencyLevelRequirement
            {
                Id = 514,
                DescEng = "Plans for final delivery and workout foreseeable challenges. Develops project management schedules. Plans and develops concept tooling and estimated costs. Conducts product testing. Provides test results. Provides and develops fixturing concepts.",
                DescFre = "Prévoir la livraison finale et trouver des solutions aux défis prévisibles. Élaborer des calendriers de gestion du projet. Planifier et élaborer des concepts d’outillage et des estimations de coûts. Mettre à l’essai les produits. Fournir les résultats des essais. Fournir et élaborer des concepts de fixation."
            },
            new CompetencyLevelRequirement
            {
                Id = 515,
                DescEng = "Designs and develops product concepts based on research and development. Provides test results to senior management and designers. Analyzes data and develops reports. Analyzes brainstorming results. Conducts research and development project meetings. Conducts preliminary drawing reviews. Provides materiels options. Provides reducibility reports. Provides budgetary evaluations. Understands and conceptualizes vague plans.",
                DescFre = "Concevoir et élaborer des concepts de produits fondés sur la recherche et le développement. Fournir les résultats des essais à la haute direction et aux concepteurs. Analyser les données et produire des rapports. Analyser les résultats des remue-méninges. Diriger les réunions des projets de recherche et développement. Examiner les dessins d’avant-projet. Fournir des options quant aux matériaux. Fournir des rapports sur la réductibilité. Fournir des évaluations budgétaires. Comprendre et conceptualiser des plans vagues."
            },
            new CompetencyLevelRequirement
            {
                Id = 516,
                DescEng = "Develops high-level reports. Provides time studies and flow diagrams. Attends design and engineering meetings, develops schedules, and considers resource allocations - including presenting to management. Understands and teaches drawings and blueprint standards. Provides feedback and communicates with design. Conducts model manipulation.",
                DescFre = "Élaborer des rapports de haut niveau. Fournir des études par chronométrage et des diagrammes de processus. Assister aux réunions de conception et aux réunions techniques, élaborer des calendriers et étudier les possibilités d’affectation des ressources, y compris la présentation à la direction. Comprendre et enseigner les normes relatives aux dessins et aux plans détaillés. Fournir de la rétroaction et communiquer avec les concepteurs. Procéder à la manipulation des modèles."
            },
            new CompetencyLevelRequirement
            {
                Id = 517,
                DescEng = "Uses operating systems to prepare plans, specifications, and calculations, for collection and analysis of spatial information.",
                DescFre = "Utilise des systèmes d'exploitation pour préparer des plans, des spécifications et des calculs, pour la collecte et l'analyse d'informations spatiales."
            },
            new CompetencyLevelRequirement
            {
                Id = 518,
                DescEng = "Performs analysis, design, and design review and/or determination of environmental and safety impacts of work processes and products.",
                DescFre = "Effectue l'analyse, la conception et la révision de la conception et/ou la détermination des impacts des processus de travail et des produits sur l'environnement et la sécurité."
            },
            new CompetencyLevelRequirement
            {
                Id = 519,
                DescEng = "Provides consultation and technical assistance to design and conduct experiments, as well as to analyze and interpret data.",
                DescFre = "Fournit des conseils et une assistance technique pour concevoir et mener des expériences, ainsi que pour analyser et interpréter les données."
            },
            new CompetencyLevelRequirement
            {
                Id = 520,
                DescEng = "Integrates the acquisition, processing, analysis, display, and management of spatial information, using various geographic information systems (GIS), photogrammetry, and remote sensing equipment. Identifies, formulates, and solves a wide range of technical problems. Provides expertise in boundary and land surveying, subdivision, and plat creation, control surveys, and construction surveys.",
                DescFre = "Intègre l’acquisition, le traitement, l’analyse, l’affichage et la gestion de données spatiales en utilisant divers systèmes d’information géographique (SIG), la photogrammétrie et du matériel de télédétection. Détecte, énonce et résout un large éventail de problèmes techniques. Fournit une expertise en ce qui a trait à l’arpentage des limites et des terrains, au morcellement des terres, à la création de plans cadastraux, ainsi qu’à la réalisation de levés de contrôle et de levés de construction."
            },
            new CompetencyLevelRequirement
            {
                Id = 521,
                DescEng = "Provides expertise on the impact of engineering solutions in a global, economic, environmental, and societal context. Reviews legislation, standards of practice, and case law affecting property interests, property boundaries, and boundary surveys.",
                DescFre = "Fournit une expertise sur l'impact des solutions d'ingénierie dans un contexte global, économique, environnemental et sociétal. Examine la législation, les normes de pratique et la jurisprudence concernant les intérêts fonciers, les limites des propriétés et les levés de terrain."
            },
            new CompetencyLevelRequirement
            {
                Id = 522,
                DescEng = "Uses Configuration Management (CM) planning and management documentation and functions. Asks questions when necessary.",
                DescFre = "Utiliser la documentation et les fonctions de gestion et de planification de la gestion de la configuration (GC). Poser des questions au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 523,
                DescEng = "Uses Configuration Management (CM) for control of basic performance and physical attributes.",
                DescFre = "Utiliser la gestion de la configuration (GC) pour le contrôle du rendement de base et des caractéristiques physiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 524,
                DescEng = "Employs Configuration Management (CM) to revise capability; improve performance, reliability, or maintainability; extend life; reduce cost; reduce risk and liability; and correct defects. Implements changes to the system by using a standardized, systematic approach that ensures consistency.",
                DescFre = "Emploie la gestion de la configuration (CM) pour réviser les capacités, améliorer les performances, la fiabilité ou la maintenabilité, prolonger la durée de vie, réduire les coûts, réduire les risques et la responsabilité et corriger les défauts. Apporte des modifications au système en utilisant une approche standardisée et systématique qui assure la cohérence."
            },
            new CompetencyLevelRequirement
            {
                Id = 525,
                DescEng = "Provides technical and administrative direction into the development and implementation of the procedures, functions, services, tools, processes, and resources required to successfully develop and support a complex system. Evaluates proposed changes in terms of their anticipated impact on the entire system. Produces documentation (e.g. requirements, design, test, and acceptance documentation) that is accurate and consistent with the actual physical design of the item.",
                DescFre = "Fournit une direction technique et administrative pour le développement et la mise en œuvre des procédures, fonctions, services, outils, processus et ressources nécessaires pour développer et soutenir avec succès un système complexe. Évalue les changements proposés en fonction de leur impact prévu sur l'ensemble du système. Produire une documentation (par exemple, les exigences, la conception, les tests et la documentation d'acceptation) qui est précise et cohérente avec la conception physique réelle de l'élément."
            },
            new CompetencyLevelRequirement
            {
                Id = 526,
                DescEng = "Produces and implements the policies, procedures, techniques, and tools that manage the Configuration Management (CM) system. Audits configuration verification to assess compliance with established performance requirements.",
                DescFre = "Produire et mettre en œuvre les politiques, procédures, techniques et outils qui gèrent le système de gestion de la configuration (GC). Procéder à la vérification de la configuration pour évaluer la conformité aux exigences de rendement établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 527,
                DescEng = "Understands the administrative support required for aspects of logistics in a unit.",
                DescFre = "Compréhension du soutien administratif nécessaire pour les aspects liés à la logistique dans une unité."
            },
            new CompetencyLevelRequirement
            {
                Id = 528,
                DescEng = "Limited knowledge of the activities required to determine items required (including food and uniforms), assembling orders, aiding in processing orders, sorting merchandise, maintaining supplies, verifying inventory, and processing return materials authorizations (RMAs).",
                DescFre = "Connaissance limitée des activités nécessaires pour déterminer les articles requis (y compris la nourriture et les uniformes), assembler les commandes, contribuer au traitement des commandes, trier les marchandises, tenir à jour l’approvisionnement, vérifier l’inventaire et traiter les autorisations de retour de matériel (ARM)."
            },
            new CompetencyLevelRequirement
            {
                Id = 529,
                DescEng = "Practical knowledge of purchasing, transportation, inventory, and warehousing. Knowledge of the appropriate use of equipment, facilities, and materials needed to do certain work. Knowledge of controlling inventory levels determined by conducting physical counts and reconciling with data storage systems.",
                DescFre = "Connaissance pratique de l’approvisionnement, du transport, des stocks et de l’entreposage. Connaissance de l’utilisation appropriée du matériel, des installations et des matières nécessaires pour effectuer certains travaux. Connaissance du contrôle des niveaux de stock qui sont déterminés en effectuant des dénombrements et des rapprochements avec les systèmes de stockage de données."
            },
            new CompetencyLevelRequirement
            {
                Id = 530,
                DescEng = "Advanced knowledge of purchasing, manufacturing and distribution, receiving, transfer, and dispatch of raw materials and finished goods. Knowledge of forecasting requirements and planning for the future. Knowledge of identifying complex warehouse and inventory monitoring systems, procedures, and issues.",
                DescFre = "Connaissance approfondie de l’approvisionnement, de la fabrication, de la distribution, de la réception, du transfert et de l’expédition de matières premières et de produits finis. Connaissance de la prévision et de la planification des besoins futurs. Connaissance de la détermination des systèmes, des procédures et des enjeux complexes en matière de surveillance des entrepôts et des stocks."
            },
            new CompetencyLevelRequirement
            {
                Id = 531,
                DescEng = "Expert knowledge in the development of solutions to logistical problems. Understanding the development and implementation of business process initiatives to optimize logistical operations. Expert knowledge of policies and procedures related to material handling, and shipping requirements.",
                DescFre = "Connaissance spécialisée de l’élaboration de solutions pour des problèmes liés à la logistique. Compréhension de l’élaboration et de la mise en œuvre d’initiatives concernant les processus opérationnels afin d’optimiser les opérations liées à la logistique. Connaissance spécialisée des politiques et procédures liées à la manutention ainsi que des exigences relatives à l’expédition."
            },
            new CompetencyLevelRequirement
            {
                Id = 532,
                DescEng = "Basic knowledge of concepts and components in an electronic environment and how they are inter-related.",
                DescFre = "Connaissance de base des concepts et des composants dans un environnement électronique et de leur interrelation."
            },
            new CompetencyLevelRequirement
            {
                Id = 533,
                DescEng = "Limited knowledge of the analysis of basic electronics concepts and the behaviour of electronic systems. Understands the operational function of electronic components in a practical context.",
                DescFre = "Connaissances limitées dans l'analyse des concepts de base de l'électronique et du comportement des systèmes électroniques. Comprend la fonction opérationnelle des composants électroniques dans un contexte pratique."
            },
            new CompetencyLevelRequirement
            {
                Id = 534,
                DescEng = "Working knowledge of advanced concepts and components in electronic environments, including energy and thermal dissipation; analog and digital signals; the time constant; amplification, logic and/or truth tables; bistable, monostable and astable circuits; and parallels and series circuits.",
                DescFre = "Connaissance pratique des concepts et composants avancés dans les environnements électroniques, y compris la dissipation d'énergie et de chaleur, les signaux analogiques et numériques, la constante de temps, l'amplification, les tables logiques et/ou de vérité, bistable, monostable et astable, les parallèles ou séries."
            },
            new CompetencyLevelRequirement
            {
                Id = 535,
                DescEng = "Advanced knowledge of electronic software development using advanced concepts such as variables, binary notation (bits, bytes and words) and the logical structure of software. Understands advanced calculations, including power rating, parallel or series circuits and the time constant, based on important parameters in side circuit behaviour. Knowledge of capacities related to different electronic components.",
                DescFre = "Connaissance avancée du développement de logiciels électroniques utilisant des concepts avancés, tels que les variables, la notation binaire (bits, octets et mots), la structuration logique des logiciels. Comprend les calculs avancés, y compris la puissance nominale, les parallèles ou les séries, et la constante de temps, basés sur des paramètres importants dans le comportement des circuits réels. Connaissance des capacités liées aux différents composants électroniques."
            },
            new CompetencyLevelRequirement
            {
                Id = 536,
                DescEng = "Extensive knowledge of important concepts used in the design and construction of electronic environments and complex hardware concepts. Expertise in doing complex calculations. ",
                DescFre = "Connaissance approfondie des concepts importants utilisés dans la conception et la construction d'environnements électroniques et de concepts matériels complexes. Expertise dans la réalisation de calculs complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 537,
                DescEng = "Participates in tours and educational experiences highlighting the workings of operation centres, their mandate, equipment, and staffing.",
                DescFre = "Participer aux visites guidées et aux expériences éducatives qui soulignent le fonctionnement des centres d’opérations, leur mandat, leur équipement et leur personnel."
            },
            new CompetencyLevelRequirement
            {
                Id = 538,
                DescEng = "Participates in exercises or incidents using sensors and equipment with an operation centre, giving information, obtaining data, and taskings or instructions. Reads operational orders and data published by operations centres.",
                DescFre = "Participer à des exercices ou à des incidents et utiliser des détecteurs et de l’équipement d’un centre d’opérations, fournir de l’information, obtenir des données et donner des tâches ou des instructions. Lire les consignes opérationnelles et les données publiées par les centres d’opérations."
            },
            new CompetencyLevelRequirement
            {
                Id = 539,
                DescEng = "Plans, deploys, and tracks resources utilizing the operation center equipment. Collects and analyses data including fisheries violations, courtesy exams, the distance covered and fuel consumed during a patrol, as well as a detailed electronic report on the actual amount of time spent in support of each program. Participates in reviewing, updating, and conducting analysis, preparation and development of operational plans, exercises and standard operating procedures and prepares recommendations to the superintendent and delegates for improving performance, ensuring compliance and meeting new operational requirements. Collects and analyzes data to create and disseminate reports at the regional and national levels.",
                DescFre = "Planifier, déployer et surveiller les ressources en utilisant l’équipement du centre d’opérations. Recueillir et analyser des données, notamment en ce qui concerne les infractions en matière de pêche, les inspections gratuites, la distance parcourue, le carburant utilisé pendant une patrouille ainsi que le rapport électronique détaillé sur le temps réellement consacré à soutenir chacun des programmes. Participer à l’examen, à la mise à jour, à l’analyse, à la préparation et à l’élaboration de plans opérationnels, d’exercices et de PON et formuler des recommandations à l’intention du surintendant et de ses délégués afin d’améliorer le rendement, d’assurer la conformité et de répondre aux nouvelles exigences opérationnelles. Recueillir et analyser des données afin de créer et de distribuer des rapports aux échelles régionale et nationale."
            },
            new CompetencyLevelRequirement
            {
                Id = 540,
                DescEng = "Plans, develops, and implements the operational plans of all regional resources on a 24/7 basis.  Provides technical and operational analysis, advice and briefings to regional management and commanding officers. Assists in finding solutions to complex and diversified technical and operational problems. Receives reports of marine incidents and initiates and supports incident response, activating alert networks, and coordinating with other emergency response agencies, including applying the Incident Command System (ICS).",
                DescFre = "Planifier, élaborer et mettre en œuvre les plans opérationnels pour l’ensemble des ressources régionales 24 heures sur 24, 7 jours sur 7. Fournir à la direction régionale et aux commandants des analyses, des conseils et de l’information d’ordres technique et opérationnel. Contribuer à l’élaboration de solutions aux problèmes techniques et opérationnels complexes et variés. Recevoir des rapports d’incidents maritimes, puis lancer et soutenir les interventions requises, activer les réseaux d’alerte, assurer une coordination avec d’autres organismes d’intervention en cas d’urgence et utiliser le SCI."
            },
            new CompetencyLevelRequirement
            {
                Id = 541,
                DescEng = "Advises and acts as spokesperson for all fleet related issues during the planning and exercising of emergency response preparedness for Canadian Coast Guard resources. Leads activities related to program and service delivery by multi-disciplinary and multi-agency organizations. Maintains emergency preparedness and readiness, and directs initial response for regional incidents. Manages the planning, conduct, and monitoring of operational exercises to ensure compliance to Coast Guard and industry regulations. Evaluates Regional Operations Centres (ROC) performance. Advises and reports to senior management on incident response situations.",
                DescFre = "Agir comme porte-parole et formuler des conseils à ce titre relativement à l’ensemble des problèmes liés à la flotte lors de la planification et de la mise en application de l’état de préparation aux urgences pour toutes les ressources de la GCC. Diriger les activités liées à la prestation de programmes et de services par les organismes multidisciplinaires et les organisations constituées de plusieurs organismes. Maintenir l’état de préparation aux urgences et dirige les interventions initiales pour les incidents qui se produisent dans la région. Gérer la planification, la tenue et la surveillance des exercices opérationnels afin d’assurer leur conformité aux règlements de la Garde côtière et de l’industrie. Évaluer le rendement des COR. Informer la haute direction des situations d’intervention en cas d’incident et lui fournir des conseils à cet égard."
            },
            new CompetencyLevelRequirement
            {
                Id = 542,
                DescEng = "Applies basic circuit analysis methods to solve electrical design problems.",
                DescFre = "Applique des méthodes d'analyse de circuit de base pour résoudre les problèmes de conception électrique."
            },
            new CompetencyLevelRequirement
            {
                Id = 543,
                DescEng = "Analyzes engineering projects for electrical specifications. Provides ideas and criticism, conducts research, plans methods and identifies resources.",
                DescFre = "Analyse les projets d'ingénierie pour les spécifications électriques. Fournit des idées et des critiques, mène des recherches, planifie des méthodes et identifie des ressources."
            },
            new CompetencyLevelRequirement
            {
                Id = 544,
                DescEng = "Develops project management schedules. Designs electrical circuits or diagrams according to project specifications. Conducts testing. Provides test results. Provides and develops fastening concepts.",
                DescFre = "Élabore des calendriers de gestion de projet. Conçoit des circuits électriques ou des graphiques selon les spécifications du projet. Effectue des tests. Fournit les résultats des tests. Fournit et développe des concepts de fixation."
            },
            new CompetencyLevelRequirement
            {
                Id = 545,
                DescEng = "Designs and develops product concepts based on research and development. Analyzes data and prepares reports including material and budgetary elements. Develops preliminary evaluations of diagrams. Understands and teaches standards for drawings and plans.",
                DescFre = "Conçoit et développe des concepts de produits basés sur la recherche et le développement. Analyse les données et élabore des rapports comprenant des éléments matériels et budgétaires. Élabore des examens préliminaires des graphiques. Comprend et enseigne les dessins et les normes de plans."
            },
            new CompetencyLevelRequirement
            {
                Id = 546,
                DescEng = "Develops high-level reports. Attends design and engineering meetings, develops schedules, reviews resource allocations and performs model manipulation. Provides comments and communicates with the design authority.",
                DescFre = "Développe des rapports de haut niveau. Assiste aux réunions de conception et d’ingénierie, élabore des calendriers, examiner les affectations de ressources et procède à la manipulation des modèles. Fournit des commentaires et communique avec l'autorité en matière de conception."
            },
            new CompetencyLevelRequirement
            {
                Id = 547,
                DescEng = "Basic knowledge of designing, drawing and modelling ship structure and of construction and classification rules and regulations.",
                DescFre = "Connaissance de base de la conception, du dessin et de la modélisation de la structure des navires, et des règles et règlements de construction et de classification."
            },
            new CompetencyLevelRequirement
            {
                Id = 548,
                DescEng = "Knowledge of the preliminary design stages, including all factors such as safety, structural resistance, hydrodynamics and ship arrangement.",
                DescFre = "Connaissance des étapes de conception préliminaire, y compris tous les facteurs tels que la sécurité, la résistance de la structure, l'hydrodynamique et la disposition du navire."
            },
            new CompetencyLevelRequirement
            {
                Id = 549,
                DescEng = "Intermediate knowledge of basic and applied research, design, development, design evaluation and calculations at all stages of a marine vessel’s life. Develops safety regulations and damage control rules, and approves and certifies vessel designs to meet statutory and non-statutory requirements.",
                DescFre = "Connaissance intermédiaire de la recherche fondamentale et appliquée, de la conception, du développement, de l'évaluation de la conception et des calculs à toutes les étapes de la vie d'un navire marin. Formulation des règlements de sécurité et des règles de contrôle des avaries, et approbation et certification des conceptions de navires pour répondre aux exigences statutaires et non statutaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 550,
                DescEng = "Extensive knowledge of the research elements for predicting marine vessel performance, including static stability (intact and damaged), dynamic stability, resistance, power, hull development, structural analysis, green water modelling and slamming analysis. Advanced knowledge of detailed design, construction, testing, operation and maintenance, launching activities and dry-docking.",
                DescFre = "Connaissance approfondie des éléments de recherche pour prédire les performances d'un navire marin, y compris la stabilité statique (intacte et endommagée), la stabilité dynamique, la résistance, l'alimentation, le développement de la coque, l'analyse structurelle, la modélisation de l'eau verte et l'analyse du claquement. Connaissance de pointe de la conception détaillée, de la construction, des essais, de l'exploitation et de la maintenance, des activités de lancement et de mise en cale sèche."
            },
            new CompetencyLevelRequirement
            {
                Id = 551,
                DescEng = "Extensive knowledge and experience in economical, environmentally friendly and seaworthy shipbuilding design.",
                DescFre = "Connaissance approfondie et expérience de la conception de construction navale économique, respectueuse de l'environnement et navigable."
            },
            new CompetencyLevelRequirement
            {
                Id = 552,
                DescEng = "Basic IT knowledge and understanding of IT applications. Understanding of architectural principles, specifications and models.",
                DescFre = "Connaissances de base en informatique et compréhension des applications informatiques. Compréhension des principes architecturaux, des spécifications et des modèles."
            },
            new CompetencyLevelRequirement
            {
                Id = 553,
                DescEng = "Limited knowledge of how to determine user needs and design a product that effectively meets requirements within economic and technological constraints and how to create basic models based on specifications.",
                DescFre = "Connaissance limitée de la détermination des besoins de l'utilisateur et de la conception d'un produit qui répond efficacement aux exigences dans le respect des contraintes économiques et technologiques et de la création de modèles de base basés sur des spécifications."
            },
            new CompetencyLevelRequirement
            {
                Id = 554,
                DescEng = "Working knowledge of the capabilities and programming models of a computer as well as the structure and behaviour of electronic circuits and digital logic circuits. Knowledge of a variety of analytical techniques to solve problems and adjust work procedures for maximum efficiency. Knowledge of how to produce analytical models and candidate design models to be used for further analysis (e.g. telecommunications, networks).",
                DescFre = "Connaissance pratique des capacités et des modèles de programmation d'un ordinateur ainsi que de la structure et du comportement des circuits électroniques et des circuits logiques numériques. Connaissance d'une variété de techniques analytiques pour résoudre des problèmes et ajuster les procédures de travail pour une efficacité maximale. Connaissance de la production de modèles analytiques et de modèles de conception candidats à utiliser pour des analyses plus poussées (p. ex. télécommunications, réseaux)."
            },
            new CompetencyLevelRequirement
            {
                Id = 555,
                DescEng = "Extensive knowledge of detailed analyses of computer organization to optimize performance-based products in a cost-effective manner. Knowledge of complex circuits and electronic design automation (EDA) systems such as integrated circuits, microprocessors and application-specific programmable logic devices. Extensive knowledge of new requirements and able to develop design recommendations. Understands post-implementation validation processes. Knowledge of metadata models at the enterprise level, information models and the interoperability model.",
                DescFre = "Connaissance approfondie des analyses détaillées de l'organisation d'un ordinateur afin d'optimiser les produits basés sur la performance d'une manière rentable. Connaissance des circuits complexes et des systèmes d'automatisation de la conception électronique (EDA) tels que les circuits intégrés, les microprocesseurs et les dispositifs logiques programmables spécifiques aux applications. Connaissance approfondie des nouvelles exigences et formulation de recommandations de conception. Comprend les processus de validation après la mise en œuvre. Connaissance des modèles de métadonnées au niveau de l'entreprise, des modèles d'information et du modèle d'interopérabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 556,
                DescEng = "Expert knowledge in optimizing the entire architectural process, including instruction set design, functional organization, logical design and implementation. Expert understanding of how to use and implement the latest IT technologies. Expertise in how the architecture relates to the organization’s vision, how new activities fit into existing business lines, of business and technology integration, and of the link between government priorities and target architectures. Understands Treasury Board standards (e.g. ISO and WC3 quality standards) and governance issues.",
                DescFre = "Connaissances expertes dans l'optimisation de l'ensemble du processus architectural, y compris la conception du jeu d'instructions, l'organisation fonctionnelle, la conception logique et la mise en œuvre. Compréhension experte de la façon d'utiliser et de mettre en œuvre les technologies informatiques les plus récentes. Expertise sur la façon dont l'architecture est liée à la vision de l'organisation, la façon dont les nouvelles activités s'intègrent aux secteurs d'activité actuels, l'intégration des activités et de la technologie, et le lien entre les priorités gouvernementales et les architectures cibles. Comprend les normes du Conseil du Trésor (p. ex. normes de qualité ISO, WC3) et les questions de gouvernance."
            },
            new CompetencyLevelRequirement
            {
                Id = 557,
                DescEng = "Applies engineering science to help create a design, solve a defined problem or prepare an engineering project proposal.",
                DescFre = "Applique les sciences de l'ingénierie pour contribuer à la création d'une conception, à la résolution d'un problème défini ou à la rédaction d'une proposition de projet d'ingénierie."
            },
            new CompetencyLevelRequirement
            {
                Id = 558,
                DescEng = "Applies engineering science to moderately complex services or creative work, such as consulting, investigation, evaluation, planning and design for engineering projects. Provides comments and analyses on drawings. Defines problems, conducts research, plans methods and identifies resources.",
                DescFre = "Applique les sciences de l'ingénierie à des services moyennement complexes ou à des travaux créatifs tels que la consultation, l'investigation, l'évaluation, la planification et la conception de projets d'ingénierie. Fournit des commentaires et des analyses sur les dessins. Définit les problèmes, effectue des recherches, planifie des méthodes et identifie des ressources."
            },
            new CompetencyLevelRequirement
            {
                Id = 559,
                DescEng = "Creates technical designs and/or program/project specifications to comply with technical principles, standards, statutes, codes, regulations and technical designs. Researches, collects and/or analyzes information/data used for technical decision making. Evaluates projects and ensures that they comply with specifications and/or design standards.",
                DescFre = "Crée des conceptions techniques et/ou des spécifications de programme/projet afin de respecter les principes techniques, normes, statuts, codes, réglementations et les conceptions techniques. Recherche, collecte et/ou analyse des informations/données qui contribuent à la prise de décisions techniques. Évalue les projets et s'assure qu'ils respectent les spécifications et/ou les normes de conception."
            },
            new CompetencyLevelRequirement
            {
                Id = 560,
                DescEng = "Able to approve other engineers’ engineering designs and/or program/project specifications. Analyzes information/data used in technical decision making. Evaluates and ensures that projects comply with specifications and/or design standards. Ensures that client relationships are proactively developed by continuously improving the level of service provided in accordance with the service provider contract and standard industry practices.",
                DescFre = "Peut approuver des conceptions techniques et/ou des spécifications de programme/projet d'autres ingénieurs. Analyse les informations/données qui contribuent à la prise de décisions techniques. Évalue et s'assure que les projets respectent les spécifications et/ou les normes de conception. S'assure que les relations avec les clients sont développées de manière proactive en améliorant continuellement le niveau de service fourni conformément au contrat de fournisseurs de service et aux pratiques standard de l'industrie."
            },
            new CompetencyLevelRequirement
            {
                Id = 561,
                DescEng = "Approves all designs, design changes and engineering projects. Examines and/or analyzes information/data used in technical decision making. Evaluates and ensures that projects comply with specifications and/or design standards.",
                DescFre = "Approuve toutes les conceptions, les modifications de conception et les projets d'ingénierie. Examine et/ou analyse les informations/données qui contribuent à la prise de décisions techniques. Évalue et s'assure que les projets respectent les spécifications et/ou les normes de conception."
            },
            new CompetencyLevelRequirement
            {
                Id = 562,
                DescEng = "Knowledge of the various visual reference commands in AutoCAD.",
                DescFre = "Connaissance des différentes commandes de référence visuelle d'AutoCAD."
            },
            new CompetencyLevelRequirement
            {
                Id = 563,
                DescEng = "Recognizes different line commands. Selects the CIRCLE command required for a specific purpose. Provides a reminder on the ARC command. Explains the ERASE command. Describes the selection window. Explains basic Z-coordinate terminology.",
                DescFre = "Reconnaît les différentes commandes de ligne. Choisit la commande de cercle requise pour un but spécifique. Rappelle la commande ARC. Explique la commande ERASE. Décrit la fenêtre de sélection. Explique les terminologies de base des coordonnées Z."
            },
            new CompetencyLevelRequirement
            {
                Id = 564,
                DescEng = "Is familiar with the basic 3D interface in AutoCAD. Explains how to draw basic 3D ribbons using different tools. Identifies different drop-down menu options. Provides a reminder of good knowledge of the 3D modeling interface. Recognizes different options in the 3D modeling drop-down menus. Applies/configures materials.",
                DescFre = "Se familiarise avec l'interface de base de la 3D dans AutoCAD. Explique comment dessiner des rubans de base en 3D à l'aide de différents outils. Identifie différentes options de menus déroulants. Rappelle une bonne connaissance de l'interface de modélisation 3D. Reconnaît différentes options dans les menus déroulants de la modélisation 3D. Appliquer/configurer les matériaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 565,
                DescEng = "Introduces thickness and elevation. Explains how to run the “thickness” command using the command prompt. Explains how to adjust object elevation. Visualizes the model by being able to define different styles. Explains how to manage different styles using different options. Defines different visual functions (hide, grid). Defines the user coordinate system. Executes the rendering. Applies lights.",
                DescFre = "Introduit l'épaisseur et l'élévation. Explique comment exécuter la commande “thickness” à l'invite de commande. Explique comment régler l'élévation de l'objet. Visualise le modèle en étant capable de définir différents styles. Explique comment gérer différents styles en utilisant différentes options. Définit différentes fonctions visuelles (masquer, grille). Définit le système de coordonnées utilisateur. Exécute le rendu. Applique des lumières."
            },
            new CompetencyLevelRequirement
            {
                Id = 566,
                DescEng = "Is familiar with 3D orbit. Performs 3D navigation. Operates 3D objects. Identifies different primitive mesh options. Explains the process for editing existing meshes. Understands complex 3D surfaces. Describes surface associativity. Creates solids. Modifies 3D objects. Develops composite 3D solids. Modifies solid faces. Modifies solids. Navigates through section objects. Merges flat objects.",
                DescFre = "Se familiarise avec l'orbite 3D. Effectue la navigation 3D. Fait fonctionner des objets 3D. Identifie différentes options primitives de maillage. Explique le processus d'édition des maillages existants. Comprend les surfaces 3D complexes. Décrit l'associativité de surface. Crée des solides. Modifie les objets 3D. Développe des composites solides 3D. Modifie les faces pleines. Modifie les solides. Navigue dans les objets de section. Fusionne des objets plats."
            },
            new CompetencyLevelRequirement
            {
                Id = 567,
                DescEng = "Applies basic level software specifications or design techniques and programming concepts using one or more programming languages and/or methodologies. Tests, documents, and ensures production assurance and with guidance.",
                DescFre = "Applique des spécifications ou des techniques de conception de logiciels de niveau de base et des concepts de programmation en utilisant un ou plusieurs langages et/ou méthodologies de programmation. Teste, documente et assure l'assurance de la production et avec des orientations."
            },
            new CompetencyLevelRequirement
            {
                Id = 568,
                DescEng = "Applies one or more programming languages. Writes or adapts software modules for testing and integration. Understands and employs basic development methods and standards. Tests/debugs program modules. Uses a testing tool and prepares basic test cases. Prepares operational documentation and uses appropriate tools and technologies for developing information technology (IT) systems and services that are barrier-free and accessible.",
                DescFre = "Applique un ou plusieurs langages de programmation. Écrit ou adapte des modules logiciels pour les tester et les intégrer. Comprend et utilise des méthodes et des normes de développement de base. Teste/débogue des modules de programmes. Utilise un outil de test et prépare des cas de test de base. Prépare la documentation opérationnelle et utilise les outils et technologies appropriés pour développer des systèmes de technologie de l'information (TI) et des services accessibles et sans obstacles."
            },
            new CompetencyLevelRequirement
            {
                Id = 569,
                DescEng = "Experienced in identifying, defining, solving and prioritizing standard problems without causing other unanticipated problems. Identifies root causes, sets goals and identifies constraints. Conducts impact analysis and identifies possible consequences of actions/decisions.",
                DescFre = "Expérience de la détection, de la définition, de la résolution et de la hiérarchisation de problèmes courants sans générer d’autres problèmes imprévus. Définit les causes profondes des problèmes, fixe des objectifs et repère les contraintes. Réalise des analyses d’impact et détermine quelles sont les conséquences possibles des mesures ou des décisions prises."
            },
            new CompetencyLevelRequirement
            {
                Id = 570,
                DescEng = "Experienced in finding workable solutions to increasingly complex and multi-dimensional problems by either intuition or systematic approach. Generates and assesses alternative solutions and develops standards to evaluate different intended results offered by alternatives. Provides training and advises on best practices. Conducts monitoring and testing of solutions after implementation.",
                DescFre = "Expérience de la recherche de solutions viables à des problèmes de plus en plus complexes et multidimensionnels, que ce soit de façon intuitive ou au moyen d’une approche systématique. Génère et évalue des solutions de rechange, et établit des normes pour évaluer les différents résultats escomptés desdites solutions. Donne de la formation et formule des conseils à l’égard des pratiques exemplaires. Effectue le suivi et la mise à l’essai des solutions après leur mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 571,
                DescEng = "Revises and amends problem solving models, flowcharts, and cause and effect diagrams. Advises on multiple alternatives and expected results based on extensive experience. Evaluates effectiveness and efficiency of solution after implementation.",
                DescFre = "Révise et modifie les modèles de résolution de problèmes, les organigrammes et les diagrammes cause-effet. Formule des conseils à l’égard des différentes solutions possibles et des résultats escomptés en s’appuyant sur une expérience approfondie. Évalue l’efficacité et l’efficience de la solution après sa mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 572,
                DescEng = "Operates the platform at a basic level under supervision, according to standards for the platform.",
                DescFre = "Exploite la plate-forme à un niveau de base sous supervision, selon les normes de la plate-forme."
            },
            new CompetencyLevelRequirement
            {
                Id = 573,
                DescEng = "Operates the platform using technology and concepts that relate to each other, and with other environments. Troubleshoots basic physical or software problems. Applies the standards, including those related to privacy, accessibility for persons with disabilities, usability, and inter-operability.",
                DescFre = "Exploite la plate-forme en utilisant des technologies et des concepts qui sont en relation les uns avec les autres et avec d'autres environnements. Dépanne les problèmes physiques ou logiciels de base. Applique les normes, notamment celles relatives à la protection de la vie privée, à l'accessibilité pour les personnes ayant des incapacités, à la convivialité et à l'interopérabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 574,
                DescEng = "Participates in daily operations (e.g. monitoring operations of the platform). Uses performance data collection tools and techniques. Installs software and hardware on the platform. Solves routine, typical hardware and software problems. Uses diagnostic tools to solve complex problems.",
                DescFre = "Participe aux opérations quotidiennes (par exemple, surveiller les opérations de la plate-forme). Utilise des outils et des techniques de collecte de données sur les performances. Installe des logiciels et du matériel sur la plate-forme. Résout les problèmes routiniers, typiques du matériel et des logiciels. Utilise des outils de diagnostic pour résoudre des problèmes complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 575,
                DescEng = "Contributes to high-level architecture. Evaluates/pilots new technologies, assesses the results, identifies how they integrate with the platform, and implements them. Carries out performance measurement and capacity planning. Incorporates business requirements such as high availability, redundancy, and disaster recovery into platform design. Resolves complex problems. Develops and monitors/enforces standards and procedures for new technology configuration and implementation, including those related to accessibility for persons with disabilities. Mentors/guides individuals and cross-functional teams.",
                DescFre = "Contribue à l'architecture de haut niveau. Évalue/pilote les nouvelles technologies, évalue les résultats, identifie la manière dont elles s'intègrent à la plate-forme et les met en œuvre. Effectue la mesure des performances et la planification des capacités. Intègre les exigences opérationnelles telles que la haute disponibilité, la redondance et la reprise après sinistre dans la conception de la plateforme. Résout les problèmes complexes. Élabore et surveille/met à exécution des normes et des procédures pour la configuration et la mise en œuvre de nouvelles technologies, y compris celles liées à l'accessibilité pour les personnes ayant des incapacités. Encadre et guide les personnes et les équipes interfonctionnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 576,
                DescEng = "Advices on platform principles, technology, government-wide technology initiatives, and technological trends. Provides effective strategic direction to enterprise-wide platform design and initiatives. Develops enterprise-wide multi-disciplinary architectural and design documents. Resolves complex problems and recommends capacity and performance improvements. Conducts procurement for platform hardware and services. Sets standards and technology direction for the platform, including those related to accessibility for persons with disabilities. Leads the development of people in the infrastructure domain.",
                DescFre = "Conseils sur les principes des plates-formes, la technologie, les initiatives technologiques à l'échelle du gouvernement et les tendances technologiques. Fournit une orientation stratégique efficace pour la conception et les initiatives de plate-forme à l'échelle de l'entreprise. Élabore des documents d'architecture et de conception pluridisciplinaires à l'échelle de l'entreprise. Résout des problèmes complexes et recommande des améliorations de capacité et de performance. Effectue les achats de matériel et de services pour la plate-forme. Établit les normes et l'orientation technologique de la plate-forme, y compris celles relatives à l'accessibilité pour les personnes ayant une invalidité. Dirige le développement des personnes dans le domaine de l'infrastructure."
            },
            new CompetencyLevelRequirement
            {
                Id = 577,
                DescEng = "Employs elements of the security standards related to information technology (IT) with assistance.",
                DescFre = "Emploie avec assistance des éléments des normes de sécurité liées aux technologies de l'information (TI)."
            },
            new CompetencyLevelRequirement
            {
                Id = 578,
                DescEng = "Applies concepts of information technology (IT) security and its application to computer systems architecture.",
                DescFre = "Applique les concepts de sécurité des technologies de l'information (TI) et leur application à l'architecture des systèmes informatiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 579,
                DescEng = "Executes security test plans. Deals with low impact threats. Protects integrity of system data at an operational level. Performs security certifications. Provides advice on disaster recovery planning. Participates in disaster recovery tests. Recommends security safeguards. Executes standards.",
                DescFre = "Exécute les plans de test de sécurité. Traite les menaces à faible impact. Protège l'intégrité des données du système à un niveau opérationnel. Effectue des certifications de sécurité. Fournit des conseils sur la planification de la récupération après sinistre. Participe aux tests de reprise après sinistre. Recommande des mesures de sécurité. Exécute les normes."
            },
            new CompetencyLevelRequirement
            {
                Id = 580,
                DescEng = "Conducts risk assessments and security safeguards. Deals with threats and serious incidents. Deals with intrusions at a high threat level.",
                DescFre = "Effectue des évaluations des risques et des mesures de sécurité. Traite les menaces et les incidents graves. Traite les intrusions à haut niveau de menace."
            },
            new CompetencyLevelRequirement
            {
                Id = 581,
                DescEng = "Interprets regulations, policies, and standards related to information technology (IT) security. Leads risk and security safeguards assessments. Mitigates threats and serious security incidents at the enterprise level. Consults on security issues and recommends corporate strategies. Leads the development of enterprise policies and standards.",
                DescFre = "Interprète les règlements, politiques et normes relatifs à la sécurité des technologies de l'information (TI). Dirige les évaluations des risques et des mesures de sécurité. Atténue les menaces et les incidents de sécurité graves au niveau de l'entreprise. Consulte sur les questions de sécurité et recommande des stratégies corporatives. Dirige l'élaboration de politiques et de normes d'entreprise."
            },
            new CompetencyLevelRequirement
            {
                Id = 582,
                DescEng = "Employs service management processes and concepts (e.g. incident management, change management, release management) with assistance.",
                DescFre = "Emploie des processus et des concepts de gestion des services (par exemple, gestion des incidents, gestion des changements, gestion des versions) avec assistance."
            },
            new CompetencyLevelRequirement
            {
                Id = 583,
                DescEng = "Follows a process in problem management, change management, or configuration management. Provides information technology (IT) help desk support services. Gathers information from end-users to determine the nature of problems and resolves them. Adheres to service level agreements (SLAs) and escalates problems. Performs initial evaluations of problems and routes, when and where applicable.",
                DescFre = "Suit un processus de gestion des problèmes, de gestion des changements ou de gestion de la configuration. Fournit des services d'assistance en matière de technologies de l'information (TI). Recueille des informations auprès des utilisateurs finaux afin de déterminer la nature des problèmes et de les résoudre. Respecte les accords sur les niveaux de service (ANS) et fait remonter les problèmes. Effectue des évaluations initiales des problèmes et les achemine, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 584,
                DescEng = "Installs, configures, troubleshoots, and supports application software. Analyzes, evaluates, and diagnoses technical problems and proposes solutions. Manages process ensuring it is followed (e.g. change, problem, testing, costing, backup and recovery, quality assurance releases). Schedules releases after ensuring absence of conflicts. Guides others and implements changes to processes.",
                DescFre = "Installe, configure, dépanne et prend en charge les logiciels d'application. Analyse, évalue et diagnostique les problèmes techniques et propose des solutions. Gère le processus en veillant à ce qu'il soit suivi (par exemple, changement, problème, test, calcul des coûts, sauvegarde et récupération, versions d'assurance qualité). Planifie les versions après s'être assuré de l'absence de conflits. Guide les autres et mets en œuvre les changements apportés aux processus."
            },
            new CompetencyLevelRequirement
            {
                Id = 585,
                DescEng = "Manages the provision of help desk services and problem resolution. Analyzes problem trends and makes recommendations. Develops service management processes. Writes/negotiates service level agreements (SLAs) for operational and internal agreements. Establishes and monitors service standards.",
                DescFre = "Gère la fourniture de services d'assistance et la résolution des problèmes. Analyse les tendances des problèmes et fait des recommandations. Développe les processus de gestion des services. Rédige/négocie des accords sur les niveaux de service (ANS) pour les accords opérationnels et internes. Établit et surveille les normes de service."
            },
            new CompetencyLevelRequirement
            {
                Id = 586,
                DescEng = "Negotiates, develops, implements, and manages service level agreements (SLAs). Develops service management standards, practices, and policies. Provides guidelines for service management (e.g. recommends changes based upon results of a customer satisfaction survey). Recommends continual improvement in service management strategy and processes.",
                DescFre = "Négocie, développe, met en œuvre et gère les accords sur les niveaux de service (ANS). Élabore des normes, des pratiques et des politiques de gestion des services. Fournit des lignes directrices pour la gestion des services (par exemple, recommande des changements sur la base des résultats d'une enquête de satisfaction des clients). Recommande l'amélioration continue de la stratégie et des processus de gestion des services."
            },
            new CompetencyLevelRequirement
            {
                Id = 587,
                DescEng = "Applies basic testing terminology, practices, and procedures to tasks related to testing a system's effectiveness.",
                DescFre = "Applique la terminologie, les pratiques et les procédures de test de base aux tâches liées à l'évaluation de l'efficacité d'un système."
            },
            new CompetencyLevelRequirement
            {
                Id = 588,
                DescEng = "Conducts unit testing using via approved testing tools and established standards for testing. Executes test scripts. Reports test results.",
                DescFre = "Effectue des tests unitaires en utilisant des outils de test approuvés et des normes de test établies. Exécute des scripts de test. Rapporte les résultats des tests."
            },
            new CompetencyLevelRequirement
            {
                Id = 589,
                DescEng = "Prepares test cases/scripts. Carries out complex testing/validation (e.g. volume testing, integration testing). Troubleshoots and resolves issues. Applies standards for testing, including a methodology and test plan to address accessibility for persons with disabilities, copyright, privacy, usability, and inter-operability.",
                DescFre = "Prépare les tests/scripts. Effectue des tests/validations complexes (par exemple, tests de volume, tests d'intégration). Dépanne et résout les problèmes. Applique des normes de test, y compris une méthodologie et un plan de test pour aborder les questions d'accessibilité pour les personnes ayant une incapacité, de droits d'auteur, de respect de la vie privée, de convivialité et d'interopérabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 590,
                DescEng = "Conducts application testing and complex series test scenarios. Prepares test plans and strategies. Researches and tests testing tools and makes recommendations. Develops test practices. Implements and monitors standards for testing. Guides application stakeholders in testing methods and tools.",
                DescFre = "Effectue des tests d'application et des scénarios de tests en série complexes. Prépare des plans et des stratégies de test. Effectue des recherches et des tests sur les outils de test et formule des recommandations. Développe des pratiques de test. Mets en œuvre et surveille les normes de test. Guide les parties prenantes de l'application dans les méthodes et les outils de test."
            },
            new CompetencyLevelRequirement
            {
                Id = 591,
                DescEng = "Manages integration testing. Sets standards for cycle testing. Designs and implements organizational testing methodologies and test plans. Develops test standards, best practices, and policies.",
                DescFre = "Gère les tests d'intégration. Établit des normes pour les tests de cycle. Conçoit et met en œuvre des méthodologies de test organisationnel et des plans de test. Élabore des normes de test, des meilleures pratiques et des politiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 592,
                DescEng = "Manipulates database information, using logical design concepts, and levels of database security. Applies various database structures (e.g. relational vs. network) in basic design (e.g. diagrams, schemas, models). Addresses minor performance issues (e.g. distribution of data, size definitions).",
                DescFre = "Manipule les informations des bases de données, en utilisant des concepts de conception logique et des niveaux de sécurité des bases de données. Applique diverses structures de base de données (par exemple, relationnelle ou réseau) dans la conception de base (par exemple, diagrammes, schémas, modèles). Résoudre des problèmes mineurs de performance (par exemple, la distribution des données, les définitions de taille)."
            },
            new CompetencyLevelRequirement
            {
                Id = 593,
                DescEng = "Manages a single database management system (DBMS), its components and how they relate to each other. Codes/tests basic database access modules (e.g. stored procedures). Troubleshoots, at a basic level, to understand database problems and identifies where to direct it (e.g. basic database accessibility). Recognizes the importance of database basic recovery and, with guidance, performs backup and recovery. Performs data population, debugging, and testing. Conducts basic impact analysis for database change management.",
                DescFre = "Gère un système de gestion de base de données (SGBD) unique, ses composants et leurs relations entre eux. code/teste les modules d'accès de base aux bases de données (par exemple, les procédures stockées). Dépanne, à un niveau élémentaire, pour comprendre les problèmes de la base de données et identifie où la diriger (par exemple, l'accessibilité de base de la base de données). Reconnaît l'importance de la récupération de base de données et, avec des conseils, effectue la sauvegarde et la récupération. Effectue la population de données, le débogage et les tests. Effectue une analyse d'impact de base pour la gestion des modifications de la base de données."
            },
            new CompetencyLevelRequirement
            {
                Id = 594,
                DescEng = "Manages single database management systems (DBMS) and its relevant operating systems, applications business rules, and its dependencies with other applications, databases and/or business partners in daily tasks. Applies a wide range of concepts to the corporate/vendor environment (e.g. database security and/or individual profiles).Develops, codes, tests, and reviews complex database access modules. Solves problems that impact on the business or service, resolves data integrity issues and implements data integrity safeguards, and uses diagnostic and monitoring tools to prevent problems/enhance performance and availability. Conducts general impact analysis on database change management.",
                DescFre = "Gère les systèmes de gestion de base de données (SGBD) uniques et leurs systèmes d'exploitation pertinents, les règles de gestion des applications et leurs dépendances avec d'autres applications, bases de données et/ou partenaires opérationnels dans les tâches quotidiennes. Applique un large éventail de concepts à l'environnement de l'entreprise ou du fournisseur (par exemple, la sécurité des bases de données et/ou les profils individuels). Développe, code, teste et examine des modules complexes d'accès aux bases de données. Résout les problèmes qui ont un impact sur les activités ou les services, résout les problèmes d'intégrité des données et met en œuvre des mesures de protection de l'intégrité des données, et utilise des outils de diagnostic et de surveillance pour prévenir les problèmes/améliorer les performances et la disponibilité. Effectue une analyse générale de l'impact sur la gestion des modifications des bases de données."
            },
            new CompetencyLevelRequirement
            {
                Id = 595,
                DescEng = "Manages multiple database management systems (DBMS). Develops logical models incorporating business requirements such as high availability, redundancy and disaster recovery into the logical/physical database design. Researches, pilots, evaluates new technologies and standards, and identifies how they will integrate with the corporate network, and recommends strategies. Solves unusual problems or problems with a significant impact on the business. Deals with major and/or multiple application groups. Creates or reviews certification testing. Develops standards and procedures for implementing new database technology. Mentors people and provides input/guidance to cross-functional teams.",
                DescFre = "Gère plusieurs systèmes de gestion de bases de données (SGBD). Développe des modèles logiques incorporant des exigences opérationnelles telles que la haute disponibilité, la redondance et la reprise après sinistre dans la conception logique/physique des bases de données. Effectue des recherches, pilote, évalue les nouvelles technologies et normes, et identifie comment elles s'intégreront au réseau de l'entreprise, et recommande des stratégies. Résout les problèmes inhabituels ou ayant un impact important sur l'entreprise. Traite des groupes d'applications majeurs et/ou multiples. Crée ou révise des tests de certification. Élabore des normes et des procédures pour la mise en œuvre de nouvelles technologies de bases de données. Encadre les personnes et fournit une contribution/orientation aux équipes interfonctionnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 596,
                DescEng = "Manages data management, data stewardship, government-wide data management initiatives, and trends in data management and how they can be applied on behalf of the Canadian Coast Guard. Provides effective strategic direction to enterprise-wide data management. Develops enterprise-wide multi-disciplinary architectural documents translating business data requirements into topographical format. Develops business cases for enterprise-wide data management initiatives as a direct response to business drivers. Guides and oversees multiple-concurrent data management systems. Conducts procurement for data management solutions and related services. Develops strategies, policy, and standards for corporate data management and contributes to governmental working groups.",
                DescFre = "Gère la gestion des données, l'intendance des données, les initiatives de gestion des données à l'échelle du gouvernement et les tendances en matière de gestion des données et la façon dont elles peuvent être appliquées au nom de la Garde côtière canadienne. Fournit une orientation stratégique efficace pour la gestion des données à l'échelle de l'entreprise. Elabore des documents d'architecture multidisciplinaires à l'échelle de l'entreprise en traduisant les besoins en données opérationnelles en format topographique. Élabore des analyses de rentabilisation pour les initiatives de gestion des données à l'échelle de l'entreprise en réponse directe aux facteurs opérationnels. Guide et supervise des systèmes de gestion de données multiples et simultanées. Effectue des achats pour des solutions de gestion de données et des services connexes. Développe des stratégies, des politiques et des normes pour la gestion des données d'entreprise et contribue aux groupes de travail gouvernementaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 597,
                DescEng = "Basic knowledge of ship or land based marine electronic devices commonly used in the Coast Guard.",
                DescFre = "Connaissance de base des dispositifs électroniques maritimes embarqués ou terrestres qui sont couramment utilisés à la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 598,
                DescEng = "Limited knowledge of the function, installation and connection requirements of commonly installed marine electronic equipment. Understands how to install, adjust, or maintain electronics communication equipment, including sound, sonar, security, navigation, and surveillance systems. Understands technical manuals and written procedures.",
                DescFre = "Connaissance limitée des exigences relatives à la fonction, à l’installation et à la connexion du matériel électronique maritime couramment installé. Compréhension de l’installation, de la mise au point ou de l’entretien du matériel électronique de communication, notamment les systèmes sonores, sonar, de sécurité, de navigation et de surveillance. Compréhension des manuels techniques et des procédures écrites."
            },
            new CompetencyLevelRequirement
            {
                Id = 599,
                DescEng = "Practical knowledge of generic procedures for programming electronic equipment in accordance with industry practice. Understands the procedures for commissioning and replacement of electronic equipment. Understands the selection considerations, maintenance, and troubleshooting of electronic equipment.",
                DescFre = "Connaissance pratique des procédures génériques pour la programmation du matériel électronique conformément à la pratique de l’industrie. Compréhension des procédures de mise en service et de remplacement du matériel électronique. Compréhension des critères de sélection, de l’entretien et du dépannage en ce qui concerne le matériel électronique."
            },
            new CompetencyLevelRequirement
            {
                Id = 600,
                DescEng = "Advanced knowledge of procedures for programming, commissioning, replacement, and troubleshooting of marine electronic equipment. Understands equipment specifications and marine electronic equipment selection considerations.",
                DescFre = "Connaissance approfondie de procédures de programmation, de mise en service, de remplacement et de dépannage en ce qui concerne le matériel électronique maritime. Compréhension des spécifications du matériel et des critères de sélection du matériel électronique maritime."
            },
            new CompetencyLevelRequirement
            {
                Id = 601,
                DescEng = "Expert knowledge in identifying complex problems and reviewing related information to develop and evaluate options and implement solutions. ",
                DescFre = "Connaissance spécialisée de la détermination de problèmes complexes et de l’examen des renseignements connexes afin d’élaborer et d’évaluer les options et de mettre en œuvre des solutions."
            },
            new CompetencyLevelRequirement
            {
                Id = 602,
                DescEng = "Informs analysis with a thorough understanding of the environment. Engages others to translate implementation strategies into concrete objectives. Contributes expertise and insight to the development of organizational strategies. Communicates with clarity and conviction. Implements strategies that respond to organizational priorities that improve outcomes for Canada and Canadians.",
                DescFre = "Informe l'analyse grâce à une compréhension approfondie de l'environnement. Engage les autres à traduire les stratégies de mise en œuvre en objectifs concrets. Apporter son expertise et sa perspicacité à l'élaboration de stratégies organisationnelles. Communique avec clarté et conviction. Mettre en œuvre des stratégies qui répondent aux priorités organisationnelles et qui améliorent les résultats pour le Canada et les Canadiens."
            },
            new CompetencyLevelRequirement
            {
                Id = 603,
                DescEng = "Understands the context of, informs stakeholders involved and synthesizes options on key issues in the environment. Engages others to secure commitment to implementation objectives. Contributes expertise and insight to the development of organizational priorities and strategy. Communicates with clarity and conviction. Implements strategies that respond to organizational priorities that improve outcomes for Canada and Canadians.",
                DescFre = "Comprend le contexte, informe les intervenants concernés et fait la synthèse des options sur les principaux enjeux de l'environnement. Engage les autres à s'engager à atteindre les objectifs de mise en œuvre. Apporter son expertise et sa perspicacité à l'élaboration des priorités et de la stratégie de l'organisation. Communique avec clarté et conviction. Mettre en œuvre des stratégies qui répondent aux priorités organisationnelles et qui améliorent les résultats pour le Canada et les Canadiens."
            },
            new CompetencyLevelRequirement
            {
                Id = 604,
                DescEng = "Interprets context and identifies implications of key issues in the environment. Engages others to secure commitment to implementation objectives. Contributes expertise and insight to the development of organizational priorities and strategy. Communicates with clarity and conviction. Implements strategies that respond to organizational priorities that improve outcomes for Canada and Canadians.",
                DescFre = "Interpréter le contexte et déterminer les répercussions des principaux enjeux environnementaux. Engage les autres à s'engager à atteindre les objectifs de mise en œuvre. Apporter son expertise et sa perspicacité à l'élaboration des priorités et de la stratégie de l'organisation. Communique avec clarté et conviction. Mettre en œuvre des stratégies qui répondent aux priorités organisationnelles et qui améliorent les résultats pour le Canada et les Canadiens."
            },
            new CompetencyLevelRequirement
            {
                Id = 605,
                DescEng = "Frames emerging issues and provides advice that reflects a thorough understanding of the environment. Engages others to develop clear, concise and viable strategies for implementation. Contributes expertise and insight to the development of the departmental vision and strategy. Establishes and communicates organizational priorities aligned with the department's vision and goals. Commits to the implementation of strategies that improve outcomes for Canada and Canadians.",
                DescFre = "Encadre les nouveaux enjeux et fournit des conseils qui reflètent une compréhension approfondie de l'environnement. Engage les autres à élaborer des stratégies de mise en œuvre claires, concises et viables. Contribuer par son expertise et sa perspicacité à l'élaboration de la vision et de la stratégie ministérielles. Établir et communiquer les priorités organisationnelles qui correspondent à la vision et aux objectifs du Ministère. S'engage à mettre en œuvre des stratégies qui améliorent les résultats pour le Canada et les Canadiens."
            },
            new CompetencyLevelRequirement
            {
                Id = 606,
                DescEng = "Extracts the key issues from complex, ambiguous, and rapidly changing environments. Considers the impact of the economic, social, and political environment on departmental priorities. Engages others to develop a compelling and responsive vision. Defines and communicates the departmental vision and strategy with a thorough understanding of the internal and external environment. Sets forward-looking goals with a broad perspective and long-term timelines to improve outcomes for Canada and Canadians.",
                DescFre = "Extrait les questions clés d'environnements complexes, ambigus et en rapide évolution. Tient compte de l'incidence de l'environnement économique, social et politique sur les priorités ministérielles. Engage les autres à développer une vision convaincante et réceptive. Définir et communiquer la vision et la stratégie du Ministère en ayant une compréhension approfondie de l'environnement interne et externe. Établit des objectifs prospectifs avec une vaste perspective et des échéanciers à long terme afin d'améliorer les résultats pour le Canada et les Canadiens."
            },
            new CompetencyLevelRequirement
            {
                Id = 607,
                DescEng = "Creates a sense of common purpose and direction in the organization and among colleagues. Sets clear expectations, monitors, and evaluates performance. Invests time and resources to support continuous learning. Gives honest feedback, recognizes performance, and manages non-performance. Engages employees to gather ideas and input to build cohesive teams. Sets challenging goals for self and models dedication and high performance.",
                DescFre = "Crée un sentiment d'objectif et d'orientation communs au sein de l'organisation et entre collègues. Établit des attentes claires, surveille et évalue le rendement. Investit du temps et des ressources pour appuyer l'apprentissage continu. Donne une rétroaction honnête, reconnaît le rendement et gère la non-performance. Engage les employés à recueillir des idées et des commentaires pour bâtir des équipes cohésives. Fixe des objectifs stimulants pour soi-même et les modèles de dévouement et de haute performance."
            },
            new CompetencyLevelRequirement
            {
                Id = 608,
                DescEng = "Creates a sense of common purpose and direction in the organization and among colleagues. Sets clear expectations, develops methods for evaluation, and oversees performance management practices. Commits to the development of organizational and individual talent. Gives honest feedback, recognizes performance, and manages non-performance. Facilitates opportunities for branch-wide feedback and constructive dialogue. Sets challenging goals for self and models dedication and high performance.",
                DescFre = "Crée un sentiment d'objectif et d'orientation communs au sein de l'organisation et entre collègues. Établit des attentes claires, élabore des méthodes d'évaluation et supervise les pratiques de gestion du rendement. S'engage à développer les talents organisationnels et individuels. Donne une rétroaction honnête, reconnaît le rendement et gère la non-performance. Facilite les occasions de rétroaction et de dialogue constructif à l'échelle de la direction générale. Fixe des objectifs stimulants pour soi-même et les modèles de dévouement et de haute performance."
            },
            new CompetencyLevelRequirement
            {
                Id = 609,
                DescEng = "Creates a sense of common purpose and direction in the organization and among colleagues. Sets clear expectations and conducts oversight of performance management practices. Commits to the development of organizational and individual talent. Gives honest feedback, recognizes performance, and manages non-performance. Creates opportunities for open and constructive dialogue. Sets challenging goals for self and models dedication and high performance.",
                DescFre = "Crée un sentiment d'objectif et d'orientation communs au sein de l'organisation et entre collègues. Établit des attentes claires et surveille les pratiques de gestion du rendement. S'engage à développer les talents organisationnels et individuels. Donne une rétroaction honnête, reconnaît le rendement et gère la non-performance. Crée des occasions de dialogue ouvert et constructif. Fixe des objectifs stimulants pour soi-même et les modèles de dévouement et de haute performance."
            },
            new CompetencyLevelRequirement
            {
                Id = 610,
                DescEng = "Creates a sense of common purpose and direction in the organization and among colleagues. Sets and communicates clear performance expectations and exercises rigorous oversight. Identifies, manages, and supports collective and individual talent. Cultivates an environment committed to continuous learning and professional development. Creates a positive environment to encourage open and constructive dialogue. Sets challenging goals for self and models dedication and high performance.",
                DescFre = "Crée un sentiment d'objectif et d'orientation communs au sein de l'organisation et entre collègues. Établit et communique des attentes claires en matière de rendement et exerce une surveillance rigoureuse. Identifie, gère et soutient les talents collectifs et individuels. Cultive un environnement engagé envers l'apprentissage continu et le perfectionnement professionnel. Crée un environnement positif pour encourager un dialogue ouvert et constructif. Fixe des objectifs stimulants pour soi-même et les modèles de dévouement et de haute performance."
            },
            new CompetencyLevelRequirement
            {
                Id = 611,
                DescEng = "Creates a sense of common purpose and direction in the department. Builds accountability and value for people management within the executive community. Creates an environment where rigorous performance management is practiced. Invests time in managing and developing organizational leaders, individually, and collectively. Generates opportunities to engage meaningfully with employees. Builds a commitment to excellence through open and constructive dialogue. Inspires others through personal dedication and actions.",
                DescFre = "Crée un sentiment d'objectif et d'orientation communs au sein du ministère. Renforce la responsabilisation et la valeur de la gestion des personnes au sein de la communauté des cadres supérieurs. Crée un environnement où une gestion rigoureuse du rendement est pratiquée. Investit du temps dans la gestion et le perfectionnement des leaders organisationnels, individuellement et collectivement. Génère des occasions de s'engager de façon significative avec les employés. Suscite un engagement envers l'excellence par le biais d'un dialogue ouvert et constructif. Inspire les autres par son dévouement personnel et ses actions."
            },
            new CompetencyLevelRequirement
            {
                Id = 612,
                DescEng = "Values and provides authentic, evidence-based advice in the interest of Canadians. Holds self and the organization to the highest ethical and professional standards. Models commitment to citizen-focused service and the public interest. Creates opportunities that encourage bilingualism and diversity. Implements practices to advance an inclusive, healthy organization, respectful of the diversity of people, and their skills and free from harassment and discrimination. Exemplifies impartial and non-partisan decision-making. Engages in self-reflection and acts upon insights.",
                DescFre = "Valorise et fournit des conseils authentiques et fondés sur des données probantes dans l'intérêt des Canadiens. Se tient, ainsi que l'organisation, aux normes éthiques et professionnelles les plus élevées. Donne l'exemple d'un engagement à l'égard d'un service axé sur les citoyens et de l'intérêt public. Crée des possibilités qui favorisent le bilinguisme et la diversité. Mettre en œuvre des pratiques visant à promouvoir une organisation inclusive et saine, respectueuse de la diversité des personnes et de leurs compétences et exempte de harcèlement et de discrimination. Fait preuve d'impartialité et d'impartialité dans la prise de décisions. S'engage dans l'autoréflexion et agit en fonction de ses intuitions."
            },
            new CompetencyLevelRequirement
            {
                Id = 613,
                DescEng = "Values and provides authentic, evidence-based advice in the interest of Canadians. Holds self and the organization to the highest ethical and professional standards. Models commitment to citizen-focused service and the public interest. Creates opportunities that encourage bilingualism and diversity. Develops and implements strategies to foster an inclusive, healthy organization, respectful of the diversity of people, and their skills and free from harassment and discrimination. Exemplifies impartial and non-partisan decision-making. Engages in self-reflection and acts upon insights.",
                DescFre = "Valorise et fournit des conseils authentiques et fondés sur des données probantes dans l'intérêt des Canadiens. Se tient, ainsi que l'organisation, aux normes éthiques et professionnelles les plus élevées. Donne l'exemple d'un engagement à l'égard d'un service axé sur les citoyens et de l'intérêt public. Crée des possibilités qui favorisent le bilinguisme et la diversité. Élabore et met en œuvre des stratégies pour favoriser une organisation inclusive et saine, respectueuse de la diversité des personnes et de leurs compétences et exempte de harcèlement et de discrimination. Fait preuve d'impartialité et d'impartialité dans la prise de décisions. S'engage dans l'autoréflexion et agit en fonction de ses intuitions."
            },
            new CompetencyLevelRequirement
            {
                Id = 614,
                DescEng = "Values and provides authentic, evidence-based advice in the interest of Canadians. Holds self and the organization to the highest ethical and professional standards. Models commitment to citizen-focused service and the public interest. Creates opportunities that encourage bilingualism and diversity. Advances strategies to foster an inclusive, healthy organization, respectful of the diversity of people, and their skills and free from harassment and discrimination. Exemplifies impartial and non-partisan decision-making. Engages in self-reflection and acts upon insights.",
                DescFre = "Valorise et fournit des conseils authentiques et fondés sur des données probantes dans l'intérêt des Canadiens. Se tient, ainsi que l'organisation, aux normes éthiques et professionnelles les plus élevées. Donne l'exemple d'un engagement à l'égard d'un service axé sur les citoyens et de l'intérêt public. Crée des possibilités qui favorisent le bilinguisme et la diversité. Fait progresser les stratégies visant à favoriser une organisation inclusive et saine, respectueuse de la diversité des personnes et de leurs compétences et exempte de harcèlement et de discrimination. Fait preuve d'impartialité et d'impartialité dans la prise de décisions. S'engage dans l'autoréflexion et agit en fonction de ses intuitions."
            },
            new CompetencyLevelRequirement
            {
                Id = 615,
                DescEng = "Values and provides authentic, evidence-based advice in the interest of Canadians. Holds self and the organization to the highest ethical and professional standards. Models and builds a culture of commitment to citizen-focused service and the public interest. Builds and promotes a bilingual, inclusive, healthy organization respectful of the diversity of people, and their skills and free from harassment and discrimination. Exemplifies impartial and non-partisan decision-making. Engages in self-reflection and acts upon insights.",
                DescFre = "Valorise et fournit des conseils authentiques et fondés sur des données probantes dans l'intérêt des Canadiens. Se tient, ainsi que l'organisation, aux normes éthiques et professionnelles les plus élevées. Modélise et bâtit une culture d'engagement à l'égard d'un service axé sur les citoyens et de l'intérêt public. Bâtit et fait la promotion d'une organisation bilingue, inclusive et saine, respectueuse de la diversité des personnes et de leurs compétences, et exempte de harcèlement et de discrimination. Fait preuve d'impartialité et d'impartialité dans la prise de décisions. S'engage dans l'autoréflexion et agit en fonction de ses intuitions."
            },
            new CompetencyLevelRequirement
            {
                Id = 616,
                DescEng = "Values and provides authentic, evidence-based advice in the interest of Canadians. Holds self and the organization to the highest ethical and professional standards. Models and instills commitment to citizen-focused service and the public interest. Builds and promotes a bilingual, inclusive, healthy organization respectful of the diversity of people, and their skills and free from harassment and discrimination. Exemplifies impartial and non-partisan decision-making. Engages in self-reflection and acts upon insights.",
                DescFre = "Valorise et fournit des conseils authentiques et fondés sur des données probantes dans l'intérêt des Canadiens. Se tient, ainsi que l'organisation, aux normes éthiques et professionnelles les plus élevées. Donne l'exemple et suscite l'engagement à l'égard d'un service axé sur les citoyens et de l'intérêt public. Bâtit et fait la promotion d'une organisation bilingue, inclusive et saine, respectueuse de la diversité des personnes et de leurs compétences, et exempte de harcèlement et de discrimination. Fait preuve d'impartialité et d'impartialité dans la prise de décisions. S'engage dans l'autoréflexion et agit en fonction de ses intuitions."
            },
            new CompetencyLevelRequirement
            {
                Id = 617,
                DescEng = "Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders. Engages others to support horizontal initiatives. Actively listens to understand the impact of issues and perspectives of others. Implements strategies that enhance collaboration. Acknowledges the contribution of others in achieving objectives.",
                DescFre = "Établit et entretient des réseaux et des relations de collaboration efficaces avec les communautés de pratique, les collègues et les intervenants. Engage les autres à appuyer les initiatives horizontales. Écoute activement pour comprendre l'impact des enjeux et des points de vue des autres. Mettre en œuvre des stratégies qui améliorent la collaboration. Reconnaît la contribution des autres à l'atteinte des objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 618,
                DescEng = "Builds and nurtures effective and collaborative relationships. Explores contingencies and implements strategic alliances with partners and stakeholders. Engages colleagues to contribute to horizontal initiatives. Actively listens to understand the impact of issues and perspectives of others. Identifies opportunities and develops strategies for collaboration. Acknowledges the contribution of others in achieving objectives.",
                DescFre = "Bâtit et entretient des relations efficaces et collaboratives. Explorer les éventualités et mettre en œuvre des alliances stratégiques avec des partenaires et des intervenants. Engage les collègues à contribuer aux initiatives horizontales. Écoute activement pour comprendre l'impact des enjeux et des points de vue des autres. Cerner les possibilités et élaborer des stratégies de collaboration. Reconnaît la contribution des autres à l'atteinte des objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 619,
                DescEng = "Builds and nurtures effective and collaborative relationships. Seeks opportunities to advance strategic alliances with partners and stakeholders. Engages colleagues to contribute to horizontal initiatives. Actively listens to understand the impact of issues and perspectives of others. Identifies opportunities and develops strategies for collaboration. Acknowledges the contribution of others in achieving objectives.",
                DescFre = "Bâtit et entretient des relations efficaces et collaboratives. Cherche des occasions de faire progresser les alliances stratégiques avec les partenaires et les intervenants. Engage les collègues à contribuer aux initiatives horizontales. Écoute activement pour comprendre l'impact des enjeux et des points de vue des autres. Cerner les possibilités et élaborer des stratégies de collaboration. Reconnaît la contribution des autres à l'atteinte des objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 620,
                DescEng = "Builds and nurtures effective and collaborative relationships. Seeks and forms strategic alliances with partners and stakeholders to continuously improve upon results. Engages colleagues to deliver on horizontal initiatives. Actively listens to understand the impact of issues and perspectives of others. Generates support from partners and stakeholders through influence and negotiation. Acknowledges the contribution of others in achieving objectives.",
                DescFre = "Bâtit et entretient des relations efficaces et collaboratives. Recherche et forme des alliances stratégiques avec des partenaires et des intervenants afin d'améliorer continuellement les résultats. Engage les collègues à mettre en œuvre des initiatives horizontales. Écoute activement pour comprendre l'impact des enjeux et des points de vue des autres. Suscite l'appui des partenaires et des intervenants grâce à l'influence et à la négociation. Reconnaît la contribution des autres à l'atteinte des objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 621,
                DescEng = "Builds and nurtures effective and collaborative relationships. Forms strategic alliances with partners and stakeholders to advance government priorities. Engages colleagues to deliver on horizontal initiatives. Collaborates with other Deputy Ministers as a community to strengthen public service performance. Advances whole-of-government objectives through influence and negotiation. Acknowledges the contribution of others in achieving objectives.",
                DescFre = "Bâtit et entretient des relations efficaces et collaboratives. Forme des alliances stratégiques avec des partenaires et des intervenants pour faire avancer les priorités du gouvernement. Engage les collègues à mettre en œuvre des initiatives horizontales. Collabore avec d'autres sous-ministres en tant que communauté pour renforcer le rendement de la fonction publique. Suscite l'appui des partenaires et des intervenants grâce à l'influence et à la négociation. Reconnaît la contribution des autres à l'atteinte des objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 622,
                DescEng = "Ensures that employees apply sound risk management practices. Identifies opportunities for and barriers to innovation and proposes creative approaches. Implements practices to learn from setbacks and mistakes. Adapts plans and strategies to respond to the scope and pace of change. Demonstrates resilience, composure, and a positive outlook in an environment of uncertainty and ambiguity.",
                DescFre = "Veiller à ce que les employés appliquent de saines pratiques de gestion des risques. Identifie les opportunités et les obstacles à l'innovation et propose des approches créatives. Mettre en œuvre des pratiques pour tirer des leçons des échecs et des erreurs. Adapte les plans et les stratégies pour répondre à la portée et au rythme du changement. Fait preuve de résilience, de sang-froid et d'une attitude positive dans un climat d'incertitude et d'ambiguïté."
            },
            new CompetencyLevelRequirement
            {
                Id = 623,
                DescEng = "Develops and implements sound risk management strategies. Promotes an environment that is open to new initiatives and responsible risk-taking based on sound project management principles. Details lessons learned from setbacks and mistakes to ensure continuous improvement. Explains to and supports employees in adapting to the scope and pace of change. Explores and proposes new ideas and identifies options to maximize potential for innovation. Demonstrates resilience, composure and a positive outlook in an environment of uncertainty and ambiguity.",
                DescFre = "Élabore et met en œuvre de saines stratégies de gestion des risques. Favorise un environnement ouvert aux nouvelles initiatives et à la prise de risque responsable, fondé sur des principes de saine gestion de projet. Détaille les leçons tirées des échecs et des erreurs afin d'assurer une amélioration continue. Explique aux employés et les aide à s'adapter à la portée et au rythme du changement. Explorer et proposer de nouvelles idées et identifier des options pour maximiser le potentiel d'innovation. Fait preuve de résilience, de sang-froid et d'une attitude positive dans un climat d'incertitude et d'ambiguïté."
            },
            new CompetencyLevelRequirement
            {
                Id = 624,
                DescEng = "Develops and implements sound risk management strategies. Fosters an environment that is open to creativity and responsible risk-taking. Learns from setbacks and mistakes to ensure continuous improvement. Engages and supports employees in adapting to the scope and pace of change. Anticipates barriers to new ideas and identifies solutions to maximize potential for innovation. Demonstrates resilience, composure, and a positive outlook in an environment of uncertainty and ambiguity.",
                DescFre = "Élabore et met en œuvre de saines stratégies de gestion des risques. Favorise un environnement ouvert à la créativité et à la prise de risque responsable. Apprend des échecs et des erreurs pour assurer une amélioration continue. Engage et aide les employés à s'adapter à la portée et au rythme du changement. Anticiper les obstacles aux nouvelles idées et trouver des solutions pour maximiser le potentiel d'innovation. Fait preuve de résilience, de sang-froid et d'une attitude positive dans un climat d'incertitude et d'ambiguïté."
            },
            new CompetencyLevelRequirement
            {
                Id = 625,
                DescEng = "Defines and communicates the parameters of acceptable risk. Creates a safe environment for creativity and learns from setbacks and mistakes. Advances and implements strategies that manage the scope and pace of change. Addresses barriers to new ideas and negotiates solutions to maximize potential for innovation. Demonstrates resilience, composure, and a positive outlook in an environment of uncertainty and ambiguity.",
                DescFre = "Définit et communique les paramètres du risque acceptable. Crée un environnement sûr pour la créativité et apprend des échecs et des erreurs. Faire progresser et mettre en œuvre des stratégies qui gèrent la portée et le rythme du changement. S'attaque aux obstacles aux nouvelles idées et négocie des solutions pour maximiser le potentiel d'innovation. Fait preuve de résilience, de sang-froid et d'une attitude positive dans un climat d'incertitude et d'ambiguïté."
            },
            new CompetencyLevelRequirement
            {
                Id = 626,
                DescEng = "Champions a culture that challenges the status quo and encourages responsible risk taking. Encourages experimentation and genuine evaluation of outcomes. Manages the scope and pace of change. Reconciles priorities to achieve broader objectives. Demonstrates resilience, composure, and a positive outlook in an environment of uncertainty and ambiguity.",
                DescFre = "Se fait le champion d'une culture qui remet en question le statu quo et encourage la prise de risques responsables. Favorise l'expérimentation et une véritable évaluation des résultats. Gère la portée et le rythme du changement. Concilie les priorités pour atteindre des objectifs plus larges. Fait preuve de résilience, de sang-froid et d'une attitude positive dans un climat d'incertitude et d'ambiguïté."
            },
            new CompetencyLevelRequirement
            {
                Id = 627,
                DescEng = "Aligns people, work, and systems to achieve program and policy efficiencies and results. Quantifies, monitors, and controls resources and costs. Sets and revises goals and plans to reflect changing priorities or conditions. Delegates responsibility and accountability to appropriate levels. Informs decision-making with sound understanding of context, data, and evidence. Demonstrates and promotes stewardship of financial and organizational resources. Makes challenging decisions and takes action at the opportune time. Takes ownership and acknowledges impact and outcome of decisions.",
                DescFre = "Harmonise les gens, le travail et les systèmes afin d'atteindre l'efficacité et les résultats des programmes et des politiques. Quantifier, surveiller et contrôler les ressources et les coûts. Établit et révise les objectifs et les plans en fonction de l'évolution des priorités ou des conditions. Délègue la responsabilité et l'obligation de rendre compte aux niveaux appropriés. Éclaire la prise de décision grâce à une bonne compréhension du contexte, des données et des éléments probants. Démontrer et promouvoir la gérance des ressources financières et organisationnelles. Prend des décisions difficiles et prend des mesures au moment opportun. S'approprier et reconnaître l'impact et les résultats des décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 628,
                DescEng = "Assimilates financial, material, human, and system resources to improve outcomes and maximize results. Fosters best project management principles with thorough planning, monitoring, and control of resources incorporated. Delegates responsibility and accountability to appropriate levels. Informs decision-making with sound understanding of context, data, and evidence. Demonstrates and promotes stewardship of financial and organizational resources. Makes challenging decisions and takes action at the opportune time. Takes ownership and acknowledges impact and outcome of decisions.",
                DescFre = "Assimilation des ressources financières, matérielles, humaines et systémiques pour améliorer les résultats et maximiser les résultats. Favorise les meilleurs principes de gestion de projet grâce à une planification, un suivi et un contrôle minutieux des ressources intégrés. Délègue la responsabilité et l'obligation de rendre compte aux niveaux appropriés. Éclaire la prise de décision grâce à une bonne compréhension du contexte, des données et des éléments probants. Démontrer et promouvoir la gérance des ressources financières et organisationnelles. Prend des décisions difficiles et prend des mesures au moment opportun. S'approprier et reconnaître l'impact et les résultats des décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 629,
                DescEng = "Implements strategies to align people, work, and systems to improve outcomes and maximize results. Ensures that the pace, scope, and cost of initiatives are planned, monitored, and controlled. Delegates responsibility and accountability to appropriate levels. Informs decision-making with sound understanding of context, data, and evidence. Demonstrates and promotes stewardship of financial and organizational resources. Makes challenging decisions and takes action at the opportune time. Takes ownership and acknowledges impact and outcome of decisions.",
                DescFre = "Mettre en œuvre des stratégies pour harmoniser les personnes, le travail et les systèmes afin d'améliorer les résultats et de maximiser les résultats. Veiller à ce que le rythme, la portée et le coût des initiatives soient planifiés, surveillés et contrôlés. Délègue la responsabilité et l'obligation de rendre compte aux niveaux appropriés. Éclaire la prise de décision grâce à une bonne compréhension du contexte, des données et des éléments probants. Démontrer et promouvoir la gérance des ressources financières et organisationnelles. Prend des décisions difficiles et prend des mesures au moment opportun. S'approprier et reconnaître l'impact et les résultats des décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 630,
                DescEng = "Develops strategies to maximize the effectiveness of resources, improve outcomes, and results. Ensures rigorous planning and implementation to deliver on priorities. Delegates responsibility and accountability to appropriate levels. Informs decision-making with sound understanding of context, data, and evidence. Sets high expectations by exemplifying stewardship of financial and organizational resources. Makes challenging decisions and takes action at the opportune time. Takes ownership and acknowledges impact and outcome of decisions.",
                DescFre = "Élabore des stratégies pour maximiser l'efficacité des ressources, améliorer les résultats et les résultats. Assurer une planification et une mise en œuvre rigoureuses afin de respecter les priorités. Délègue la responsabilité et l'obligation de rendre compte aux niveaux appropriés. Éclaire la prise de décision grâce à une bonne compréhension du contexte, des données et des éléments probants. Fixe des attentes élevées en donnant l'exemple de l'intendance des ressources financières et organisationnelles. Prend des décisions difficiles et prend des mesures au moment opportun. S'approprier et reconnaître l'impact et les résultats des décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 631,
                DescEng = "Sets direction and oversees the implementation of priorities. Builds an effective, sustainable organization through stewardship and governance. Informs decision-making with sound understanding of context, data, and evidence. Makes challenging decisions and takes action at the opportune time. Takes ownership and acknowledges impact and outcome of decisions.",
                DescFre = "Établit l'orientation et supervise la mise en œuvre des priorités. Bâtit une organisation efficace et durable grâce à l'intendance et à la gouvernance. Éclaire la prise de décision grâce à une bonne compréhension du contexte, des données et des éléments probants. Prend des décisions difficiles et prend des mesures au moment opportun. S'approprier et reconnaître l'impact et les résultats des décisions."
            }
        };
    }
}
