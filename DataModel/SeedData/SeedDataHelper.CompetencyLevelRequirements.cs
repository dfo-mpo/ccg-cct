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
                DescEng =
                    "Basic knowledge of a unit in the Coast Guard organization chart and its reporting relationships.",
                DescFre =
                    "Connaissance de base d’une unité de l’organigramme de la Garde côtière et de ses liens hiérarchiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 2,
                DescEng =
                    "Limited knowledge of the Coast Guard's mandate and its relationship with Fisheries and Oceans Canada (DFO). Understands the organization's directorates regionally and/or nationally.",
                DescFre =
                    "Connaissance limitée du mandat de la Garde côtière et de ses relations avec le ministère des Pêches et des Océans (MPO). Comprend les directions de l’organisation à l’échelle régionale et nationale."
            },
            new CompetencyLevelRequirement
            {
                Id = 3,
                DescEng =
                    "Practical knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, and of the Coast Guard as a special operating agency. Understands a program and its linkages to other programs and directorates regionally and/or nationally.",
                DescFre =
                    "Connaissance pratique des organisations de la Garde côtière et de Pêches et Océans Canada (MPO), ainsi que de la Garde côtière en tant qu’organisme de service spécial. Comprend un programme et ses liens avec d’autres programmes et directions à l’échelle régionale et nationale."
            },
            new CompetencyLevelRequirement
            {
                Id = 4,
                DescEng =
                    "Advanced knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations, directorates and associated programs and relations regionally and nationally.",
                DescFre =
                    "Connaissance avancée des organisations, des directions et des programmes et relations de la Garde côtière et de Pêches et Océans Canada (MPO) à l’échelle régionale et nationale."
            },
            new CompetencyLevelRequirement
            {
                Id = 5,
                DescEng =
                    "Expert knowledge of the Coast Guard and Fisheries and Oceans Canada (DFO) organizations and their interdependencies with other internal (includes other government departments) and external (includes industry and other governments) organizations. Expertise in providing advice and guidance to stakeholders about the organization and its capabilities.",
                DescFre =
                    "Connaissance approfondie des organisations de la Garde côtière et de Pêches et Océans Canada (MPO) et de leurs interdépendances avec d’autres organisations internes (y compris d’autres ministères) et externes (y compris l’industrie et d’autres gouvernements). Expertise dans la présentation de conseils et d’orientations aux intervenants sur l’organisation et ses capacités."
            },
            new CompetencyLevelRequirement
            {
                Id = 6,
                DescEng = "Basic knowledge of the Coast Guard and its role as an enabler of various programs.",
                DescFre =
                    "Connaissance de base de la Garde côtière et de son rôle en tant que facilitateur de divers programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 7,
                DescEng =
                    "Limited knowledge of the Coast Guard's functions and the roles and responsibilities of key Coast Guard contacts within a regional organizational setting. Understands some programs and assets well.",
                DescFre =
                    "Connaissance limitée des fonctions de la Garde côtière et des rôles et responsabilités des principaux contacts de la Garde côtière dans un cadre organisationnel régional. Comprend bien certains programmes et actifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 8,
                DescEng =
                    "Practical knowledge of program deliveries in a regional or national organizational setting.  Understands most programs and associated assets. Knowledge of key contacts for other programs. Comprehends roles and responsibilities of client partners.",
                DescFre =
                    "Connaissance pratique de l'exécution des programmes dans un cadre organisationnel régional ou national.  Comprend la plupart des programmes et les actifs associés. Connaissance des contacts clés pour d'autres programmes. Comprend les rôles et les responsabilités des partenaires clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 9,
                DescEng =
                    "Advanced knowledge of programs and their impacts on public and partner relations, regionally and/or nationally. Extensive knowledge of all the Coast Guard's programs and the capability and status of Coast Guard assets regionally and/or nationally. Understands program planning exercises.",
                DescFre =
                    "Connaissance avancée des programmes et de leurs impacts sur les relations publiques et les relations avec les partenaires, au niveau régional et/ou national. Connaissance approfondie de tous les programmes de la Garde côtière et de la capacité et du statut des biens de la Garde côtière au niveau régional et/ou national. Comprend les exercices de planification des programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 10,
                DescEng =
                    "Expert knowledge of all the Coast Guard programs and delivery modes and timelines regionally and nationally. Understands expectations and needs of stakeholders for the Coast Guard and other government departments (OGDs) in planning and exercises. Understands the significance of potential program efficiencies, changes, or expansion opportunities.",
                DescFre =
                    "Une connaissance approfondie de tous les programmes de la Garde côtière, ainsi que des modes et des délais de prestation à l'échelle régionale et nationale. Comprend les attentes et les besoins des parties prenantes pour la Garde côtière et les autres ministères dans le cadre de la planification et des exercices. Comprend l'importance de l'efficacité, des changements ou des possibilités d'expansion des programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 12,
                DescEng =
                    "Understands basic administrative tasks and rules as they relate to a position. Recognizes the need to have supervisor approve requests where applicable.",
                DescFre =
                    "Comprend les tâches et les règles administratives de base liées à un poste. Reconnaît la nécessité de faire approuver les demandes par le superviseur, s'il y a lieu. "
            },
            new CompetencyLevelRequirement
            {
                Id = 13,
                DescEng =
                    "Recognizes when administration requirements are met. Understands systems and software pertaining to administrative functions and where applicable, the shipboard logistics functions in the performance of duties.",
                DescFre =
                    "Reconnaît quand les exigences administratives sont satisfaites. Comprend les systèmes et les logiciels relatifs aux fonctions administratives et, s'il y a lieu, aux fonctions logistiques à bord du navire dans l'exécution des tâches."
            },
            new CompetencyLevelRequirement
            {
                Id = 14,
                DescEng =
                    "Understands the full range of administration services such as expense forms, reimbursements (travel, stores, etc.) and where applicable items such as ex gratiapayments, timesheets, drafting correspondence and reports, training requests and authorizations, etc.",
                DescFre =
                    "Comprend la gamme complète des services administratifs tels que les formulaires de dépenses, les remboursements (voyages, magasins, etc.) et, le cas échéant, les dépenses ex gratiapayments, les feuilles de temps, la rédaction de correspondance et de rapports, les demandes et autorisations de formation, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 15,
                DescEng =
                    "Understands the full administration requirements of a sector or unit and how they interrelate with one another to effect efficient transactions throughout. Knowledge of all applicable policies, standards etc., to perform duties.",
                DescFre =
                    "Comprend toutes les exigences administratives d'un secteur ou d'une unité et la façon dont elles sont reliées les unes aux autres pour effectuer des transactions efficaces tout au long du processus. Connaissance de toutes les politiques, normes, etc. applicables à l'exécution des tâches."
            },
            new CompetencyLevelRequirement
            {
                Id = 16,
                DescEng =
                    "Expert knowledge in the administrative functions of multiple units working together and the needs of a work site, when and where applicable. Awareness of national and regional initiatives related to the administrative functions of a unit or units.",
                DescFre =
                    "Connaissance approfondie des fonctions administratives de plusieurs unités travaillant ensemble et des besoins d'un lieu de travail, le cas échéant. Connaissance des initiatives nationales et régionales liées aux fonctions administratives d'une ou de plusieurs unités."
            },
            new CompetencyLevelRequirement
            {
                Id = 17,
                DescEng =
                    "Basic understanding of the different Incident Command System (ICS) elements and incident levels. Understands the established and applicable operational procedures within ICS. Knowledge of associated computer software and hardware.",
                DescFre =
                    "Compréhension de base des différents éléments du Système de commandement du lieu de l'incident (SCI) et des niveaux d'incident. Comprend les procédures opérationnelles établies et applicables au sein du SCI. Connaissance des logiciels et du matériel informatique connexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 18,
                DescEng =
                    "Limited knowledge of the principles and working process of the Incident Command System (ICS). Knowledge of methodology for all Coast Guard incidents, emergency or contingency plans executed in environmental response, humanitarian assistance, maritime security, planned security events, Coast Guard internal incidents and major maritime incidents.",
                DescFre =
                    "Connaissance limitée des principes et du processus de travail du Système de commandement du lieu de l'incident (SCI). Connaissance de la méthodologie pour tous les incidents de la Garde côtière canadienne, des plans d'urgence ou de contingence exécutés dans les domaines de l'intervention environnementale, de l'aide humanitaire, de la sécurité maritime, des événements de sécurité prévus, des incidents internes de la Garde côtière et des incidents maritimes majeurs."
            },
            new CompetencyLevelRequirement
            {
                Id = 19,
                DescEng =
                    "Practical knowledge of the Incident Command System (ICS) during pollution incidents. Knowledge of the relationship between the Coast Guard Safety Management System (SMS) and the ICS. Understands how to determine optimum intervention options and determining the severity, sensitivity, and impact of an incident. Understands equipment specifications and maintenance requirements.",
                DescFre =
                    "Connaissance pratique du Système de commandement des interventions (SCI) lors d'incidents de pollution. Connaissance de la relation entre le Système de gestion de la sécurité (SGS) de la Garde côtière et le SCI. Comprend comment déterminer les options d'intervention optimales et déterminer la gravité, la sensibilité et l'impact d'un incident. Comprend les spécifications de l'équipement et les exigences d'entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 20,
                DescEng =
                    "Advanced knowledge of the management of an Incident Command System (ICS) command and control structure. Knowledge of interoperability with other organizations such as regional, federal, provincial, territorial, and international partners, and response organizations. Understands and applies life cycle management of equipment. Understands national exercise program (NEP) principles.",
                DescFre =
                    "Connaissance approfondie de la gestion d'une structure de commandement et de contrôle du Système de commandement du lieu de l'incident (SCI). Connaissance de l'interopérabilité avec d'autres organisations comme les partenaires régionaux, fédéraux, provinciaux, territoriaux et internationaux, et les organismes d'intervention. Comprend et applique la gestion du cycle de vie de l'équipement. Comprend les principes du programme national d'exercices (PNE)."
            },
            new CompetencyLevelRequirement
            {
                Id = 21,
                DescEng =
                    "Expert knowledge of the Incident Command System (ICS) and identifying new possibilities/capabilities to improve the existing systems and practices. Expertise in drafting/review of acts, regulations, and frameworks, and emergency management policies and directions. ",
                DescFre =
                    "Connaissance approfondie du Système de commandement du lieu de l'incident (SCI) et identification de nouvelles possibilités/capacités pour améliorer les systèmes et pratiques existants. Expertise dans la rédaction et l'examen des lois, des règlements et des cadres, ainsi que des politiques et des orientations en matière de gestion des urgences."
            },
            new CompetencyLevelRequirement
            {
                Id = 22,
                DescEng =
                    "Basic knowledge of existing policies and documents related to seagoing personnel and where to locate them.",
                DescFre =
                    "Connaissance de base des politiques et documents existants relatifs au personnel navigant et savoir où les trouver."
            },
            new CompetencyLevelRequirement
            {
                Id = 23,
                DescEng =
                    "Limited knowledge of the Canadian Coast Guard's documentation covering policies and directives related to crewing profile, rotation regulations, leave, medical fitness and training, and certification for seagoing personnel. ",
                DescFre =
                    "Connaissance limitée de la documentation de la Garde côtière canadienne couvrant les politiques et directives relatives aux profils d'armements en équipage, aux règlements de rotation, aux congés, à l'aptitude médicale, à la formation et à la certification du personnel navigant."
            },
            new CompetencyLevelRequirement
            {
                Id = 24,
                DescEng =
                    "Practical knowledge of the Coast Guard's seagoing dynamic environment. Understands applicable policies and directives when initiating administration processes related to seagoing personnel such as timesheet verification, scheduling and tracking medicals, using the crewing profiles, leave management, labour relations protocols, and using the MariTime system, etc.",
                DescFre =
                    "Connaissance pratique de l'environnement maritime dynamique de la Garde côtière. Comprendre les politiques et directives applicables lors du lancement de processus administratifs liés au personnel navigant, tels que la vérification des feuilles de temps, la programmation et le suivi des examens médicaux, l'utilisation des profils d'armement en équipage, la gestion des congés, les protocoles de relations de travail et l'utilisation du système MariTime, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 25,
                DescEng =
                    "Advanced knowledge of the regional/national approaches in the application of any required policies and regulations related to operational personnel management. Understands new concepts and processes to improve recruitment, retention, and sustainment of the Coast Guard's seagoing personnel and its management.",
                DescFre =
                    "Connaissance avancée des approches régionales/nationales dans l'application de toutes les politiques et réglementations nécessaires liées à la gestion du personnel opérationnel. Comprend les nouveaux concepts et processus visant à améliorer le recrutement, la rétention et le soutien du personnel navigant de la Garde côtière et de sa gestion."
            },
            new CompetencyLevelRequirement
            {
                Id = 26,
                DescEng =
                    "Expert knowledge in strategic guidance related to the seagoing personnel management doctrine. Expertise in recommending, drafting, and implementation of policies related to the management of seagoing personnel. ",
                DescFre =
                    "Connaissances spécialisées en matière d'orientation stratégique liée à la doctrine de gestion du personnel navigant. Expertise en matière de recommandation, de rédaction et de mise en œuvre de politiques liées à la gestion du personnel navigant."
            },
            new CompetencyLevelRequirement
            {
                Id = 27,
                DescEng =
                    "Basic knowledge of coastal domain factors, working relations with other Canadian Coast Guard units, and equipment.",
                DescFre =
                    "Connaissance de base des facteurs du domaine côtier, des relations de travail avec les autres unités de la Garde côtière canadienne et de l'équipement."
            },
            new CompetencyLevelRequirement
            {
                Id = 28,
                DescEng =
                    "Limited knowledge in supporting Fisheries and Oceans Canada's (DFO) marine security programs and conducting analyses using surveillance equipment and working with internal partners.",
                DescFre =
                    "Connaissances limitées en matière de soutien aux programmes de sûreté maritime de Pêches et Océans Canada (MPO) et de réalisation d'analyses à l'aide d'équipements de surveillance et de collaboration avec des partenaires internes."
            },
            new CompetencyLevelRequirement
            {
                Id = 29,
                DescEng =
                    "Practical knowledge in the full range of the maritime security operations centres (MSOC),  its exercises, and its surveillance and analyses with internal partners.",
                DescFre =
                    "Connaissance pratique de toute la gamme des Centres d'opérations de la sûreté maritime (COSM), de leurs exercices, de leur surveillance et de leurs analyses avec les partenaires internes."
            },
            new CompetencyLevelRequirement
            {
                Id = 30,
                DescEng =
                    "Advanced knowledge of all facets of marine security operations, training, and analyses regionally or nationally, as well as training/consultation initiatives. Knowledge of Fisheries and Oceans Canada (DFO), Department of National Defence (DND), Royal Canadian Mounted Police (RCMP), Transport Canada (TC), and the Coast Guard's response systems, programs, and surveillance equipment (Long Range Identification and Tracking [LRIT], radars, cameras).",
                DescFre =
                    "Connaissance avancée de toutes les facettes des opérations de sûreté maritime, formation et analyses au niveau régional ou national, ainsi que des initiatives de formation/consultation. Connaissance de Pêches et Océans Canada (MPO), du ministère de la Défense nationale (MDN), de la Gendarmerie royale du Canada (GRC), de Transports Canada (TC), ainsi que des systèmes d'intervention, des programmes et du matériel de surveillance de la Garde côtière (identification et suivi à grande distance [LRIT], radars, caméras)."
            },
            new CompetencyLevelRequirement
            {
                Id = 31,
                DescEng =
                    "Expert knowledge of all facets of the marine security operations program and its relations with international and industrial stakeholders (e.g. United States Coast Guard [USCG], Ports). Expertise in providing insights to managers and stakeholders in advisory groups, the military, Canadian Security Intelligence Service (CSIS), and governments.",
                DescFre =
                    "Connaissance experte de toutes les facettes du programme d'opérations de sûreté maritime et de ses relations avec les parties prenantes internationales et industrielles (par exemple, la Garde côtière américaine [USCG], les ports). Expertise dans la fourniture d'informations aux gestionnaires et aux parties prenantes des groupes consultatifs, aux militaires, au Service canadien du renseignement de sécurité (SCRS) et aux gouvernements."
            },
            new CompetencyLevelRequirement
            {
                Id = 32,
                DescEng =
                    "Basic knowledge of the training needs analysis process in relation to the Canadian Coast Guard's training gaps and requirements.",
                DescFre =
                    "Connaissance de base du processus d’analyse des besoins en formation en relation avec les lacunes et les exigences de la Garde côtière canadienne en matière de formation."
            },
            new CompetencyLevelRequirement
            {
                Id = 33,
                DescEng =
                    "Limited knowledge of determining training elements including terminal objectives, training structure and outline, brief description of the training, and the method of delivery.",
                DescFre =
                    "Connaissance limitée de la définition d’éléments de la formation, y compris les objectifs terminaux, la structure et le plan de la formation, le résumé de la formation et la méthode de prestation."
            },
            new CompetencyLevelRequirement
            {
                Id = 34,
                DescEng =
                    "Practical knowledge in developing enabling objectives. Understands the development of course materials and curriculum including the instructor lesson plan, participant handouts, assessments, and selected media such as PowerPoint presentations, video, or audio, etc.",
                DescFre =
                    "Connaissances pratiques en matière d’élaboration d’objectifs de base. Comprendre l’élaboration du matériel de cours et du programme d’études, y compris le plan de cours de l’instructeur, les documents distribués aux participants, les évaluations et certains supports tels que les présentations PowerPoint, la vidéo ou l’audio, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 35,
                DescEng =
                    "Advanced knowledge in identifying methods and activities for presenting new information. Knowledge of setting aims and learning objectives. Understanding of the design strategy, for the development of new courses. Knowledge of making course modifications based on feedback.",
                DescFre =
                    "Connaissances avancées de l’identification des méthodes et des activités de présentation de nouvelles informations. Connaissance de l’établissement de buts et d’objectifs d’apprentissage. Compréhension de la stratégie de conception pour le développement de nouveaux cours. Connaissance de la façon d’apporter des modifications à des cours en fonction de la rétroaction."
            },
            new CompetencyLevelRequirement
            {
                Id = 36,
                DescEng =
                    "Expert knowledge of evaluating training results to determine whether the sessions led to required changes in behaviour for the participants. Knowledge in redefining course development, materials, and instructional methods. Understanding of briefing senior management regarding issues, trends, suggestions, and areas of improvement based on evaluation, including trends related to diversity and generational issues.",
                DescFre =
                    "Connaissance approfondie de l’évaluation des résultats de la formation pour déterminer si les séances ont mené aux changements de comportement exigés des participants. Connaissances des méthodes de redéfinition de la conception de cours, de matériel et de méthodes d’enseignement. Compréhension de la façon d’informer la haute direction concernant des problèmes et des tendances et de lui faire part de suggestions et d’aspects à améliorer fondés sur l’évaluation, y compris les tendances liées à la diversité et aux questions générationnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 37,
                DescEng =
                    "Basic knowledge of aspects of specialized fields to accomplish defined activities by applying methods, techniques, and established practices.",
                DescFre =
                    "Connaissance de base des aspects des domaines spécialisés pour accomplir des activités définies en appliquant des méthodes, des techniques et des pratiques établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 38,
                DescEng =
                    "Limited knowledge of theories and principles of a specialized field and the relevancy to their application.",
                DescFre =
                    "Connaissance limitée des théories et des principes d'un domaine spécialisé et de leur pertinence pour leur application."
            },
            new CompetencyLevelRequirement
            {
                Id = 39,
                DescEng =
                    "Practical knowledge of specialized methodologies of a field and comprehensive understanding of their underlying concepts, theories, and principles.",
                DescFre =
                    "Connaissance pratique des méthodologies spécialisées d'un domaine et compréhension approfondie de leurs concepts, théories et principes sous-jacents."
            },
            new CompetencyLevelRequirement
            {
                Id = 40,
                DescEng =
                    "Advanced knowledge in specialized methodologies of a field and of their underlying concepts. Extensive comprehension of the methodologies, theories, and applied principles of a specialized field.",
                DescFre =
                    "Connaissance avancée des méthodologies spécialisées d'un domaine et de leurs concepts sous-jacents. Compréhension approfondie des méthodologies, théories et principes appliqués d'un domaine spécialisé."
            },
            new CompetencyLevelRequirement
            {
                Id = 41,
                DescEng =
                    "Expert knowledge in specialized methodologies of a field or fields and of their underlying concepts, theories, and principles. Extensive knowledge in the provision of coaching/guidance to staff, peers, and senior management.",
                DescFre =
                    "Connaissance approfondie des méthodologies spécialisées d'un ou de plusieurs domaines et de leurs concepts, théories et principes sous-jacents. Connaissances approfondies dans la prestation de services d'encadrement et d'orientation au personnel, aux pairs et aux cadres supérieurs."
            },
            new CompetencyLevelRequirement
            {
                Id = 42, DescEng = "Participates in project/program support activities.",
                DescFre = "Participer à des activités de soutien aux projets et aux programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 43,
                DescEng =
                    "Respects project/program goals, participants' roles, and the importance of project management principles. Participates in project support activities (i.e. gathering needed information). Participates with others in small and well defined components of the project/program.",
                DescFre =
                    "Respecter les objectifs du projet ou du programme, le rôle des participants et l’importance des principes de gestion de projet. Participer aux activités de soutien du projet (p. ex. recueillir les informations nécessaires). Participer avec d’autres personnes à des aspects limités et bien définis de projets et de programmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 44,
                DescEng =
                    "Actively promotes project goals, participants' roles, and the importance of project management principles, such as time, cost, and quality management. Participates, with minimal supervision, with others in all aspects of project or program. Seeks advice and guidance for more complex components of the project/program.",
                DescFre =
                    "Promouvoir activement les buts du projet, les rôles des participants et l’importance des principes de gestion du projet, comme la gestion du temps, des coûts et de la qualité. Collaborer avec d’autres personnes à tous les aspects du projet ou du programme en ayant une supervision minimale. Demander des conseils et des orientations concernant les éléments plus complexes du projet ou du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 45,
                DescEng =
                    "Leads projects and/or programs. Leads project/program support activities, taking the initiative to gather additional information, keep documentation organized, and identify process improvements, when and where applicable. Provides advice to others who seek assistance within the project/program scope.",
                DescFre =
                    "Diriger des projets ou des programmes. Diriger des activités de soutien aux projets et aux programmes, en prenant l’initiative de recueillir des informations supplémentaires, de garder la documentation classée et de cibler les améliorations à apporter aux processus, le cas échéant. Donner des conseils aux autres personnes qui demandent de l’aide dans le cadre du projet ou du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 46,
                DescEng =
                    "Responsibly delivers on the established mandate of a project/program. Directs teams to complete activities in accordance with current policies and practices. Provides accurate and timely recommendations to clients. Trains and advises anyone seeking guidance on basic to complex elements of project/program.",
                DescFre =
                    "S’acquitter de manière responsable du mandat établi d’un projet ou d’un programme. Diriger les équipes pour qu’elles réalisent les activités conformément aux politiques et aux pratiques en vigueur. Formuler des recommandations exactes et pertinentes à la clientèle. Donner de la formation et des conseils à toute personne souhaitant obtenir des conseils sur les éléments de base ou les éléments complexes d’un projet ou d’un programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 47,
                DescEng =
                    "Monitors the quality and timeliness of individual responsibilities using the available resources, searching for clarity as needed.",
                DescFre =
                    "Surveiller si chacun s’acquitte de ses responsabilités individuelles de façon adéquate et dans le respect des délais, en utilisant les ressources disponibles et en obtenant des éclaircissements au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 48,
                DescEng =
                    "Plans and organizes individual responsibilities to accomplish pre-determined standards or procedures. Monitors the quality and timeliness of work while leveraging the resources at immediate disposal.",
                DescFre =
                    "Planifier et organiser l’exécution de responsabilités individuelles en fonction de normes ou de procédures prédéterminées. S’assurer de produire un travail de qualité et de respecter les délais en utilisant correctement les ressources mises à sa disposition."
            },
            new CompetencyLevelRequirement
            {
                Id = 49,
                DescEng =
                    "Plans and organizes activities efficiently. Monitors the quality and timeliness of unit workloads. Uses available resources and seeks assistance to clarify priorities, when and where required. Reports on results to promote accountability.",
                DescFre =
                    "Planifier et organiser les activités de manière efficace. Surveiller la qualité et la rapidité de l’exécution de la charge de travail de l’unité. Utiliser les ressources disponibles et demander de l’aide pour clarifier les priorités au besoin. Rendre compte des résultats pour promouvoir la responsabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 50,
                DescEng =
                    "Efficiently plans and organizes activities for a unit. Establishes goals and objectives and anticipates obstacles realistically. Determines priorities and allocates resources effectively. Assists others and gives guidance as required.",
                DescFre =
                    "Planifier et organiser efficacement les activités d’une unité. Établir des buts et des objectifs et prévoir les obstacles de manière réaliste. Déterminer les priorités et affecter les ressources de manière efficace. Aider les autres et leur donner des conseils au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 51,
                DescEng =
                    "Plans and organizes effectively while managing multiple demands and competing priorities. Influences processes and courses of action. Provides guidance and advice on a project or program area.",
                DescFre =
                    "Planifier et organiser efficacement tout en gérant des demandes multiples et des priorités incompatibles. Orienter les processus et les lignes de conduite. Donner des orientations et des conseils sur un projet ou un secteur de programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 52,
                DescEng =
                    "Administers low-risk contracts. Monitors inventory levels of materials, equipment, and stock using manual or computerized inventory systems. Prepares requisition orders to replenish materials, equipment, and stock. Maintains stock rotation, disposes of and accounts for outdated stock. Enters data for production scheduling, stock replenishment, relocation, and inventory adjustments. Maintains a contractor database, insurance requirements, and pricing accuracy. ",
                DescFre =
                    "Administrer les contrats à faible risque. Surveiller les inventaires de matériaux, d’équipements et de stocks à l’aide de systèmes d’inventaire manuels ou informatisés. Préparer les demandes de réapprovisionnement en matériaux, en équipements et en stocks. Assurer la rotation des stocks, éliminer et comptabiliser les stocks périmés. Saisir les données relatives à la programmation de la production, au réapprovisionnement en stocks, au déplacement et aux rajustements des stocks. Tenir à jour une base de données sur les entrepreneurs, les exigences en matière d’assurance et l’exactitude des prix."
            },
            new CompetencyLevelRequirement
            {
                Id = 53,
                DescEng =
                    "Monitors and reports on contract milestones and outcomes. Completes price variations in accordance with predetermined processes. Sources and obtains price quotations from catalogues and suppliers, and prepares purchase orders. Calculates cost of orders and charges or forwards invoices to appropriate accounts. Prepares and maintains purchasing files, reports, and price lists. Assesses requirements of clients and develops specifications for equipment, materials, and supplies to be purchased.",
                DescFre =
                    "Surveiller les jalons de l’exécution des contrats et en rendre compte. Traiter les variations de prix selon des processus déterminés au préalable. Obtenir des propositions de prix dans les catalogues et auprès des fournisseurs et préparer les bons de commande. Calculer le coût des commandes et imputer les factures aux comptes appropriés ou les acheminer aux responsables des comptes appropriés. Préparer et tenir à jour des dossiers d’achat, des rapports et des listes de prix. Évaluer les besoins de clients et préciser les spécifications de l’équipement, du matériel et des fournitures à acheter."
            },
            new CompetencyLevelRequirement
            {
                Id = 54,
                DescEng =
                    "Manages medium-risk contracts including governance, risk, performance, and financial management. Purchases general and specialized equipment, materials, land or access rights, or business services for use or for further processing by the Canadian Coast Guard. Interprets and applies the terms and conditions of the contract to varied situations. Manages, or assists in the management of, all procedural aspects of purchasing activities. Adapts contract management practices in changing circumstances whilst maintaining the overall intent of the contract.",
                DescFre =
                    "Gère les contrats à risque moyen, en ce qui concerne notamment la gouvernance, le risque, l’exécution et la gestion financière. Acheter de l’équipement général et spécialisé, du matériel, des terrains ou des droits d’accès ou des services opérationnels qui sont utilisés ou transformés par la Garde côtière canadienne. Interpréter les modalités du contrat et les appliquer à des situations variées. Gérer ou aider à gérer tous les aspects procéduraux des activités d’achat. Adapter les pratiques de gestion des contrats en fonction de l’évolution des circonstances tout en préservant l’intention générale du contrat."
            },
            new CompetencyLevelRequirement
            {
                Id = 55,
                DescEng =
                    "Establishes delivery schedules, monitors progress, and contacts clients and suppliers to resolve problems in a work unit. Negotiates land acquisition or access rights for Coast Guard use, and may conduct field investigations of properties. Reviews and processes claims against suppliers. Monitors contract performance and identifies when corrective action needs to be taken to drive better outcomes. Assesses contract variations, and makes appropriate decisions based on risk. Invites tenders, consults with suppliers, and reviews quotations. Determines or negotiates contract terms and conditions, awards supplier contracts or recommend contract awards. Explores innovative contract management strategies for complex requirements with stakeholders.",
                DescFre =
                    "Établir les calendriers de livraison, surveiller l’exécution des contrats et communiquer avec les clients et les fournisseurs pour résoudre les problèmes dans une unité de travail. Négocier l’acquisition de terrains ou les droits d’accès pour l’usage de la Garde côtière; il faut parfois se rendre sur place pour inspecter les propriétés. Examiner et traiter les réclamations contre des fournisseurs. Surveiller l’exécution des contrats et déterminer quand des mesures correctives doivent être prises pour obtenir de meilleurs résultats. Évalue les dérogations aux contrats et prendre les décisions appropriées en fonction du risque. Solliciter des soumissions, consulter des fournisseurs et examiner les devis. Déterminer ou négocier les modalités de contrats, accorder des contrats aux fournisseurs ou recommander leur attribution. Explorer des stratégies innovantes de gestion de contrats auprès des intervenants pour satisfaire aux exigences complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 56,
                DescEng =
                    "Plans, organizes, directs, controls, and evaluates the purchasing activities of one or more work units. Identifies vendors of materials, equipment, or supplies. Participates in the development of specifications for equipment, products, or substitute materials. Interprets and advises on the terms and conditions of the contract, and applies to varied and complex situations. Monitors, evaluates and reports on contract milestones, key performance indicators adherence, performance metrics, and outcomes. Oversees the management of contracts and categories, and reports on contract activities that may result in political or public interest. Defines and advises on contract management responsibilities and processes across the Coast Guard. Drives the use of innovative contract management strategies where appropriate to deliver the best outcome and maximize value. Develops purchasing policies and procedures and controls purchasing department budget, when and where applicable.",
                DescFre =
                    "Planifier, organiser, diriger, contrôler et évaluer les activités d’achat d’une ou de plusieurs unités de travail. Cibler les fournisseurs de matériaux, d’équipements ou de fournitures. Participer à l’élaboration de spécifications pour les équipements, les produits ou des matériaux de substitution. Interpréter les modalités de marchés, donner des conseils sur ces modalités et les appliquer à des situations variées et complexes. Surveiller et évaluer l’exécution de jalons de contrats, le respect des indicateurs clés de rendement, des mesures de rendement et des résultats et en rendre compte. Surveiller la gestion des contrats et des catégories et produire des rapports sur les activités liées aux contrats qui peuvent susciter l’intérêt des milieux politiques ou du public. Définir les responsabilités et les processus de gestion des contrats au sein de la Garde côtière et formuler des conseils à ce sujet. Encourager l’utilisation de stratégies innovantes de gestion des contrats, le cas échéant, pour obtenir les meilleurs résultats et optimiser l’utilisation des ressources. Élaborer des politiques et des procédures d’achat et contrôler le budget du service des achats, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 57,
                DescEng =
                    "Coordinates a variety of recruitment, training, performance evaluation, HR systems, and classification activities. Prepares and proofreads forms and documents for and between the workforce management team or clients. Runs reports. Ensures that workforce management-related material is signed, dated, distributed, maintained, and filed appropriately.",
                DescFre =
                    "Coordonne diverses activités de recrutement, de formation, d'évaluation des performances, de systèmes RH et de classification. Prépare et corrige des formulaires et des documents pour et entre l'équipe de gestion du personnel ou les clients. Produit des rapports. S'assure que les documents relatifs à la gestion des effectifs sont signés, datés, distribués, mis à jour et classés de manière appropriée."
            },
            new CompetencyLevelRequirement
            {
                Id = 58,
                DescEng =
                    "Compiles, maintains, and processes information relating to recruitment, training, performance evaluation, HR systems, or classification. Facilitates business line, workforce intelligence, succession planning, organizational awareness, and HR management practices. Arranges for advertising or posting job vacancies. Assists in screening of job applicants, and conducting of reference checks, when and where applicable.",
                DescFre =
                    "Compile, tenir à jour et traiter les informations relatives au recrutement, à la formation, à l'évaluation des performances, aux systèmes de RH ou à la classification. Facilite les pratiques de gestion des lignes d'activité, des renseignements sur les effectifs, de la planification de la relève, de la sensibilisation à l'organisation et de la gestion des RH. Organise la publication ou l'affichage des offres d'emploi. Aide à la sélection des candidats et à la vérification des références, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 59,
                DescEng =
                    "Identifies job vacancies and prospective recruiting requirements. Provides advice to managers related to recruitment, training, or HR systems. Interprets and applies legislation and policies related to workforce management functions. Determines eligibility to entitlements, arranges and delivers member training. Provides information or services such as employee assistance, counselling, and recognition programs, when and where applicable.",
                DescFre =
                    "Identifie les offres d'emploi et les besoins de recrutement éventuels. Fournit des conseils aux gestionnaires en matière de recrutement, de formation ou de systèmes de ressources humaines. Interprète et applique la législation et les politiques relatives aux fonctions de gestion des effectifs. Détermine l'admissibilité aux droits, organise et dispense la formation des membres. Fournit des informations ou des services tels que l'aide aux employés, de councelling et des programmes de reconnaissance, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 60,
                DescEng =
                    "Implements and evaluates workforce management policies, programs, and procedures. Working closely with clients or the workforce management team, collaborates in developing the merit criteria, assessment tools, and employment equity programs, offering strategic staffing ideas and assisting with performance management or disability files according to portfolio. Provides advice on the interpretation of policies, staffing, training, and benefits programs. Maintains workforce management information and related records systems. Hires and oversees training of staff. Co-ordinates employee performance appraisal programs. ",
                DescFre =
                    "Met en œuvre et évalue les politiques, programmes et procédures de gestion des effectifs. Travaille en étroite collaboration avec les clients ou l'équipe de gestion des effectifs, collabore à l'élaboration des critères de mérite, des outils d'évaluation et des programmes d'équité en matière d'emploi, propose des idées stratégiques de dotation en personnel et aide à la gestion des performances ou des dossiers d'invalidité selon le portefeuille. Fournit des conseils sur l'interprétation des politiques, la dotation en personnel, la formation et les programmes d'avantages sociaux. Tient à jour les informations sur la gestion des effectifs et les systèmes de dossiers connexes. Engage et supervise la formation du personnel. Coordonne les programmes d'évaluation de la performance des employés."
            },
            new CompetencyLevelRequirement
            {
                Id = 61,
                DescEng =
                    "Directs, controls, and evaluates the operations of the Canadian Coast Guard's workforce management discipline. Develops and implements policies, programs and procedures regarding workforce management planning, recruitment, training and development, and classification. Negotiates settlements of appeals and disputes and co-ordinates the termination of employment process, when and where applicable. Directs the organization's quality management program in relation to workforce management.",
                DescFre =
                    "Dirige, contrôle et évalue les opérations de la discipline de gestion des effectifs de la Garde côtière canadienne. Élabore et met en œuvre des politiques, des programmes et des procédures concernant la planification de la gestion des effectifs, le recrutement, la formation et le développement, et la classification. Négocie le règlement des appels et des différends et coordonne le processus de cessation d'emploi, le cas échéant. Diriger le programme de gestion de la qualité de l'organisation en ce qui concerne la gestion de la main-d'œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 62,
                DescEng =
                    "Adheres to budget controls as assigned. Articulates a 'value for money' mindset. Provides correct financial information as required.",
                DescFre =
                    "Respecte les contrôles budgétaires tels qu'ils ont été assignés. Il adopte un état d'esprit de l'optimisation des ressources. Fournir des informations financières correctes, comme demandé."
            },
            new CompetencyLevelRequirement
            {
                Id = 63,
                DescEng =
                    "Monitors project/program expenditures and individual expenses for reporting purposes. Identifies wasteful financial practices or opportunities for greater efficiencies. Tracks and files variation reports. ",
                DescFre =
                    "Surveille les dépenses des projets/programmes et les dépenses individuelles à des fins d'établissement de rapports. Identifie les pratiques financières inutiles ou les possibilités d'amélioration de l'efficacité. Suivre et classer les rapports de variation."
            },
            new CompetencyLevelRequirement
            {
                Id = 64,
                DescEng =
                    "Analyzes unit cash flow trends. Maintains financial records and compares trends by period and year. Prepares statistical, financial, and accounting reports. Verifies and evaluates procedures used for recording financial transactions, and makes recommendations for changes to procedures, systems, and other financial controls. Provides guidance to members.",
                DescFre =
                    "Analyse les tendances de roulement de fonds des unités. Tient à jour les registres financiers et compare les tendances par période et par année. Prépare des rapports statistiques, financiers et comptables. Vérifie et évalue les procédures utilisées pour l'enregistrement des transactions financières, et fait des recommandations sur les changements à apporter aux procédures, systèmes et autres contrôles financiers. Fournir des conseils aux membres."
            },
            new CompetencyLevelRequirement
            {
                Id = 65,
                DescEng =
                    "Analyzes broad accounting and financial records to ensure accuracy and compliance with established accounting standards and procedures. Plans, organizes, and administers financial tracking and reconciliation systems for Canadian Coast Guard programs and business lines. Prepares detailed reports and conducts audits to improve organizational financial management practices. Provides guidance to management. Designs, operates, and monitors rigorous systems for Financial Information Management, internal audit, and evaluation.",
                DescFre =
                    "Analyse les documents comptables et financiers généraux afin de garantir l'exactitude et la conformité aux normes et procédures comptables établies. Planifie, organise et administre les systèmes de suivi et de rapprochement financier pour les programmes et les secteurs d'activité de la Garde côtière canadienne. Prépare des rapports détaillés et effectue des vérifications pour améliorer les pratiques de gestion financière de l'organisation. Fournir des conseils à la direction. Concevoir, exploiter et surveiller des systèmes rigoureux de gestion de l'information financière, de vérification interne et d'évaluation."
            },
            new CompetencyLevelRequirement
            {
                Id = 66,
                DescEng =
                    "Directs, controls, and evaluates the operation of financial and accounting departments. Reports on established trends with organizational recommendations for change. Ensures partner organizations, agencies, or governments understand the organization's complex fiscal issues. Develops and implements financial policies, establishes performance standards, and prepares various financial reports for senior management. Advises senior management on current and best practices in sound financial management practice and procedure.",
                DescFre =
                    "Dirige, contrôle et évalue le fonctionnement des services financiers et comptables. Fait rapport sur les tendances établies avec des recommandations organisationnelles pour le changement. S'assure que les organisations, agences ou gouvernements partenaires comprennent les questions fiscales complexes de l'organisation. Élabore et met en œuvre des politiques financières, établit des normes de performance et prépare divers rapports financiers à l'intention de la haute direction. Conseille la haute direction sur les pratiques actuelles et les meilleures pratiques en matière de bonnes méthodes et procédures de gestion financière."
            },
            new CompetencyLevelRequirement
            {
                Id = 67,
                DescEng =
                    "Conducts media monitoring and coverage analysis. Provides communication support services. Offers logistical support for media events and interviews.",
                DescFre =
                    "Effectue un suivi des médias et une analyse de la couverture médiatique. Fournit des services de soutien à la communication. Offre un soutien logistique pour les événements médiatiques et les interviews."
            },
            new CompetencyLevelRequirement
            {
                Id = 68,
                DescEng =
                    "Writes and edits a range of communications products. Supports social media and websites. Assists in the development and/or implementation of communications products. Contributes to implementing communication plans or projects in the digital environment.",
                DescFre =
                    "Rédige et édite une série de produits de communication. Prend en charge les médias sociaux et les sites web. Aide à l'élaboration et/ou à la mise en œuvre de produits de communication. Contribue à la mise en œuvre de plans ou de projets de communication dans l'environnement numérique."
            },
            new CompetencyLevelRequirement
            {
                Id = 69,
                DescEng =
                    "Produces communications products. Plans, coordinates, and/or implements announcements or special events such as town halls or media availabilities. Provides communication support to clients. Contributes to content of strategic communications plans. Monitors and analyzes multimedia coverage, providing tactical responses where requested. Uses social media to communicate in a government context.",
                DescFre =
                    "Produit des produits de communication. Planifie, coordonne et/ou met en œuvre des annonces ou des événements spéciaux tels que les assemblées publiques ou les disponibilités des médias. Fournit un support de communication aux clients. Contribue au contenu des plans de communication stratégiques. Surveille et analyse la couverture multimédia, en fournissant des réponses tactiques si nécessaire. Utilise les médias sociaux pour communiquer dans un contexte gouvernemental."
            },
            new CompetencyLevelRequirement
            {
                Id = 70,
                DescEng =
                    "Provides strategic communications advice to managers. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products, when and where required. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Extracts subject-matter experts while executing segmentation and audience analysis. Assists senior management in conveying messages on behalf of the Coast Guard in an appropriate manner that is consistent with established Acts, policies, and practices. Establishes networks with Fisheries and Oceans Canada (DFO) communications partners.",
                DescFre =
                    "Fournit des conseils en communication stratégique aux gestionnaires. Élabore et met en œuvre des plans de marketing et/ou de publicité, des story-boards et des vidéos. Évalue les plans de communication et développe des produits de communication associés, quand et où cela est nécessaire. Coordonne et/ou travaille dans le cadre d'initiatives, de projets ou de stratégies de communication intergouvernementaux ou multiservices. Extrait des experts en la matière tout en effectuant une segmentation et une analyse d'audience. Aider la haute direction à transmettre les messages au nom de la Garde côtière d'une manière appropriée et conforme aux lois, politiques et pratiques établies. Établit des réseaux avec les partenaires de communication de Pêches et Océans Canada (MPO)."
            },
            new CompetencyLevelRequirement
            {
                Id = 71,
                DescEng =
                    "Organizes and coordinates ministerial events. Leads the development, implementation, and evaluation of communications plans. Develops specialized communications products. In partnership with Fisheries and Oceans Canada (DFO) communications partners, leads or participates in external and internal stakeholder collaboration and major event responses. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies. Plans and executes extensive electronic (web and social media) communications initiatives.",
                DescFre =
                    "Organise et coordonne les événements ministériels. Dirige l'élaboration, la mise en œuvre et l'évaluation des plans de communication. Élabore des produits de communication spécialisés. En partenariat avec les partenaires de communication de Pêches et Océans Canada (MPO), dirige ou participe à la collaboration des intervenants externes et internes et aux réponses aux événements majeurs. Gère les relations avec les médias pour les questions sensibles. Élabore et met en œuvre des stratégies proactives de sensibilisation des médias. Planifie et exécute des initiatives de communication électronique (web et médias sociaux) de grande envergure."
            },
            new CompetencyLevelRequirement
            {
                Id = 72,
                DescEng =
                    "Applies real property and accommodation management’s key elements and policies and identifies where to find related information. Supports activities related to real property and accommodation maintenance and operations.",
                DescFre =
                    "Applique les éléments clés et les politiques de la gestion des biens immobiliers et des locaux et indique où trouver les informations correspondantes. Soutient les activités liées à l'entretien et au fonctionnement des biens immobiliers et des locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 73,
                DescEng =
                    "Assists in the writing of real property and/or accommodation management documents. Gathers information for planning, coordinating, and/or monitoring budgets. Assists in the search, analysis, and integration of information from different sources to formulate recommendations or action plans.",
                DescFre =
                    "Aide à la rédaction des documents de gestion des biens immobiliers et/ou des locaux. Recueille des informations pour la planification, la coordination et/ou le suivi des budgets. Aide à la recherche, à l'analyse et à l'intégration d'informations provenant de différentes sources afin de formuler des recommandations ou des plans d'action."
            },
            new CompetencyLevelRequirement
            {
                Id = 74,
                DescEng =
                    "Interprets policies, standards, directives, or codes related to office accommodations or real property construction projects. Plans, organizes, or implements office accommodation or real property construction projects and analyses information and provides recommendations to clients or management.",
                DescFre =
                    "Interprète les politiques, les normes, les directives ou les codes relatifs aux locaux ou aux projets de construction de biens immobiliers. Planifie, organise ou met en œuvre des projets de construction de locaux ou de biens immobiliers, analyse des informations et fournit des recommandations aux clients ou à la direction."
            },
            new CompetencyLevelRequirement
            {
                Id = 75,
                DescEng =
                    "Monitors marine structure projects, when and where applicable. Develops systems and/or processes, guidelines, and policies for identifying, collecting, maintaining, and evaluating real property and accommodations management information. ",
                DescFre =
                    "Surveille les projets de structures marines, le cas échéant. Élabore des systèmes et/ou des processus, des lignes directrices et des politiques pour identifier, recueillir, maintenir et évaluer les informations relatives à la gestion des biens immobiliers et des locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 76,
                DescEng =
                    "Identifies and implements risk and performance management strategies in assessing and planning real property and/or accommodations management projects. Develops plans and strategies that address the variety and complexity of real property and accommodations management operations, use, and maintenance.",
                DescFre =
                    "Identifie et met en œuvre des stratégies de gestion des risques et du rendement dans l'évaluation et la planification des projets de gestion des biens immobiliers et/ou des locaux. Élabore des plans et des stratégies qui tiennent compte de la variété et de la complexité des opérations, de l'utilisation et de l'entretien des biens immobiliers et de la gestion des locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 77,
                DescEng =
                    "Describes the basic function of the business’s core systems. Defines objectives and success criteria of the specific role. Identifies sources of existing and potential information relating to the project. Documents consistently.",
                DescFre =
                    "Décrit la fonction de base des systèmes centraux de l'entreprise. Définit les objectifs et les critères de succès de la fonction spécifique. Identifie les sources d'informations existantes et potentielles relatives au projet. Documente de manière systématique."
            },
            new CompetencyLevelRequirement
            {
                Id = 78,
                DescEng =
                    "Identifies key project milestones and defines project scope. Derives project estimates and quantifies uncertainty. Stores, references, and locates information in an efficient manner appropriate to the role. Validates, refines, and optimizes solution option models. Communicates difficult issues concisely and effectively to supervisors. Identifies potential areas of conflict and works to aasync Task their occurrence or their impact.",
                DescFre =
                    "Identifie les étapes clés du projet et définit la portée du projet. Dérive les estimations du projet et quantifie l'incertitude. Stocker, référencer et localiser les informations de manière efficace et adaptée au rôle. Valide, raffine et optimise les modèles d'options de solution. Communique les questions difficiles de manière concise et efficace aux superviseurs. Identifie les zones potentielles de conflit et s'efforce d'éviter leur apparition ou leur impact."
            },
            new CompetencyLevelRequirement
            {
                Id = 79,
                DescEng =
                    "Identifies and minimizes risk to ongoing Coast Guard operations. Consistently identifies technology interfaces and focuses on integration aspects of projects. Identifies and defines proposed business benefits. Ensures planning tools and techniques are applied effectively. Through analysis of options, selects the option with the greatest business benefit bearing in mind the Coast Guard objectives. Articulates the vision, objectives, and benefits of a new initiative. Identifies current areas of conflict and seeks to understand apposing points of view. ",
                DescFre =
                    "Identifie et minimise les risques pour les opérations en cours de la Garde côtière. Identifie de manière cohérente les interfaces technologiques et se concentre sur les aspects d'intégration des projets. Identifie et définit les avantages opérationnels proposés. S'assure que les outils et les techniques de planification sont appliqués efficacement. Par l'analyse des options, sélectionne l'option présentant le plus grand avantage opérationnel en gardant à l'esprit les objectifs de la Garde côtière. Articuler la vision, les objectifs et les avantages d'une nouvelle initiative. Identifie les zones de conflit actuelles et cherche à comprendre les points de vue opposés."
            },
            new CompetencyLevelRequirement
            {
                Id = 80,
                DescEng =
                    "Identifies and relays improvement opportunities and industry trends to the organization. Ensures a mechanism is in place to capture project risks, issues, and scope. Follows up with individuals and/or groups to clarify or complete the identified gaps and errors. Employees models to determine and communicate solution options. Makes recommendations with justifications to the appropriate decision making authority.",
                DescFre =
                    "Identifie et transmet à l'organisation les opportunités d'amélioration et les tendances du monde industriel. S'assure qu'un mécanisme est en place pour saisir les risques, les problèmes et la portée du projet. Assurer un suivi avec des personnes et/ou des groupes pour clarifier ou compléter les lacunes et les erreurs identifiées. Les employés établissent des modèles pour déterminer et communiquer les options de solution. Fait des recommandations avec justifications à l'autorité décisionnelle appropriée."
            },
            new CompetencyLevelRequirement
            {
                Id = 81,
                DescEng =
                    "Identifies risks and impacts associated with proposed business options. Forecasts the impact of change. Applies effective influencing strategies.",
                DescFre =
                    "Identifie les risques et les impacts associés aux options opérationnelles proposées. Prévoit l'impact du changement. Applique des stratégies d'influence efficaces."
            },
            new CompetencyLevelRequirement
            {
                Id = 82,
                DescEng =
                    "Employs a fair and non-partisan approach in the delivery of services. Supports others in managing their tasks/responsibilities by providing timely information or resources. Accurately determines where to direct inquiries.",
                DescFre =
                    "Adopter une approche équitable et non partisane dans la prestation des services. Aider les autres à gérer leurs tâches et leurs responsabilités en leur fournissant des informations ou des ressources en temps utile. Déterminer avec précision où diriger les demandes de renseignements."
            },
            new CompetencyLevelRequirement
            {
                Id = 83,
                DescEng =
                    "Establishes and maintains electronic and paper filing systems so that information can be readily retrieved. Actively promotes services to existing and potential clients. Anticipates potential problems and initiates ways of improving standards. Complies with existing quality standards, procedures, guidelines, and service agreements. Asks questions in order to clarify the needs and requirements associated with initial client requests. ",
                DescFre =
                    "Établir et tenir des systèmes de classement des dossiers électroniques et papier afin que l’information soit facilement accessible. Promouvoir activement les services auprès des clients existants et éventuels. Prévoir les problèmes possibles et prendre les moyens d’améliorer les normes. Respecter les normes de qualité, les procédures, les lignes directrices et les ententes de service existantes. Poser des questions afin d’obtenir des éclaircissements sur les besoins et les exigences associés aux demandes initiales des clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 84,
                DescEng =
                    "Applies due diligence and sound judgment when responding to requests and dealing with confidential information. Quickly and effectively solves client’s problems including complaints. Serves Coast Guard clients with the understanding that service is a core principle of the organization.",
                DescFre =
                    "Faire preuve de diligence raisonnable et d’un bon jugement lorsqu’il répond aux demandes et gère des renseignements confidentiels. Régler rapidement et efficacement les problèmes des clients, y compris les plaintes. Servir les clients de la Garde côtière en sachant que le service est un principe fondamental de l’organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 85,
                DescEng =
                    "Develops standards of service delivery beyond those generally accepted. Promotes innovative measures to address client service needs. Deals with stakeholders professionally while representing the Coastg Guard. ",
                DescFre =
                    "Élaborer des normes de prestation de services plus rigoureuses que les normes généralement acceptées. Promouvoir des mesures innovantes pour répondre aux besoins des clients en matière de service. Traiter avec les intervenants de manière professionnelle tout en représentant la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 86,
                DescEng =
                    "Strategically and systematically evaluates opportunities within a sector, field, or area to improve client service in a non-partisan manner. Develops and implements creative and innovative ways of meeting client needs, whether in the regions or in headquarters.",
                DescFre =
                    "Évaluer de manière stratégique et systématique les possibilités d’améliorer le service à la clientèle dans un secteur, un domaine ou une région de manière non partisane. Élaborer et mettre en œuvre des moyens originaux et innovants de répondre aux besoins des clients, que ce soit dans les régions ou à l’administration centrale."
            },
            new CompetencyLevelRequirement
            {
                Id = 87,
                DescEng =
                    "Identifies irregular workforce management practices. Seeks advice when workforce management issues arise.",
                DescFre =
                    "Reconnaître les pratiques irrégulières de gestion de l’effectif. Demander des conseils lorsque des problèmes de gestion de l’effectif se posent."
            },
            new CompetencyLevelRequirement
            {
                Id = 88,
                DescEng =
                    "Provides basic HR-related information to colleagues, members, and others. Identifies deviations in applications of HR procedures or validates them with the competent authority. Supervises a small unit and conducts performance management input.",
                DescFre =
                    "Fournir des informations de base sur les ressources humaines aux collègues, aux membres du personnel et à d’autres personnes. Reconnaître les dérogations aux procédures de RH ou les valider auprès de l’autorité compétente. Superviser une petite unité et contribuer à la gestion du rendement."
            },
            new CompetencyLevelRequirement
            {
                Id = 89,
                DescEng =
                    "Addresses standard workforce management issues within areas of responsibility (AOR). Supervises or manages staff (operational or administrative). Provides performance feedback. Aligns workforce management practices to audit results and findings, when and where applicable. Provides on-the-job training and makes training and development recommendations. Participates on staffing boards and provides input into statements of merit criteria, when and where required.",
                DescFre =
                    "Traiter de questions courantes de gestion de l’effectif dans ses secteurs de responsabilité. Superviser ou gérer du personnel (opérationnel ou administratif). Donner de la rétroaction sur le rendement. Harmoniser les pratiques de gestion de l’effectif avec les résultats et les conclusions des audits, le cas échéant. Donner de la formation en cours d’emploi et formuler des recommandations en matière de formation et de perfectionnement. Participer aux commissions de dotation en personnel et contribuer à la production des énoncés des critères de mérite, lorsque cela est nécessaire."
            },
            new CompetencyLevelRequirement
            {
                Id = 90,
                DescEng =
                    "Manages a unit. Participates on staffing boards and drafts statements of merit criteria, and, where applicable, conducts assessments. Manages unit member performance, including the development of objectives, learning plans, talent management and action plans, and dealing with disciplinary matters. Analyzes and forecasts workforce management needs and initiates required succession planning processes. Approves training requests by considering value for money.",
                DescFre =
                    "Gérer une unité. Participer aux commissions de dotation en personnel et rédiger des énoncés des critères de mérite et, au besoin, procéder à des évaluations. Gérer le rendement des membres de l’unité, ce qui comprend l’élaboration d’objectifs, de plans d’apprentissage, de gestion des talents et de plans d’action, et s’occuper des questions de discipline. Analyser et prévoir les besoins en matière de gestion des effectifs et lancer les processus de planification de la relève nécessaires. Approuver les demandes de formation en tenant compte du rapport qualité-prix."
            },
            new CompetencyLevelRequirement
            {
                Id = 91,
                DescEng =
                    "Manages several units or projects. Develops complex workforce management plans that capitalize on recruitment, performance management, etc. Exercises an influence on Canadian Coast Guard workforce management strategic planning and development, succession planning, and other workforce management areas. Contributes to linking policies and systems to performance management processes, competencies, and performance outcomes in support of broader organizational goals. Ensures alignment of workforce management plans with the objectives of the Coast Guard's overall program strategy.",
                DescFre =
                    "Gérer plusieurs unités ou projets. Élaborer des plans complexes de gestion des effectifs qui tirent parti du recrutement, de la gestion du rendement, etc. Exercer une influence sur la planification et le développement stratégiques de la gestion des effectifs de la Garde côtière canadienne, la planification de la relève et d’autres domaines de la gestion des effectifs. Contribuer à lier les politiques et les systèmes aux processus de gestion du rendement, aux compétences et aux résultats en matière de rendement pour soutenir les objectifs organisationnels généraux. Veiller à l’harmonisation des plans de gestion des effectifs avec les objectifs de la stratégie globale du programme de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 92,
                DescEng =
                    "Prepares and processes bills, invoices, accounts payable and receivable. Enters data into financial tracking systems according to established procedures.",
                DescFre =
                    "Préparer et traiter des factures, des comptes fournisseurs et des comptes clients. Saisir les données dans les systèmes de suivi financier selon les procédures établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 93,
                DescEng =
                    "Maintains Coast Guard unit assets and property (e.g. office equipment, vehicles, information databases, etc.). Updates budgets and projections. Purchases with credit cards when required. Runs salary and Operations and Maintenance (O&M) reports and statements for managers. Makes budget entries and reconciles accounts with rationales. Tracks and analyzes unit cash flow.",
                DescFre =
                    "Gérer les biens et les actifs de l’unité de la Garde côtière (par exemple, le matériel de bureau, les véhicules et les bases de données d’information) Mettre à jour des budgets et des projections. Procéder à des achats par carte de crédit au besoin. Produire des rapports et des relevés sur les salaires et les dépenses de fonctionnement et d’entretien (F et E) pour les gestionnaires. Remplir des postes budgétaires et effectuer le rapprochement des comptes et des justifications. Suivre et analyser les flux monétaires de l’unité."
            },
            new CompetencyLevelRequirement
            {
                Id = 94,
                DescEng =
                    "Articulates the processes by which financial resources are identified, obtained, allocated, managed and accounted for. Makes sound financial decisions after having analyzed their impact on the organization and operations within the scope of fiscal responsibilities. Monitors the use of Coast Guard financial resources and budgets by employees, suppliers, partners or others. Complies with legislation, policies and practices applicable to the appropriate and effective use of financial resources. Takes a significant role in preparing budgets and forecasts for projects and initiatives.",
                DescFre =
                    "Décrire les processus selon lesquels les ressources sont déterminées, obtenues, attribuées, gérées et justifiées. Prendre des décisions financières appropriées après avoir analysé leur incidence sur l’organisation et les opérations dans le cadre de ses responsabilités financières. Surveiller l’utilisation des ressources financières et des budgets de la Garde côtière par les employés, les fournisseurs, les partenaires ou autres. Observer les lois, les politiques et les pratiques qui s’appliquent à l’utilisation appropriée et efficace des ressources. Jouer un rôle important dans la préparation des budgets et des prévisions des projets et des initiatives."
            },
            new CompetencyLevelRequirement
            {
                Id = 95,
                DescEng =
                    "Ensures adequate internal control systems over the Coast Guard's financial assets, investments, liabilities, revenues, and expenditures. Manages financial and accounting responsibilities for large programs or multiple business lines. Identifies additional or alternative financial resources and opportunities for funding organization-wide projects, programs, research centers and/or services, etc. Acts on audit, evaluation, and other objective financial performance information. Sets up and manages income and expenditure monitoring systems and keeps these systems under close review and makes improvements where relevant. Uses delegated authority to purchase supplies for the work group. Performs a variety of financial management practices such as: budgeting, forecasting, cost benefits, risk analysis. ",
                DescFre =
                    "Veiller à ce que des systèmes de contrôle interne adéquats encadrent les actifs financiers, les investissements, les passifs, les recettes et les dépenses de la Garde côtière. Gérer les responsabilités financières et comptables de programmes importants ou de multiples secteurs d’activité. Cibler des ressources et des possibilités financières supplémentaires ou de rechange en vue du financement de projets, de programmes, de centres et/ou services de recherche, entre autres, à l’échelle de l’organisation. Donner suite aux vérifications, aux évaluations et à d’autres informations objectives sur le rendement financier. Mettre en place et gérer des systèmes de contrôle des recettes et des dépenses, les surveiller de près et les améliorer au besoin. Utiliser ses pouvoirs délégués pour acheter des fournitures pour le groupe de travail. Utiliser différentes pratiques de gestion financière telles que la budgétisation, la prévision, l’analyse coût-avantage et l’analyse des risques."
            },
            new CompetencyLevelRequirement
            {
                Id = 96,
                DescEng =
                    "Ensures framework is in place for sound financial planning, management, control and reporting (i.e. spanning pay, capital, Operations and Maintenance [O&M] costs and revenues). Ensures processes and infrastructure provide managers with integrated financial and non-financial performance information, a mature approach to risk management, appropriate control systems, and a shared set of values and ethics. ",
                DescFre =
                    "S’assurer que le cadre est en place pour une planification et une gestion financières saines, un contrôle des finances rigoureux et des rapports financiers solides (c’est-à-dire couvrant les salaires, les immobilisations, les coûts de fonctionnement et d’entretien [F et E] et les recettes). Veiller à ce que des processus et des infrastructures fournissent aux gestionnaires des renseignements financiers et autres sur le rendement, une approche réfléchie en matière de gestion du risque, des mécanismes de contrôle adéquats et un ensemble commun de valeurs et de principes éthiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 97,
                DescEng =
                    "Recognizes relations between shipboard departments and how they interact and the role of the cooks and stewards. Actively learns meal planning and storage protocols.",
                DescFre =
                    "Reconnaît les relations entre les services de bord et leur interaction, ainsi que le rôle des cuisiniers et des stewards. Apprend activement la planification des repas et les protocoles de stockage."
            },
            new CompetencyLevelRequirement
            {
                Id = 98,
                DescEng =
                    "Manages the logistics department in the absence of a supply officer. Consults with the cook and steward in managing storage and purchasing protocols. Assists in menu planning.",
                DescFre =
                    "Gère le service logistique en l'absence d'un responsable de l'approvisionnement. Consulte le cuisinier et le steward pour la gestion des protocoles de stockage et d'achat. Aide à la planification des menus."
            },
            new CompetencyLevelRequirement
            {
                Id = 99,
                DescEng =
                    "Manages the logistics department in the absence of a logistics officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation. Establishes requirements for the requisition, receipt, storage, and distribution of supplies. Collaborates with the engine room department in the loading of stores.",
                DescFre =
                    "Gère le service de la logistique en l'absence d'un responsable de la logistique. Consulte le chef cuisinier pour la préparation des menus. Consulte le steward sur les questions relatives au logement. Établit les exigences pour la réquisition, la réception, le stockage et la distribution des fournitures. Collabore avec le service de la salle des machines pour le chargement des magasins."
            },
            new CompetencyLevelRequirement
            {
                Id = 100,
                DescEng =
                    "Manages the logistics department as a supply officer. Consults with the chief cook in preparing menus. Consults with the steward on matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores and supplies.",
                DescFre =
                    "Gère le département logistique en tant qu'agent d'approvisionnement. Consulte le chef cuisinier pour la préparation des menus. Consulte le steward sur les questions relatives à l'hébergement, aux installations sanitaires et aux buanderies. Établit les exigences et les procédures pour la réquisition, la réception, le stockage et la distribution des fournitures. Collabore avec les officiers du département de la salle des machines pour le chargement et le déplacement des magasins et des fournitures."
            },
            new CompetencyLevelRequirement
            {
                Id = 101,
                DescEng =
                    "Manages the logistics department as a logistics officer. Consults with the chief cook and steward in all matters pertaining to shipboard hotel provisions and systems. Consults with shoreside stakeholders and conducts logistics audits and training at sea and ashore. ",
                DescFre =
                    "Gère le département logistique en tant qu'officier de logistique. Consulte le chef cuisinier et le steward pour tout ce qui concerne les dispositions et les systèmes hôteliers à bord du navire. Consulte les parties prenantes à terre et effectue des audits logistiques et des formations en mer et à terre."
            },
            new CompetencyLevelRequirement
            {
                Id = 102,
                DescEng =
                    "Cites relevant sections of acts and regulations pertaining to maritime security operations centres (MSOC) (Privacy Act, Oceans Act, etc.). Identifies memoranda of understandings (MOUs) and service level agreements (SLAs) in place. Observes and records data for analysis from various sources.",
                DescFre =
                    "Cite les articles pertinents des lois et règlements relatifs aux centres des opérations de sûreté maritime (COSM) (Loi sur la protection des renseignements personnels, Loi sur les océans, etc.) Identifie les protocoles d'entente (PE) et les accords sur les niveaux de service  en vigueur. Observe et enregistre les données de diverses sources pour analyse."
            },
            new CompetencyLevelRequirement
            {
                Id = 103,
                DescEng =
                    "Identifies legal and regulatory limitations related to operations. Applies appropriate document classification to reports. Undertakes basic assignments in surveillance activities. Observes radar feeds and identifies basic trends, patterns, and anomalies.",
                DescFre =
                    "Identifie les limites légales et réglementaires liées aux opérations. Applique la classification appropriée des documents aux rapports. Effectue des missions de base dans le cadre d'activités de surveillance. Observe les signaux radar et identifie les tendances de base, les motifs et les anomalies."
            },
            new CompetencyLevelRequirement
            {
                Id = 104,
                DescEng =
                    "Applies various constraints imposed by legislation and agreements by considering information sharing limitations when distributing products and/or information. Provides regular vessel tracking updates to partners as required. Analyzes information to contribute to products such as threat/risk assessments. Compiles and filters data received from partners for duplicates and unknowns. ",
                DescFre =
                    "Applique diverses contraintes imposées par la législation et les accords en tenant compte des limites du partage des informations lors de la distribution des produits et/ou des informations. Fournit aux partenaires des mises à jour régulières sur le suivi des navires, selon les besoins. Analyse les informations pour contribuer aux produits tels que les évaluations des menaces/risques. Compile et filtre les données reçues des partenaires pour détecter les doublons et les inconnues. "
            },
            new CompetencyLevelRequirement
            {
                Id = 105,
                DescEng =
                    "Incorporates legal opinions into procedures and processes. Identifies new sources of information. Produces vessel movement analysis based on historical data from various sources. Identifies surveillance gaps to recommend new products to fill gaps. Advises management on potential maritime threats/risks when no obvious warning is present. Conceives new maritime security initiatives to expand services and products within Fisheries and Oceans Canada (DFO).",
                DescFre =
                    "Intègre les avis juridiques dans les procédures et les processus. Identifie de nouvelles sources d'information. Produit une analyse des mouvements des navires basée sur des données historiques provenant de diverses sources. Identifie les lacunes en matière de surveillance afin de recommander de nouveaux produits pour combler les lacunes. Conseille la direction sur les menaces/risques maritimes potentiels lorsqu'il n'y a pas d'avertissement évident. Conçoit de nouvelles initiatives de sûreté maritime pour étendre les services et les produits au sein de Pêches et Océans Canada (MPO)."
            },
            new CompetencyLevelRequirement
            {
                Id = 106,
                DescEng =
                    "Develops formalized collection plans. Provides advice on maritime security incidents. Identifies new products to assist partners and clients in identifying potential threats. Collaborates with partners to develop maritime security operations centres (MSOC) products. Recommends capability of Canadian Coast Guard assets to and works with other government departments (OGDs) during maritime security events. Influences Coast Guard maritime security policy utilizing knowledge of partners changing initiatives, policies, and mandates.",
                DescFre =
                    "Élabore des plans de collecte formalisés. Fournit des conseils sur les incidents de sûreté maritime. Identifie de nouveaux produits pour aider les partenaires et les clients à identifier les menaces potentielles. Collabore avec les partenaires pour développer les produits des Centres des opérations de la sûreté maritime (COSM). Recommande la capacité des ressources de la Garde côtière canadienne à d'autres ministères et collabore avec eux lors d'événements de sûreté maritime. Influence la politique de sûreté maritime de la Garde côtière en utilisant la connaissance des initiatives, des politiques et des mandats changeants des partenaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 107, DescEng = "Reports and logs observed non-conformities.",
                DescFre = "Signaler et consigner les non-conformités observées."
            },
            new CompetencyLevelRequirement
            {
                Id = 108,
                DescEng =
                    "Participates in reviews and drafts quality assurance reports. Researches and compares findings against standard operating procedures or design specifications.",
                DescFre =
                    "Participer aux examens et rédiger des rapports sur l’assurance de la qualité. Effectuer des recherches et comparer les résultats avec les procédures opérationnelles normalisées ou les normes de conception."
            },
            new CompetencyLevelRequirement
            {
                Id = 109,
                DescEng =
                    "Implements the Canadian Coast Guard's quality assurance program. Interprets a wide variety of data and makes recommendations. Formulates recommendations for, or where appropriate, develops options to resolve non-conformities.",
                DescFre =
                    "Mettre en œuvre le programme d’assurance qualité de la Garde côtière canadienne. Interpréter une grande variété de données et formuler des recommandations. Formuler des recommandations ou, le cas échéant, élaborer des options pour résoudre les non-conformités."
            },
            new CompetencyLevelRequirement
            {
                Id = 110,
                DescEng =
                    "Defines and articulates parameters and desired objectives, encouraging others to adopt and deliver on those objectives. Applies the constraints within which information can or cannot be shared. Assists in developing quality assurance (QA) programs. Provides summary reports detailing QA findings.",
                DescFre =
                    "Définir et articuler les paramètres et les objectifs souhaités en encourageant les autres à adopter et à atteindre ces objectifs. Mettre en pratique les contraintes dans le cadre desquelles les informations peuvent ou non être communiquées. Contribuer à l’élaboration de programmes d’assurance de la qualité (AQ). Fournir des rapports de synthèse qui décrivent les résultats de l’AQ."
            },
            new CompetencyLevelRequirement
            {
                Id = 111,
                DescEng =
                    "Champions the Coast Guard's quality assurance (QA) program and systems. Develops creative and innovative programs, projects, and activities. Advises stakeholders on QA protocols and best practices.",
                DescFre =
                    "Promouvoir le programme et les systèmes d’assurance de la qualité (AQ) de la Garde côtière. Élaborer des programmes, des projets et des activités créatifs et innovants. Conseiller les intervenants sur les protocoles d’assurance de la qualité et les pratiques exemplaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 112,
                DescEng =
                    "Requests supplies based on demand. Ensures that proper receipt, identification, and inspection is carried out for all incoming materiel.",
                DescFre =
                    "Demande des fournitures en fonction de la demande. S'assure que la réception, l'identification et l'inspection appropriées sont effectuées pour tout le matériel entrant."
            },
            new CompetencyLevelRequirement
            {
                Id = 113,
                DescEng =
                    "Requests parts and supplies from internal stocks using approved classification system. Understands and follows the inventory management system (IMS). Processes special and emergency requirements of all clients.",
                DescFre =
                    "Demande des pièces et des fournitures à partir des stocks internes en utilisant un système de classification approuvé. Comprend et suit le Système de gestion des stocks. Traite les besoins spéciaux et urgents de tous les clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 114,
                DescEng =
                    "Receives, stores, issues, and records materiel according to approved inventory management system (IMS) and categories of materiel. Ensures that materiel held in stock is properly identified, catalogued, and incorporated in the centralized cataloguing files. Ensures that inventory is managed in accordance with Acts and regulations, when and where applicable. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items.",
                DescFre =
                    "Reçoit, stocke, distribue et enregistre le matériel selon le système de gestion des stocks approuvé et les catégories de matériel. S'assure que le matériel en stock est correctement identifié, catalogué et incorporé dans les fichiers de catalogage centralisés. S'assure que l'inventaire est géré conformément aux lois et règlements, le cas échéant. Tient à jour les registres de contrôle des engagements pour le matériel demandé en stock et pour les articles non stockés."
            },
            new CompetencyLevelRequirement
            {
                Id = 115,
                DescEng =
                    "Uses supplier classifications systems and cross-reference tables where available. Performs a full systematic process of developing, operating, maintaining, upgrading, and disposing, including commissioning and decommissioning of vessels as they relate to fleet operations, when and where applicable.",
                DescFre =
                    "Utilise les systèmes de classification des fournisseurs et les tableaux de correspondance lorsqu'ils sont disponibles. Effectue un processus systématique complet de développement, d'exploitation, d'entretien, de mise à niveau et d'élimination, y compris la mise en service et le déclassement des navires en ce qui concerne les opérations de la flotte, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 116,
                DescEng =
                    "Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches. Tests new software and innovative approaches within the field. Trains and guides employees within the materiel management field, when and where applicable.",
                DescFre =
                    "Assiste aux réunions nationales et représente les intérêts régionaux dans le domaine de la gestion du matériel. Conseille et oriente la direction sur les approches rentables. Teste de nouveaux logiciels et des approches innovantes dans le domaine. Forme et guide les employés dans le domaine de la gestion du matériel, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 117, DescEng = "Provides input into basic exercise plans.",
                DescFre = "Fournit des informations sur les plans d'exercices de base."
            },
            new CompetencyLevelRequirement
            {
                Id = 118,
                DescEng =
                    "Participates in and validates discussion-based exercises in talking through plan finalization.",
                DescFre =
                    "Participe à des exercices basés sur la discussion et les valider en parlant de la finalisation du plan."
            },
            new CompetencyLevelRequirement
            {
                Id = 119,
                DescEng =
                    "Produces and validates tabletop exercises, which stimulate the divisions between responders needing to communicate and be coordinated, where the participants are expected to know the plan and test it for procedural weaknesses.",
                DescFre =
                    "Produit et valide des exercices sur table, qui stimulent les divisions entre les intervenants ayant besoin de communiquer et d'être coordonnés, où les participants sont censés connaître le plan et le tester pour les faiblesses de procédure."
            },
            new CompetencyLevelRequirement
            {
                Id = 120,
                DescEng =
                    "Produces and validates live exercises in order to help participants develop skills  and confidence, testing logistics and physical capabilities, and providing experience of what it would be like to use a plan or procedure in real life. ",
                DescFre =
                    "Produit et valide des exercices en direct afin d'aider les participants à développer leurs compétences et leur confiance, en mettant à l'épreuve leurs capacités logistiques et physiques, et en leur donnant une expérience de ce que serait l'utilisation d'un plan ou d'une procédure dans la vie réelle."
            },
            new CompetencyLevelRequirement
            {
                Id = 121,
                DescEng =
                    "Proposes, develops, trials, and validates all types of exercises, including discussion-based, table top, and live. Uses hotwash and lesson learned functions to propose changes and new exercises. Consults on developing testing exercises and training others.",
                DescFre =
                    "Propose, développe, teste et valide tous les types d'exercices, y compris ceux basés sur des discussions, sur table et en direct. Utilise les fonctions de rétroaction immédiate et de leçons apprises pour proposer des changements et de nouveaux exercices. Consulte pour développer des exercices d'essai et former d'autres personnes."
            },
            new CompetencyLevelRequirement
            {
                Id = 122,
                DescEng =
                    "Assesses learners’ prior knowledge, learning needs, and career and college readiness goals. Sets learning goals and a course of study. Monitors learning through summative and formative assessment.",
                DescFre =
                    "Évalue les connaissances préalables des apprenants, leurs besoins d'apprentissage et leurs objectifs de carrière et de préparation au collège. Fixe des objectifs d'apprentissage et un programme d'études. Surveille l'apprentissage par le biais d'une évaluation sommative et formative."
            },
            new CompetencyLevelRequirement
            {
                Id = 123,
                DescEng =
                    "Designs learner-centered classroom environments. Designs standards-based instructional units. Uses instructional techniques that are relevant and effective with adult learners.",
                DescFre =
                    "Conçoit des cours centrés sur l'apprenant dans des environnements de classe. Conçoit des unités d'enseignement basées sur des normes. Utilise des techniques d'enseignement pertinentes et efficaces pour les apprenants adultes."
            },
            new CompetencyLevelRequirement
            {
                Id = 124,
                DescEng =
                    "Communicates high expectations of learners on Coast Guard employment in motivating them to meet  goals. Delivers lessons in a professional, clear, and understandable way. Engages in active listening, dialogue, and questioning to facilitate and support learning.",
                DescFre =
                    "Communique les attentes élevées des apprenants en matière d'emploi dans la Garde côtière en les motivant à atteindre leurs objectifs. Donne des cours de manière professionnelle, claire et compréhensible. S'engage dans une écoute active, un dialogue et un questionnement pour faciliter et soutenir l'apprentissage."
            },
            new CompetencyLevelRequirement
            {
                Id = 125,
                DescEng =
                    "Participates in professional development networks and learning communities. Shares content and pedagogical resources with program staff in collaborative professional development projects. Refines instructional practices through reflection on experience, evidence, and data. Designs instruction to build learners’ subject matter of expertise skills (i.e. marine skills in the Coast Guard). ",
                DescFre =
                    "Participe à des réseaux de développement professionnel et à des communautés d'apprentissage. Partage le contenu et les ressources pédagogiques avec le personnel du programme dans le cadre de projets de développement professionnel collaboratifs. Raffine les pratiques pédagogiques par une réflexion sur l'expérience, les faits et les données. Conçoit l'enseignement de manière à renforcer les compétences des apprenants en matière d'expertise (c'est-à-dire les compétences maritimes de la Garde côtière)."
            },
            new CompetencyLevelRequirement
            {
                Id = 126,
                DescEng =
                    "Champions a training environment featuring maximum flexibility, creativity, and passion, encouraging questions and discussion. Models an understanding of diversity in self and in students.",
                DescFre =
                    "Championne un environnement de formation caractérisé par un maximum de flexibilité, de créativité et de passion, encourageant les questions et la discussion. Modélise une compréhension de la diversité en soi et chez les étudiants."
            },
            new CompetencyLevelRequirement
            {
                Id = 127,
                DescEng =
                    "Reads the Government of Canada's Values and Ethics Code. Behaves consistently with the Values and Ethics Code and seeks appropriate guidance when required.",
                DescFre =
                    "Lire le Code de valeurs et d’éthique du gouvernement du Canada. Se comporter de manière cohérente avec le Code de valeurs et d’éthique et chercher à obtenir des conseils appropriés lorsque cela est nécessaire."
            },
            new CompetencyLevelRequirement
            {
                Id = 128,
                DescEng =
                    "Uses government assets responsibly. Discusses ethical concerns with their supervisor or colleagues and, when necessary, seeks and follows appropriate disclosure procedures.",
                DescFre =
                    "Utiliser les biens du gouvernement de manière responsable. Discuter des préoccupations éthiques avec son superviseur ou ses collègues et, au besoin, trouver et suivre les procédures de divulgation appropriées."
            },
            new CompetencyLevelRequirement
            {
                Id = 129,
                DescEng =
                    "Works in a manner that reflects a commitment to public service excellence. Assists peers respectfully when dealing with ethical concerns. Recognizes the importance of diversity, and bilingualism. Is well versed in the Government of Canada's Values and Ethics Code. Demonstrates respect for government property and policies.",
                DescFre =
                    "Mener ses activités au travail d’une manière qui témoigne de son engagement envers l’excellence de la fonction publique. Aider ses pairs de manière respectueuse lorsqu’il s’agit de questions éthiques. Reconnaître l’importance de la diversité et du bilinguisme. Bien connaître le Code de valeurs et d’éthique du gouvernement du Canada. Respecter les biens et les politiques du gouvernement."
            },
            new CompetencyLevelRequirement
            {
                Id = 130,
                DescEng =
                    "Consistently balances national, regional, and site specific ethical priorities. Actively promotes integrity, diversity, bilingualism, and respect through work behaviour and the workplace.  ",
                DescFre =
                    "Concilier constamment les priorités éthiques nationales, régionales et propres à chaque site. Promouvoir activement l’intégrité, la diversité, le bilinguisme et le respect par son comportement au travail et sur le lieu de travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 131,
                DescEng =
                    "Models public service before self. Assists and advises on issues with national and/or legal implications. Champions diversity and bilingualism. Acts with transparency and fairness. Enforces the appropriate use of government assets and resources.",
                DescFre =
                    "Faire passer la fonction publique avant soi. Donner de l’aide et des conseils sur les questions ayant des incidences nationales ou juridiques. Défendre la diversité et le bilinguisme. Agir en toute transparence et en toute équité. Veiller à l’utilisation appropriée des biens et des ressources de l’État."
            },
            new CompetencyLevelRequirement
            {
                Id = 132,
                DescEng =
                    "Breaks down concrete problems into parts and organizes information. Recognizes pertinent facts and issues that make up a problem. Asks standard questions and follows first line of investigation to identify the key elements of a situation or problem. Uses known procedures and standard operating models.",
                DescFre =
                    "Décomposer des problèmes concrets en composantes et structurer l’information. Reconnaître les faits et les enjeux pertinents qui constituent un problème. Poser des questions courantes et suivre la première piste d’enquête pour cerner les éléments clés d’une situation ou d’un problème. Utiliser des procédures connues et des modèles opérationnels normalisés."
            },
            new CompetencyLevelRequirement
            {
                Id = 133,
                DescEng =
                    "Researches available options to recommend a solution. Understands the Coast Guard's operational and organizational goals and strategies, and aligns activities towards the vision and strategic imperatives. ",
                DescFre =
                    "Rechercher des options disponibles pour recommander une solution. Comprendre les stratégies et objectifs opérationnels et organisationnels de la Garde côtière et orienter les activités sur la vision et les impératifs stratégiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 134,
                DescEng =
                    "Analyzes multiple causal relationships among several parts of a problem or situation. Anticipates the risks or implications inherent in a suggested plan of action and devises appropriate strategies to mitigate their impact. Makes a well-reasoned response even when faced with incomplete or contradictory information. Synthesizes complex ideas, issues, and observations into a clear understanding. Thinks beyond the work environment and makes decisions in the context of the bigger picture.",
                DescFre =
                    "Analyser les relations causales multiples entre plusieurs composantes d’un problème ou d’une situation. Prévoir les risques ou les répercussions inhérents d’un plan d’action suggéré, et élaborer des stratégies appropriées pour en atténuer l’incidence. Donner une réponse réfléchie, même en présence d’informations incomplètes ou contradictoires. Synthétiser les idées, les enjeux et les observations complexes pour les comprendre pleinement. Pousser la réflexion au-delà de l’environnement de travail et prendre des décisions dans le contexte de l’environnement global."
            },
            new CompetencyLevelRequirement
            {
                Id = 135,
                DescEng =
                    "Identifies several potential causes of events or multiple-part consequences. Analyzes complex, evolving circumstances and takes corrective action to aasync Task resource constraints and meet deadlines. Compares and contrasts evidence and information from various sources in a comprehensive and time sensitive manner. Understands program interdependencies and the need to integrate activities across functions/areas related to project planning, program implementation, and evaluation. Creates strategic alignment between cross-functional teams. Thinks laterally about business problems and opportunities; sees how the work and efforts of other Coast Guard teams/functions/operational centres intertwine to meet broad objectives.",
                DescFre =
                    "Déterminer les diverses causes possibles d’une situation ou d’une série d’événements à composantes multiples. Analyser les circonstances complexes et en évolution et prendre des mesures correctives pour éviter les contraintes de ressources et respecter les échéanciers. Effectuer en temps voulu des comparaisons et des contrastes complets entre les preuves et l’information provenant de diverses sources. Comprendre les interdépendances des programmes et la nécessité d’intégrer les activités aux fonctions et secteurs liés à la planification de projets ainsi qu’à la mise en œuvre et à l’évaluation des programmes. Créer des alignements stratégiques entre des équipes interfonctionnelles. Envisager de façon horizontale les problèmes et les possibilités organisationnelles; comprendre la façon dont le travail et les efforts des autres équipes, fonctions ou centres opérationnels de la Garde côtière sont liés afin d’atteindre les objectifs généraux."
            },
            new CompetencyLevelRequirement
            {
                Id = 136,
                DescEng =
                    "Thinks strategically about the range of market and business issues likely to impact the Coast Guard's ability to fulfill its mandate. Uses a sound understanding of the organization's strengths and weaknesses, its key stakeholders, and its long-term organizational strategy to leverage decisions of varying scope.",
                DescFre =
                    "Réfléchir stratégiquement à l’éventail des questions commerciales et des questions de marché susceptibles d’avoir une incidence sur la capacité de la Garde côtière à s’acquitter de son mandat. Utiliser une bonne compréhension des forces et des faiblesses de l’organisation, de ses principaux intervenants et de sa stratégie organisationnelle à long terme pour tirer parti de décisions de portée variable."
            },
            new CompetencyLevelRequirement
            {
                Id = 137,
                DescEng =
                    "Encourages members of the team to contribute to a process. Listens and asks questions. Expresses appreciation to others who have provided information assistance or support. Deals proactively with interpersonal matters that could affect team performance.",
                DescFre =
                    "Encourager les membres de l’équipe à contribuer à un processus. Écouter et poser des questions. Exprimer sa gratitude aux personnes qui fournissent des renseignements, de l’aide ou du soutien. Régler de manière proactive les affaires interpersonnelles qui pourraient nuire au rendement de l’équipe."
            },
            new CompetencyLevelRequirement
            {
                Id = 138,
                DescEng =
                    "Solicits opinions and viewpoints of team members. Cultivates personal bonds with colleagues in order to enhance performance throughout the organization. Discusses issues and exchanges information with partners to identify areas of mutual interest and benefit. Draws on other groups to facilitate project execution or persuade others. Manages personal work-life balance and respects the work-life balance of others.",
                DescFre =
                    "Solliciter les opinions et les points de vue des membres de l’équipe. Cultiver les liens personnels avec les collègues afin d’améliorer le rendement dans toute l’organisation. Discuter des problèmes et échanger des informations avec les partenaires afin de cibler les domaines d’intérêt communs et les avantages réciproques possibles. Faire appel à d’autres groupes pour faciliter l’exécution du projet ou pour en persuader d’autres. Gérer son propre équilibre travail-vie personnelle et respecter celui des autres."
            },
            new CompetencyLevelRequirement
            {
                Id = 139,
                DescEng =
                    "Effectively promotes a respectful and positive work environment. Recognizes diverse needs and perspectives (e.g. language differences, cultural differences, disabilities, and personal family circumstances). Recognizes individuals' achievements, knowledge, and capabilities. Monitors the work environment, successfully identifies underlying issues that impact negatively on people, and takes appropriate action, when and where applicable. Seeks and influences new relationships outside own unit and identifies new collaborative partnerships that better position of the Coast Guard's programs and services. Identifies and creates opportunities to partner through networking and participating in cross-functional, multi-stakeholder groups.",
                DescFre =
                    "Promouvoir un milieu de travail respectueux et positif. Reconnaître les différents besoins et points de vue des gens (p. ex., les différences linguistiques et culturelles, les incapacités et les situations familiales personnelles). Reconnaître les réalisations, les connaissances et les compétences de chacun. Surveiller l’environnement de travail, réussir à définir les problèmes sous-jacents qui ont une incidence négative sur les personnes et prendre les mesures appropriées, le cas échéant. Chercher à établir de nouvelles relations en dehors de son unité ou à orienter des relations existantes et repérer de nouveaux partenariats axés sur la collaboration permettant de mieux positionner les programmes et les activités de la Garde côtière. Trouver et créer de nouvelles occasions de partenariat en établissant des réseaux, en participant à des groupes interfonctionnels comprenant plusieurs intervenants."
            },
            new CompetencyLevelRequirement
            {
                Id = 140,
                DescEng =
                    "Models and promotes a culture of respect, fairness, and trust. Proficient in capitalizing on the strengths of team members. Encourages members of the team to contribute to a process, and seeks consensus. Always actively works with other teams to ensure that broader common goals are met. Builds and nurtures effective and collaborative networks and relationships with communities of practice, colleagues, and stakeholders.",
                DescFre =
                    "Donner l’exemple en adoptant une culture de respect, d’équité et de confiance et promouvoir cette culture. Tirer profit des forces des membres de son équipe. Encourager les membres de l’équipe à contribuer à un processus et rechercher le consensus. Toujours collaborer activement aux activités d’autres équipes afin que les objectifs généraux communs soient atteints. Créer et entretenir des réseaux et des relations efficaces et collaboratifs avec des communautés de pratique, des collègues et des intervenants."
            },
            new CompetencyLevelRequirement
            {
                Id = 141,
                DescEng =
                    "Advises others in dealing with ethical dilemmas, displaying sensitivity to diversity, and diverse needs in all dealings and relationships, and in maintaining fairness, consistency, and equity. Challenges current organizational behaviours and methods of operating, when and where applicable. Sets direction in terms of ethical standards and values for the organization. Draws on internal and external networks to help ensure buy-in and ownership; enhances the visibility of the Coast Guard's operations in the broader public sphere.",
                DescFre =
                    "Offrir des conseils à d’autres personnes sur la gestion des dilemmes éthiques, la sensibilité à la diversité et aux besoins variés dans toutes les interactions et relations, ainsi que le maintien de la justice, de la cohérence et de l’équité. Procéder à un examen critique des comportements organisationnels et des méthodes de fonctionnement actuels, au besoin. Montrer la voie en matière de normes éthiques et de valeurs pour l’organisation. S’appuyer sur des réseaux internes et externes pour assurer l’adhésion et l’appropriation; améliorer la visibilité des opérations de la Garde côtière dans la sphère publique."
            },
            new CompetencyLevelRequirement
            {
                Id = 142,
                DescEng =
                    "Completes work assignments. Balances work to meet commitments and deadlines by being focused on goals.",
                DescFre =
                    "Accomplir les tâches qui lui sont attribuées. Équilibrer le travail pour respecter les engagements et les délais en se concentrant sur les objectifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 143,
                DescEng =
                    "Responds to issues and/or brings concerns forward rather than waiting for them to be reported by someone else. Looks for new opportunities and seizes them when they arise. Plans for contingencies to deal with unexpected events. Structures work in order to achieve required results.",
                DescFre =
                    "Répondre aux préoccupations ou les soulever plutôt que d’attendre que quelqu’un d’autre les soulève. Rechercher continuellement de nouvelles occasions et les saisir lorsqu’elles se présentent. Prévoir les urgences afin d’être en mesure de gérer les événements imprévus. Structurer le travail de manière à obtenir les résultats requis."
            },
            new CompetencyLevelRequirement
            {
                Id = 144,
                DescEng =
                    "Considers ideas from a variety of sources in order to solve problems. Remains flexible to find alternate ways around obstacles/barriers to achieve goals. Takes calculated risks to achieve goals/outcomes. Perseveres in seeking solutions despite obstacles. Regularly evaluate and challenges work processes. Establishes effective organizational methods for assigning, managing, and tracking work, when and where applicable. Solicits and/or provides information that could affect the planning, programs, and decision-making for the Canadian Coast Guard.",
                DescFre =
                    "Examiner des idées qui proviennent de diverses sources pour résoudre des problèmes. Faire preuve de souplesse afin de trouver d’autres moyens de surmonter les obstacles pour atteindre les buts. Prendre des risques calculés pour atteindre des objectifs ou obtenir des résultats. Persévérer pour trouver des solutions malgré les obstacles. Évaluer et remettre en question régulièrement les processus de travail. Établir des méthodes organisationnelles efficaces pour attribuer, gérer et suivre le travail, lorsqu’il est nécessaire de la faire. Demander ou transmettre des renseignements susceptibles d’avoir une incidence sur la planification, les programmes et les processus décisionnels de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 145,
                DescEng =
                    "Offers expertise to resolve problems. Plans ahead to address future requirements without being asked. Anticipates and responds in a proactive manner to future needs of internal or external clients or groups. Coaches, supports, and encourages others to test limits, when and where applicable. Seeks new opportunities to improve outcomes using innovative approaches to overcome obstacles and surpass performance goals.",
                DescFre =
                    "Offrir son expertise pour résoudre les problèmes. Planifier pour répondre aux exigences futures, et ce, de sa propre initiative. Prévoir les besoins futurs de clients ou de groupes internes ou externes) et y répondre de manière proactive. Encadrer et appuyer les autres et les encourager à tester leurs limites, lorsque la situation s’y prête. Chercher de nouvelles occasions d’améliorer les résultats en adoptant des approches novatrices pour surmonter les obstacles et améliorer les objectifs de rendement."
            },
            new CompetencyLevelRequirement
            {
                Id = 146,
                DescEng =
                    "Sets standards and criteria for measuring success organizationally. Seizes opportunities and initiatives across organizational boundaries to achieve efficiencies consistent with the Coast Guard's vision. Creates an environment in which all systems and processes support high levels of efficiency. Champions the ongoing spirit of improvement and professional growth across the organization.",
                DescFre =
                    "Établir des normes et des critères pour mesurer la réussite de l’organisation. Saisir des occasions et prendre part à des initiatives au-delà des frontières de l’organisation afin de réaliser des gains d’efficacité conformes à la vision de la Garde côtière. Créer un environnement dans lequel tous les systèmes et processus soutiennent des niveaux élevés d’efficacité. Se faire le champion de l’amélioration continue des activités et de la croissance professionnelle dans toute l’organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 147,
                DescEng =
                    "Awareness of the importance of safety in the Canadian Coast Guard. Familiar with the joining safety package.",
                DescFre =
                    "Reconnaître l’importance de la sécurité au sein de la Garde côtière canadienne. Se familiariser avec la formation d’orientation et de sensibilisation à la sécurité."
            },
            new CompetencyLevelRequirement
            {
                Id = 148,
                DescEng =
                    "Evaluates environment and adapts work to maintain safety. Ensures safety training is up to date. Uses appropriate personal protective equipment (PPE) when and where applicable. Applies proper safety procedures.",
                DescFre =
                    "Évaluer l’environnement et adapter le travail pour assurer la sécurité. Voir à ce que la formation sur la sécurité soit à jour. Utiliser l’équipement de protection individuelle (EPI) approprié lorsque cela est nécessaire. Appliquer les procédures de sécurité appropriées."
            },
            new CompetencyLevelRequirement
            {
                Id = 149,
                DescEng =
                    "Conducts operations consistent with the Coast Guard Safety Management System (SMS), national and regulatory safety procedures, and policy when and where applicable. Understands the risks and manages safety and health issues when and where applicable. May participate in occupational health and safety groups and audits.",
                DescFre =
                    "Mener des opérations conformes au Système de gestion de la sécurité de la Garde côtière, aux procédures de sécurité nationales et réglementaires et à la politique, le cas échéant. Comprendre les risques et gérer les questions de sécurité et de santé le cas échéant. Peut participer à des groupes et à des audits sur la santé et la sécurité au travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 150,
                DescEng =
                    "Promotes a culture of unit safety. Ensures required personnel under supervision are trained in first aid and safety procedures. Ensures personnel under supervision apply safety plans and principles. Integrates health and safety planning in conformity with Incident Command Systems (ICS) principles when and where applicable. Integrates health and safety considerations in post-incident and post-exercise reviews.",
                DescFre =
                    "Promouvoir une culture de la sécurité dans l’unité. Veiller à ce que le personnel requis supervisé soit formé aux procédures de premiers soins et de sécurité. Veiller à ce que le personnel supervisé mette en pratique les plans et les principes de sécurité. Intégrer la planification de la santé et de la sécurité conformément aux principes des systèmes de commandement d’intervention (SCI), au besoin. Intégrer les considérations de santé et de sécurité dans les examens après incident et après exercice."
            },
            new CompetencyLevelRequirement
            {
                Id = 151,
                DescEng =
                    "Promotes and integrates a culture of organizational safety. Develops risk analyses for responders and senior personnel regarding health and safety. Ensures required personnel are trained in first aid and safety procedures, as required. Leverages health and safety lessons learned from post-incident and post-exercise reviews in daily operations.",
                DescFre =
                    "Promouvoir et intégrer une culture de sécurité dans l’organisation. Élaborer des analyses de risques pour les intervenants et le personnel supérieur en matière de santé et de sécurité. Veiller à ce que le personnel requis soit formé aux premiers soins et aux procédures de sécurité, selon les besoins. Tirer les enseignements en matière de santé et de sécurité des examens après incident et après exercice et les mettre en pratique dans les opérations quotidiennes."
            },
            new CompetencyLevelRequirement
            {
                Id = 152,
                DescEng =
                    "Listens to leaders and emulates positive behaviour through observation and imitation, when and where applicable. Recognizes personal limitations and is motivated to address and improve them.",
                DescFre =
                    "Écouter les dirigeants et imiter les comportements positifs par l’observation et l’imitation, le cas échéant. Reconnaître ses limites personnelles et prendre les moyens pour les aborder et s’améliorer."
            },
            new CompetencyLevelRequirement
            {
                Id = 153,
                DescEng =
                    "Adapts to change to help the team evolve in conjunction with the Coast Guard's evolving concerns. Seizes opportunities to increase skills and knowledge about operations, members, and stakeholders, when and where applicable.",
                DescFre =
                    "S’adapter au changement pour aider l’équipe à évoluer en fonction des préoccupations changeantes de la Garde côtière. Saisir les occasions d’accroître ses compétences et ses connaissances sur les opérations, les membres et les intervenants, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 154,
                DescEng =
                    "Demonstrates interest in team members' success and well-being by listening and actively viewing situations through others' perspectives. Identifies strengths, leverages them, and persuades others for the benefit of the Coast Guard. Routinely teaches and guides work, based on operational knowledge through direct and indirect means. Seeks solutions by charting opinions and options.",
                DescFre =
                    "Manifester son intérêt pour la réussite et le bien-être des membres de l’équipe en écoutant et en examinant activement les situations en adoptant le point de vue des autres. Cibler les points forts, en tirer parti et persuader les autres au profit de la Garde côtière. Donner régulièrement de l’enseignement et des orientations sur le travail, en s’appuyant sur des connaissances opérationnelles, par des moyens directs et indirects. Chercher des solutions en consignant les opinions et les options."
            },
            new CompetencyLevelRequirement
            {
                Id = 155,
                DescEng =
                    "Links members' individual development to organizational objectives and developing future leaders. Encourages innovation. Remains effective in the face of obstacles. Identifies and assesses risks in projects or decisions and produces realistic contingency plans to mitigate possible impacts. Exercises positive influence on the organization when needed. ",
                DescFre =
                    "Relier le perfectionnement individuel des membres aux objectifs organisationnels et au perfectionnement des futurs dirigeants. Stimuler l’innovation. Demeurer efficace malgré les obstacles. Cibler et évaluer les risques dans les projets ou les décisions et produire des plans d’urgence réalistes pour atténuer les incidences possibles. Exercer une influence positive sur l’organisation lorsque cela est nécessaire."
            },
            new CompetencyLevelRequirement
            {
                Id = 156,
                DescEng =
                    "Sets and champions organizational directions. Recognizes the big picture and cultivates organizational vision. Prioritizes the creation of a work environment that propels teams to step up to new challenges. Seamlessly assumes next level responsibilities. Regularly exercises persuasive influence on the organization in a wide variety of tactical and strategic areas.",
                DescFre =
                    "Établir et défendre les orientations de l’organisation. Reconnaître la vue d’ensemble et cultiver la vision organisationnelle. Donner la priorité à la création d’un environnement de travail qui pousse les équipes à relever de nouveaux défis. Assumer sans problème des responsabilités croissantes. Exercer régulièrement une influence persuasive sur l’organisation dans un large éventail de domaines tactiques et stratégiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 157,
                DescEng =
                    "Articulates pride in being a member of the Coast Guard. Wears and maintains the uniform properly, when and where applicable.",
                DescFre =
                    "Exprimer sa fierté d’être membre de la Garde côtière. Porter et entretenir correctement son uniforme, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 158,
                DescEng =
                    "Expresses pride in the humanitarian and environmental nature of the Coast Guard's mission. Participates in organizational engagement activities. Wears the uniform proudly.",
                DescFre =
                    "Exprimer sa fierté quant à la nature humanitaire et environnementale de la mission de la Garde côtière. Participer à des activités de mobilisation organisationnelles. Porter fièrement l’uniforme."
            },
            new CompetencyLevelRequirement
            {
                Id = 159,
                DescEng =
                    "Expresses pride in the Coast Guard's regional and/or national achievements. Incorporates and models the Coast Guard's ambitious vision and motto in daily practice and supports it within units. Articulates the Coast Guard's vision when providing advice or instructions internally. ",
                DescFre =
                    "Exprimer sa fierté pour les réalisations régionales ou nationales de la Garde côtière. Intégrer et exprimer la vision et la devise ambitieuse de la Garde côtière dans la pratique quotidienne et soutenir cette vision et cette devise au sein des unités. Décrire la vision de la Garde côtière lorsqu’il faut donner des conseils ou de la formation en interne."
            },
            new CompetencyLevelRequirement
            {
                Id = 160,
                DescEng =
                    "Propagates the Coast Guard's vision, mission, mandate, and programs internally and externally as an example of deep pride in the organization. Conveys the importance of the Coast Guard's work to members and stakeholders. Celebrates organizational achievements.",
                DescFre =
                    "Diffuser la vision, la mission, le mandat et les programmes de la Garde côtière en interne et en externe comme un exemple de la profonde fierté que suscite l’organisation. Faire valoir l’importance du travail de la Garde côtière aux membres et aux intervenants. Célébrer les réalisations de l’organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 161,
                DescEng =
                    "Models organizational pride in the Coast Guard's brand and the jobs it performs. Champions the organization when working collectively with internal and external stakeholders. Promotes organizational achievements and employee engagement events nationally. Strives to hone organizational excellence through celebration and pageantry.",
                DescFre =
                    "Manifester sa fierté envers la marque de la Garde côtière et le travail qu’elle accomplit. Défendre l’organisation lorsqu’il faut collaborer avec des intervenants internes et externes. Promouvoir les réalisations organisationnelles et les événements de mobilisation des employés à l’échelle nationale. Favoriser l’excellence organisationnelle par la tenue de célébration et de cérémonies."
            },
            new CompetencyLevelRequirement
            {
                Id = 162, DescEng = "Understands primary coastal features, weather, tide, and charts.",
                DescFre =
                    "Comprend les principales caractéristiques côtières, les conditions météorologiques, les marées et les cartes marines."
            },
            new CompetencyLevelRequirement
            {
                Id = 163,
                DescEng =
                    "Understands basic traffic patterns for traffic aasync Taskance, observing and reporting weather conditions, and local tides in immediate surroundings.",
                DescFre =
                    "Comprend les schémas de circulation de base pour éviter le trafic, observer et signaler les conditions météorologiques et les marées locales dans les environs immédiats."
            },
            new CompetencyLevelRequirement
            {
                Id = 164,
                DescEng =
                    "Practical knowledge of a range of coastal domain factors including local weather predictability, vessel traffic aasync Taskance in a given charted area, and local tides and currents.",
                DescFre =
                    "Connaissance pratique d'une gamme de facteurs du domaine côtier, y compris la prévisibilité des conditions météorologiques locales, l'évitement du trafic maritime dans une zone cartographiée donnée, et les marées et courants locaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 165,
                DescEng =
                    "Significant knowledge of a regional coastline including weather reporting and patterns, impacts on shipping, vessel traffic patterns and reporting, cartographic and oceanographic factors, and the search net. ",
                DescFre =
                    "Connaissance approfondie d'un littoral régional, y compris les rapports et les tendances météorologiques, les répercussions sur la navigation, les tendances et les rapports du trafic maritime, les facteurs cartographiques et océanographiques, et le réseau de recherche."
            },
            new CompetencyLevelRequirement
            {
                Id = 166,
                DescEng =
                    "Excellent knowledge of regional and/or national coastal factors including those likely to impact the coast, threats from offshore, natural disasters and their impacts, vessel traffic management, operations of other government vessels, detailed cartography, meteorology, hydrogeology, and oceanography.",
                DescFre =
                    "Excellente connaissance des facteurs côtiers régionaux et/ou nationaux, y compris ceux susceptibles d'avoir une incidence sur la côte, les menaces provenant de la haute mer, les catastrophes naturelles et leurs répercussions, la gestion du trafic maritime, les opérations des autres navires gouvernementaux, la cartographie détaillée, la météorologie, l'hydrogéologie et l'océanographie"
            },
            new CompetencyLevelRequirement
            {
                Id = 167,
                DescEng =
                    "Basic knowledge of how the movement of water generates gravity force to lift or lower a vessel in a canal lock.",
                DescFre =
                    "Basic knowledge of how the movement of water generates gravity force to lift or lower a vessel in a canal lock."
            },
            new CompetencyLevelRequirement
            {
                Id = 168,
                DescEng =
                    "Limited knowledge of the major operational components of a canal, such as the bollard, gate, lock, reach, and valve.",
                DescFre =
                    "Limited knowledge of the major operational components of a canal, such as the bollard, gate, lock, reach, and valve."
            },
            new CompetencyLevelRequirement
            {
                Id = 169,
                DescEng =
                    "Practical knowledge of how to signal a canal master, approach a lock reach, navigate a lock, and proceed safely clear of a canal.",
                DescFre =
                    "Practical knowledge of how to signal a canal master, approach a lock reach, navigate a lock, and proceed safely clear of a canal."
            },
            new CompetencyLevelRequirement
            {
                Id = 170,
                DescEng =
                    "Advanced knowledge of canal lock operation from a canal master perspective, including receiving signals of transits, operating the gates, flooding the lock, and troublshooting for current or potential problems.",
                DescFre =
                    "Advanced knowledge of canal lock operation from a canal master perspective, including receiving signals of transits, operating the gates, flooding the lock, and troublshooting for current or potential problems."
            },
            new CompetencyLevelRequirement
            {
                Id = 171,
                DescEng =
                    "Expert knowledge of all facets of canal lock operating, as well as such maintenance functions as ordering and overseeing preventative maintenance of gates, and controls.",
                DescFre =
                    "Expert knowledge of all facets of canal lock operating, as well as such maintenance functions as ordering and overseeing preventative maintenance of gates, and controls."
            },
            new CompetencyLevelRequirement
            {
                Id = 172,
                DescEng =
                    "Assists trades staff in performing basic labour activities, when and where applicable. Maintains clean and orderly conditions in all working areas, including shop, vehicle, vessel, and the Canadian Coast Guard's work sites.",
                DescFre =
                    "Aide le personnel des métiers à exercer des activités de base, le cas échéant. Maintient des conditions propres et ordonnées dans tous les lieux de travail, y compris l'atelier, le véhicule, le navire et les sites de travail de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 173,
                DescEng =
                    "Performs duties such as window mechanism repairs, lubricating doors, tile and carpet removal, painting, boiler tube cleaning, securing buildings, emergency water shut off, roof drain cleaning, ceiling tile replacement, air filter changing, removal of roof debris, replacement of lights, minor driveway and walkway repairs, catch basin maintenance. Loads, transports, and unloads planned furniture, equipment, books, risers and other material requested and approved within vessels and facilities of the Coast Guard. Uses power and hand tools.",
                DescFre =
                    "S'acquitte de tâches telles que la réparation des mécanismes de fenêtres, la lubrification des portes, l'enlèvement des tuiles et des tapis, la peinture, le nettoyage des tubes de chaudière, la sécurisation des bâtiments, la coupure d'urgence de l'eau, le nettoyage des canalisations d'évacuation des eaux de toit, le remplacement des tuiles de plafond, le changement des filtres à air, l'enlèvement des débris de toit, le remplacement des lumières, les petites réparations des allées et des trottoirs, l'entretien des puisards. Charger, transporter et décharger le mobilier, l'équipement, les livres, les colonnes montantes et autres matériels prévus, demandés et approuvés dans les navires et les installations de la Garde côtière. Utilise des outils électriques et manuels."
            },
            new CompetencyLevelRequirement
            {
                Id = 174,
                DescEng =
                    "Completes and documents work and/or inspection/test orders. Makes recommendations and determines potential work time for planned equipment moves and maintenance. Operates precision power hand tools, and cleans, maintains, and stores equipment after use.",
                DescFre =
                    "Effectue et documente les travaux et/ou les ordres d'inspection/de test. Formule des recommandations et détermine le temps de travail potentiel pour les déplacements et l'entretien prévus de l'équipement. Utilise des outils à main électriques de précision, et nettoyer, entretenir et stocker l'équipement après utilisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 175,
                DescEng =
                    "Performs risk assessment of all assigned projects and maintains risk management protocols at all times. Performs inspections and keeps maintenance records. Operates and maintains power and hand tools, and trains others.",
                DescFre =
                    "Effectue l'évaluation des risques de tous les projets assignés et maintient des protocoles de gestion des risques à tout moment. Effectue des inspections et tient des registres de maintenance. Fait fonctionner et entretient les outils électriques et manuels, et forme d'autres personnes."
            },
            new CompetencyLevelRequirement
            {
                Id = 176,
                DescEng =
                    "Maintains buildings and grounds. Performs minor construction and renovation projects. Implements vehicle, vessel, and/or building system practices and procedures. Inspects and conducts quality assurance functions.",
                DescFre =
                    "Entretient les bâtiments et les terrains. Réalise des projets de construction et de rénovation mineurs. Mettre en œuvre des pratiques et des procédures relatives aux véhicules, aux navires et/ou aux systèmes de bâtiments. Inspecte et exerce des fonctions d'assurance qualité."
            },
            new CompetencyLevelRequirement {Id = 177, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 178, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 179, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 180,
                DescEng =
                    "Works on a daily basis with documents such as labels on hazardous materials, signs, lists, operator’s manuals, inspection forms, hazard assessment forms, log books, and time sheets. Makes entries in daily equipment reports (logbooks) during pre- and post-operational inspections. Calculates the number of loads required to remove materials and the weight distribution of a load being lifted. Measures and calculates the slope and ratio of ditches. Uses computer-controlled equipment such as electronic scales, GPS, and advanced operating systems. Keep an equipment maintenance log to note repairs made and service schedules. Writes accident and incident reports describing details. Estimates distances between the machine and various obstacles, width of ramps for space on either side of a machine, and how many truckloads of fill are required. Converts between the imperial and metric systems of measurement.",
                DescFre =
                    "Works on a daily basis with documents such as labels on hazardous materials, signs, lists, operator’s manuals, inspection forms, hazard assessment forms, log books, and time sheets. Makes entries in daily equipment reports (logbooks) during pre- and post-operational inspections. Calculates the number of loads required to remove materials and the weight distribution of a load being lifted. Measures and calculates the slope and ratio of ditches. Uses computer-controlled equipment such as electronic scales, GPS, and advanced operating systems. Keep an equipment maintenance log to note repairs made and service schedules. Writes accident and incident reports describing details. Estimates distances between the machine and various obstacles, width of ramps for space on either side of a machine, and how many truckloads of fill are required. Converts between the imperial and metric systems of measurement."
            },
            new CompetencyLevelRequirement
            {
                Id = 181,
                DescEng =
                    "Reads pamphlets explaining regulations and codes, bulletins from unions, employers or other regulatory bodies, and memos or work orders with information on the nature of the work to be performed. Reads or marks stakes with station numbers and slope ratios, mark off caution areas on maps, and make sketches or drawings. Consults surveyor charts and blueprints. Stays up to date with regulations, health and safety procedures and new technology. Advise and guide management in best practices, approaches, and strategies to resolve issues or define programs. Train staff to perform essential functions of the position and adhere to internal practices that have been established by self for the benefit of the shop or the Canadian Coast Guard",
                DescFre =
                    "Reads pamphlets explaining regulations and codes, bulletins from unions, employers or other regulatory bodies, and memos or work orders with information on the nature of the work to be performed. Reads or marks stakes with station numbers and slope ratios, mark off caution areas on maps, and make sketches or drawings. Consults surveyor charts and blueprints. Stays up to date with regulations, health and safety procedures and new technology. Advise and guide management in best practices, approaches, and strategies to resolve issues or define programs. Train staff to perform essential functions of the position and adhere to internal practices that have been established by self for the benefit of the shop or the Canadian Coast Guard"
            },
            new CompetencyLevelRequirement
            {
                Id = 182,
                DescEng =
                    "Assists carpenters. Interprets simple blueprints and drawings. Uses basic materials and techniques. Sets up and operates hand tools and equipment. Sets up framing using basic joining techniques. Maintains and cleans tools and the site.",
                DescFre =
                    "Aide aux menuisiers. Interprète des plans et des dessins simples. Utilise des matériaux et des techniques de base. Installe et utilise des outils à main et du matériel. Met en place l'encadrement en utilisant les techniques d'assemblage de base. Entretient et nettoie les outils et le site."
            },
            new CompetencyLevelRequirement
            {
                Id = 183,
                DescEng =
                    "Performs standard building construction and repair using sketches, working blueprints, and work plans. Uses and maintains tools according to standards. Selects appropriate materials and gear. Assembles items with standard joining, woodworking, and bonding techniques. Works independently on basic jobs.",
                DescFre =
                    "Effectue la construction et la réparation de bâtiments standard à l'aide de croquis, de plans de travail et de plans d'exécution. Utilise et entretient les outils conformément aux normes. Sélectionne les matériaux et les équipements appropriés. Assemble des articles en utilisant des techniques d'assemblage, de menuiserie et de collage standard. Travaille de manière indépendante sur des travaux de base."
            },
            new CompetencyLevelRequirement
            {
                Id = 184,
                DescEng =
                    "Performs intermediate heavy and light construction and repair. Manages cyclic preventive maintenance on a selected array of machinery, tools, and equipment. Works from sketches, orders, and standard blueprints to independently assemble and repair most basic structures.",
                DescFre =
                    "Effectue des travaux de construction et de réparation intermédiaires, lourds et légers. Gère l'entretien préventif cyclique d'un ensemble sélectionné de machines, d'outils et d'équipements. Travaille à partir de croquis, de commandes et de plans standard pour assembler et réparer de manière indépendante la plupart des structures de base."
            },
            new CompetencyLevelRequirement
            {
                Id = 185,
                DescEng =
                    "Performs complex construction and repair using the full range of woodworking tools, techniques, and machines. Interprets complex blueprints, drawings, and specifications. Determines layout and work sequence. Assembles items to close tolerance and fit with a wide variety of joining techniques.",
                DescFre =
                    "Effectue des travaux de construction et de réparation complexes en utilisant toute la gamme des outils, techniques et machines de menuiserie. Interprète des plans, des dessins et des spécifications complexes. Détermine la disposition et la séquence de travail. Assemble des articles avec une tolérance étroite et les adapter à une grande variété de techniques d'assemblage."
            },
            new CompetencyLevelRequirement
            {
                Id = 186,
                DescEng =
                    "Develops and implements work schedules. Uses advanced knowledge of wood and other materials and shop mathematics to compute and lay out arcs, tangents, and circles according to complex blueprints. Sets up and operates all precision carpentry and wood working tools and equipment. Finishes products with precise fit, accurate dimensions, and appearance. Determines grade, size and type of lumber.",
                DescFre =
                    "Elabore et met en œuvre des programmes de travail. Utilise des connaissances avancées sur le bois et d'autres matériaux et faire des calculs mathématiques d'atelier pour calculer et tracer des arcs, des tangentes et des cercles selon des plans complexes. Met en place et utilise tous les outils et équipements de menuiserie et de travail du bois de précision. Finit les produits avec un ajustement précis, des dimensions et un aspect précis. Détermine la qualité, la taille et le type de bois d'œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 187,
                DescEng =
                    "Aware of routine electrical (or electronic) processes or other areas requiring technical expertise. Conducts analysis based on standardized flowchart.",
                DescFre =
                    "Aware of routine electrical (or electronic) processes or other areas requiring technical expertise. Conducts analysis based on standardized flowchart."
            },
            new CompetencyLevelRequirement
            {
                Id = 188,
                DescEng =
                    "Makes recommendations on routine/technical designs and/or program/project specifications to meet desired compliance with electrical engineering principles, standards, codes, designs, and statutes when and where applicable.",
                DescFre =
                    "Makes recommendations on routine/technical designs and/or program/project specifications to meet desired compliance with electrical engineering principles, standards, codes, designs, and statutes when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 189,
                DescEng =
                    "Makes decisions on non-routine and/or program matters requiring technical expertise when and where applicable. Provides technical analysis. Serves as a mentor/resource to lower level employees in the area of assignment when and where applicable. Addresses conflicting design constraints when and where applicable.",
                DescFre =
                    "Makes decisions on non-routine and/or program matters requiring technical expertise when and where applicable. Provides technical analysis. Serves as a mentor/resource to lower level employees in the area of assignment when and where applicable. Addresses conflicting design constraints when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 190,
                DescEng =
                    "Approves complex or new electrical engineering / technical designs and/or program/project specifications to meet desired compliance with principles, standards, codes, designs, and statutes. Reviews stock replenishment requisitions to ensure the items in current use and quantities ordered are realistic.",
                DescFre =
                    "Approves complex or new electrical engineering / technical designs and/or program/project specifications to meet desired compliance with principles, standards, codes, designs, and statutes. Reviews stock replenishment requisitions to ensure the items in current use and quantities ordered are realistic."
            },
            new CompetencyLevelRequirement
            {
                Id = 191,
                DescEng =
                    "Makes final recommendations for specialized electrical engineering and/or program areas. Represents the CCG as an expert in electrical review and design.",
                DescFre =
                    "Makes final recommendations for specialized electrical engineering and/or program areas. Represents the CCG as an expert in electrical review and design."
            },
            new CompetencyLevelRequirement {Id = 192, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 193, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 194, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 195,
                DescEng =
                    "Interprets work orders and technical manuals, and drafts service reports and maintenance logs. Checks bulldozers, cranes, graders, and other heavy construction equipment for proper performance and inspects equipment to detect faults and malfunctions. Diagnoses faults or malfunctions using computerized and other testing equipment to determine extent of repair required. Cleans, lubricates, and performs other routine maintenance work on equipment. Adjusts equipment and repairs or replaces defective parts, components or systems, using hand and power tools. Tests repaired equipment for proper performance and to ensure that work meets manufacturers' specifications.",
                DescFre =
                    "Interprets work orders and technical manuals, and drafts service reports and maintenance logs. Checks bulldozers, cranes, graders, and other heavy construction equipment for proper performance and inspects equipment to detect faults and malfunctions. Diagnoses faults or malfunctions using computerized and other testing equipment to determine extent of repair required. Cleans, lubricates, and performs other routine maintenance work on equipment. Adjusts equipment and repairs or replaces defective parts, components or systems, using hand and power tools. Tests repaired equipment for proper performance and to ensure that work meets manufacturers' specifications."
            },
            new CompetencyLevelRequirement
            {
                Id = 196,
                DescEng =
                    "Assists other mechanics with more challenging assignments. Maintains a schedule for preventative maintenance on all equipment. Ensures that equipment meets all government regulations and standards for safety. Stays current with regulations, health and safety procedures, and new technologies. Advises and guides management in best practices, approaches, and strategies to resolve issues or define programs. Provides instruction and training in the proper methods and processes necessary to perform equipment repair, inspection, and preventive maintenance.",
                DescFre =
                    "Assists other mechanics with more challenging assignments. Maintains a schedule for preventative maintenance on all equipment. Ensures that equipment meets all government regulations and standards for safety. Stays current with regulations, health and safety procedures, and new technologies. Advises and guides management in best practices, approaches, and strategies to resolve issues or define programs. Provides instruction and training in the proper methods and processes necessary to perform equipment repair, inspection, and preventive maintenance."
            },
            new CompetencyLevelRequirement {Id = 197, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 198, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 199, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 200, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 201,
                DescEng =
                    "Reviews manuals, bulletins, and safety documents. Locates data such as classifications, product and material specifications, identification numbers, quantities, and costs. Completes workplace documents such as written explanations to the client, work orders, inspection reports, and incident reports. Analyzes pressure, power, torque, compression, and electrical readings to assess vehicle performance and troubleshoot faults. Takes a variety of measurements using digital and analog equipment. Evaluates the severity of vehicle defects and deficiencies and the quality of repairs. Uses computerized scanning equipment, onboard vehicle diagnostics and hand-held diagnostic tools to gain operational information about vehicles. Repairs damaged vehicles, vessels, including engine repair and body work.",
                DescFre =
                    "Reviews manuals, bulletins, and safety documents. Locates data such as classifications, product and material specifications, identification numbers, quantities, and costs. Completes workplace documents such as written explanations to the client, work orders, inspection reports, and incident reports. Analyzes pressure, power, torque, compression, and electrical readings to assess vehicle performance and troubleshoot faults. Takes a variety of measurements using digital and analog equipment. Evaluates the severity of vehicle defects and deficiencies and the quality of repairs. Uses computerized scanning equipment, onboard vehicle diagnostics and hand-held diagnostic tools to gain operational information about vehicles. Repairs damaged vehicles, vessels, including engine repair and body work."
            },
            new CompetencyLevelRequirement {Id = 202, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 203, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 204,
                DescEng =
                    "Sands and hydro blasts for cleaning, decorative or preparatory purposes steel, concrete, or wood. Installs rubber, fiberglass, acid resistant or metalized linings to tanks, pipes, or other vessels. Installs all wall coverings on buildings or structure surfaces, when and where applicable. Uses hand tools and measuring equipment. ",
                DescFre =
                    "Sands and hydro blasts for cleaning, decorative or preparatory purposes steel, concrete, or wood. Installs rubber, fiberglass, acid resistant or metalized linings to tanks, pipes, or other vessels. Installs all wall coverings on buildings or structure surfaces, when and where applicable. Uses hand tools and measuring equipment."
            },
            new CompetencyLevelRequirement
            {
                Id = 205,
                DescEng =
                    "Cleans and sands surfaces. Applies drywall and plaster repair and finishing techniques. Applies chemical treatments and wood fillers to a given surface. Applies procedures or treatments to prepare a substrate. Strains, mixes, and thins coatings according to specifications including ratios and induction times. Applies a spray finish using airless equipment according to project specifications. Performs abrasive and hydro blasting. Corrects coating failures. Uses hoisting and lifting equipment.",
                DescFre =
                    "Cleans and sands surfaces. Applies drywall and plaster repair and finishing techniques. Applies chemical treatments and wood fillers to a given surface. Applies procedures or treatments to prepare a substrate. Strains, mixes, and thins coatings according to specifications including ratios and induction times. Applies a spray finish using airless equipment according to project specifications. Performs abrasive and hydro blasting. Corrects coating failures. Uses hoisting and lifting equipment."
            },
            new CompetencyLevelRequirement
            {
                Id = 206,
                DescEng =
                    "Manages workplace hazards while respecting fall protection systems, personal protective equipment (PPE), and fire safety procedures. Uses power, pneumatic tools, and access equipment. Prepares and repairs drywall, plaster, concrete, masonry, metal and wood surfaces. Applies and corrects paint/coating failures. Uses airless, specialty, and thermal spray equipment. Applies caulking, finishes, and graphics. Applies decorative finishes. Interprets drawings and specifications. Identifies standards for application of coatings to metal substrates. Provides guidance on the types and functions of abrasive blasting equipment, on the procedures involved in hydro blasting, the architectural, high performance, and industrial coatings, and on the causes and remedies for given coating failures.",
                DescFre =
                    "Manages workplace hazards while respecting fall protection systems, personal protective equipment (PPE), and fire safety procedures. Uses power, pneumatic tools, and access equipment. Prepares and repairs drywall, plaster, concrete, masonry, metal and wood surfaces. Applies and corrects paint/coating failures. Uses airless, specialty, and thermal spray equipment. Applies caulking, finishes, and graphics. Applies decorative finishes. Interprets drawings and specifications. Identifies standards for application of coatings to metal substrates. Provides guidance on the types and functions of abrasive blasting equipment, on the procedures involved in hydro blasting, the architectural, high performance, and industrial coatings, and on the causes and remedies for given coating failures."
            },
            new CompetencyLevelRequirement
            {
                Id = 207,
                DescEng =
                    "Basic knowledge of the acts and regulations applicable to a given program area, based on education or training.",
                DescFre =
                    "Connaissance de base des lois et règlements applicables à un domaine de programme donné, fondée sur l'éducation ou la formation."
            },
            new CompetencyLevelRequirement
            {
                Id = 208,
                DescEng =
                    "Limited knowledge of acts and regulations based on training, researching, and limited experience in a given program setting.",
                DescFre =
                    "Connaissance limitée des lois et des règlements fondée sur la formation, la recherche et l'expérience limitée dans un contexte de programme donné."
            },
            new CompetencyLevelRequirement
            {
                Id = 209,
                DescEng =
                    "Practical knowledge of all acts and regulations pertinent to a program of expertise, being able to advise appropriately, link to rules, and contribute to instructions relating to these areas.",
                DescFre =
                    "Connaissance pratique de toutes les lois et de tous les règlements pertinents à un programme d'expertise, capacité de conseiller adéquatement, d'établir des liens avec les règles et de contribuer aux instructions relatives à ces domaines."
            },
            new CompetencyLevelRequirement
            {
                Id = 210,
                DescEng =
                    "Advanced knowledge in the acts and regulations pertinent to a program as well as its impacts on and relationships with other programs.  Participates in the clarification and creation of rules based in acts and regulations. Instructs in the subject, when and where applicable.",
                DescFre =
                    "Connaissance approfondie des lois et règlements pertinents à un programme ainsi que de ses répercussions sur d'autres programmes et de ses relations avec eux.  Participer à la clarification et à la création de règles fondées sur des lois et des règlements. Enseigne le sujet, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 211,
                DescEng =
                    "Expert knowledge in acts and regulations relating to several programs. Participates in joint sessions, and advises with internal and external stakeholders on how acts and regulations pertain to and relate among and between programs, industry, and the public.",
                DescFre =
                    "Connaissance experte des lois et règlements relatifs à plusieurs programmes. Participer à des séances conjointes et donner des conseils aux intervenants internes et externes sur la façon dont les lois et les règlements se rapportent aux programmes, à l'industrie et au public, et entre eux."
            },
            new CompetencyLevelRequirement
            {
                Id = 212,
                DescEng =
                    "Understands the operational and contingency plans for each diving operation. Can articulate the hazards that could be encountered in the underwater work site. ",
                DescFre =
                    "Comprend les plans opérationnels et d'urgence pour chaque opération de plongée. Peut exprimer clairement les dangers qui pourraient survenir sur le site de travail sous-marin. "
            },
            new CompetencyLevelRequirement
            {
                Id = 213,
                DescEng =
                    "Understands the nature of the work, procedures to be used, equipment and personnel required for the operation, places and timing. Aware of the code of practice to be used for each operation's specific tasking.",
                DescFre =
                    "Comprend la nature du travail, les procédures à utiliser, l'équipement et le personnel requis pour l'opération, les lieux et le calendrier. Connaître le code de pratique à utiliser pour les tâches spécifiques à chaque opération. "
            },
            new CompetencyLevelRequirement
            {
                Id = 214,
                DescEng =
                    "Knowledge of specifications for each operation: task evaluation, schedules, equipment selection. Understands the site specificities. Understands the importance appropriate dive teams to suit skills of available personnel. Understands dive profiles and planning, gas requirements calculations and contingency planning as indicated by Hazard Identification and Risk Assessment (HIRA).",
                DescFre =
                    "Connaissance des spécifications de chaque opération : évaluation des tâches, horaires, choix des équipements. Comprend les spécificités du site. Comprend l'importance d'avoir des équipes de plongée adaptées aux compétences du personnel disponible. Comprend les profils et la planification des plongées, les calculs des besoins en gaz et la planification d'urgence tels qu'indiqués par l'Identification des dangers et évaluation des risques (HIRA)."
            },
            new CompetencyLevelRequirement
            {
                Id = 215,
                DescEng =
                    "Advanced knowledge of emergency evacuation plan and the arrangements for evacuation of casualties. Understands and knows contact numbers and locations and frequencies for backup services. Understands accessibilities to emergency medical facilities and how to prepare a roadmap and/or list of directions for the driver.",
                DescFre =
                    "Connaissance approfondie du plan d'évacuation d'urgence et des dispositions à prendre pour l'évacuation des blessés. Comprend et connaît les numéros de téléphone, les emplacements et les fréquences des personnes-ressources pour les services de relève. Comprend les possibilités d'accès aux installations médicales d'urgence et la façon de préparer une feuille de route et/ou une liste d'instructions pour le conducteur."
            },
            new CompetencyLevelRequirement
            {
                Id = 216,
                DescEng =
                    "Expert knowledge in diving operations and policies. Stays updated on safety matters which may have changed such as changes in regulations, codes of practice, or the operations manual, safety procedures, equipment, personal protective equipment (PPE), and job assignments and responsibilities. Champions diving operations knowledge as a prevention mechanism.",
                DescFre =
                    "Connaissances approfondies des opérations et des politiques de plongée. Se tient au courant des questions de sécurité qui peuvent avoir changé, comme les modifications apportées aux règlements, aux codes de pratique ou au manuel d'exploitation, aux procédures de sécurité, à l'équipement, à l'équipement de protection individuelle (EPI) et aux affectations de travail et responsabilités. Se fait le champion de la connaissance des opérations de plongée en tant que mécanisme de prévention."
            },
            new CompetencyLevelRequirement
            {
                Id = 217,
                DescEng =
                    "Where assisted or trained, employs safe operating procedures in erecting a temporary jib or derrick for boats or painting or gangway uses. Learns splicing and rigging gear to make slings and tackle. Ties appropriate knots as required.",
                DescFre =
                    "Where assisted or trained, employs safe operating procedures in erecting a temporary jib or derrick for boats or painting or gangway uses. Learns splicing and rigging gear to make slings and tackle. Ties appropriate knots as required."
            },
            new CompetencyLevelRequirement
            {
                Id = 218,
                DescEng =
                    "Installs cables, pulleys, and tackle as directed. Identifies the components and characteristics of wire rope and synthetic slings. Uses safety harnesses and life lines when hoisting and rigging on deck and aloft. Conducts rigging for basic operations (e.g. safety lines, boat, painting, gangway). Performs routine inspections.  ",
                DescFre =
                    "Installs cables, pulleys, and tackle as directed. Identifies the components and characteristics of wire rope and synthetic slings. Uses safety harnesses and life lines when hoisting and rigging on deck and aloft. Conducts rigging for basic operations (e.g. safety lines, boat, painting, gangway). Performs routine inspections.  "
            },
            new CompetencyLevelRequirement
            {
                Id = 219,
                DescEng =
                    "Calculates the load on a sling using the load angle factor for different loads. Identifies and employs various rigging equipment, slings, and hardware (wire rope, shackles, eyebolts, hooks, etc.). Conducts routine and periodic inspections and reports. Employs proper hand signals during lifting operations.",
                DescFre =
                    "Calculates the load on a sling using the load angle factor for different loads. Identifies and employs various rigging equipment, slings, and hardware (wire rope, shackles, eyebolts, hooks, etc.). Conducts routine and periodic inspections and reports. Employs proper hand signals during lifting operations."
            },
            new CompetencyLevelRequirement
            {
                Id = 220,
                DescEng =
                    "Handles, cares for, and stores mooring ropes and wires, rope stoppers. Handles mooring winches, windlesses, and capstans safely. Correctly fits wire grips. Slings a stage and bosun chair. Rigs overside ladders, gangways, and accommodation ladders. Rigs hydrostatic releases. Secures the deck for heavy weather, and anchors for sea. Employs emergency lights, rig, and steering using emergency gear, when and where applicable.",
                DescFre =
                    "Handles, cares for, and stores mooring ropes and wires, rope stoppers. Handles mooring winches, windlesses, and capstans safely. Correctly fits wire grips. Slings a stage and bosun chair. Rigs overside ladders, gangways, and accommodation ladders. Rigs hydrostatic releases. Secures the deck for heavy weather, and anchors for sea. Employs emergency lights, rig, and steering using emergency gear, when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 221,
                DescEng =
                    "Directs and performs rigging operations of all aspects directly or indirectly associated with removal, installation, repair, and/or construction of major shipboard components, at sea, while loading, and during refits. Champions and provides on the job training in rigging, splicing, and safety protocols. ",
                DescFre =
                    "Directs and performs rigging operations of all aspects directly or indirectly associated with removal, installation, repair, and/or construction of major shipboard components, at sea, while loading, and during refits. Champions and provides on the job training in rigging, splicing, and safety protocols."
            },
            new CompetencyLevelRequirement
            {
                Id = 222,
                DescEng =
                    "Conducts basic maintenance requirements on diving equipment as per owner's manual instructions. Extracts air samples for purity analyses. ",
                DescFre =
                    "Conducts basic maintenance requirements on diving equipment as per owner's manual instructions. Extracts air samples for purity analyses. "
            },
            new CompetencyLevelRequirement
            {
                Id = 223,
                DescEng =
                    "Assembles and disassembles Compressed Air Breathing Apparatus (CABA) diving ensemble, diagnoses and repairs high pressure faults, and calibrates diving equipment. ",
                DescFre =
                    "Assembles and disassembles Compressed Air Breathing Apparatus (CABA) diving ensemble, diagnoses and repairs high pressure faults, and calibrates diving equipment. "
            },
            new CompetencyLevelRequirement
            {
                Id = 224,
                DescEng =
                    "Conducts advanced maintenance such as oxygen cleaning for high pressure parts and maintains diving life support equipment. Completes preventative maintenance on dive cylinders and dive cylinder valves, on buoyancy compensators, and 1st/2nd stage regulators. ",
                DescFre =
                    "Conducts advanced maintenance such as oxygen cleaning for high pressure parts and maintains diving life support equipment. Completes preventative maintenance on dive cylinders and dive cylinder valves, on buoyancy compensators, and 1st/2nd stage regulators. "
            },
            new CompetencyLevelRequirement
            {
                Id = 225,
                DescEng =
                    "Plans technical maintenance requirements and maintains maintenance data base systems (air samples, inspection etc.). Takes corrective action on reported equipment recalls and deficiencies. ",
                DescFre =
                    "Plans technical maintenance requirements and maintains maintenance data base systems (air samples, inspection etc.). Takes corrective action on reported equipment recalls and deficiencies. "
            },
            new CompetencyLevelRequirement
            {
                Id = 226,
                DescEng =
                    "Manages the air and gas purity program. Liaises with outside agencies for 3rd line maintenance requirements. Conducts inspection of dive equipment.",
                DescFre =
                    "Manages the air and gas purity program. Liaises with outside agencies for 3rd line maintenance requirements. Conducts inspection of dive equipment."
            },
            new CompetencyLevelRequirement {Id = 227, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 228, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 229,
                DescEng =
                    "Plans and attends all dives. Assesses the readiness of members prior to dives, including that each diver has a diving log book at the dive site and is available for inspection before dives. Conducts pre/post dive routines and mission briefs. Ensures warning devices are displayed to indicate the area around the dive site and where the diving operation is being carried out. Ensures equipment checks. Controls divers' depth and duration of dives. Responds to diving emergencies. Identifies diving related ailments not requiring recompression.",
                DescFre =
                    "Plans and attends all dives. Assesses the readiness of members prior to dives, including that each diver has a diving log book at the dive site and is available for inspection before dives. Conducts pre/post dive routines and mission briefs. Ensures warning devices are displayed to indicate the area around the dive site and where the diving operation is being carried out. Ensures equipment checks. Controls divers' depth and duration of dives. Responds to diving emergencies. Identifies diving related ailments not requiring recompression."
            },
            new CompetencyLevelRequirement
            {
                Id = 230,
                DescEng =
                    "Briefs teams and ensures that the operational and contingency plans for diving operations are followed. Reviews and briefs on hazards that could be encountered in the underwater site. Ensures that any diving equipment to be used in the diving operation is examined, tested, and repaired before its use by a competent person at least once on the day of a dive. Ensures that the dive area is kept clear of equipment that is not associated with the diving operation. Ensures that no diver exceeds a depth longer than the maximum time allowed for a dive. Supervises all decompressions and therapeutic recompressions, in strict accordance with procedures and tables.",
                DescFre =
                    "Briefs teams and ensures that the operational and contingency plans for diving operations are followed. Reviews and briefs on hazards that could be encountered in the underwater site. Ensures that any diving equipment to be used in the diving operation is examined, tested, and repaired before its use by a competent person at least once on the day of a dive. Ensures that the dive area is kept clear of equipment that is not associated with the diving operation. Ensures that no diver exceeds a depth longer than the maximum time allowed for a dive. Supervises all decompressions and therapeutic recompressions, in strict accordance with procedures and tables."
            },
            new CompetencyLevelRequirement
            {
                Id = 231,
                DescEng =
                    "Establishes dive supervision parameters using the Compressed Air Breathing Apparatus (CABA) or the Light Weight Surface Supply (LWSS) dive equipment. Manages diving plans and schedules. Recommends and attends training for divers. Manages and directs all dive emergencies. Collects evidence on incident/accident reports. Conducts incident reviews and implements corrective actions. Champions diving safety protocols and practices.",
                DescFre =
                    "Establishes dive supervision parameters using the Compressed Air Breathing Apparatus (CABA) or the Light Weight Surface Supply (LWSS) dive equipment. Manages diving plans and schedules. Recommends and attends training for divers. Manages and directs all dive emergencies. Collects evidence on incident/accident reports. Conducts incident reviews and implements corrective actions. Champions diving safety protocols and practices."
            },
            new CompetencyLevelRequirement
            {
                Id = 232,
                DescEng =
                    "Paints and stores small vessels and lifesaving equipment. Participates in cargo stowage, cleaning/sanding, and paint evolutions.",
                DescFre =
                    "Paints and stores small vessels and lifesaving equipment. Participates in cargo stowage, cleaning/sanding, and paint evolutions."
            },
            new CompetencyLevelRequirement
            {
                Id = 233,
                DescEng =
                    "Participates as a hand in refit operations. Employs safe standards in small vessel maintenance and operations in most sea states, including pre and post sailing checks, drills, and evolutions. Participates as lookout and quartermaster, when required. ",
                DescFre =
                    "Participates as a hand in refit operations. Employs safe standards in small vessel maintenance and operations in most sea states, including pre and post sailing checks, drills, and evolutions. Participates as lookout and quartermaster, when required. "
            },
            new CompetencyLevelRequirement
            {
                Id = 234,
                DescEng =
                    "Operates as lead hand in various operations, including small vessel use and maintenance in all conditions, lookout duties, and tackle stowage and maintenance. Conducts safety checks on equipment. Participates, when and where required, as a hand in helicopter operations, regarding clearing equipment while following protocols including participating in fire and emergency teams. Steers the ship in all conditions, when and where required.",
                DescFre =
                    "Operates as lead hand in various operations, including small vessel use and maintenance in all conditions, lookout duties, and tackle stowage and maintenance. Conducts safety checks on equipment. Participates, when and where required, as a hand in helicopter operations, regarding clearing equipment while following protocols including participating in fire and emergency teams. Steers the ship in all conditions, when and where required."
            },
            new CompetencyLevelRequirement
            {
                Id = 235,
                DescEng =
                    "Handles cargo, operates lifting appliances, conducts tackle/lifting machinery maintenance, and checks and operates lifesaving equipment. Participates as lead hand in helicopter operations and on fire and emergency team parties, when and where applicable. Recognizes irregularities in the use and/or appearance of equipment and recommends action. Participates in all small vessel operations and maintenance in all conditions, when and where required.",
                DescFre =
                    "Handles cargo, operates lifting appliances, conducts tackle/lifting machinery maintenance, and checks and operates lifesaving equipment. Participates as lead hand in helicopter operations and on fire and emergency team parties, when and where applicable. Recognizes irregularities in the use and/or appearance of equipment and recommends action. Participates in all small vessel operations and maintenance in all conditions, when and where required."
            },
            new CompetencyLevelRequirement
            {
                Id = 236,
                DescEng =
                    "Directs cargo handling, tackle/lifting machinery maintenance and operation, lifesaving operation, and hull inspections while enforcing regulations. Handles small boats under all sea states and advises on optimized operating practices. Supervises deck and cargo crews in all seagoing operations, at sea in all conditions, or in refit, when and where required.",
                DescFre =
                    "Directs cargo handling, tackle/lifting machinery maintenance and operation, lifesaving operation, and hull inspections while enforcing regulations. Handles small boats under all sea states and advises on optimized operating practices. Supervises deck and cargo crews in all seagoing operations, at sea in all conditions, or in refit, when and where required."
            },
            new CompetencyLevelRequirement
            {
                Id = 237,
                DescEng =
                    "Uses the of basics of the life cycle asset management program in daily activities. Performs routine asset management tasks. Manages the life cycle of tackle books, safety equipment, charts, etc. when and where applicable.",
                DescFre =
                    "Utiliser les bases du programme de gestion du cycle de vie des actifs dans les activités quotidiennes. Effectuer des tâches de routine en matière de gestion des actifs. Gérer le cycle de vie des livres sur l’outillage, des équipements de sécurité, des cartes, etc. le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 238,
                DescEng =
                    "Advises and follows the Government of Canada's Controlled Goods Directive, directives on fleet management, the Policy on Management of Materiel, and the Directive on Disposal of Surplus Materiel, when and where applicable.",
                DescFre =
                    "Suivre la Directive sur les marchandises contrôlées du gouvernement du Canada, les directives sur la gestion de flotte, la Politique sur la gestion du matériel et la Directive sur l’aliénation du matériel en surplus, le cas échéant et formuler des conseils à ce sujet."
            },
            new CompetencyLevelRequirement
            {
                Id = 239,
                DescEng =
                    "Performs all four phases of life cycle materiel management, including assessing and planning materiel requirements, acquiring materiel resources, operating and using, maintaining, and disposing of materiel. Implements the concepts of the Policy Framework for the Management of Assets and Acquired Services. ",
                DescFre =
                    "Effectuer les quatre phases de la gestion du cycle de vie du matériel, y compris l’évaluation et la planification des besoins en matériel, l’acquisition des ressources matérielles, l’exploitation et l’utilisation, l’entretien et l’élimination du matériel. Mettre en œuvre les concepts du Cadre de politique sur la gestion des actifs et services acquis."
            },
            new CompetencyLevelRequirement
            {
                Id = 240,
                DescEng =
                    "Manages a risk-based and complexity-based approach to processes, systems, capacity, resourcing, oversight, and reporting to promote the attainment of program outcomes. Advises and guides decisions on life cycle asset management within their area of concern.",
                DescFre =
                    "Gérer une approche axée sur le risque et la complexité en ce qui concerne les processus, les systèmes, la capacité, le ressourcement, la surveillance et l’établissement de rapports, à l’appui des résultats des programmes. Formuler des conseils et orienter les décisions sur la gestion du cycle de vie des actifs dans son domaine de compétence."
            },
            new CompetencyLevelRequirement
            {
                Id = 241,
                DescEng =
                    "Implements an effective management framework, including departmental procedures, processes, and systems. Manages based on the principles of value for money acquisition of assets, effective management and usage of these assets, and effective disposal of such assets. Advises and guides decisions on life cycle asset management within the Coast Guard from a regional and/or national perspective.",
                DescFre =
                    "Mettre en œuvre un cadre de gestion efficace, y compris des procédures, des processus et des systèmes ministériels. Gérer en fonction des principes d’optimisation des ressources pour l’acquisition de biens, la gestion et l’utilisation efficaces de ces biens et leur cession efficace. Formuler des conseils et orienter les décisions relatives à la gestion du cycle de vie des biens au sein de la Garde côtière dans une perspective régionale ou nationale."
            },
            new CompetencyLevelRequirement
            {
                Id = 242,
                DescEng =
                    "Observes an issue or problem, gathers information, and reports on its expected versus actual functionality.",
                DescFre =
                    "Observer un problème ou une question, recueillir des informations et rendre compte de sa fonctionnalité prévue par rapport à sa fonctionnalité réelle."
            },
            new CompetencyLevelRequirement
            {
                Id = 243,
                DescEng =
                    "Gathers information on an observed issue or problem. Considers the difference between expected and actual functionality, looks at special circumstances to diagnose it, and attempts various fixes and tests for confirmation before reporting.",
                DescFre =
                    "Recueillir des informations sur un problème ou une question observés. Examiner l’écart entre la fonctionnalité attendue et la fonctionnalité réelle, examiner les circonstances particulières pour trouver la cause de l’écart et tenter d’apporter diverses corrections et procéder à des tests à des fins de confirmation avant de faire un rapport."
            },
            new CompetencyLevelRequirement
            {
                Id = 244,
                DescEng =
                    "Interprets data and accurately determines essential elements of an issue or problem. Applies various problem isolation techniques to determine causes. Tests equipment under multiple settings to confirm it is restored to working state.",
                DescFre =
                    "Interpréter des données et déterminer avec précision les éléments essentiels d’une question ou d’un problème. Mettre en pratique diverses techniques d’isolement des problèmes pour en déterminer les causes. Mettre à l’essai l’équipement sous plusieurs paramètres pour confirmer qu’il est remis en état de fonctionnement."
            },
            new CompetencyLevelRequirement
            {
                Id = 245,
                DescEng =
                    "Interprets data from many sources to determine essential elements of a problem. Recognizes a problem at the earliest stages, pinpoints problem sources, and uses corrective actions to restore a system to working state. Uses data interpretation to recommend preventative measures that will prevent further failure.",
                DescFre =
                    "Interpréter des données provenant de nombreuses sources pour déterminer les éléments essentiels d’un problème. Reconnaître un problème dès le début, cerner les sources du problème et prendre des mesures correctives pour remettre un système en état de fonctionnement. Utiliser l’interprétation des données pour recommander des mesures préventives qui empêcheront toute nouvelle défaillance."
            },
            new CompetencyLevelRequirement
            {
                Id = 246,
                DescEng =
                    "Uses data interpretation and accuracy in determining essential elements of an issue or problem. Consults, and provides training on, trends to prevent future issues and presents these and related items to units and stakeholders.",
                DescFre =
                    "S’appuyer sur l’interprétation et la précision des données pour déterminer les éléments essentiels d’une question ou d’un problème. Procéder à des consultations et donner de la formation sur les tendances afin de prévenir les problèmes futurs et présenter ces tendances et les éléments qui s’y rapportent aux unités et aux intervenants."
            },
            new CompetencyLevelRequirement
            {
                Id = 247,
                DescEng =
                    "Recognizes a problem. Solves basic problems by following a set of standard rules and practices. Identifies alternate solutions, based on precedent.",
                DescFre =
                    "Reconnaît un problème. Résout les problèmes de base en suivant un ensemble de règles et de pratiques standard. Identifie des solutions alternatives, basées sur des précédents."
            },
            new CompetencyLevelRequirement
            {
                Id = 248,
                DescEng =
                    "Recognizes and identifies a problem based on a range of clear factors. Identifies, with some assistance, optimal solutions based on weighing the advantages and disadvantages of alternative approaches.",
                DescFre =
                    "Reconnaît et identifie un problème sur la base d'une série de facteurs clairs. Identifie, avec une certaine assistance, des solutions optimales basées sur l'évaluation des avantages et des désavantages des approches alternatives."
            },
            new CompetencyLevelRequirement
            {
                Id = 249,
                DescEng =
                    "Identifies, defines, solves, and prioritizes standard problems without causing other unanticipated problems. Identifies root causes, sets goals, and identifies constraints. Conducts impact analyses and identifies possible consequences of actions and decisions.",
                DescFre =
                    "Identifie, définit, résout et priorise les problèmes standards sans causer d'autres problèmes imprévus. Identifie les causes fondamentales, fixe des objectifs et identifie les contraintes. Effectue des analyses d'impact et identifie les conséquences possibles des actions et des décisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 250,
                DescEng =
                    "Finds workable solutions to increasingly complex and multi-dimensional problems by either intuition or a systematic approach. Generates and assesses options and develops standards to evaluate different intended results offered by alternatives. Advises on best practices. Conducts monitoring and testing of solutions after implementation.",
                DescFre =
                    "Trouve des solutions pratiques à des problèmes de plus en plus complexes et multidimensionnels, soit par intuition, soit par une approche systématique. Génère et évalue les options et élabore des normes pour évaluer les différents résultats attendus offerts par les alternatives. Donne des conseils sur les meilleures pratiques. Effectue le suivi et la mise à l'essai des solutions après leur mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 251,
                DescEng =
                    "Revises and amends problem solving models, flowcharts, and cause and effect diagrams. Advises on multiple alternatives and expected results. Evaluates effectiveness and efficiency of solutions following implementation.",
                DescFre =
                    "Révise et modifie les modèles de résolution de problèmes, les organigrammes et les diagrammes de cause à effet. Donne des conseils sur les multiples alternatives et les résultats attendus. Évalue l'efficacité et l'efficience des solutions après leur mise en œuvre."
            },
            new CompetencyLevelRequirement
            {
                Id = 252,
                DescEng =
                    "Basic knowledge of uses of cooking and cleaning utensils, storage protocols, cutlery, cleaning gear, and machinery used in the galley, refrigeration and laundry spaces, and cleaning lockers.",
                DescFre =
                    "Connaissances de base sur l'utilisation des ustensiles de cuisine et de nettoyage, les protocoles d'entreposage, la coutellerie, le matériel de nettoyage et les machines utilisées dans la cuisine, les espaces de réfrigération et de lavage, et les casiers de nettoyage."
            },
            new CompetencyLevelRequirement
            {
                Id = 253,
                DescEng =
                    "Knowledge of methods, tools and combinations of ingredients to improve the flavour or digestibility of food. Knowledge of the selection, measurement and combining of ingredients in an ordered procedure in an effort to achieve the desired result. Knowledge of raw and cooked food, expirations, cooking methods and types of cuisine.",
                DescFre =
                    "Connaissance des méthodes, des outils et des combinaisons d'ingrédients pour améliorer la saveur ou la digestibilité des aliments. Connaissance de la sélection, de la mesure et de la combinaison d'ingrédients dans une procédure ordonnée afin d'atteindre le résultat souhaité. Connaissance des aliments crus et cuits, des expirations, des méthodes de cuisson et des types de cuisine."
            },
            new CompetencyLevelRequirement
            {
                Id = 254,
                DescEng =
                    "Significant knowledge of dietary needs, allergies, and intolerances, cooking and storing modes and preferences. Knowledge of key recipes, preservation, food guide recommendations and requirements. Basic knowledge of menu preparation and logistics.",
                DescFre =
                    "Connaissance approfondie des besoins alimentaires, des allergies et des intolérances, des modes de cuisson et de conservation et des préférences. Connaissance des recettes clés, de la conservation, des recommandations et des exigences du guide alimentaire. Connaissances de base de la préparation des menus et de la logistique."
            },
            new CompetencyLevelRequirement
            {
                Id = 255,
                DescEng =
                    "Advanced knowledge of cookery from experience and inputs, by considering and planning a variety of types of cuisine in an effective and efficient manner.",
                DescFre =
                    "Connaissance avancée de la cuisine grâce à l'expérience et aux intrants, en considérant et en planifiant une variété de types de cuisine d'une manière efficace et efficiente."
            },
            new CompetencyLevelRequirement
            {
                Id = 256,
                DescEng =
                    "Expert knowledge as a chef in industrial settings, with an emphasis on meal, snack, and menu planning based on guidelines and inputs. Knowledge of preparation methods and sanitation requirements.",
                DescFre =
                    "Connaissances spécialisées en tant que chef cuisinier en milieu industriel, avec une emphase sur la planification des repas, des collations et des menus en fonction des directives et des intrants. Connaissance des méthodes de préparation et des exigences sanitaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 257,
                DescEng =
                    "Basic knowledge in requesting supplies, logging receipts at issue, and assisting with storage.",
                DescFre =
                    "Basic knowledge in requesting supplies, logging receipts at issue, and assisting with storage."
            },
            new CompetencyLevelRequirement
            {
                Id = 258,
                DescEng =
                    "Limited knowledge of proper stowage protocols. Understands safe handling, labeling, and preserving government assets.",
                DescFre =
                    "Limited knowledge of proper stowage protocols. Understands safe handling, labeling, and preserving government assets."
            },
            new CompetencyLevelRequirement
            {
                Id = 259,
                DescEng =
                    "Practical knowledge of recording material management (MM) actions in the approved inventory management system (IMS). Understands how to perform, control, and maintain inventories as directed. Awareness of asset disposal protocols.",
                DescFre =
                    "Practical knowledge of recording material management (MM) actions in the approved inventory management system (IMS). Understands how to perform, control, and maintain inventories as directed. Awareness of asset disposal protocols."
            },
            new CompetencyLevelRequirement
            {
                Id = 260,
                DescEng =
                    "Advanced knowledge in the management of all inventory management system (IMS) processes, including receipt, tracking, storage, and disposal mechanisms.",
                DescFre =
                    "Advanced knowledge in the management of all inventory management system (IMS) processes, including receipt, tracking, storage, and disposal mechanisms."
            },
            new CompetencyLevelRequirement
            {
                Id = 261,
                DescEng =
                    "Expert knowledge in inventory management system (IMS) and in the training of others. Understands the IMS process including large acquisitions or disposal projects, regionally or nationally.",
                DescFre =
                    "Expert knowledge in inventory management system (IMS) and in the training of others. Understands the IMS process including large acquisitions or disposal projects, regionally or nationally."
            },
            new CompetencyLevelRequirement
            {
                Id = 262,
                DescEng =
                    "Reviews supplies, inventories food and supplies, including the rate of usage. Manages galley cleaning of equipment, utensils, and gear. Preps and lays out snacks,  prepares and arranges salads, and makes and serves food and beverages hot and cold. Makes beds and rotates laundry. Ensures safe and clean workstations and food preparation areas before and after each use.",
                DescFre =
                    "Reviews supplies, inventories food and supplies, including the rate of usage. Manages galley cleaning of equipment, utensils, and gear. Preps and lays out snacks,  prepares and arranges salads, and makes and serves food and beverages hot and cold. Makes beds and rotates laundry. Ensures safe and clean workstations and food preparation areas before and after each use."
            },
            new CompetencyLevelRequirement
            {
                Id = 263,
                DescEng =
                    "Does cooking preparations for major dishes by following menus and recipes. Prepares soup stocks and dessert materials. Assembles supplies for and mixes salads. ",
                DescFre =
                    "Does cooking preparations for major dishes by following menus and recipes. Prepares soup stocks and dessert materials. Assembles supplies for and mixes salads. "
            },
            new CompetencyLevelRequirement
            {
                Id = 264,
                DescEng =
                    "Does general duty cooking, following menus and recipes by preparing roasting, grilling and frying meat as required, by cooking vegetables, by baking pies, cakes, cookies and desserts, by preparing and packing lunches for field use, and by slicing meat and cutting cakes and pies.",
                DescFre =
                    "Does general duty cooking, following menus and recipes by preparing roasting, grilling and frying meat as required, by cooking vegetables, by baking pies, cakes, cookies and desserts, by preparing and packing lunches for field use, and by slicing meat and cutting cakes and pies."
            },
            new CompetencyLevelRequirement
            {
                Id = 265,
                DescEng =
                    "Manages the full range of cooking and cleaning requirements for all ships' crews and clients. Provides feedback and input to ordering supplies for approval, as well as recommendations for new uses for equipment and cooking ideas. ",
                DescFre =
                    "Manages the full range of cooking and cleaning requirements for all ships' crews and clients. Provides feedback and input to ordering supplies for approval, as well as recommendations for new uses for equipment and cooking ideas. "
            },
            new CompetencyLevelRequirement
            {
                Id = 266,
                DescEng =
                    "Manages and oversees the planning, preparation, cooking, and presentation of all meals and snacks in the unit. Conducts all planning in concert with mates, logistics officers, or managers. Provides training and guidance to galley and steward staff. ",
                DescFre =
                    "Manages and oversees the planning, preparation, cooking, and presentation of all meals and snacks in the unit. Conducts all planning in concert with mates, logistics officers, or managers. Provides training and guidance to galley and steward staff. "
            },
            new CompetencyLevelRequirement
            {
                Id = 267,
                DescEng =
                    "Basic knowledge of the different stakeholders and authorities in the Search and Rescue (SAR) system. Understands where to seek full awareness of the system.",
                DescFre =
                    "Basic knowledge of the different stakeholders and authorities in the Search and Rescue (SAR) system. Understands where to seek full awareness of the system."
            },
            new CompetencyLevelRequirement
            {
                Id = 268,
                DescEng =
                    "Limited knowledge of each part of the Search and Rescue (SAR) system, how each works and works together, and how a local incident plays out in exercises and real life scenarios.",
                DescFre =
                    "Limited knowledge of each part of the Search and Rescue (SAR) system, how each works and works together, and how a local incident plays out in exercises and real life scenarios."
            },
            new CompetencyLevelRequirement
            {
                Id = 269,
                DescEng =
                    "Practical knowledge of the development of incidents and tactical responses between and among all participants in a number of real incidents of varying size and complexity, and exercises.",
                DescFre =
                    "Practical knowledge of the development of incidents and tactical responses between and among all participants in a number of real incidents of varying size and complexity, and exercises."
            },
            new CompetencyLevelRequirement
            {
                Id = 270,
                DescEng =
                    "Practical knowledge of the development of incidents and tactical responses between and among all participants in a number of real incidents of varying size and complexity, and exercises.",
                DescFre =
                    "Practical knowledge of the development of incidents and tactical responses between and among all participants in a number of real incidents of varying size and complexity, and exercises."
            },
            new CompetencyLevelRequirement
            {
                Id = 271,
                DescEng =
                    "Expert knowledge of all elements of the Search and Rescue (SAR) system, strategic planning regionally and nationally, exploring and redefining roles with horizon technologies. Understands how to mentor others, and provide information and insights to stakeholders internally and externally in SAR networks.",
                DescFre =
                    "Expert knowledge of all elements of the Search and Rescue (SAR) system, strategic planning regionally and nationally, exploring and redefining roles with horizon technologies. Understands how to mentor others, and provide information and insights to stakeholders internally and externally in SAR networks."
            },
            new CompetencyLevelRequirement
            {
                Id = 272,
                DescEng =
                    "Participates in search and rescue (SAR) activities,  tactical searches, and in exercises and simulations. Provides on scene first-aid services and reports, when and where applicable.",
                DescFre =
                    "Participates in search and rescue (SAR) activities,  tactical searches, and in exercises and simulations. Provides on scene first-aid services and reports, when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 273,
                DescEng =
                    "Provides first-aid and rescue specialist training. Recruits, trains, and supervises Inshore Rescue Boat (IRB) crews. Provides training on the search and rescue program. Develops and delivers Search and Rescue (SAR) presentations for stakeholders. Researches best practices in the search and rescue domain.",
                DescFre =
                    "Provides first-aid and rescue specialist training. Recruits, trains, and supervises Inshore Rescue Boat (IRB) crews. Provides training on the search and rescue program. Develops and delivers Search and Rescue (SAR) presentations for stakeholders. Researches best practices in the search and rescue domain."
            },
            new CompetencyLevelRequirement
            {
                Id = 274,
                DescEng =
                    "Initiates, coordinates, and terminates local area marine incidents under supervision. Coordinates stricken vessel responses using the local search and rescue net, including the coastal area’s incident categories and classifications. Identifies search types, patterns, and techniques best suited to the search mission.",
                DescFre =
                    "Initiates, coordinates, and terminates local area marine incidents under supervision. Coordinates stricken vessel responses using the local search and rescue net, including the coastal area’s incident categories and classifications. Identifies search types, patterns, and techniques best suited to the search mission."
            },
            new CompetencyLevelRequirement
            {
                Id = 275,
                DescEng =
                    "Applies entire range of search and rescue (SAR) regional responses, analyzing current and past incidents, conducting simulations, providing training, and managing a large variety of incidents to conclusions tactically and strategically. Identifies and communicates hazards to team members. Assesses risks and provides insights to program managers and stakeholders.",
                DescFre =
                    "Applies entire range of search and rescue (SAR) regional responses, analyzing current and past incidents, conducting simulations, providing training, and managing a large variety of incidents to conclusions tactically and strategically. Identifies and communicates hazards to team members. Assesses risks and provides insights to program managers and stakeholders."
            },
            new CompetencyLevelRequirement
            {
                Id = 276,
                DescEng =
                    "Reviews regional and national search and rescue incidents and reviews program coordination strategies for effectiveness and efficiencies. Analyzes program metadata, conducts studies, develops service standards and needs analyses and risk mitigation measures, and provides information and feedback to stakeholders. Drafts national directives and policies.",
                DescFre =
                    "Reviews regional and national search and rescue incidents and reviews program coordination strategies for effectiveness and efficiencies. Analyzes program metadata, conducts studies, develops service standards and needs analyses and risk mitigation measures, and provides information and feedback to stakeholders. Drafts national directives and policies."
            },
            new CompetencyLevelRequirement
            {
                Id = 277,
                DescEng =
                    "Maintains continuous lookout and reports hazards to the officer of the watch (OOW) that can be an obstacle to navigation such as other ships, debris, and/or floating objects. In case of a person overboard, continuously points out in the direction of the person's location.",
                DescFre =
                    "Maintains continuous lookout and reports hazards to the officer of the watch (OOW) that can be an obstacle to navigation such as other ships, debris, and/or floating objects. In case of a person overboard, continuously points out in the direction of the person's location."
            },
            new CompetencyLevelRequirement
            {
                Id = 278,
                DescEng =
                    "Steers a vessel in open waters. Maintains a steady course, properly executes all rudder and speed orders, and communicates to the officer of the watch (OOW) using navigational terms relating to a vessel's heading. Completes any course change or critical maneuver that is in progress before handing over the helm or turning over the watch. Recognizes irregularities in the ship's maneuvering responses.",
                DescFre =
                    "Steers a vessel in open waters. Maintains a steady course, properly executes all rudder and speed orders, and communicates to the officer of the watch (OOW) using navigational terms relating to a vessel's heading. Completes any course change or critical maneuver that is in progress before handing over the helm or turning over the watch. Recognizes irregularities in the ship's maneuvering responses."
            },
            new CompetencyLevelRequirement
            {
                Id = 279,
                DescEng =
                    "Steers a vessel in open and closed waters under various sea states. Reaches set course based on a vessel's maneuvering characteristics. Anticipates the delay between when the helm is applied and when the ship responds to the rudder. Recognizes navigation rules and aids.",
                DescFre =
                    "Steers a vessel in open and closed waters under various sea states. Reaches set course based on a vessel's maneuvering characteristics. Anticipates the delay between when the helm is applied and when the ship responds to the rudder. Recognizes navigation rules and aids."
            },
            new CompetencyLevelRequirement
            {
                Id = 280,
                DescEng =
                    "Steers a vessel in any sea conditions including during emergencies. Aasync Tasks overcompensating for a ship's movement caused by local conditions, such as wind, swells, currents, or rough seas and recommends different course of action.",
                DescFre =
                    "Steers a vessel in any sea conditions including during emergencies. Aasync Tasks overcompensating for a ship's movement caused by local conditions, such as wind, swells, currents, or rough seas and recommends different course of action."
            },
            new CompetencyLevelRequirement
            {
                Id = 281,
                DescEng =
                    "Steers various classes of vessels precisely under all sea state conditions. Trains others in performing those duties using best practices.",
                DescFre =
                    "Steers various classes of vessels precisely under all sea state conditions. Trains others in performing those duties using best practices."
            },
            new CompetencyLevelRequirement {Id = 282, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 283,
                DescEng =
                    "Limited knowledge of common mechanical tools and instruments use, and function of marine engine major systems like ignition, exhaust, cooling and lubricating.",
                DescFre =
                    "Limited knowledge of common mechanical tools and instruments use, and function of marine engine major systems like ignition, exhaust, cooling and lubricating."
            },
            new CompetencyLevelRequirement
            {
                Id = 284,
                DescEng =
                    "Practical knowledge of minor repair and first line maintenance of marine engines, electrical systems, transmissions, and fuel systems.",
                DescFre =
                    "Practical knowledge of minor repair and first line maintenance of marine engines, electrical systems, transmissions, and fuel systems."
            },
            new CompetencyLevelRequirement
            {
                Id = 285,
                DescEng =
                    "Advanced practical knowledge of maintenance and repair of shipboard machinery and equipment including pumps, valves, air compressors, heat exchangers, and deck machinery. Understands diagrams, drafts, flow-charts, and other information contained in technical data packages (TDP).",
                DescFre =
                    "Advanced practical knowledge of maintenance and repair of shipboard machinery and equipment including pumps, valves, air compressors, heat exchangers, and deck machinery. Understands diagrams, drafts, flow-charts, and other information contained in technical data packages (TDP)."
            },
            new CompetencyLevelRequirement
            {
                Id = 286,
                DescEng =
                    "Expert understanding of internal combustion engines operation, maintenance requirements, inspection, and overhaul of all propulsion and auxiliary equipment and systems.",
                DescFre =
                    "Expert understanding of internal combustion engines operation, maintenance requirements, inspection, and overhaul of all propulsion and auxiliary equipment and systems."
            },
            new CompetencyLevelRequirement
            {
                Id = 287,
                DescEng =
                    "Monitors equipment, check gauges and dials, records readings on equipment. Cleans leaks on machinery and in engine room spaces. Reports observations as needed.",
                DescFre =
                    "Monitors equipment, check gauges and dials, records readings on equipment. Cleans leaks on machinery and in engine room spaces. Reports observations as needed."
            },
            new CompetencyLevelRequirement
            {
                Id = 288,
                DescEng =
                    "Starts up and shuts down engine room and propulsion auxiliaries and ancillaries equipment. Maintains temperatures, pressures, and proper oil and water levels in engine room equipment and ensure the equipment is working in normal parameters. Reviews indicating instruments reading. Assists in minor repairs.",
                DescFre =
                    "Starts up and shuts down engine room and propulsion auxiliaries and ancillaries equipment. Maintains temperatures, pressures, and proper oil and water levels in engine room equipment and ensure the equipment is working in normal parameters. Reviews indicating instruments reading. Assists in minor repairs."
            },
            new CompetencyLevelRequirement
            {
                Id = 289,
                DescEng =
                    "Participates in fueling, lube oil transfer, and waste oil products handling, and the production, transfer, testing and treatment of potable water. Performs minor repairs and assists in assembling, maintaining and repairing mechanical components according to required specifications.",
                DescFre =
                    "Participates in fueling, lube oil transfer, and waste oil products handling, and the production, transfer, testing and treatment of potable water. Performs minor repairs and assists in assembling, maintaining and repairing mechanical components according to required specifications."
            },
            new CompetencyLevelRequirement
            {
                Id = 290,
                DescEng =
                    "Reviews engine room logs and collects, and/or analyzes information/data which contributes to making engineering decision. Updates machinery maintenance records. Assists in planning the maintenance of the ships main and auxiliary equipment and systems. Troubleshoots equipment and effects minor and major repairs.",
                DescFre =
                    "Reviews engine room logs and collects, and/or analyzes information/data which contributes to making engineering decision. Updates machinery maintenance records. Assists in planning the maintenance of the ships main and auxiliary equipment and systems. Troubleshoots equipment and effects minor and major repairs."
            },
            new CompetencyLevelRequirement
            {
                Id = 291,
                DescEng =
                    "Expert in diagnostic capabilities, advises senior engineer on status of engine room machinery. Collaborates with others in finding solutions to more complex engineering matters. Reviews stock replenishment requisitions with user departments to ensure the items are in current use, that quantities ordered are realistic and pertinent.",
                DescFre =
                    "Expert in diagnostic capabilities, advises senior engineer on status of engine room machinery. Collaborates with others in finding solutions to more complex engineering matters. Reviews stock replenishment requisitions with user departments to ensure the items are in current use, that quantities ordered are realistic and pertinent."
            },
            new CompetencyLevelRequirement
            {
                Id = 292,
                DescEng =
                    "Basic understanding of deck layout and stowage. Understands emergency stations. Asks questions of deck crew and officers concerning knots and work parties.",
                DescFre =
                    "Compréhension de base du plan de pont et de l'arrimage. Comprend les stations d'urgence. Poser des questions à l'équipage de pont et aux officiers au sujet des nœuds et des groupes de travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 293,
                DescEng =
                    "Working understanding of some rigging and tackle procedures and manuals, including logging. Understands small boat principles, use, towing, and mooring.",
                DescFre =
                    "Compréhension pratique de certains manuels et procédures de gréement et d'accastillage, y compris l'exploitation forestière. Comprend les principes, l'utilisation, le remorquage et l'amarrage des petites embarcations."
            },
            new CompetencyLevelRequirement
            {
                Id = 294,
                DescEng =
                    "Practical knowledge of small boat operations of most types, rigging and lifting gear and uses, tackle and tackle registry and stowage, and basic helicopter procedures. Understands hand signals in working with deck crew.",
                DescFre =
                    "Connaissance pratique de la plupart des types d'opérations de petits bateaux, du gréement et des engins de levage et de levage, de l'immatriculation et de l'arrimage du matériel, ainsi que des procédures de base pour les hélicoptères. Comprend les signaux de la main lorsqu'il travaille avec l'équipage de pont."
            },
            new CompetencyLevelRequirement
            {
                Id = 295,
                DescEng =
                    "Advanced practical knowledge of tackle and maintenance, lifting appliances of all types and procedures, practical refit management, damage control management, and helicopter operations.",
                DescFre =
                    "Connaissances pratiques avancées en matière d'outillage et d'entretien, d'appareils de levage de tous types et procédures, de gestion pratique du carénage, de gestion des dommages et d'exploitation des hélicoptères."
            },
            new CompetencyLevelRequirement
            {
                Id = 296,
                DescEng =
                    "Expert practical knowledge of all elements, practical and theoretical, concerning deck and deck crew management, including safe rigging, lifting, tackle, small craft, cargo loading, and helicopter operations, plans, and procedures.",
                DescFre =
                    "Connaissance pratique experte de tous les éléments, pratiques et théoriques, concernant la gestion du pont et de l'équipage de pont, y compris le gréement, le levage, l'accastillage, les petits bateaux, le chargement de la cargaison et les opérations, plans et procédures par hélicoptère."
            },
            new CompetencyLevelRequirement
            {
                Id = 297,
                DescEng =
                    "Basic knowledge of fishing locations, the marine physical environments, and fish habitats.",
                DescFre =
                    "Connaissance de base des lieux de pêche, des milieux physiques marins et des habitats du poisson."
            },
            new CompetencyLevelRequirement
            {
                Id = 298,
                DescEng =
                    "Limited knowledge of standing watches on the Canadian Coast Guard bridge overseeing some fishing operations. Knowledge of fishing techniques, grounds, nets, etc.",
                DescFre =
                    "Connaissance limitée des quarts de quart sur le pont de la Garde côtière canadienne qui surveille certaines opérations de pêche. Connaissance des techniques de pêche, des fonds, des filets, etc."
            },
            new CompetencyLevelRequirement
            {
                Id = 299,
                DescEng =
                    "Practical knowledge of fishing master bridge and deck oversight duties on a small to medium sized Coast Guard science fishing vessels, including biomass location, consultation with scientists, and rig choice, design, and deployment.",
                DescFre =
                    "Connaissance pratique des fonctions de surveillance du capitaine de pêche à la passerelle et du pont à bord d'un navire de pêche scientifique de petite et moyenne taille de la Garde côtière, y compris l'emplacement de la biomasse, la consultation des scientifiques et le choix, la conception et le déploiement des appareils."
            },
            new CompetencyLevelRequirement
            {
                Id = 300,
                DescEng =
                    "Advanced knowledge in managing the range of fishing master bridge and deck watch duties in all Coast Guard science fishing vessels, including locating fishing spots for each species; determining, adjusting, and positioning fishing gear for optimal catch; and classifying and identifying species.",
                DescFre =
                    "Connaissances avancées dans la gestion de l'éventail des fonctions de quart à la passerelle et au pont de tous les navires de pêche scientifiques de la Garde côtière, y compris la localisation des lieux de pêche pour chaque espèce, la détermination, l'ajustement et le positionnement des engins de pêche pour des prises optimales et la classification et l'identification des espèces."
            },
            new CompetencyLevelRequirement
            {
                Id = 301,
                DescEng =
                    "Expert knowledge of bridge management of all fishing deck crews on Coast Guard science fishing vessels, including stock assessment and location, determination of gear and gear adjustment, building trust and relationships with science stakeholders, and providing training to fishing masters and fishing crews.",
                DescFre =
                    "Connaissances spécialisées de la gestion des ponts de tous les membres d'équipage des bateaux de pêche scientifiques de la Garde côtière, y compris l'évaluation et l'emplacement des stocks, la détermination de l'ajustement des engins et des engins, l'établissement d'une relation de confiance avec les intervenants scientifiques et l'établissement de relations avec eux et la formation des maîtres pêcheurs et des équipes de pêche."
            },
            new CompetencyLevelRequirement
            {
                Id = 302,
                DescEng =
                    "A rudimentary understanding of engineering principles as they relate to marine engineering both theoretical and practical in naval architecture, engineering drawing, marine engineering, electro technology, applied mechanics, strength of materiels, thermodynamics, fluid mechanics, and theory of machines subjects.",
                DescFre =
                    "Compréhension rudimentaire des principes d'ingénierie dans la mesure où ils ont trait à l'ingénierie maritime théorique et pratique en architecture navale, dessin technique, génie maritime, électrotechnique, mécanique appliquée, résistance des matériaux, thermodynamique, mécanique des fluides, et théorie des machines."
            },
            new CompetencyLevelRequirement
            {
                Id = 303,
                DescEng =
                    "Basic understanding and application of engineering principles as they relate to marine engineering both theoretical and practical. Demonstrates the ability to read and interpret engineering data while conducting watchkeeping duties. Assists in the conduct of preventive and corrective maintenance of various systems. Seeks opportunities to improve occupational and technological knowledge.",
                DescFre =
                    "Compréhension de base et application des principes d'ingénierie dans la mesure où ils se rapportent au génie maritime, tant sur le plan théorique que pratique. Démontre sa capacité de lire et d'interpréter des données techniques dans l'exercice de ses fonctions de quart. Participer à l'entretien préventif et correctif de divers systèmes. Cherche des occasions d'améliorer ses connaissances professionnelles et technologiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 304,
                DescEng =
                    "Good application of engineering principles as they relate to marine engineering both theoretical and practical. Ability to analyze test data, compare and contrast information, and draw rational conclusions improving productivity. Differentiates between critical and non-critical defects, can quickly diagnose equipment problems, and execute necessary repairs. Ability to solve problems and recommend amendments to processes or procedures.",
                DescFre =
                    "Bonne application des principes d'ingénierie dans la mesure où ils se rapportent au génie maritime, tant sur le plan théorique que pratique. Capacité d'analyser les données d'essai, de comparer et de contraster les informations et de tirer des conclusions rationnelles pour améliorer la productivité. Distingue les défauts critiques des défauts non critiques, peut diagnostiquer rapidement les problèmes d'équipement et effectuer les réparations nécessaires. Capacité de résoudre des problèmes et de recommander des modifications aux processus ou aux procédures."
            },
            new CompetencyLevelRequirement
            {
                Id = 305,
                DescEng =
                    "Ensures machinery and systems operate safely, reliably, and efficiently. Oversees the operation, maintenance, and repair of the marine engineering systems. Applies statistical, cost, lifecycle, and related management principles to standard operating principles.",
                DescFre =
                    "S'assure que les machines et les systèmes fonctionnent de façon sécuritaire, fiable et efficace. Superviser l'exploitation, l'entretien et la réparation des systèmes de génie maritime. Applique les principes statistiques, de coût, de cycle de vie et les principes de gestion connexes aux principes d'exploitation normalisés."
            },
            new CompetencyLevelRequirement
            {
                Id = 306,
                DescEng =
                    "Strategic in approach, understands and addresses inter-dependencies and real issues. Ability to make timely decisions within engineering constraints and direct actions to mitigate impact on mission.",
                DescFre =
                    "Approche stratégique, comprend et aborde les interdépendances et les problèmes réels. Capacité de prendre des décisions en temps opportun en tenant compte des contraintes techniques et de prendre des mesures directes pour atténuer l'impact sur la mission."
            },
            new CompetencyLevelRequirement
            {
                Id = 307,
                DescEng =
                    "Basic knowledge of equipment operating procedures including propulsion generation, ancillary and auxiliary equipment, power distribution, heating and ventilation, refrigeration,  bilge and ballast, and steering systems.",
                DescFre =
                    "Connaissance de base des procédures d'utilisation de l'équipement, y compris la production de la propulsion, l'équipement auxiliaire et auxiliaire, la distribution de l'énergie, le chauffage et la ventilation, la réfrigération, la cale et le ballast, et les systèmes de direction."
            },
            new CompetencyLevelRequirement
            {
                Id = 308,
                DescEng =
                    "Limited working knowledge of equipment operating procedures in semi-automatic and manual modes. Understands basic prerequisites for systems start up and operations.",
                DescFre =
                    "Connaissance pratique limitée des procédures de fonctionnement de l'équipement en mode semi-automatique et manuel. Comprend les conditions de base pour la mise en service et l'exploitation des systèmes."
            },
            new CompetencyLevelRequirement
            {
                Id = 309,
                DescEng =
                    "Practical knowledge of equipment operating procedures. Understands systems redundancies and their operating efficiencies. Intricate knowledge of established safety procedures for operation and maintenance.",
                DescFre =
                    "Connaissance pratique des procédures d'utilisation de l'équipement. Comprend les redondances des systèmes et leur efficacité opérationnelle. Connaissance approfondie des procédures de sécurité établies pour l'exploitation et l'entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 310,
                DescEng =
                    "Advanced knowledge of equipment operating procedures. Sufficient understanding of procedures to be able to assist in drafting new procedures. Knowledge of established emergency operating procedures and limitations.",
                DescFre =
                    "Connaissance approfondie des procédures d'utilisation de l'équipement. Compréhension suffisante des procédures pour être en mesure d'aider à la rédaction de nouvelles procédures. Connaissance des procédures et des limites établies en cas d'urgence."
            },
            new CompetencyLevelRequirement
            {
                Id = 311,
                DescEng =
                    "Expert knowledge of equipment operating procedures and the development of new or revised standard operating procedures in varying engineering and environmental situations.",
                DescFre =
                    "Connaissance approfondie des procédures d'utilisation de l'équipement et de l'élaboration de procédures d'utilisation normalisées nouvelles ou révisées dans diverses situations techniques et environnementales."
            },
            new CompetencyLevelRequirement
            {
                Id = 312, DescEng = "Basic knowledge of a unit's role in an operational context.",
                DescFre = "Basic knowledge of a unit's role in an operational context."
            },
            new CompetencyLevelRequirement
            {
                Id = 313,
                DescEng =
                    "Limited understanding of the roles and responsibilities in an operational context to provide services to clients and stakeholders.  Understands departmental policies, standards, directives, and guidelines relevant to operations.",
                DescFre =
                    "Limited understanding of the roles and responsibilities in an operational context to provide services to clients and stakeholders.  Understands departmental policies, standards, directives, and guidelines relevant to operations."
            },
            new CompetencyLevelRequirement
            {
                Id = 314,
                DescEng =
                    "Practical knowledge of the methods, techniques, practices, and procedures associated with various types of operations. Understands appropriate methods and procedures for dealing with marine operations, exercises, and emergencies.",
                DescFre =
                    "Practical knowledge of the methods, techniques, practices, and procedures associated with various types of operations. Understands appropriate methods and procedures for dealing with marine operations, exercises, and emergencies."
            },
            new CompetencyLevelRequirement
            {
                Id = 315,
                DescEng =
                    "Advanced knowledge of operational capabilities and adaptive processes. Understands how an approaches or procedure should work and how changes in conditions, operations, and the environment will affect outcomes. Knowledge of best practices and processes for asset use and performance recommendations. Understands operational interoperabilities with internal and external stakeholders (including international).",
                DescFre =
                    "Advanced knowledge of operational capabilities and adaptive processes. Understands how an approaches or procedure should work and how changes in conditions, operations, and the environment will affect outcomes. Knowledge of best practices and processes for asset use and performance recommendations. Understands operational interoperabilities with internal and external stakeholders (including international)."
            },
            new CompetencyLevelRequirement
            {
                Id = 316,
                DescEng =
                    "Expert knowledge of operational capabilities and decision making to complete the mandate effectively and efficiently. Understands emerging and best practices in the management of regional and/or national operations. Expertise in reviewing policies, regulations, directives, and guidelines.",
                DescFre =
                    "Expert knowledge of operational capabilities and decision making to complete the mandate effectively and efficiently. Understands emerging and best practices in the management of regional and/or national operations. Expertise in reviewing policies, regulations, directives, and guidelines."
            },
            new CompetencyLevelRequirement
            {
                Id = 317,
                DescEng =
                    "Basic knowledge of equipment operating procedures including global navigation satellite systems and other equipment used as a source of positional information. Understands how to report errors and issues.",
                DescFre =
                    "Basic knowledge of equipment operating procedures including global navigation satellite systems and other equipment used as a source of positional information. Understands how to report errors and issues."
            },
            new CompetencyLevelRequirement
            {
                Id = 318,
                DescEng =
                    "Limited understanding of equipment operating procedures including global navigation satellite systems, electronic charts, steering and propulsion systems and warnings, and other equipment used as a source of positional information. Ability to solve basic problems independently and more complex ones with some assistance. Capable of identifying problems based on a limited number of clear and basic factors. Actively engages in errors/issues identification and resolution where appropriate.",
                DescFre =
                    "Limited understanding of equipment operating procedures including global navigation satellite systems, electronic charts, steering and propulsion systems and warnings, and other equipment used as a source of positional information. Ability to solve basic problems independently and more complex ones with some assistance. Capable of identifying problems based on a limited number of clear and basic factors. Actively engages in errors/issues identification and resolution where appropriate."
            },
            new CompetencyLevelRequirement
            {
                Id = 319,
                DescEng =
                    "Good understanding/knowledge of equipment operating procedures. Experienced in solving basic and more complex problems. Skillful in identifying problems based on a limited number of clear factors. Diligent in verifying the problem has been solved. Proactively resolves errors/issues and seeks to prevent them from occurring.",
                DescFre =
                    "Good understanding/knowledge of equipment operating procedures. Experienced in solving basic and more complex problems. Skillful in identifying problems based on a limited number of clear factors. Diligent in verifying the problem has been solved. Proactively resolves errors/issues and seeks to prevent them from occurring."
            },
            new CompetencyLevelRequirement
            {
                Id = 320,
                DescEng =
                    "Advanced understanding of equipment operating procedures. Extensive experience in solving various degrees of errors/issues/problems and providing effective guidance and advice to others seeking assistance. Effective in identifying problems with minimal information or clear factors.",
                DescFre =
                    "Advanced understanding of equipment operating procedures. Extensive experience in solving various degrees of errors/issues/problems and providing effective guidance and advice to others seeking assistance. Effective in identifying problems with minimal information or clear factors."
            },
            new CompetencyLevelRequirement
            {
                Id = 321,
                DescEng =
                    "Extensive experience in managing serious problems/issues/errors and implementing viable and practical solutions to address the situation. Effective in identifying problems with minimal information or clear factors and managing other persons and resources in the implementation of a solution.",
                DescFre =
                    "Extensive experience in managing serious problems/issues/errors and implementing viable and practical solutions to address the situation. Effective in identifying problems with minimal information or clear factors and managing other persons and resources in the implementation of a solution."
            },
            new CompetencyLevelRequirement
            {
                Id = 322,
                DescEng = "Basic understanding of the Environmental Response (ER) program, mission, and mandate.",
                DescFre =
                    "Compréhension de base du programme, de la mission et du mandat d'intervention environnementale (IE)"
            },
            new CompetencyLevelRequirement
            {
                Id = 323,
                DescEng =
                    "Limited knowledge of the Environmental Response (ER) program's resources such as, spill equipment, maintenance, storage; clean up gear; and containment boom operation.",
                DescFre =
                    "Connaissance limitée des ressources du programme d'intervention environnementale (IE) telles que l'équipement en cas de déversement, l'entretien, l'entreposage, le nettoyage de l'équipement et le fonctionnement de la flèche de confinement."
            },
            new CompetencyLevelRequirement
            {
                Id = 324,
                DescEng =
                    "Practical understanding of the Canadian Coast Guard's Environmental Response (ER) response capabilities in a variety of moderately complex situations. Understands the roles and responsibilities of direct partners, other government departments (OGDs), and external partners collaborating with the ER program. Knowledge of contingency planning and exercise execution.",
                DescFre =
                    "Compréhension pratique des capacités d'intervention de la Garde côtière canadienne - Intervention environnementale (IE) dans une variété de situations modérément complexes. Comprend les rôles et les responsabilités des partenaires directs, des autres ministères et des partenaires externes qui collaborent au programme d'IE. Connaissance de la planification d'urgence et de l'exécution des exercices."
            },
            new CompetencyLevelRequirement
            {
                Id = 325,
                DescEng =
                    "Extensive knowledge of capability and status of Coast Guard assets. Advanced knowledge of international intervention agencies (such as the United States Coast Guard and the Environmental Protection Agency of United States) roles and the state of preparation of the adjacent and circumpolar countries. Knowledge of the enforcement of pollution prevention plans between vessel operators and governments. Knowledge of roles and mandates of key stakeholders in the provincial, municipal and private communities. Knowledge of national and international regulations concerning environmental protection.",
                DescFre =
                    "Connaissance approfondie de la capacité et de l'état des biens de la Garde côtière. Connaissance approfondie des organismes d'intervention internationaux (comme la Garde côtière des États-Unis et  l'Environnement Agence de protection des États-Unis) et l'état de préparation des pays voisins et circumpolaires. Connaissance de l'application des plans de prévention de la pollution entre les exploitants de navires et les gouvernements. Connaissance des rôles et des mandats des principaux intervenants dans les collectivités provinciales, municipales et privées.  Connaissance des réglementations nationales et internationales en matière de protection de l'environnement."
            },
            new CompetencyLevelRequirement
            {
                Id = 326,
                DescEng =
                    "Expert knowledge of the full range of the Coast Guard's Environmental Response (ER) program and its relations with industry and governments within Canada and abroad.",
                DescFre =
                    "Connaissance approfondie de la gamme complète du programme d'intervention environnementale (IE) de la Garde côtière et de ses relations avec l'industrie et les gouvernements au Canada et à l'étranger."
            },
            new CompetencyLevelRequirement
            {
                Id = 327,
                DescEng =
                    "Understands the established and applicable operational procedures within Icebreaking (IB). Knowledge of basic computer software related to icebreaking. Understands charts and maps, and knows their specific characteristics.",
                DescFre =
                    "Comprend les procédures opérationnelles établies et applicables en matière de déglaçage. Connaissance des logiciels informatiques de base liés au déglaçage. Comprend les graphiques et les cartes et connaît leurs caractéristiques spécifiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 328,
                DescEng =
                    "Understanding of concentration, stages of development, and forms of ice (Egg Code).  Knowledge of assets’ communication equipment and capabilities. Understands meteorological processes, such as air masses, weather, and atmospheric structures. Understands ice analyses and charts. Understands iceberg formation and tracking.",
                DescFre =
                    "Compréhension de la concentration, des stades de développement et des formes de glace (Egg Code).  Connaissance de l'équipement et des capacités de communication des biens. Comprend les processus météorologiques, comme les masses d'air, les conditions météorologiques et les structures atmosphériques. Comprend les analyses et les cartes des glaces. Comprend la formation et le suivi des icebergs."
            },
            new CompetencyLevelRequirement
            {
                Id = 329,
                DescEng =
                    "Practical knowledge of navigation, ship construction, and ship handling principles as they relate to navigation in ice infested waters. Knowledge of reporting (such as the Icebreaking Operations Data Information System [IODIS]) and mapping (such as Information System on Marine Navigation [INNAV] and Exact Earth) systems and other related software in daily operations. Understands oceanographic processes: waves, currents, and shoreline dynamics as they relate to ice. Understands navigation protocols, such as course plotting, in order to evaluate the safety of an ice route.",
                DescFre =
                    "Connaissance pratique des principes de navigation, de construction et de manœuvre des navires en ce qui a trait à la navigation dans les eaux recouvertes de glace. Connaissance des systèmes d'établissement de rapports (comme le Système d'information sur les données des opérations de déglaçage[SIDOD]) et de cartographie (Système d'information sur la gestion du trafic maritime [SIGTM] et Exact Earth) et d'autres logiciels connexes dans les opérations quotidiennes. Comprend les processus océanographiques : les vagues, les courants et la dynamique des rives par rapport aux glaces. Comprend les protocoles de navigation, comme le tracé de route, afin d'évaluer la sécurité d'une route de glace."
            },
            new CompetencyLevelRequirement
            {
                Id = 330,
                DescEng =
                    "Advanced knowledge of alternate or emerging strategies that may fall outside standard operating procedures in order to resolve a situation. Has detailed knowledge of areas of responsibility characteristics which play a role in Icebreaking (IB) operations or influence the outcome of the program.",
                DescFre =
                    "Connaissance approfondie des stratégies de rechange ou des stratégies émergentes qui peuvent ne pas faire partie des procédures d'exploitation normalisées afin de résoudre une situation. A une connaissance détaillée des caractéristiques des secteurs de responsabilité qui jouent un rôle dans les opérations de déglaçage ou qui influencent les résultats du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 331,
                DescEng =
                    "Expert program knowledge in implementing new possibilities /capabilities to improve the existing systems and practices. Knowledge of creating program procedures.",
                DescFre =
                    "Connaissance experte du programme dans la mise en œuvre de nouvelles possibilités/capacités pour améliorer les systèmes et les pratiques existants. Connaissance de la création des procédures du programme."
            },
            new CompetencyLevelRequirement
            {
                Id = 332,
                DescEng =
                    "Reads and interprets diagrams and schematics. Starts and stops main propulsion, auxillary and ancillary machinery. Monitors and reports equipment performance. Assists in scheduling equipment maintenance. Performs repair by replacement.",
                DescFre =
                    "Lit et interprète des diagrammes et des schémas. Mettre en marche et arrêter la propulsion principale, les machines auxiliaires et auxiliaires. Surveille et signale les performances de l'équipement. Aide à planifier l'entretien de l'équipement. Effectue la réparation par remplacement."
            },
            new CompetencyLevelRequirement
            {
                Id = 333,
                DescEng =
                    "Perform first and second line maintenance as per watch instructions. Maintains list of parts. Directs fuel transfers. Analyzes engineering reports. Directs configuration changes in propulsion plant and machinery. Advises bridge officers on machinery status, liquid cargo transfers, and ongoing maintenance issues. Responds to ancillary and auxiliary breakdowns.",
                DescFre =
                    "Effectue la maintenance de première et de deuxième ligne selon les instructions de la surveillance. Tient à jour la liste des pièces. Dirige les transferts de carburant. Analyse les rapports techniques. Dirige les changements de configuration des installations et des machines de propulsion. Conseille les officiers de pont sur l'état des machines, les transferts de cargaisons liquides et les questions d'entretien courant. Réponds aux pannes des équipements auxiliaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 334,
                DescEng =
                    "Provides information and advice to bridge officers and chief engineers. Peforms engine overhaul at sea and ashore. Establishes trends in machinery performance and future maintenance requirements based on logs. Makes recommendations, and may make decisions on engineering matters or other areas requiring technical engineering expertise.",
                DescFre =
                    "Fournit des informations et des conseils aux officiers de pont et aux chefs mécaniciens. Effectue la révision des moteurs en mer et à terre. Établit les tendances en matière de performance de la machinerie et les besoins futurs d'entretien basés sur les journaux de bord. Fait des recommandations et peut prendre des décisions sur des questions d'ingénierie ou d'autres domaines nécessitant une expertise technique en ingénierie."
            },
            new CompetencyLevelRequirement
            {
                Id = 335,
                DescEng =
                    "Advises commanding officers on all shipboard engineering matters, including fuel consumption best practices, maintenance status and requirements, speed restrictions, and stability configurations and environmental considerations. Oversees the completion of all engineering logs and reports. Manages engineering docking procedures. Liaises and directs contractors.",
                DescFre =
                    "Conseille les commandants sur toutes les questions relatives à l'ingénierie à bord des navires, y compris les meilleures pratiques en matière de consommation de carburant, l'état et les exigences d'entretien, les restrictions de vitesse, les configurations de stabilité et les considérations environnementales. Supervise la tenue de tous les journaux et rapports techniques. Gére les procédures d'accostage technique. Assure la liaison avec les entrepreneurs et les diriger."
            },
            new CompetencyLevelRequirement
            {
                Id = 336,
                DescEng =
                    "Manages all shipboard and/or shoreside engineering matters, operations, maintenance, and reporting. Manages engineering docking procedures. Liaises with and directs contractors. Provides engineering expertise to units at sea and ashore regionally and nationally. Develops vessel class engineering procedures for operation under normal and emergency situations. Participates in regional and national working groups on refit scheduling best practices, engineering change proposals, and new platform acquisition.",
                DescFre =
                    "Gère toutes les questions d'ingénierie à bord des navires et/ou à terre, les opérations, la maintenance et les rapports. Gère les procédures d'accostage technique. Assure la liaison avec les entrepreneurs et les diriger. Fournit une expertise technique aux unités en mer et à terre, au niveau régional et national. Élabore des procédures d'ingénierie de classe navire pour l'exploitation dans des situations normales et d'urgence. Participe aux groupes de travail régionaux et nationaux sur les meilleures pratiques en matière de planification du radoub, les propositions de modifications techniques et l'acquisition de nouvelles plates-formes."
            },
            new CompetencyLevelRequirement {Id = 337, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 338, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 339,
                DescEng =
                    "Operates and monitors a ship's electrical distribution system. Conducts system configuration changes. Provides limited advise to bridge officers on electical issues.",
                DescFre =
                    "Operates and monitors a ship's electrical distribution system. Conducts system configuration changes. Provides limited advise to bridge officers on electical issues."
            },
            new CompetencyLevelRequirement
            {
                Id = 340,
                DescEng =
                    "Reads and interprets diagrams and schematics. Applies basic circuit analysis methods to solve electrical problems. Operates the electrical plant, monitors parameters and reports on electrical components and equipment status. Installs, tests, and repairs ship electrical and electronic equipment, in collaboration with the engineering department.",
                DescFre =
                    "Reads and interprets diagrams and schematics. Applies basic circuit analysis methods to solve electrical problems. Operates the electrical plant, monitors parameters and reports on electrical components and equipment status. Installs, tests, and repairs ship electrical and electronic equipment, in collaboration with the engineering department."
            },
            new CompetencyLevelRequirement
            {
                Id = 341,
                DescEng =
                    "Manages all shipboard electrical matters, operations, maintenance, and reporting. Liaises with and directs electrical contractors. Provides electrical expertise to units at sea and ashore, regionally and nationally. Develops vessel class electrical procedures for operation under normal and emergency situations. Participates in regional and national working groups on electrical best practices.",
                DescFre =
                    "Manages all shipboard electrical matters, operations, maintenance, and reporting. Liaises with and directs electrical contractors. Provides electrical expertise to units at sea and ashore, regionally and nationally. Develops vessel class electrical procedures for operation under normal and emergency situations. Participates in regional and national working groups on electrical best practices."
            },
            new CompetencyLevelRequirement
            {
                Id = 342,
                DescEng =
                    "Basic use of navigational principles. Stands a steering watch and plots speed, distance, and time calculations, along pre-established routes. Studies charts and corrections. Researches weather and tide information. Observes traffic.",
                DescFre =
                    "Basic use of navigational principles. Stands a steering watch and plots speed, distance, and time calculations, along pre-established routes. Studies charts and corrections. Researches weather and tide information. Observes traffic."
            },
            new CompetencyLevelRequirement
            {
                Id = 343,
                DescEng =
                    "Stands bridge watches, including using most bridge equipment. Routinely plots courses. Manages safety and/or chart correction portfolios. Handles radio traffic and logs. Gathers domain awareness relevant to passage planning. Observes and reports collision risks.",
                DescFre =
                    "Stands bridge watches, including using most bridge equipment. Routinely plots courses. Manages safety and/or chart correction portfolios. Handles radio traffic and logs. Gathers domain awareness relevant to passage planning. Observes and reports collision risks."
            },
            new CompetencyLevelRequirement
            {
                Id = 344,
                DescEng =
                    "Manages a range of bridge watch duties in most conditions, including using all bridge gear (Electronic Chart Display System (ECDIS), radar, etc.), course plotting and correction, handling safety portfolios, radio communications, logging, and giving helm orders, including collision avoidance. Participates in various program operations including search and rescue.",
                DescFre =
                    "Manages a range of bridge watch duties in most conditions, including using all bridge gear (Electronic Chart Display System (ECDIS), radar, etc.), course plotting and correction, handling safety portfolios, radio communications, logging, and giving helm orders, including collision avoidance. Participates in various program operations including search and rescue."
            },
            new CompetencyLevelRequirement
            {
                Id = 345,
                DescEng =
                    "Manages bridge watches in all types of vessel operations, passage and station keeping, including bridge team management through acting command. Manages most program supports, including handling searches, risk analyses, emergencies. Oversees the training of junior watchkeeping officers and crew.",
                DescFre =
                    "Manages bridge watches in all types of vessel operations, passage and station keeping, including bridge team management through acting command. Manages most program supports, including handling searches, risk analyses, emergencies. Oversees the training of junior watchkeeping officers and crew."
            },
            new CompetencyLevelRequirement
            {
                Id = 346,
                DescEng =
                    "Manages all bridge teams and watch scenarios including pilotage and program supports, risk and emergency management from a command perspective. Recommends and tests new gear and procedures. Provides advice on lessons learned through sightings, bearings, land and sea features, meteorological and oceanographic trends, and electronic aids and their limitations.",
                DescFre =
                    "Manages all bridge teams and watch scenarios including pilotage and program supports, risk and emergency management from a command perspective. Recommends and tests new gear and procedures. Provides advice on lessons learned through sightings, bearings, land and sea features, meteorological and oceanographic trends, and electronic aids and their limitations."
            },
            new CompetencyLevelRequirement
            {
                Id = 347,
                DescEng =
                    "Requests supplies, ensuring that proper receipt, identification, and inspection is carried out for incoming shipboard materiel. Performs routine asset management tasks. Conducts the life cycle of tackle books, safety equipment, charts, etc., when and where applicable.",
                DescFre =
                    "Requests supplies, ensuring that proper receipt, identification, and inspection is carried out for incoming shipboard materiel. Performs routine asset management tasks. Conducts the life cycle of tackle books, safety equipment, charts, etc., when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 348,
                DescEng =
                    "Requests parts and supplies from internal stocks using the approved classification system. Adheres to the inventory management system (IMS) as it relates to a position. Applies proper stowage, ensures safe handling, and preserves assets. Reviews incoming standing offer agreements, purchase orders, and maintains a central file of agreements for monthly/annual contracts. Manages special and emergency requirements of departments by determining the best means of purchase, contacting regional suppliers and managers, and ensuring that materiel is received within the deadline required.",
                DescFre =
                    "Requests parts and supplies from internal stocks using the approved classification system. Adheres to the inventory management system (IMS) as it relates to a position. Applies proper stowage, ensures safe handling, and preserves assets. Reviews incoming standing offer agreements, purchase orders, and maintains a central file of agreements for monthly/annual contracts. Manages special and emergency requirements of departments by determining the best means of purchase, contacting regional suppliers and managers, and ensuring that materiel is received within the deadline required."
            },
            new CompetencyLevelRequirement
            {
                Id = 349,
                DescEng =
                    "Receives, stores, issues, and records materiel according to the approved classification system. Categorizes materiel (i.e. equipment, controllable, and expendable). Requisitions types and quantities of materiel to meet authorized allowances or specified requirements of provisions, general stores, spare parts, controllable items, uniforms, and protective clothing, pharmaceutical and medical supplies, canteen and bonded stores. Ensures the proper stowage, care, preservation, and security of materiel stocked in central stores or in use by the logistics department, that materiel is properly identified, catalogued, and incorporated in the centralized cataloguing files. Implements the concepts of the Policy Framework for the Management of Assets and Acquired Services in daily routines.",
                DescFre =
                    "Receives, stores, issues, and records materiel according to the approved classification system. Categorizes materiel (i.e. equipment, controllable, and expendable). Requisitions types and quantities of materiel to meet authorized allowances or specified requirements of provisions, general stores, spare parts, controllable items, uniforms, and protective clothing, pharmaceutical and medical supplies, canteen and bonded stores. Ensures the proper stowage, care, preservation, and security of materiel stocked in central stores or in use by the logistics department, that materiel is properly identified, catalogued, and incorporated in the centralized cataloguing files. Implements the concepts of the Policy Framework for the Management of Assets and Acquired Services in daily routines."
            },
            new CompetencyLevelRequirement
            {
                Id = 350,
                DescEng =
                    "Enables and promotes the management of the approved materiel classification system. Uses supplier classifications systems and cross-reference tables where available. Performs a full function of asset management processes. Follows the life cycle management regime for all trackable assets. Follows the process of commissioning and decommissioning of vessels as they relate to fleet operations. Ensures security of assets. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items.",
                DescFre =
                    "Enables and promotes the management of the approved materiel classification system. Uses supplier classifications systems and cross-reference tables where available. Performs a full function of asset management processes. Follows the life cycle management regime for all trackable assets. Follows the process of commissioning and decommissioning of vessels as they relate to fleet operations. Ensures security of assets. Maintains commitment control records for materiel requisitioned for stock and for non-stocked items."
            },
            new CompetencyLevelRequirement
            {
                Id = 351,
                DescEng =
                    "Partners with Corporate Services, Shared Services, and other personnel. Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches to managing shipboard logistics. Trains and guides employees within the materiel management field, when and where applicable.",
                DescFre =
                    "Partners with Corporate Services, Shared Services, and other personnel. Attends national meetings and represents regional interests in the area of materiel management. Advises and guides management on cost-effective approaches to managing shipboard logistics. Trains and guides employees within the materiel management field, when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 352,
                DescEng =
                    "Logs basic project/program needs, prepares orders, schedules delivery times, and receives and stores material as directed.",
                DescFre =
                    "Logs basic project/program needs, prepares orders, schedules delivery times, and receives and stores material as directed."
            },
            new CompetencyLevelRequirement
            {
                Id = 353,
                DescEng =
                    "Prepares list of required items. Assembles orders. Sorts merchandise, maintains supplies, verifies inventory, and processes return materials authorizations.",
                DescFre =
                    "Prepares list of required items. Assembles orders. Sorts merchandise, maintains supplies, verifies inventory, and processes return materials authorizations."
            },
            new CompetencyLevelRequirement
            {
                Id = 354,
                DescEng =
                    "Controls purchasing, transportation, inventory, and site storage protocols. Uses appropriate equipment, facilities, and materials to conduct unit work. Controls inventory levels by conducting physical counts and reconciling with data storage system.",
                DescFre =
                    "Controls purchasing, transportation, inventory, and site storage protocols. Uses appropriate equipment, facilities, and materials to conduct unit work. Controls inventory levels by conducting physical counts and reconciling with data storage system."
            },
            new CompetencyLevelRequirement
            {
                Id = 355,
                DescEng =
                    "Enters commitment and contracts for goods and services. Receives and distributes raw materials and finished goods. Forecasts requirements and planning for the future. Identifies complex problems and reviewing related information to develop and evaluate options and implement solutions. Designs strategies to minimize the cost or time. Develops and implements site inventory monitoring procedures.",
                DescFre =
                    "Enters commitment and contracts for goods and services. Receives and distributes raw materials and finished goods. Forecasts requirements and planning for the future. Identifies complex problems and reviewing related information to develop and evaluate options and implement solutions. Designs strategies to minimize the cost or time. Develops and implements site inventory monitoring procedures."
            },
            new CompetencyLevelRequirement
            {
                Id = 356,
                DescEng =
                    "Initiates, manages, and follows through on unit or shared units large contracts for goods and services. Resolves complex unit or site logistical issues and their impacts on other units or operations. Develops and implements business process initiatives to optimize logistical operations. Follows strict controls according to policies and procedures related to material handling, and shipping requirements.",
                DescFre =
                    "Initiates, manages, and follows through on unit or shared units large contracts for goods and services. Resolves complex unit or site logistical issues and their impacts on other units or operations. Develops and implements business process initiatives to optimize logistical operations. Follows strict controls according to policies and procedures related to material handling, and shipping requirements."
            },
            new CompetencyLevelRequirement
            {
                Id = 357,
                DescEng =
                    "Locates aids to navigation, logs and files records. Asks pertinent questions related to the Aids to Navigation (AtoN) program.",
                DescFre =
                    "Locates aids to navigation, logs and files records. Asks pertinent questions related to the Aids to Navigation (AtoN) program."
            },
            new CompetencyLevelRequirement
            {
                Id = 358,
                DescEng =
                    "Plans first-line maintenance for existing aids to navigation, logging information appropriately, and reporting outages where necessary for further action.",
                DescFre =
                    "Plans first-line maintenance for existing aids to navigation, logging information appropriately, and reporting outages where necessary for further action."
            },
            new CompetencyLevelRequirement
            {
                Id = 359,
                DescEng =
                    "Coordinates the range of aids services, including  aids maintenance planning, inspections, maintenance, and replacement operations with Fleet partners. Drafts reports and notices to shipping (NOTSHIP). Provides on-the-job training. ",
                DescFre =
                    "Coordinates the range of aids services, including  aids maintenance planning, inspections, maintenance, and replacement operations with Fleet partners. Drafts reports and notices to shipping (NOTSHIP). Provides on-the-job training. "
            },
            new CompetencyLevelRequirement
            {
                Id = 360,
                DescEng =
                    "Manages the entire range of Aids to Navigation (AtoN) program activities. Identifies, analyzes, and prioritizes risks related to aids to navigation for the management of notices to shipping (NOTSHIP), aids requests, failures, replacement, and maintenance according to life cycles, in co-operation with Canadian Coast Guard's Integrated Technical Services (ITS) and Fleet partners. Provides inputs and recommendations into levels of service and operational requirements and updates to data systems. Assesses navigational risks.",
                DescFre =
                    "Manages the entire range of Aids to Navigation (AtoN) program activities. Identifies, analyzes, and prioritizes risks related to aids to navigation for the management of notices to shipping (NOTSHIP), aids requests, failures, replacement, and maintenance according to life cycles, in co-operation with Canadian Coast Guard's Integrated Technical Services (ITS) and Fleet partners. Provides inputs and recommendations into levels of service and operational requirements and updates to data systems. Assesses navigational risks."
            },
            new CompetencyLevelRequirement
            {
                Id = 361,
                DescEng =
                    "Oversees the planning of regional and national Aids to Navigation (AtoN) program activities, including analyzing program metadata, conducting studies, developing service standards and needs analyses and risk mitigation measures. Provides information and feedback to and from partners and stakeholders internally and externally. Explores opportunities for program improvement. Drafts national directives and/or policies.",
                DescFre =
                    "Oversees the planning of regional and national Aids to Navigation (AtoN) program activities, including analyzing program metadata, conducting studies, developing service standards and needs analyses and risk mitigation measures. Provides information and feedback to and from partners and stakeholders internally and externally. Explores opportunities for program improvement. Drafts national directives and/or policies."
            },
            new CompetencyLevelRequirement
            {
                Id = 362,
                DescEng =
                    "Conducts information searches, organizes, reviews, and processes information and performs directed, routine analysis. Ensures the accuracy and completeness of the information.",
                DescFre =
                    "Effectue des recherches d'informations, organise, examine et traite les informations et effectue des analyses de routine dirigées. Veille à l'exactitude et à l'exhaustivité des informations."
            },
            new CompetencyLevelRequirement
            {
                Id = 363,
                DescEng =
                    "Determines and selects information relevant to a particular area of study, compiles and verifies information and performs directed, non-routine analyses. Ensures consistency, coherence, and information integrity.",
                DescFre =
                    "Détermine et sélectionne les informations pertinentes pour un domaine d'étude particulier, compile et vérifie les informations et effectue des analyses dirigées et non routinières. Veille à la cohérence et à l'intégrité des informations."
            },
            new CompetencyLevelRequirement
            {
                Id = 364,
                DescEng =
                    "Studies a range of information and identifies and interprets trends and patterns, determines gaps in research, and develops comprehensive background material for further analysis. Assesses information and evaluates and compares current approaches and practices for the gathering, dissemination, or analysis of information. Identifies possible modifications or alternative approaches when deeming current methodology as inadequate or inaccurate.",
                DescFre =
                    "Étudie une série d'informations et identifie et interprète les tendances et les modèles, détermine les lacunes dans la recherche et élabore des documents de référence complets pour une analyse plus approfondie. Évalue les informations et évalue et compare les approches et les pratiques actuelles en matière de collecte, de diffusion ou d'analyse des informations. Identifie les modifications possibles ou les approches alternatives lorsque la méthodologie actuelle est jugée inadéquate ou inexacte."
            },
            new CompetencyLevelRequirement
            {
                Id = 365,
                DescEng =
                    "Synthesizes and interprets complex information from diverse sources and identifies the conceptual frameworks related to areas of study. Accounts for interrelationships among variables or determines the need for new analytical methodologies, systems, or approaches.",
                DescFre =
                    "Synthétiser et interpréter des informations complexes provenant de diverses sources et identifier les cadres conceptuels liés aux domaines d'étude. Tient compte des interrelations entre les variables ou détermine le besoin de nouvelles méthodes, systèmes ou approches analytiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 366,
                DescEng =
                    "Investigates and challenges existing conceptual frameworks. Examines multiple variables from distinct sources within a subject matter area and reaches conclusions and/or generates solutions. Integrates distinct broad-based qualitative or quantitative analyses. Creates/adapts conceptual frameworks for the development, application, interpretation, and evaluation of studies, methodologies, strategies, and policies for the Canadian Coast Guard.",
                DescFre =
                    "Examine et remet en question les cadres conceptuels existants. Examine de multiples variables provenant de sources distinctes au sein d'un même domaine et aboutit à des conclusions et/ou génère des solutions. Intègre des analyses qualitatives ou quantitatives distinctes et de grande envergure. Crée/adapte des cadres conceptuels pour l'élaboration, l'application, l'interprétation et l'évaluation d'études, de méthodologies, de stratégies et de politiques pour la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 367, DescEng = "Makes recommendations for decision on technical engineering matters.",
                DescFre = "Fait des recommandations de décision sur des questions d'ingénierie technique."
            },
            new CompetencyLevelRequirement
            {
                Id = 368,
                DescEng =
                    "Makes recommendations to approve routine engineering/technical designs and/or project/program specifications of other engineers to meet desired compliance with engineering principles, standards, codes, designs, and statutes.",
                DescFre =
                    "Fait des recommandations pour approuver les conceptions techniques régulières et/ou les spécifications de projets/programmes d'autres ingénieurs afin de respecter les principes, normes, codes, conceptions et statuts d'ingénierie."
            },
            new CompetencyLevelRequirement
            {
                Id = 369,
                DescEng =
                    "Makes recommendations, and may make decisions on non-engineering and/or program matters or other areas requiring technical engineering expertise. May make final decisions. Provides technical analysis. May serve as a mentor/resource to lower level employees in the area of assignment. May approve moderately complex engineering/technical designs and/or project/program specificiations of other engineers to meet desired compliance with engineering principles, standards, codes, designs, and statutes. May address conflicting design constraints.",
                DescFre =
                    "Fait des recommandations et peut prendre des décisions sur des questions autres que l'ingénierie et/ou les programmes ou d'autres domaines nécessitant une expertise technique en ingénierie. Peut prendre des décisions finales. Fournit des analyses techniques. Peut servir de mentor/ressource pour les employés de niveau inférieur dans la zone d'affectation. Peut approuver des conceptions techniques modérément complexes et/ou des spécificités de projets/programmes d'autres ingénieurs afin d'assurer la conformité souhaitée aux principes, normes, codes, conceptions et statuts en matière d'ingénierie. Peut traiter des contraintes de conception contradictoires."
            },
            new CompetencyLevelRequirement
            {
                Id = 370,
                DescEng =
                    "Approves complex or novel engineering/technical designs and/or project/program specifications of other engineers, to meet desired compliance with engineering principles, standards, codes, designs, and statutes. Addresses conflicting design constraints.",
                DescFre =
                    "Approuve les conceptions techniques complexes ou inhabituelles et/ou les spécifications de projets/programmes d'autres ingénieurs, afin de respecter les principes, normes, codes, conceptions et statuts d'ingénierie. Traite les contraintes de conception contradictoires."
            },
            new CompetencyLevelRequirement
            {
                Id = 371,
                DescEng =
                    "Makes final recommendations and may make decisions that require specialized engineering and/or program knowledge. Decisions may not be technically reviewed. Collaborates with others in finding solutions to controversial or sensitive matters that establish precendents. Technical expert in the area of assignment and may represent the Canadian Coast Guard as an expert.",
                DescFre =
                    "Fait des recommandations finales et peut prendre des décisions qui nécessitent des connaissances spécialisées en ingénierie et/ou en programmes. Les décisions ne peuvent pas faire l'objet d'un examen technique. Collabore avec d'autres personnes pour trouver des solutions à des questions controversées ou sensibles qui établissent des précendents. Expert technique dans le domaine d'affectation et peut représenter la Garde côtière canadienne en tant qu'expert."
            },
            new CompetencyLevelRequirement
            {
                Id = 372,
                DescEng =
                    "Applies engineering sciences to assist in the design of engineering projects. Solves or assists in solving defined problems in drafting an engineering project proposal.",
                DescFre =
                    "Applies engineering sciences to assist in the design of engineering projects. Solves or assists in solving defined problems in drafting an engineering project proposal."
            },
            new CompetencyLevelRequirement
            {
                Id = 373,
                DescEng =
                    "Applies engineering sciences to moderately complex services or creative work such as consultations, investigations, evaluation, plans, and designs of engineering projects. Provides drawing input and reviews. Defines problems, conducts research, plans methods, and identifies resources.",
                DescFre =
                    "Applies engineering sciences to moderately complex services or creative work such as consultations, investigations, evaluation, plans, and designs of engineering projects. Provides drawing input and reviews. Defines problems, conducts research, plans methods, and identifies resources."
            },
            new CompetencyLevelRequirement
            {
                Id = 374,
                DescEng =
                    "Develops engineering designs and/or project/program specifications to meet desired compliance with engineering principles, standards, statutes, codes, regulations. Researches, collects, and/or analyzes information/data which contributes to making engineering decisions. Monitors and ensures projects meet specifications and/or design standards.",
                DescFre =
                    "Develops engineering designs and/or project/program specifications to meet desired compliance with engineering principles, standards, statutes, codes, regulations. Researches, collects, and/or analyzes information/data which contributes to making engineering decisions. Monitors and ensures projects meet specifications and/or design standards."
            },
            new CompetencyLevelRequirement
            {
                Id = 375,
                DescEng =
                    "Approves engineering designs, program, and project specifications. Researches new procedures and products for current and future projects. Improves manufacturing processes.",
                DescFre =
                    "Approves engineering designs, program, and project specifications. Researches new procedures and products for current and future projects. Improves manufacturing processes."
            },
            new CompetencyLevelRequirement
            {
                Id = 376,
                DescEng =
                    "Approves all designs, design modifications, and engineering projects. Reviews and/or analyzes information/data which contributes to making engineering decisions. Monitors and ensures projects meet specifications and/or design standards. Develops client relations by continually improving the level of service provided in accordance with the provision of service agreement and industry standard practices.",
                DescFre =
                    "Approves all designs, design modifications, and engineering projects. Reviews and/or analyzes information/data which contributes to making engineering decisions. Monitors and ensures projects meet specifications and/or design standards. Develops client relations by continually improving the level of service provided in accordance with the provision of service agreement and industry standard practices."
            },
            new CompetencyLevelRequirement
            {
                Id = 377,
                DescEng =
                    "Performs introductory collection, organization, preservation, and dissemination of information resources functions. Answers routine informational/directional questions. Explains and upholds policies & procedures, handles routine complaints. Enters basic data, manipulates software for information (e.g. adding barcodes, keying orders, Innopac records).",
                DescFre =
                    "Performs introductory collection, organization, preservation, and dissemination of information resources functions. Answers routine informational/directional questions. Explains and upholds policies & procedures, handles routine complaints. Enters basic data, manipulates software for information (e.g. adding barcodes, keying orders, Innopac records)."
            },
            new CompetencyLevelRequirement
            {
                Id = 378,
                DescEng =
                    "Collects, preserves, and disseminates information items using established guidelines, identifying useable copy of categories of material which can be cataloged online or in print. Keys records into systems. Sorts and distributes incoming materials to appropriate workflows. Performs basic processing of notices and sources of information. Performs stack maintenance per established guidelines.",
                DescFre =
                    "Collects, preserves, and disseminates information items using established guidelines, identifying useable copy of categories of material which can be cataloged online or in print. Keys records into systems. Sorts and distributes incoming materials to appropriate workflows. Performs basic processing of notices and sources of information. Performs stack maintenance per established guidelines."
            },
            new CompetencyLevelRequirement
            {
                Id = 379,
                DescEng =
                    "Collects, preserves, and disseminates information resources for database maintenance and added copy tasks in local database. Updates lower level records in local databases. Creates records in databases. Trains others in stack maintenance. Serves at a reference desk or general service desk providing routine information to members using the library’s catalogs and resources.",
                DescFre =
                    "Collects, preserves, and disseminates information resources for database maintenance and added copy tasks in local database. Updates lower level records in local databases. Creates records in databases. Trains others in stack maintenance. Serves at a reference desk or general service desk providing routine information to members using the library’s catalogs and resources."
            },
            new CompetencyLevelRequirement
            {
                Id = 380,
                DescEng =
                    "Performs difficult collection, organization, preservation, and dissemination tasks and records management in all formats. Creates new records on national or local database based on existing records. Performs and is responsible for more difficult database maintenance. Performs authority record creation and/or editing in local database.  Interprets and applies policy, or assists unit head in creating and developing local and national library policies and procedures.",
                DescFre =
                    "Performs difficult collection, organization, preservation, and dissemination tasks and records management in all formats. Creates new records on national or local database based on existing records. Performs and is responsible for more difficult database maintenance. Performs authority record creation and/or editing in local database.  Interprets and applies policy, or assists unit head in creating and developing local and national library policies and procedures."
            },
            new CompetencyLevelRequirement
            {
                Id = 381,
                DescEng =
                    "Plans, organizes, directs, controls, and evaluates the activities of a library or library system, archive or archive system, museum or art gallery or a technical department within such an institution in the Canadian Coast Guard. Performs standard collection of materials, filing, tracking, and cataloguing. Develops, promotes, and implements public relations and promotional programs. Conducts library information and orientation training programs and tours. Collects and compiles statistics. Codifies and classifies archival materiels and puts archival materiels on microfilm or in databases. Purges, sorts, reduces, and samples archives.",
                DescFre =
                    "Plans, organizes, directs, controls, and evaluates the activities of a library or library system, archive or archive system, museum or art gallery or a technical department within such an institution in the Canadian Coast Guard. Performs standard collection of materials, filing, tracking, and cataloguing. Develops, promotes, and implements public relations and promotional programs. Conducts library information and orientation training programs and tours. Collects and compiles statistics. Codifies and classifies archival materiels and puts archival materiels on microfilm or in databases. Purges, sorts, reduces, and samples archives."
            },
            new CompetencyLevelRequirement
            {
                Id = 382,
                DescEng =
                    "Basic knowledge of the structure of the human body and the function of organisms and their parts, conditions typically observed during a disease state. Understanding of concepts related to the diagnosis of psychopathology. Knowledge of how to access various pharmacology resource documentation.",
                DescFre =
                    "Connaissance de base de la structure du corps humain et de la fonction des organismes et de leurs parties, conditions typiques d'un état pathologique. Compréhension des concepts liés au diagnostic de la psychopathologie. Connaissance de la façon d'accéder à la documentation de diverses ressources pharmacologiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 383,
                DescEng =
                    "Limited knowledge of the structure of the human body and the function of organisms and their parts, physical and biological abnormalities occurring within the body as a result of disease, concepts related to the diagnosis of psychopathology, process to preform physical exams and obtaining medical/health histories, and how to access various pharmacology resource documentation.",
                DescFre =
                    "Connaissance limitée de la structure du corps humain et de la fonction des organismes et de leurs parties, des anomalies physiques et biologiques survenant dans le corps à la suite d'une maladie, des concepts liés au diagnostic de psychopathologie, du processus de préformation des examens physiques et de l'obtention des antécédents médicaux et sanitaires, et de l'accès à divers documents de pharmacologie."
            },
            new CompetencyLevelRequirement
            {
                Id = 384,
                DescEng =
                    "Practical knowledge of signs and symptoms that warrant further examination, ordering diagnostic tests, treating acute and chronic illnesses, managing medications, and managing general health care and disease prevention. Understanding of how drugs work, their sides effects and possible drug interactions. Knowledge of diseases that are caused by immune system dysfunction. Understands the interaction of nutrients related to food intake, absorption, assimilation, biosynthesis, catabolism, and excretion. Experience in providing primary and preventative care.",
                DescFre =
                    "Connaissance pratique des signes et des symptômes qui justifient un examen plus approfondi, la demande de tests diagnostiques, le traitement des maladies aiguës et chroniques, la gestion des médicaments, la gestion des soins de santé généraux et la prévention des maladies. Compréhension du fonctionnement des médicaments, de leurs effets secondaires et des interactions médicamenteuses possibles. Connaissance des maladies causées par un dysfonctionnement du système immunitaire. Comprend l'interaction des nutriments liés à l'ingestion, l'absorption, l'assimilation, la biosynthèse, le catabolisme et l'excrétion. Expérience dans la prestation de soins primaires et préventifs."
            },
            new CompetencyLevelRequirement
            {
                Id = 385,
                DescEng =
                    "Advanced knowledge in consultation with other healthcare providers, monitor patients, educate individuals, and family. Understanding of the coordination of timely nursing care for clients with various co-morbidities, complexity, and rapidly changing health statuses. Knowledge of providing care to clients with acute, chronic, and/or persistent health challenges (e.g. stroke, cardiovascular conditions, mental health and addiction, dementia, arthritis, diabetes). Advanced knowledge of workplace health and safety principles.",
                DescFre =
                    "Connaissances avancées en consultation avec d'autres fournisseurs de soins de santé, surveiller les patients, éduquer les individus et la famille. Compréhension de la coordination des soins infirmiers en temps opportun pour les clients ayant des comorbidités, des complexités et des états de santé qui changent rapidement. Connaissance de la prestation de soins aux clients ayant des problèmes de santé aigus, chroniques ou persistants (p. ex., accident vasculaire cérébral [AVC], maladies cardiovasculaires, santé mentale et toxicomanie, démence, arthrite, diabète). Connaissance approfondie des principes de santé et de sécurité au travail."
            },
            new CompetencyLevelRequirement
            {
                Id = 386,
                DescEng =
                    "Expert knowledge in emerging therapies and treatments, and the provision of acute care. Knowledge of diet formulation in relation to special needs situations. Knowledge of current, and the development of new policies and directives related to the health and welfare of members.",
                DescFre =
                    "Connaissances spécialisées dans les thérapies et les traitements émergents et dans la prestation de soins aigus. Connaissance de la formulation d'un régime alimentaire en relation avec des situations de besoins spéciaux. Connaissance des politiques et des directives actuelles et nouvelles en matière de santé et de bien-être des membres."
            },
            new CompetencyLevelRequirement
            {
                Id = 387,
                DescEng =
                    "Applies principles of population health to implement strategies that promote health and disease prevention (e.g. promoting hand washing, immunization, helmet safety etc.). Provides timely information or resources.",
                DescFre =
                    "Applies principles of population health to implement strategies that promote health and disease prevention (e.g. promoting hand washing, immunization, helmet safety etc.). Provides timely information or resources."
            },
            new CompetencyLevelRequirement
            {
                Id = 388,
                DescEng =
                    "Determines and implements preventive, therapeutic, and safety strategies based on ongoing client assessments, to prevent injury and the development of client complications. Proactively seeks and shares new information, knowledge and best practices for use in the provision of nursing care.",
                DescFre =
                    "Determines and implements preventive, therapeutic, and safety strategies based on ongoing client assessments, to prevent injury and the development of client complications. Proactively seeks and shares new information, knowledge and best practices for use in the provision of nursing care."
            },
            new CompetencyLevelRequirement
            {
                Id = 389,
                DescEng =
                    "Provides nursing care based on critical inquiry and evidence-informed decision making. Performs therapeutic interventions safely (e.g. positioning, skin, and wound care, management of intravenous therapy and drainage tubes, and psychosocial interaction). Implements safe and evidence-informed medication practices. Informs others on the progress or unpreventable delays related to the delivery of services.",
                DescFre =
                    "Provides nursing care based on critical inquiry and evidence-informed decision making. Performs therapeutic interventions safely (e.g. positioning, skin, and wound care, management of intravenous therapy and drainage tubes, and psychosocial interaction). Implements safe and evidence-informed medication practices. Informs others on the progress or unpreventable delays related to the delivery of services."
            },
            new CompetencyLevelRequirement
            {
                Id = 390,
                DescEng =
                    "Applies workplace health and safety principles, including bio-hazard prevention, and infection control practices, and appropriate protective devices when providing nursing care to prevent harm to clients, self, other health care workers and the public. Implements evidence-informed practices of pain prevention and pain management with clients while using pharmacological and non-pharmacological measures.",
                DescFre =
                    "Applies workplace health and safety principles, including bio-hazard prevention, and infection control practices, and appropriate protective devices when providing nursing care to prevent harm to clients, self, other health care workers and the public. Implements evidence-informed practices of pain prevention and pain management with clients while using pharmacological and non-pharmacological measures."
            },
            new CompetencyLevelRequirement
            {
                Id = 391,
                DescEng =
                    "Contributes to a culture that supports involvement in nursing or health care research through collaboration with others in conducting, participating in, and implementing research findings into practice. Exercises professional judgment when using organizational policies and procedures, or when practicing in the absence of organizational policies and procedures in relation to best practices. Continuously integrates quality improvement principles and activities into nursing practice.",
                DescFre =
                    "Contributes to a culture that supports involvement in nursing or health care research through collaboration with others in conducting, participating in, and implementing research findings into practice. Exercises professional judgment when using organizational policies and procedures, or when practicing in the absence of organizational policies and procedures in relation to best practices. Continuously integrates quality improvement principles and activities into nursing practice."
            },
            new CompetencyLevelRequirement
            {
                Id = 392,
                DescEng =
                    "Establishes and maintains appropriate professional boundaries with clients and the health care team, including the distinction between social interaction and therapeutic relationships.",
                DescFre =
                    "Establishes and maintains appropriate professional boundaries with clients and the health care team, including the distinction between social interaction and therapeutic relationships."
            },
            new CompetencyLevelRequirement
            {
                Id = 393,
                DescEng =
                    "Acts to minimize the potential influence of personal values, beliefs, and positional power on client assessment and care. Promotes a safe environment for clients, self, health care workers, and the public that addresses the unique needs of clients within the context of care.",
                DescFre =
                    "Acts to minimize the potential influence of personal values, beliefs, and positional power on client assessment and care. Promotes a safe environment for clients, self, health care workers, and the public that addresses the unique needs of clients within the context of care."
            },
            new CompetencyLevelRequirement
            {
                Id = 394,
                DescEng =
                    "Acts in a way that demonstrates the distinction between ethical responsibilities and legal obligations and their relevance when providing nursing care. Engages in relational practice through a variety of approaches that demonstrate caring behaviours appropriate for clients. Shows consideration for the spiritual and religious beliefs and practices of clients. Makes informed decisions  about clients' health care, and respects their decisions.",
                DescFre =
                    "Acts in a way that demonstrates the distinction between ethical responsibilities and legal obligations and their relevance when providing nursing care. Engages in relational practice through a variety of approaches that demonstrate caring behaviours appropriate for clients. Shows consideration for the spiritual and religious beliefs and practices of clients. Makes informed decisions  about clients' health care, and respects their decisions."
            },
            new CompetencyLevelRequirement
            {
                Id = 395,
                DescEng =
                    "Respects and preserves clients’ rights based on the values in the Canadian Nurses Association (CNA) Code of Ethics for registered nurses and an ethical framework. Respects the principles of informed consent as it applies in multiple contexts (e.g. consent for care, refusal of treatment, release of health information, and consent for participation in research). Employs an ethical reasoning and decision-making process to address ethical dilemmas and situations of ethical distress. Accepts and provides care for all clients, regardless of gender, age, health status, lifestyle, sexual orientation, beliefs, and health practices. Advocates for safe, competent, compassionate, and ethical care for clients or their representatives, especially when they are unable to advocate for themselves.",
                DescFre =
                    "Respects and preserves clients’ rights based on the values in the Canadian Nurses Association (CNA) Code of Ethics for registered nurses and an ethical framework. Respects the principles of informed consent as it applies in multiple contexts (e.g. consent for care, refusal of treatment, release of health information, and consent for participation in research). Employs an ethical reasoning and decision-making process to address ethical dilemmas and situations of ethical distress. Accepts and provides care for all clients, regardless of gender, age, health status, lifestyle, sexual orientation, beliefs, and health practices. Advocates for safe, competent, compassionate, and ethical care for clients or their representatives, especially when they are unable to advocate for themselves."
            },
            new CompetencyLevelRequirement
            {
                Id = 396,
                DescEng =
                    "Honours ethical responsibilities and legal obligations related to maintaining client privacy, confidentiality, and security in all forms of communication, including social media. Engages in relational practice and uses ethical principles with the health care team to maximize collaborative client care.",
                DescFre =
                    "Honours ethical responsibilities and legal obligations related to maintaining client privacy, confidentiality, and security in all forms of communication, including social media. Engages in relational practice and uses ethical principles with the health care team to maximize collaborative client care."
            },
            new CompetencyLevelRequirement
            {
                Id = 397, DescEng = "Forecasts inventory, orders materials, and monitors and audits inventory.",
                DescFre = "Forecasts inventory, orders materials, and monitors and audits inventory."
            },
            new CompetencyLevelRequirement
            {
                Id = 398,
                DescEng =
                    "Employs the basics of supply-chain management.  Works with production systems, lead and cycle time, change orders, bills of material, and work orders. Packages and distributes products including labeling product inventory tags and bar codes.",
                DescFre =
                    "Employs the basics of supply-chain management.  Works with production systems, lead and cycle time, change orders, bills of material, and work orders. Packages and distributes products including labeling product inventory tags and bar codes."
            },
            new CompetencyLevelRequirement
            {
                Id = 399,
                DescEng =
                    "Employs warehouse management systems. Applies transportation methods, customs rules and regulations, export control, and the completion of paperwork.",
                DescFre =
                    "Employs warehouse management systems. Applies transportation methods, customs rules and regulations, export control, and the completion of paperwork."
            },
            new CompetencyLevelRequirement
            {
                Id = 400,
                DescEng =
                    "Forecasts and plans resource needs. Employs E-business and direct shipments, automated materiel handling and distribution systems, and integrated supply chain information technology. Manages master scheduling and most paperwork.",
                DescFre =
                    "Forecasts and plans resource needs. Employs E-business and direct shipments, automated materiel handling and distribution systems, and integrated supply chain information technology. Manages master scheduling and most paperwork."
            },
            new CompetencyLevelRequirement
            {
                Id = 401,
                DescEng =
                    "Executes procurement operations from external supply sources. Prioritizes and sequences work. Executes plans and implements controls. Develops sharing and collaboration across the supply chain, with an eye to taxes and duties, shipping, freight, and legal aspects of customs and controls.  Maintains and protects the Canadian Coast Guard's intellectual property.",
                DescFre =
                    "Executes procurement operations from external supply sources. Prioritizes and sequences work. Executes plans and implements controls. Develops sharing and collaboration across the supply chain, with an eye to taxes and duties, shipping, freight, and legal aspects of customs and controls.  Maintains and protects the Canadian Coast Guard's intellectual property."
            },
            new CompetencyLevelRequirement {Id = 402, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 403, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 404, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 405,
                DescEng =
                    "Prepares subject material for presentation to students according to an approved curriculum. Teaches students using a systematic plan of lectures, discussions, audio-visual presentations, and sports, games, and exercise regimes. Evaluates progress, determines individual needs of students, and discusses results with students and officials. Prepares and implements remedial programs for students requiring extra help. Participates in staff meetings, educational conferences, and teacher training workshops.",
                DescFre =
                    "Préparer les sujets à présenter aux étudiants selon un programme d'études approuvé. Enseigne aux étudiants en utilisant un plan systématique de cours, de discussions, de présentations audiovisuelles, et de sports, de jeux et d'exercices. Évalue les progrès, détermine les besoins individuels des étudiants et discute des résultats avec les étudiants et les responsables. Prépare et met en œuvre des programmes de rattrapage pour les étudiants qui ont besoin d'une aide supplémentaire. Participe aux réunions du personnel, aux conférences éducatives et aux ateliers de formation des enseignants."
            },
            new CompetencyLevelRequirement
            {
                Id = 406,
                DescEng =
                    "Plans, organizes, directs, controls, and evaluates the operations of recreation, sports, and fitness programs, and services. Provides technical and professional advice on recreation, sports, and fitness matters. Prepares budget estimates and develops policies and procedures to implement programs. Organizes and administers national and regional training, coaching, officiating, and other programs associated with physical education programs at the Canadian Coast Guard.",
                DescFre =
                    "Planifie, organise, dirige, contrôle et évalue les activités des programmes et services de loisirs, de sport et de mise en forme. Fournit des conseils techniques et professionnels sur les questions de loisirs, de sports et de mise en forme. Prépare les prévisions budgétaires et élabore des politiques et des procédures pour la mise en œuvre des programmes. Organise et administre les programmes nationaux et régionaux de formation, d'entraînement, d'arbitrage et autres programmes associés aux programmes d'éducation physique de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement {Id = 407, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 408, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 409, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 410,
                DescEng =
                    "Performs pre-operational checks, start-up and shut-down, general operation, stopping, starting, turning, driving forward and in reverse, parking, operating around personnel. Selects and secures  loads, picks-up and places, stacks and restocks, loads and unloads, and works with lifting crew. Performs operational maintenance such as refueling,  recharging (where appropriate), troubleshooting, and basic repairs. Hauls and dumps materials and equipment.",
                DescFre =
                    "Performs pre-operational checks, start-up and shut-down, general operation, stopping, starting, turning, driving forward and in reverse, parking, operating around personnel. Selects and secures  loads, picks-up and places, stacks and restocks, loads and unloads, and works with lifting crew. Performs operational maintenance such as refueling,  recharging (where appropriate), troubleshooting, and basic repairs. Hauls and dumps materials and equipment."
            },
            new CompetencyLevelRequirement
            {
                Id = 411,
                DescEng =
                    "Supervises operational checks, loading protocols, stacking practices, confined space maneuvering, and maintenance efforts to ensure accuracy and safety. Provides training and scheduling for new forklift operators.",
                DescFre =
                    "Supervises operational checks, loading protocols, stacking practices, confined space maneuvering, and maintenance efforts to ensure accuracy and safety. Provides training and scheduling for new forklift operators."
            },
            new CompetencyLevelRequirement
            {
                Id = 412,
                DescEng = "Responds to basic information requests from principal lightkeepers and management.",
                DescFre = "Responds to basic information requests from principal lightkeepers and management."
            },
            new CompetencyLevelRequirement
            {
                Id = 413, DescEng = "Uses basic gear to observe and report local phenomena to the organization.",
                DescFre = "Uses basic gear to observe and report local phenomena to the organization."
            },
            new CompetencyLevelRequirement
            {
                Id = 414,
                DescEng =
                    "Selects appropriate collection equipment and methodology. Observes and reports on information within the maritime environment to forecast physical states like weather, ocean currents, or wave conditions. Offers on-site advice and support to internal stakeholders, when and where applicable.",
                DescFre =
                    "Selects appropriate collection equipment and methodology. Observes and reports on information within the maritime environment to forecast physical states like weather, ocean currents, or wave conditions. Offers on-site advice and support to internal stakeholders, when and where applicable."
            },
            new CompetencyLevelRequirement
            {
                Id = 415,
                DescEng =
                    "Provides the full range of observation and reporting services of local phenomena of all types. Develops and delivers training for lightkeepers. Predicts area weather and sea conditions based on past patterns.",
                DescFre =
                    "Provides the full range of observation and reporting services of local phenomena of all types. Develops and delivers training for lightkeepers. Predicts area weather and sea conditions based on past patterns."
            },
            new CompetencyLevelRequirement
            {
                Id = 416,
                DescEng =
                    "Reports on all aspects of lighthouse domain, including observed trends in meteorology, oceanography, and area shipping. Coordinates with others lightkeepers, managers, and boaters on area conditions. Provides options and suggestions to management on program improvement.",
                DescFre =
                    "Reports on all aspects of lighthouse domain, including observed trends in meteorology, oceanography, and area shipping. Coordinates with others lightkeepers, managers, and boaters on area conditions. Provides options and suggestions to management on program improvement."
            },
            new CompetencyLevelRequirement
            {
                Id = 417, DescEng = "Learns how to operate and maintain front line maintenance equipment.",
                DescFre = "Learns how to operate and maintain front line maintenance equipment."
            },
            new CompetencyLevelRequirement
            {
                Id = 418, DescEng = "Operates and maintains front line gear at light stations.",
                DescFre = "Operates and maintains front line gear at light stations."
            },
            new CompetencyLevelRequirement
            {
                Id = 419,
                DescEng =
                    "Operates and maintains mechanical and electrical equipment grounds, buildings, aerials, derricks, and equipment used to power light station equipment.",
                DescFre =
                    "Operates and maintains mechanical and electrical equipment grounds, buildings, aerials, derricks, and equipment used to power light station equipment."
            },
            new CompetencyLevelRequirement
            {
                Id = 420,
                DescEng =
                    "Operates and maintains all lighthouse equipment. Trains assistant lightkeepers in equipment operation and maintenance.",
                DescFre =
                    "Operates and maintains all lighthouse equipment. Trains assistant lightkeepers in equipment operation and maintenance."
            },
            new CompetencyLevelRequirement
            {
                Id = 421,
                DescEng =
                    "Makes recommendations for maintenance of lighthouse equipment to management. Trains other light keepers. Advises management on light keeping protocols and procedures.",
                DescFre =
                    "Makes recommendations for maintenance of lighthouse equipment to management. Trains other light keepers. Advises management on light keeping protocols and procedures."
            },
            new CompetencyLevelRequirement
            {
                Id = 422, DescEng = "Basic knowledge on the use of equipment relative to the immediate task.",
                DescFre =
                    "Connaissances de base de l’utilisation de l’équipement requis pour exécuter la tâche immédiate."
            },
            new CompetencyLevelRequirement
            {
                Id = 423,
                DescEng =
                    "Limited knowledge in using a range of operational equipment in a given area of expertise.",
                DescFre =
                    "Connaissance limitée de l’utilisation d’une gamme d’équipements opérationnels dans un domaine d’expertise donné."
            },
            new CompetencyLevelRequirement
            {
                Id = 424,
                DescEng =
                    "Practical knowledge of the full range of operational equipment provided to perform operational tasks that demonstrate and are linked to understanding and impacting the marine domain.",
                DescFre =
                    "Connaissance pratique de toute la gamme des équipements opérationnels fournis pour effectuer des tâches opérationnelles qui démontrent la compréhension du domaine maritime et qui ont une incidence sur le domaine maritime."
            },
            new CompetencyLevelRequirement
            {
                Id = 425,
                DescEng =
                    "Advanced knowledge in the use of various types of operational equipment and surveillance gear in an operations center and instructing others in its use.",
                DescFre =
                    "Connaissance avancée de l’utilisation de divers types d’équipements opérationnels et de matériel de surveillance dans un centre d’opérations et de la formation d’autres personnes sur cette utilisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 426,
                DescEng =
                    "Expert knowledge in all the operational and surveillance gear in an operations center, their range of characteristics, including the development of instructions and procedures. Expert knowledge of the troubleshooting, preventative and corrective maintenance procedures.",
                DescFre =
                    "Connaissance approfondie de tous les équipements opérationnels et équipements de surveillance d’un centre d’opérations, de leur gamme de caractéristiques, ce qui comprend l’élaboration d’instructions et de procédures. Connaissance approfondie des procédures de dépannage et d’entretien préventif et correctif."
            },
            new CompetencyLevelRequirement
            {
                Id = 427,
                DescEng =
                    "Selects the right tool for the job. Uses basic hand and portable power tools, and their attachments correctly. Inspect tools for defects before use. Keeps tools clean and dry, and stores them properly after each use.",
                DescFre =
                    "Selects the right tool for the job. Uses basic hand and portable power tools, and their attachments correctly. Inspect tools for defects before use. Keeps tools clean and dry, and stores them properly after each use."
            },
            new CompetencyLevelRequirement
            {
                Id = 428,
                DescEng =
                    "Operates pneumatic hammers, vibrators and tampers as directed. Performs basic maintenance such as sharpening and lubricating. Tags damaged and defective tools to be removed from service.",
                DescFre =
                    "Operates pneumatic hammers, vibrators and tampers as directed. Performs basic maintenance such as sharpening and lubricating. Tags damaged and defective tools to be removed from service."
            },
            new CompetencyLevelRequirement
            {
                Id = 429,
                DescEng =
                    "Uses precision tools for work that requires high accuracy of shape, dimension and precise tolerances. Calibrates precision machine tools for dynamic balance as required.",
                DescFre =
                    "Uses precision tools for work that requires high accuracy of shape, dimension and precise tolerances. Calibrates precision machine tools for dynamic balance as required."
            },
            new CompetencyLevelRequirement
            {
                Id = 430,
                DescEng =
                    "Oversees equipment maintenance, tool inventories and, keeps records. Trains others in the use and maintenance of tools.",
                DescFre =
                    "Oversees equipment maintenance, tool inventories and, keeps records. Trains others in the use and maintenance of tools."
            },
            new CompetencyLevelRequirement
            {
                Id = 431,
                DescEng =
                    "Defines and manages the maintenance and inspection program for tools in accordance with manufacturers recommendations.",
                DescFre =
                    "Defines and manages the maintenance and inspection program for tools in accordance with manufacturers recommendations."
            },
            new CompetencyLevelRequirement
            {
                Id = 432,
                DescEng =
                    "Applies workplace safety procedures including the proper use and inspection of personal protective equipment (PPE). Safely interacts with all welding systems, including equipment, supplies, tools, and power sources.",
                DescFre =
                    "Applique les procédures de sécurité sur le lieu de travail, y compris l'utilisation et l'inspection correctes des équipements de protection individuelle (EPI). Interagit en toute sécurité avec tous les systèmes de soudage, y compris l'équipement, les fournitures, les outils et les sources d'énergie."
            },
            new CompetencyLevelRequirement
            {
                Id = 433,
                DescEng =
                    "Identifies, selects, uses, and maintains basic welding tools and accessories. Identifies and stores electrodes and filler materials. Interprets welding symbols, abbreviations, and joint designs. Reads and interprets basic prints. Fabricates parts from a shop print using both standard and metric linear measurements. Employs basic shielded metal arc welding procedures.",
                DescFre =
                    "Identifie, sélectionne, utilise et entretient les outils et accessoires de soudure de base. Identifie et stocke les électrodes et les matériaux d'apport. Interprète les symboles de soudage, les abréviations et les dessins de joints. Lit et interprète les impressions de base. Fabrique des pièces à partir d'une impression d'atelier en utilisant des mesures linéaires standard et métriques. Emploie des procédures de base de soudage à l'arc métallique blindé."
            },
            new CompetencyLevelRequirement
            {
                Id = 434,
                DescEng =
                    "Makes layout of materials (e.g. plate, structural, and pipe fabrication). Prepares material for weld procedure specifications (welding procedures specifications). Identifies, selects, and sets up oxyfuel equipment (e.g. cylinders, regulators, flame cutting apparatus). Makes fillet and groove welds in all positions on carbon steel.",
                DescFre =
                    "Fait la disposition des matériaux (par exemple, fabrication de plaques, de structures et de tuyaux). Prépare les matériaux pour les spécifications des procédures de soudage (spécifications des procédures de soudage). Identifie, sélectionne et met en place l'équipement d'oxycombustion (par exemple, les cylindres, les régulateurs, les appareils d'oxycoupage). Effectue des soudures d'angle et des soudures en rainure dans toutes les positions sur l'acier au carbone."
            },
            new CompetencyLevelRequirement
            {
                Id = 435,
                DescEng =
                    "Creates shielded metal arc welds on carbon steel plates, gas metal arc welds on plates and structural members, flux cored arc welds, and gas tungsten arc welds consistent with industry and safety standards. Lays out and cuts materials using plasma arc cutting procedures. Manipulates material using carbon arc gouging consistent with industry and safety standards. Employs metallurgy concepts and skills in the welding laboratory. Inspects and test welds (non-destructive and destructive).",
                DescFre =
                    "Réalise des soudures à l'arc blindé sur des plaques d'acier au carbone, des soudures à l'arc sous gaz sur des plaques et des éléments de structure, des soudures à l'arc avec flux et des soudures à l'arc sous gaz tungstène, conformément aux normes industrielles et de sécurité. Découpe et pose de matériaux en utilisant des procédures de découpe au plasma. Manipule les matériaux en utilisant le gougeage à l'arc au carbone conformément aux normes industrielles et de sécurité. Emploie des concepts et des compétences métallurgiques dans le laboratoire de soudage. Inspecte et test les soudures (non destructives et destructives)."
            },
            new CompetencyLevelRequirement
            {
                Id = 436,
                DescEng =
                    "Advises and trains on use and maintenance of tools, equipment, material handling, and safety equipment. Directs tasks related to welding activities on work sites and the storage of welding equipment and supplies. Establishes quality control for the quality of welding.  Advises senior leadership and stakeholders on best practices, processes, and strategies.",
                DescFre =
                    "Conseille et forme sur l'utilisation et l'entretien des outils, des équipements, de la manutention et des équipements de sécurité. Dirige les tâches liées aux activités de soudage sur les sites de travail et au stockage du matériel et des fournitures de soudage. Établit le contrôle de la qualité du soudage. Conseille la haute direction et les parties prenantes sur les meilleures pratiques, les processus et les stratégies."
            },
            new CompetencyLevelRequirement
            {
                Id = 437, DescEng = "Basic knowledge of location and types of navigational aids in regions.",
                DescFre =
                    "Connaissance de base de l'emplacement et des types d'aides à la navigation dans les régions."
            },
            new CompetencyLevelRequirement
            {
                Id = 438,
                DescEng =
                    "Limited knowledge in supporting aids design and review regarding locations of aids, their operating characteristics, and maintenance scheduling.",
                DescFre =
                    "Connaissances limitées en matière de soutien à la conception et à l'examen des aides en ce qui a trait à leur emplacement, à leurs caractéristiques de fonctionnement et à leur calendrier d'entretien."
            },
            new CompetencyLevelRequirement
            {
                Id = 439,
                DescEng =
                    "Practical knowledge in the full range and type of all aids regionally and/or nationally, planning, and training functions in support of design review and scheduling maintenance with fleet partners.",
                DescFre =
                    "Connaissance pratique de la gamme complète et du type de toutes les fonctions d'aide à l'échelle régionale et/ou nationale, de planification et de formation à l'appui de l'examen de la conception et de l'établissement du calendrier de maintenance avec les partenaires de la flotte."
            },
            new CompetencyLevelRequirement
            {
                Id = 440,
                DescEng =
                    "Significant knowledge of all elements of the Aids to Navigation (AtoN) program, its operating and maintenance cost domain factors, horizon technologies, and training/consultation initiatives with local internal and external stakeholders.",
                DescFre =
                    "Connaissance approfondie de tous les éléments du programme des aides à la navigation (AtoN), de ses facteurs de coûts d'exploitation et d'entretien, des technologies de l'horizon et des initiatives de formation/consultation avec les intervenants locaux internes et externes."
            },
            new CompetencyLevelRequirement
            {
                Id = 441,
                DescEng =
                    "Excellent knowledge and awareness of all facets of the program and its relations internally and externally. Routinely provides insights to managers and stakeholders in advisory groups and with the media, First Nations, other government departments, industry, and the military.",
                DescFre =
                    "Excellente connaissance et conscience de toutes les facettes du programme et de ses relations à l'interne et à l'externe. Fournit régulièrement de l'information aux gestionnaires et aux intervenants des groupes consultatifs ainsi qu'aux médias, aux Premières nations, aux autres ministères, à l'industrie et à l'armée."
            },
            new CompetencyLevelRequirement
            {
                Id = 442,
                DescEng =
                    "Performs routine electrical and/or electronic maintenance. Conducts analysis based on standardized flowchart.",
                DescFre =
                    "Effectuer l’entretien électrique et/ou électronique de routine. Effectue l’analyse en s’appuyant sur un organigramme normalisé."
            },
            new CompetencyLevelRequirement
            {
                Id = 443,
                DescEng =
                    "Recommends approaches on routine technical work, designs, and engineering change proposals (ECP) to meet desired compliance with electrical engineering principles, standards, codes, designs, and statutes, when and where applicable.",
                DescFre =
                    "Recommander des approches concernant les travaux techniques de routine, les conceptions et les propositions de modifications techniques (PMT) afin d’atteindre la conformité souhaitée avec les principes, les normes, les codes, les conceptions et les lois du génie électrique, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 444,
                DescEng =
                    "Makes decisions on non-routine and/or program matters requiring electrical and/or electronic technical expertise. Provides technical analysis. Mentors lower level members in the area of assignment. Reviews stock replenishment requisitions to ensure the items in current use and quantities ordered are realistic.",
                DescFre =
                    "Prendre des décisions sur des questions non routinières et/ou des questions relatives aux programmes qui nécessitent une expertise technique en électrique ou en électronique. Fournir une analyse technique. Encadrer les membres subalternes dans le secteur d’affectation. Examiner les demandes de réapprovisionnement des stocks pour s’assurer que les articles en cours d’utilisation et les quantités commandées sont réalistes."
            },
            new CompetencyLevelRequirement
            {
                Id = 445,
                DescEng =
                    "Approves complex or new electrical engineering/technical designs and/or project/program specifications to meet desired compliance with principles, standards, codes, designs, and statutes. Addresses conflicting design constraints, when and where applicable.",
                DescFre =
                    "Approuver les conceptions techniques ou d’ingénierie électrique complexes ou nouvelles et/ou les spécifications de projets/programmes pour répondre à la conformité souhaitée aux principes, normes, codes, conceptions et lois. Aborder des contraintes de conception conflictuelles, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 446,
                DescEng =
                    "Approves final proposals for large scale electrical engineering and/or program areas. Represents the Canadian Coast Guard as an expert in electrical review and design.",
                DescFre =
                    "Approuver les propositions finales de grands projets de génie électrique ou de domaines de programme. Représenter la Garde côtière canadienne en tant qu’expert en matière d’examen et de conception électrique."
            },
            new CompetencyLevelRequirement
            {
                Id = 447,
                DescEng =
                    "Basic knowledge of radio frequency system and components that enables the propagation of radio waves.",
                DescFre =
                    "Connaissance de base du système de radiofréquence et des composants qui permettent la propagation des ondes radio."
            },
            new CompetencyLevelRequirement
            {
                Id = 448,
                DescEng =
                    "Limited knowledge of radio waves attributes such as amplitudes with units of watts, phases, modulations, spread spectrum. Knowledge of antenna parameters including desired frequency, gain, bandwidth, impedance, and polarization.",
                DescFre =
                    "Connaissance limitée des attributs des ondes radio telles que les amplitudes avec les unités de watts, les phases, les modulations, le spectre étalé. Connaissance des paramètres de l’antenne, notamment la fréquence désirée, le facteur d’amplification, la largeur de bande, l’impédance et la polarisation souhaités."
            },
            new CompetencyLevelRequirement
            {
                Id = 449,
                DescEng =
                    "Practical knowledge of radio waves attributes such as waveforms (continuous range of frequencies) and alteration of attributes output/input by orthogonal frequency-division multiplexing, amplitude-shift keying, frequency-shift keying, phase-shift keying, quadrature amplitude modulation. Knowledge of what affects propagation of radio waves and process to select the appropriate propagation model necessary.",
                DescFre =
                    "Connaissance pratique des attributs des ondes radio tels que les formes d’onde (gamme continue de fréquences) et la modification des attributs sortie/entrée par multiplexage orthogonal par répartition en fréquence, la modulation par déplacement d’amplitude, la modulation par déplacement de fréquence, la modulation par déplacement de phase et la modulation d’amplitude en quadrature. Connaissance des éléments qui ont une incidence sur la propagation des ondes radio et du processus de sélection du modèle de propagation qui convient."
            },
            new CompetencyLevelRequirement
            {
                Id = 450,
                DescEng =
                    "Advanced knowledge of losses and dispersion features of radio waves and main compensation scheme including fast fading, signal fading, extension of radio waves delay, diffraction loss and penetration loss. Advanced knowledge in testing transmitting platform including the transmitting antenna, feeder, high-frequency signal source, and antenna support as well as the receiving subsystem including the test receiver, global positioning system (GPS) receiver, test software, and portable computer.",
                DescFre =
                    "Connaissance avancée des pertes et des caractéristiques de dispersion des ondes radio et du principal système de compensation, notamment l’évanouissement rapide, l’évanouissement du signal, l’extension du retard des ondes radio, la perte par diffraction et la perte par pénétration. Connaissances avancées en matière de mise à l’essai de la plateforme de transmission, y compris l’antenne de transmission, la ligne d’alimentation, la source de signal haute fréquence et le support d’antenne, ainsi que du sous-système de réception, y compris le récepteur d’essai, le récepteur du système de mondial de localisation (GPS), le logiciel d’essai et l’ordinateur portatif."
            },
            new CompetencyLevelRequirement
            {
                Id = 451,
                DescEng =
                    "Expert knowledge in major electrical and mechanical specifications of antenna and selection of antenna pattern. Knowledge of processes resolution strategies to complex problems not readily solved by other means. Intricate knowledge of emerging network technology.",
                DescFre =
                    "Connaissance approfondie des principales spécifications électriques et mécaniques de l’antenne et de la sélection du diagramme de rayonnement de l’antenne. Connaissance des stratégies de résolution de processus à des problèmes complexes qui ne sont pas facilement résolus par d’autres moyens. Connaissance complexe de la technologie des réseaux émergents."
            },
            new CompetencyLevelRequirement {Id = 452, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 453, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 454, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 455,
                DescEng =
                    "Interprets drawings, blueprints, schematics and electrical code specifications to determine the layout of industrial electrical equipment installations. Installs, examines, replaces, or repairs electrical wiring, receptacles, switch boxes, conduits, feeders, fibre-optic and coaxial cable assemblies, lighting fixtures and other electrical components. Tests electrical and electronic equipment and components for continuity, current, voltage, and resistance. Maintains, repairs, tests, and installs electrical motors, generators, alternators, industrial storage batteries, and hydraulic and pneumatic electrical control systems. Troubleshoots, maintains, and repairs industrial, electrical, and electronic control systems and other related devices.",
                DescFre =
                    "Interprets drawings, blueprints, schematics and electrical code specifications to determine the layout of industrial electrical equipment installations. Installs, examines, replaces, or repairs electrical wiring, receptacles, switch boxes, conduits, feeders, fibre-optic and coaxial cable assemblies, lighting fixtures and other electrical components. Tests electrical and electronic equipment and components for continuity, current, voltage, and resistance. Maintains, repairs, tests, and installs electrical motors, generators, alternators, industrial storage batteries, and hydraulic and pneumatic electrical control systems. Troubleshoots, maintains, and repairs industrial, electrical, and electronic control systems and other related devices."
            },
            new CompetencyLevelRequirement
            {
                Id = 456,
                DescEng =
                    "Directs the electrical maintenance activities and managing work assignments. Inspects and reports on work performed. Recommends updating maintenance guidelines, procedures, standard work orders, preventative maintenance tasks, materials, parts, and labor estimates. Collaborates in the development and validation of maintenance procedures.",
                DescFre =
                    "Directs the electrical maintenance activities and managing work assignments. Inspects and reports on work performed. Recommends updating maintenance guidelines, procedures, standard work orders, preventative maintenance tasks, materials, parts, and labor estimates. Collaborates in the development and validation of maintenance procedures."
            },
            new CompetencyLevelRequirement
            {
                Id = 457,
                DescEng =
                    "Performs pre-start checks, starts and stops equipment in automatic, semi-automatic and manual modes. Adjusts temperature controls as required. Monitors equipment to ensure operation within established parameters.",
                DescFre =
                    "Performs pre-start checks, starts and stops equipment in automatic, semi-automatic and manual modes. Adjusts temperature controls as required. Monitors equipment to ensure operation within established parameters."
            },
            new CompetencyLevelRequirement
            {
                Id = 458,
                DescEng =
                    "Performs preventative maintenance on climate-control systems by following a checklist of parts and operations that need to be tested such as compressors, condensers, electrical connections and motor operations.",
                DescFre =
                    "Performs preventative maintenance on climate-control systems by following a checklist of parts and operations that need to be tested such as compressors, condensers, electrical connections and motor operations."
            },
            new CompetencyLevelRequirement
            {
                Id = 459,
                DescEng =
                    "Diagnoses malfunctions and defects in equipment by applying troubleshooting methods. Replaces parts and runs tests to ensure the systems is working properly following repairs. Recharges systems with refrigerant, checks and test regulators and, calibrates systems.",
                DescFre =
                    "Diagnoses malfunctions and defects in equipment by applying troubleshooting methods. Replaces parts and runs tests to ensure the systems is working properly following repairs. Recharges systems with refrigerant, checks and test regulators and, calibrates systems."
            },
            new CompetencyLevelRequirement
            {
                Id = 460,
                DescEng =
                    "Assembles and installs climate-control systems including components such as motors, controls, gauges, valves, circulating pumps, condensers, humidifiers, evaporators and compressors. Reads and interprets blueprints, drawings and sketches to determine specifications and calculate requirements.",
                DescFre =
                    "Assembles and installs climate-control systems including components such as motors, controls, gauges, valves, circulating pumps, condensers, humidifiers, evaporators and compressors. Reads and interprets blueprints, drawings and sketches to determine specifications and calculate requirements."
            },
            new CompetencyLevelRequirement
            {
                Id = 461,
                DescEng =
                    "Upgrades systems to satisfy new regulations or meet new standards. Reviews designs and makes recommendations for considerations such as optimal temperature control and energy efficienty.",
                DescFre =
                    "Upgrades systems to satisfy new regulations or meet new standards. Reviews designs and makes recommendations for considerations such as optimal temperature control and energy efficienty."
            },
            new CompetencyLevelRequirement
            {
                Id = 462,
                DescEng =
                    "Prepares reports, plans, and forecasts. Liaises with managers to understand and develop explanations that ensures alignment of the Canadian Coast Guard's workforce with the government’s priorities, and the organization’s mission, strategic plan, and budgetary resources.",
                DescFre =
                    "Prépare des rapports, des plans et des prévisions. Assurer la liaison avec les gestionnaires pour comprendre et élaborer des explications qui permettent d'aligner l'effectif de la Garde côtière canadienne sur les priorités du gouvernement, ainsi que sur la mission, le plan stratégique et les ressources budgétaires de l'organisation."
            },
            new CompetencyLevelRequirement
            {
                Id = 463,
                DescEng =
                    "Develops specialized reports. Explains program variances and implications. Analyzes operational performance and evaluates alternative outcomes of business strategies. Identifies the critical points in the Government of Canada's budget planning cycle and how they are used to devise strategy for the Coast Guard.",
                DescFre =
                    "Élabore des rapports spécialisés. Explique les écarts et les implications des programmes. Analyse les performances opérationnelles et évalue les résultats alternatifs des stratégies opérationnelles. Identifie les points critiques du cycle de planification budgétaire du gouvernement du Canada et la façon dont ils sont utilisés pour concevoir la stratégie de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 464,
                DescEng =
                    "Builds and presents new analytical approaches. Analyzes financial implications of policy, program, and project proposals, and alternative strategies. Researches and prepares the groundwork for partnering agreements. Determines expenditure and cost requirements based on the three parliamentary supply periods, the main estimates, and the supplementary estimates process.",
                DescFre =
                    "Construit et présente de nouvelles approches analytiques. Analyse les implications financières des propositions de politiques, de programmes et de projets, ainsi que des stratégies alternatives. Effectue des recherches et prépare le terrain pour des accords de partenariat. Détermine les dépenses et les coûts nécessaires en fonction des trois périodes de crédits parlementaires, des prévisions budgétaires principales et du processus des prévisions supplémentaires."
            },
            new CompetencyLevelRequirement
            {
                Id = 465,
                DescEng =
                    "Assesses budgets and ensures alignment with the organization’s goals. Plays a challenge role in assessing the financial implications of program and project proposals and the quality of related financial information. Compiles data and recommendations of current supply and expenditure and future needs based on program requirements within the Coast Guard.",
                DescFre =
                    "Évalue les budgets et s'assure qu'ils sont conformes aux objectifs de l'organisation. Joue un rôle de défi en évaluant les implications financières des propositions de programmes et de projets et la qualité des informations financières qui s'y rapportent. Compile des données et des recommandations sur l'offre et les dépenses actuelles et les besoins futurs en fonction des exigences des programmes au sein de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 466,
                DescEng =
                    "Advises on, and implements, government-wide standards for control to promote a sound management framework. Guides, advises, and makes recommendations to senior management on expenditure results and future needs based on the government's expenditure plan and budgetary allocations.",
                DescFre =
                    "Conseille et met en œuvre des normes de contrôle à l'échelle du gouvernement afin de promouvoir un cadre de gestion saine. Guide, conseille et fait des recommandations à la haute direction sur les résultats des dépenses et les besoins futurs en fonction du plan de dépenses et des allocations budgétaires du gouvernement."
            },
            new CompetencyLevelRequirement
            {
                Id = 467,
                DescEng =
                    "Identifies and applies relevant cost accounting techniques (e.g. activity-based costing).",
                DescFre =
                    "Identifie et applique les techniques de comptabilité analytique pertinentes (par exemple, la comptabilité par activités)."
            },
            new CompetencyLevelRequirement
            {
                Id = 468,
                DescEng =
                    "Develops cost-accounting techniques to specifically address departmental/organizational needs. Applies generally accepted accounting principles, including accrual accounting and the financial information strategy.",
                DescFre =
                    "Développe des techniques de comptabilité analytique pour répondre spécifiquement aux besoins des départements et des organisations. Applique les principes comptables généralement reconnus, y compris la comptabilité d'exercice et la stratégie d'information financière."
            },
            new CompetencyLevelRequirement
            {
                Id = 469,
                DescEng =
                    "Participates with senior management in strategic decision-making as a result of cost-accounting information.",
                DescFre =
                    "Participe avec la haute direction à la prise de décisions stratégiques grâce aux informations de la comptabilité analytique."
            },
            new CompetencyLevelRequirement
            {
                Id = 470,
                DescEng =
                    "Accounts for expenditures (e.g. line objects, standard objects for sound expenditure management). Presents and discusses applicability of, and arguments for and against, alternative accounting principles.",
                DescFre =
                    "Comptabilise les dépenses (par exemple, les articles d'exécution, les articles standard pour la bonne gestion des dépenses). Présente et examine l'applicabilité de principes comptables alternatifs et les arguments pour et contre ceux-ci."
            },
            new CompetencyLevelRequirement
            {
                Id = 471,
                DescEng =
                    "Provides information and advice in the development of expenditure reports (within department, Parliament and Public Accounts). Anticipates the effect of new accounting principles on the organization and assists in the transition. Represents the Canadian Coast Guard to the Chief Financial Officer at Fisheries and Oceans Canada (DFO), the Auditor General, Public Accounts, Treasury Board, etc.",
                DescFre =
                    "Fournit des informations et des conseils pour l'élaboration des rapports de dépenses (au sein du ministère, du Parlement et des comptes publics). Anticipe l'effet des nouveaux principes comptables sur l'organisation et aide à la transition. Représente la Garde côtière canadienne auprès du dirigeant principal des finances de Pêches et Océans Canada (MPO), du vérificateur général, des comptes publics, du Conseil du Trésor, etc."
            },
            new CompetencyLevelRequirement {Id = 472, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 473, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 474, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 475,
                DescEng =
                    "Participates in relationship building exercises. Researches community interests, Government of Canada policies on Indigenous relations. Records inputs. Maintains open communication lines with the bands. Provides recommendation on strategic approaches. Liaises with Canadian Coast Guard programs.",
                DescFre =
                    "Participe à des exercices de renforcement des relations. Effectue des recherches sur les intérêts des communautés et sur les politiques du gouvernement du Canada en matière de relations avec les Autochtones. Enregistre les contributions. Entretient des lignes de communication ouvertes avec les bandes. Fournir des recommandations sur les approches stratégiques. Assure la liaison avec les programmes de la Garde côtière canadienne."
            },
            new CompetencyLevelRequirement
            {
                Id = 476,
                DescEng =
                    "Establishes relations with all concerned bands on a given agenda. Clarifies community interest. Develops strategies that provide interest based outcomes and consistencies of approach, by considering all inputs over time and communicating clearly. Monitors and clarifies consultation specificities and sensitivities between Indigenous bands and Canadian Coast Guard programs and initiatives. Follows up on negotiated deliverables with the overall goal to establish lasting trust. Provides key information on Indigenous files to management.",
                DescFre =
                    "Etablit des relations avec tous les groupes concernés sur un agenda donné. Clarifie les intérêts de la communauté. Développe des stratégies qui fournissent des résultats basés sur les intérêts et une approche cohérente, en considérant tous les apports au fil du temps et en communiquant clairement. Surveille et clarifie les spécificités et les sensibilités des consultations entre les bandes autochtones et les programmes et initiatives de la Garde côtière canadienne. Assure le suivi des résultats négociés dans le but général d'établir une confiance durable. Fournit des informations clés sur les dossiers autochtones à la direction."
            },
            new CompetencyLevelRequirement {Id = 477, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 478, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement {Id = 479, DescEng = "N/A", DescFre = "N/A"},
            new CompetencyLevelRequirement
            {
                Id = 480,
                DescEng =
                    "Inspects and evaluates quality assurance systems, processes, equipment, products, materials, and associated components including electronic equipment used in shipbuilding trade measurement. Recommends enforcement of statutes, regulations, standards, specifications, or quality assurance policies, procedures and techniques. Investigates accidents, defects, and/or disputes.",
                DescFre =
                    "Inspects and evaluates quality assurance systems, processes, equipment, products, materials, and associated components including electronic equipment used in shipbuilding trade measurement. Recommends enforcement of statutes, regulations, standards, specifications, or quality assurance policies, procedures and techniques. Investigates accidents, defects, and/or disputes."
            },
            new CompetencyLevelRequirement
            {
                Id = 481,
                DescEng =
                    "Writes standards, specifications, procedures, or manuals related to inspection and evaluation of shipbuilding activities. Liaises with shipbuilding representatives on enforcing inspection items, defects, and deficiencies and offers recommendations for improvement. Plans, develops, and conducts training in these activities.",
                DescFre =
                    "Writes standards, specifications, procedures, or manuals related to inspection and evaluation of shipbuilding activities. Liaises with shipbuilding representatives on enforcing inspection items, defects, and deficiencies and offers recommendations for improvement. Plans, develops, and conducts training in these activities."
            },
            new CompetencyLevelRequirement
            {
                Id = 482,
                DescEng =
                    "Basic knowledge of the Vessels of Concern Program area and how it is a part of the Oceans Protection Plan (OPP) mandate, based on training.",
                DescFre =
                    "Basic knowledge of the Vessels of Concern Program area and how it is a part of the Oceans Protection Plan (OPP) mandate, based on training."
            },
            new CompetencyLevelRequirement
            {
                Id = 483,
                DescEng =
                    "Knowledge of the elements within the Vessels of Concern program area. Knowledge of DFO’s Small Craft Harbours Abandoned and Wrecked Vessels Removal Program and some of the stakeholders to be consulted prior to decisions being made. Knowledge of the different roles and responsibilities of the DFO, Transport Canada, and Coast Guard in the implementation of the Vessels of Concern Program. Awareness of the established enforcement regime. Knowledge of the program issues and challenges related to the hundreds of problem vessels in Canadian waters.",
                DescFre =
                    "Knowledge of the elements within the Vessels of Concern program area. Knowledge of DFO’s Small Craft Harbours Abandoned and Wrecked Vessels Removal Program and some of the stakeholders to be consulted prior to decisions being made. Knowledge of the different roles and responsibilities of the DFO, Transport Canada, and Coast Guard in the implementation of the Vessels of Concern Program. Awareness of the established enforcement regime. Knowledge of the program issues and challenges related to the hundreds of problem vessels in Canadian waters."
            },
            new CompetencyLevelRequirement
            {
                Id = 484,
                DescEng =
                    "Practical knowledge of the Inventory and Assessments of Vessels of Concern, the Abandoned Boats Program, and the Small Craft Harbours Abandoned and Wrecked Vessels Removal Program. Knowledge of key internal partners, to be consulted with prior to decisions being taken. Detailed knowledge of the process for the removal of dilapidated vessels left on property for which DFO/CCG are responsible and actions to be taken directly. Detailed knowledge of the established enforcement regime that authorizes the monetary penalties, creates regulatory offences (summary convictions and indictments), and sets out a penalty regime to deter non-compliance.",
                DescFre =
                    "Practical knowledge of the Inventory and Assessments of Vessels of Concern, the Abandoned Boats Program, and the Small Craft Harbours Abandoned and Wrecked Vessels Removal Program. Knowledge of key internal partners, to be consulted with prior to decisions being taken. Detailed knowledge of the process for the removal of dilapidated vessels left on property for which DFO/CCG are responsible and actions to be taken directly. Detailed knowledge of the established enforcement regime that authorizes the monetary penalties, creates regulatory offences (summary convictions and indictments), and sets out a penalty regime to deter non-compliance."
            },
            new CompetencyLevelRequirement
            {
                Id = 485,
                DescEng =
                    "Advanced knowledge of all internal and external stakeholders involved in the decision and resolution processes related to Vessels of Concern. In-depth knowledge of coastal and shoreline communities. In-depth awareness on the offenses and punishments possible and impacts related to offense enforcement in relation to the Vessels of Concern Program. Familiarity with the program employed within Federal and State jurisdictions within the United States and how they may be leveraged for program needs.",
                DescFre =
                    "Advanced knowledge of all internal and external stakeholders involved in the decision and resolution processes related to Vessels of Concern. In-depth knowledge of coastal and shoreline communities. In-depth awareness on the offenses and punishments possible and impacts related to offense enforcement in relation to the Vessels of Concern Program. Familiarity with the program employed within Federal and State jurisdictions within the United States and how they may be leveraged for program needs."
            },
            new CompetencyLevelRequirement
            {
                Id = 486,
                DescEng =
                    "Expert knowledge of the Inventory and Assessments of Vessels of Concern, the Abandoned Boats Program, and the Small Craft Harbours Abandoned and Wrecked Vessels Removal Program. Extensive knowledge of the duty to consult stipulations per legislation.",
                DescFre =
                    "Expert knowledge of the Inventory and Assessments of Vessels of Concern, the Abandoned Boats Program, and the Small Craft Harbours Abandoned and Wrecked Vessels Removal Program. Extensive knowledge of the duty to consult stipulations per legislation."
            },
            new CompetencyLevelRequirement
            {
                Id = 487,
                DescEng =
                    "Provides SITREPS on icebreakers’ position. Understand the established and applicable operational procedures within IB. Applies knowledge of basic computer software and hardware in a productive way. Understands charts and maps, and knows their specific characteristics.",
                DescFre =
                    "Provides SITREPS on icebreakers’ position. Understand the established and applicable operational procedures within IB. Applies knowledge of basic computer software and hardware in a productive way. Understands charts and maps, and knows their specific characteristics."
            },
            new CompetencyLevelRequirement
            {
                Id = 488,
                DescEng =
                    "Follows transit of vessels through ice within AOR. Calculates AIRSS data. Monitors ice conditions using ice charts. Receives icebreakers assistance requests directly from ships owners, ship operators or by MCTS. Uses IODIS as required. Receives requests for ice routing from VTS and ships; asks for all necessary information in order to action them, consolidates it in a standardized way and forwards the requests to the ISS. Uses appropriate email templates for ship’s tasking’s. Prepares the daily SitRep of CCG assets’ location for internal partners. General understanding the ice Egg code.",
                DescFre =
                    "Follows transit of vessels through ice within AOR. Calculates AIRSS data. Monitors ice conditions using ice charts. Receives icebreakers assistance requests directly from ships owners, ship operators or by MCTS. Uses IODIS as required. Receives requests for ice routing from VTS and ships; asks for all necessary information in order to action them, consolidates it in a standardized way and forwards the requests to the ISS. Uses appropriate email templates for ship’s tasking’s. Prepares the daily SitRep of CCG assets’ location for internal partners. General understanding the ice Egg code."
            },
            new CompetencyLevelRequirement
            {
                Id = 489,
                DescEng =
                    "Monitors progress and behaviour of vessels in ice in order to detect problematic situations. Assesses effectiveness of response. Uses appropriate software (such as Exact Earth) to track ships and verify if following given ice routing. Verifies the validity of received AIRSS data from ship by comparing to own calculation. Tasks CCG icebreakers through ROC. Monitors ice conditions using a variety of tools (satellite pictures, ship messages, overflights, etc.). Prepares and delivers written tasking’s to icebreakers, through ROC. Verifies the navigational safety aspect of the general ice route produced by the ISS. Coordinates requests for specific ice routing with ISS, verifies safety, and delivers information directly to ship or through MCTS. Fills required information in IODIS system when initiating ice tasking’s for CCG ships. Answers clients and stakeholders questions, by phone or email. Applies knowledge of reporting systems (such as IODIS), mapping systems (such as INNAV and Exact Earth) and other related software in daily operations.",
                DescFre =
                    "Monitors progress and behaviour of vessels in ice in order to detect problematic situations. Assesses effectiveness of response. Uses appropriate software (such as Exact Earth) to track ships and verify if following given ice routing. Verifies the validity of received AIRSS data from ship by comparing to own calculation. Tasks CCG icebreakers through ROC. Monitors ice conditions using a variety of tools (satellite pictures, ship messages, overflights, etc.). Prepares and delivers written tasking’s to icebreakers, through ROC. Verifies the navigational safety aspect of the general ice route produced by the ISS. Coordinates requests for specific ice routing with ISS, verifies safety, and delivers information directly to ship or through MCTS. Fills required information in IODIS system when initiating ice tasking’s for CCG ships. Answers clients and stakeholders questions, by phone or email. Applies knowledge of reporting systems (such as IODIS), mapping systems (such as INNAV and Exact Earth) and other related software in daily operations."
            },
            new CompetencyLevelRequirement
            {
                Id = 490,
                DescEng =
                    "Monitors for changes in ice conditions, weather and other environmental factors, and liaises with EC ISS appropriately, in order to detect potential problems well in advance. Initiates the issuance of the NOTSHIPs as required for Ice control zone. Creates seasonal, periodic and post-incidents report for internal partner and/or industry. Is able to develop alternate or new strategies that may fall outside SOPs in order to resolve a situation. Has detailed knowledge of AOR characteristics which play a role in IB operations or influence the outcome of the program. Identifies new possibilities /capabilities to improve the existing systems and practices. Evaluates impacts of changes to regulations, orders and standards on work practices. Provides departmental interpretation of key IB legislation, orders and standards to personnel, partners, and clients.",
                DescFre =
                    "Monitors for changes in ice conditions, weather and other environmental factors, and liaises with EC ISS appropriately, in order to detect potential problems well in advance. Initiates the issuance of the NOTSHIPs as required for Ice control zone. Creates seasonal, periodic and post-incidents report for internal partner and/or industry. Is able to develop alternate or new strategies that may fall outside SOPs in order to resolve a situation. Has detailed knowledge of AOR characteristics which play a role in IB operations or influence the outcome of the program. Identifies new possibilities /capabilities to improve the existing systems and practices. Evaluates impacts of changes to regulations, orders and standards on work practices. Provides departmental interpretation of key IB legislation, orders and standards to personnel, partners, and clients."
            },
            new CompetencyLevelRequirement
            {
                Id = 491,
                DescEng =
                    "Implements new possibilities /capabilities to improve the existing systems and practices. Reviews and creates SOPs. Provides official advice regarding regulation for the department. Provides recommendations to legislative texts.",
                DescFre =
                    "Implements new possibilities /capabilities to improve the existing systems and practices. Reviews and creates SOPs. Provides official advice regarding regulation for the department. Provides recommendations to legislative texts."
            },
            new CompetencyLevelRequirement
            {
                Id = 492,
                DescEng =
                    "Maintains an ongoing Inventory and Assessments  of wrecked and abandoned vessels, including updated risk assessments to help prioritize future actions on high risk vessels.",
                DescFre =
                    "Maintains an ongoing Inventory and Assessments  of wrecked and abandoned vessels, including updated risk assessments to help prioritize future actions on high risk vessels."
            },
            new CompetencyLevelRequirement
            {
                Id = 493,
                DescEng =
                    "Responds to area queries about and reports of wrecked and abandoned vessels. Establishes contacts with other government departments and the public. Participates in exercises. Conducts some site investigations.",
                DescFre =
                    "Responds to area queries about and reports of wrecked and abandoned vessels. Establishes contacts with other government departments and the public. Participates in exercises. Conducts some site investigations."
            },
            new CompetencyLevelRequirement
            {
                Id = 494,
                DescEng =
                    "Conducts in-depth investigations of regional reports of wrecked and abandoned vessels, including, where possible, contacting vessel owners and logging all information. Liaises with operational stakeholders where necessary. Drafts reports and recommendations.",
                DescFre =
                    "Conducts in-depth investigations of regional reports of wrecked and abandoned vessels, including, where possible, contacting vessel owners and logging all information. Liaises with operational stakeholders where necessary. Drafts reports and recommendations."
            },
            new CompetencyLevelRequirement
            {
                Id = 495,
                DescEng =
                    "Conducts risk assessments and reports on investigative findings and trends, regionally and/or nationally. Improves and increases contact with coastal communities with respect to vessels of concern. Educates on the offences and punishments associated with wrecked and abandoned vessels and the roles of government departments and the Coast Guard.",
                DescFre =
                    "Conducts risk assessments and reports on investigative findings and trends, regionally and/or nationally. Improves and increases contact with coastal communities with respect to vessels of concern. Educates on the offences and punishments associated with wrecked and abandoned vessels and the roles of government departments and the Coast Guard."
            },
            new CompetencyLevelRequirement
            {
                Id = 496,
                DescEng =
                    "Advises internal and external stakeholders, including the private sector(s), on how the program is to be advanced with knowledge of financial and personnel resources allocation. Champions the program nationally with the public and senior management. Recommends mandate or scope changes.",
                DescFre =
                    "Advises internal and external stakeholders, including the private sector(s), on how the program is to be advanced with knowledge of financial and personnel resources allocation. Champions the program nationally with the public and senior management. Recommends mandate or scope changes."
            },
            new CompetencyLevelRequirement
            {
                Id = 497,
                DescEng =
                    "Conducts daily media monitoring and coverage analysis. Provides administrative support services. Offers logistical support for media events and interviews.",
                DescFre =
                    "Conducts daily media monitoring and coverage analysis. Provides administrative support services. Offers logistical support for media events and interviews."
            },
            new CompetencyLevelRequirement
            {
                Id = 498,
                DescEng =
                    "Familiar with the Government of Canada Communications Policy. Can write or edit a broad range of communications products. Supports websites. Provides advice and recommendations to clients. Assists in the development and/or implementation of communications products. Contributes to implementation of communication plans or projects in the digital environment. Uses social media to communicate on the web in a government context.",
                DescFre =
                    "Familiar with the Government of Canada Communications Policy. Can write or edit a broad range of communications products. Supports websites. Provides advice and recommendations to clients. Assists in the development and/or implementation of communications products. Contributes to implementation of communication plans or projects in the digital environment. Uses social media to communicate on the web in a government context."
            },
            new CompetencyLevelRequirement
            {
                Id = 499,
                DescEng =
                    "Knowledge of the Government of Canada Communications Policy. Knowledge of emerging trends in communications in a federal government context. Plans, coordinates, and/or implements announcements or events. Develops and implements communications products. Develops communications to support managers. Monitors and analyzes media coverage. Ability to generate tactical media response. Organizes the logistics associated with special events, such as town halls or media availabilities.",
                DescFre =
                    "Knowledge of the Government of Canada Communications Policy. Knowledge of emerging trends in communications in a federal government context. Plans, coordinates, and/or implements announcements or events. Develops and implements communications products. Develops communications to support managers. Monitors and analyzes media coverage. Ability to generate tactical media response. Organizes the logistics associated with special events, such as town halls or media availabilities."
            },
            new CompetencyLevelRequirement
            {
                Id = 500,
                DescEng =
                    "Knowledge of project management methodologies in a communications context. Provides strategic communications advice to management/senior officials. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Meets and works with subject matter and methodology experts while executing segmentation and audience analysis. Leads meetings and works with clients or stakeholders.",
                DescFre =
                    "Knowledge of project management methodologies in a communications context. Provides strategic communications advice to management/senior officials. Develops and implements marketing and/or advertising plans, storyboards, and videos. Evaluates communications plans and develops associated communications products. Coordinates and/or works within inter-governmental or multi-departmental communications initiatives, projects, or strategies. Meets and works with subject matter and methodology experts while executing segmentation and audience analysis. Leads meetings and works with clients or stakeholders."
            },
            new CompetencyLevelRequirement
            {
                Id = 501,
                DescEng =
                    "Organizes and coordinates ministerial events. Leads the development and implementation, and evaluation of communications plans and develops associated communications products. Leads on behalf of the CCG, the collaboration with external partners, stakeholders, other levels of government, and/or other departments in the communications sector. Plans and executes extensive electronic (web and social media) communications initiatives. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies.",
                DescFre =
                    "Organizes and coordinates ministerial events. Leads the development and implementation, and evaluation of communications plans and develops associated communications products. Leads on behalf of the CCG, the collaboration with external partners, stakeholders, other levels of government, and/or other departments in the communications sector. Plans and executes extensive electronic (web and social media) communications initiatives. Manages media relations for sensitive issues. Develops and implements proactive media outreach strategies."
            },
            new CompetencyLevelRequirement
            {
                Id = 502,
                DescEng =
                    "Understands ICS command hierarchy. Executes tasks in incident action plan (IAP). Identifies and describes own AOR characteristics.   Identifies and uses proper planning formats and templates.",
                DescFre =
                    "Understands ICS command hierarchy. Executes tasks in incident action plan (IAP). Identifies and describes own AOR characteristics. Identifies and uses proper planning formats and templates."
            },
            new CompetencyLevelRequirement
            {
                Id = 503,
                DescEng =
                    "Conducts initial assessment. Identifies the pollutant released. Uses appropriate methods or tactics, to minimize the impacts of the pollutant on the population, environment and the economy. Operates the appropriate interventions equipment when applicable. Understands ICS structure as it pertains to ER incidents. Uses appropriate ICS terminology. Assumes role in ICS structure and understands responsibilities. Identifies geographic particularities that impact ER. Conducts area assessments with partners to identify threats and opportunities. Provides advice on tactical matters for the purpose of local area planning. Identifies equipment capabilities and gives recommendations for local area response planning. Identifies plans weaknesses pertaining to own role during exercises and incidents. Designs internal exercises.",
                DescFre =
                    "Conducts initial assessment. Identifies the pollutant released. Uses appropriate methods or tactics, to minimize the impacts of the pollutant on the population, environment and the economy. Operates the appropriate interventions equipment when applicable. Understands ICS structure as it pertains to ER incidents. Uses appropriate ICS terminology. Assumes role in ICS structure and understands responsibilities. Identifies geographic particularities that impact ER. Conducts area assessments with partners to identify threats and opportunities. Provides advice on tactical matters for the purpose of local area planning. Identifies equipment capabilities and gives recommendations for local area response planning. Identifies plans weaknesses pertaining to own role during exercises and incidents. Designs internal exercises."
            },
            new CompetencyLevelRequirement
            {
                Id = 504,
                DescEng =
                    "Acts as Duty Officer. Conducts spill assessment. Contracts service providers as required. Applies the PRO powers, acts as OSC and provides advice and guidance to polluter as FMO in simple situations. Conducts pollutants sampling and fills relevant documentation. Predicts the behavior of pollutants release in the marine environment. Uses wastes storage equipment and techniques appropriately. Uses shoreline clean-up assessment techniques (SCAT). Inputs marine pollution incident data in relevant systems. Uses appropriate ICS forms. Provides advice and guidance to command staff within scope of expertise. Understands roles within IAP and how they relate to each other and the overall mission. Identifies resident capacity in own AOR and integrates data in planning. Preplans response strategies adapted to area particularities and expected scenarios. Designs communication plan based on capabilities and area characteristics. Maintains safety, medical and communication plans, during pre-planning or incidents.",
                DescFre =
                    "Acts as Duty Officer. Conducts spill assessment. Contracts service providers as required. Applies the PRO powers, acts as OSC and provides advice and guidance to polluter as FMO in simple situations. Conducts pollutants sampling and fills relevant documentation. Predicts the behavior of pollutants release in the marine environment. Uses wastes storage equipment and techniques appropriately. Uses shoreline clean-up assessment techniques (SCAT). Inputs marine pollution incident data in relevant systems. Uses appropriate ICS forms. Provides advice and guidance to command staff within scope of expertise. Understands roles within IAP and how they relate to each other and the overall mission. Identifies resident capacity in own AOR and integrates data in planning. Preplans response strategies adapted to area particularities and expected scenarios. Designs communication plan based on capabilities and area characteristics. Maintains safety, medical and communication plans, during pre-planning or incidents."
            },
            new CompetencyLevelRequirement
            {
                Id = 505,
                DescEng =
                    "Applies the PRO powers, acts as OSC, and provides advice and guidance to polluter as FMO in moderate complexity situations. Prepares investigation and cost-recovery documentation. Develops strategic response objectives. Identifies and implements alternate response strategies. Determines the impacts of a pollutant in the marine environment with help of specialized resources. Determines response priorities and optimum response option. Integrates and uses the science table. Initiates and coordinates wildlife protection and rehabilitation process. Selects best storage option for residues and wastes. Recommends appropriate ICS structure in relation to incident; considers appropriateness of unified command. Assesses and integrates stakeholder’s concerns. Assumes role in planning process. Communicates and briefs Incident Action Plan. Applies principles laid out in collaboration agreements. Manages resources appropriately according to incident level. Adapts Response plans in new situations. Sets priorities with stakeholders for local area response planning. Makes recommendations about sector and regional plans. Designs logistics plans, during pre-planning or incidents.",
                DescFre =
                    "Applies the PRO powers, acts as OSC, and provides advice and guidance to polluter as FMO in moderate complexity situations. Prepares investigation and cost-recovery documentation. Develops strategic response objectives. Identifies and implements alternate response strategies. Determines the impacts of a pollutant in the marine environment with help of specialized resources. Determines response priorities and optimum response option. Integrates and uses the science table. Initiates and coordinates wildlife protection and rehabilitation process. Selects best storage option for residues and wastes. Recommends appropriate ICS structure in relation to incident; considers appropriateness of unified command. Assesses and integrates stakeholder’s concerns. Assumes role in planning process. Communicates and briefs Incident Action Plan. Applies principles laid out in collaboration agreements. Manages resources appropriately according to incident level. Adapts Response plans in new situations. Sets priorities with stakeholders for local area response planning. Makes recommendations about sector and regional plans. Designs logistics plans, during pre-planning or incidents."
            },
            new CompetencyLevelRequirement
            {
                Id = 506,
                DescEng =
                    "Applies the PRO powers, acts as OSC, and provides advice and guidance to polluter as FMO in high complexity situations. Assesses strategies and tactics and ensures regulatory compliance. Establishes Unified Command when in the best interest of the response effectiveness. Acts as IC during a high-complexity incident. Integrates legal, territorial, media, public and organizational expectations in planning process. Evaluates players’ expectations and integrates relevant stakeholders in command structure. Makes recommendations to improve the ICS philosophy and structure to National headquarters. Sets strategies and goals. Provides relevant advice and input for national and international planning. Maintains and coordinates sector and regional plans. Ensures that identified improvements to plans are implemented. Manages overall exercise program and provides input to national exercise planning team.",
                DescFre =
                    "Applies the PRO powers, acts as OSC, and provides advice and guidance to polluter as FMO in high complexity situations. Assesses strategies and tactics and ensures regulatory compliance. Establishes Unified Command when in the best interest of the response effectiveness. Acts as IC during a high-complexity incident. Integrates legal, territorial, media, public and organizational expectations in planning process. Evaluates players’ expectations and integrates relevant stakeholders in command structure. Makes recommendations to improve the ICS philosophy and structure to National headquarters. Sets strategies and goals. Provides relevant advice and input for national and international planning. Maintains and coordinates sector and regional plans. Ensures that identified improvements to plans are implemented. Manages overall exercise program and provides input to national exercise planning team."
            },
            new CompetencyLevelRequirement
            {
                Id = 507,
                DescEng =
                    "Basic understanding of the fundamental principles of hydraulic engineering including fluid mechanics, fluid flow, behavior of real fluids, hydrology, pipelines, open channel hydraulics, mechanics of sediment transport, physical modeling, hydraulic machines, and drainage hydraulics.",
                DescFre =
                    "Compréhension de base des principes fondamentaux du génie hydraulique, y compris la mécanique des fluides, l'écoulement des fluides, le comportement des fluides réels, l'hydrologie, les pipelines, l'hydraulique à canal ouvert, la mécanique du transport des sédiments, la modélisation physique, les machines hydrauliques et le drainage hydraulique."
            },
            new CompetencyLevelRequirement
            {
                Id = 508,
                DescEng =
                    "Limited knowledge of the application of equations developed from the principles of fluid dynamics and fluid mechanics in relations to water flowing in an isolated environment (pipe, pump) and/or in an open channel (river, lake, ocean).",
                DescFre =
                    "Connaissance limitée de l'application des équations développées à partir des principes de la dynamique des fluides et de la mécanique des fluides en relation avec l'eau s'écoulant dans un environnement isolé (conduite, pompe) et/ou dans un canal ouvert (rivière, lac, océan)."
            },
            new CompetencyLevelRequirement
            {
                Id = 509,
                DescEng =
                    "Practical knowledge of hydraulic engineers designs, including hydraulic structures such as dams, levees, water distribution networks, water collection networks, sewage collection networks, storm water management, and sediment transport.",
                DescFre =
                    "Connaissance pratique de la conception d'ouvrages hydrauliques tels que barrages, digues, réseaux de distribution d'eau, réseaux de collecte d'eau, réseaux de collecte d'eaux usées, gestion des eaux pluviales et transport de sédiments, entre autres."
            },
            new CompetencyLevelRequirement
            {
                Id = 510,
                DescEng =
                    "Advanced knowledge of the application of hydrological statistics and risk analysis, reservoir system analysis, planning analysis and real-time water control management. Knowledge of new and emerging technologies, flood risk management, and eco-hydraulics.",
                DescFre =
                    "Connaissance avancée de l'application des statistiques hydrologiques et de l'analyse des risques, de l'analyse des systèmes de réservoirs, de l'analyse de la planification et de la gestion en temps réel du contrôle de l'eau. Connaissance des technologies nouvelles et émergentes, de la gestion des risques d'inondation et de l'écohydraulique."
            },
            new CompetencyLevelRequirement
            {
                Id = 511,
                DescEng =
                    "Expert knowledge in providing support for decision making at all levels including governance and policy through to management of operations. Knowledge of sustainable development and optimization of water resources management, and flow processes.",
                DescFre =
                    "Connaissances spécialisées en matière de soutien à la prise de décisions à tous les niveaux, y compris la gouvernance et les politiques, jusqu'à la gestion des opérations. Connaissance du développement durable et de l'optimisation de la gestion des ressources en eau et des processus d'écoulement."
            },
            new CompetencyLevelRequirement
            {
                Id = 512,
                DescEng =
                    "Understands basic circuit elements (source, ground, resistor, capacitor). Applies basic circuit analysis methods to solve electrical design problems.",
                DescFre =
                    "Comprendre les éléments de base du circuit (source, masse, résistance, condensateur). Appliquer les méthodes d’analyse de base des circuits pour résoudre les problèmes de conception électrique."
            },
            new CompetencyLevelRequirement
            {
                Id = 513,
                DescEng =
                    "Applies electrical engineering sciences to moderately complex services or creative work as consultation, investigation, evaluation, planning, and design of engineering projects. Provides drawing input and reviews. Defines problems, conducts research, plans methods, and identifies resources.",
                DescFre =
                    "Appliquer les sciences de génie électrique à des services modérément complexes ou à des travaux créatifs comme les activités de consultation, d’enquête, d’évaluation, de planification et de conception de projets d’ingénierie. Fournir des commentaires sur les dessins et les révisions. Définir les problèmes, mener des recherches, planifier des méthodes et cerner les ressources."
            },
            new CompetencyLevelRequirement
            {
                Id = 514,
                DescEng =
                    "Plans for final delivery and workout foreseeable challenges. Develops project management schedules. Plans and develops concept tooling and estimated costs. Conducts product testing. Provides test results. Provides and develops fixturing concepts.",
                DescFre =
                    "Planifier la livraison finale et régler les problèmes prévisibles. Élaborer des calendriers de gestion de projet. Planifier et développer l’outillage de conception et les coûts estimés. Effectuer des tests de produits. Fournir les résultats des tests. Fournir et développer des concepts de serrage."
            },
            new CompetencyLevelRequirement
            {
                Id = 515,
                DescEng =
                    "Designs and develops product concepts based on research and development. Provides test results to senior management and designers. Analyzes data and develops reports. Analyzes brainstorming results. Conducts research and development project meetings. Conducts preliminary drawing reviews. Provides materiels options. Provides reducibility reports. Provides budgetary evaluations. Understands and conceptualizes vague plans.",
                DescFre =
                    "Concevoir et élaborer des concepts de produits fondés sur la recherche et le développement. Fournir des résultats des tests aux cadres supérieurs et aux concepteurs. Analyser des données et élaborer des rapports. Analyser des résultats de la séance de réflexion. Tenir des réunions sur les projets de recherche et de développement de projet. Effectuer des examens préliminaires des dessins. Fournir des options matérielles. Fournir des rapports de réductibilité. Fournir des évaluations budgétaires. Comprendre et conceptualiser des plans vagues."
            },
            new CompetencyLevelRequirement
            {
                Id = 516,
                DescEng =
                    "Develops high-level reports. Provides time studies and flow diagrams. Attends design and engineering meetings, develops schedules, and considers resource allocations - including presenting to management. Understands and teaches drawings and blueprint standards. Provides feedback and communicates with design. Conducts model manipulation.",
                DescFre =
                    "Élaborer des rapports de haut niveau. Fournir des études de temps et des organigrammes. Assister aux réunions de conception et d’ingénierie, élaborer des calendriers et examiner l’affectation des ressources, notamment en faisant des présentations à la direction. Comprendre et enseigner les normes relatives aux dessins et aux plans. Fournir de la rétroaction et communiquer avec les responsables de la conception. Effectuer la manipulation des modèles."
            },
            new CompetencyLevelRequirement
            {
                Id = 517,
                DescEng =
                    "Uses operating systems to prepare plans, specifications, and calculations, for collection and analysis of spatial information.",
                DescFre =
                    "Utilise des systèmes d'exploitation pour préparer des plans, des spécifications et des calculs, pour la collecte et l'analyse d'informations spatiales."
            },
            new CompetencyLevelRequirement
            {
                Id = 518,
                DescEng =
                    "Performs analysis, design, and design review and/or determination of environmental and safety impacts of work processes and products.",
                DescFre =
                    "Effectue l'analyse, la conception et la révision de la conception et/ou la détermination des impacts des processus de travail et des produits sur l'environnement et la sécurité."
            },
            new CompetencyLevelRequirement
            {
                Id = 519,
                DescEng =
                    "Provides consultation and technical assistance to design and conduct experiments, as well as to analyze and interpret data.",
                DescFre =
                    "Fournit des conseils et une assistance technique pour concevoir et mener des expériences, ainsi que pour analyser et interpréter les données."
            },
            new CompetencyLevelRequirement
            {
                Id = 520,
                DescEng =
                    "Integrates the acquisition, processing, analysis, display, and management of spatial information, using various geographic information systems (GIS), photogrammetry, and remote sensing equipment. Identifies, formulates, and solves a wide range of technical problems. Provides expertise in boundary and land surveying, subdivision, and plat creation, control surveys, and construction surveys.",
                DescFre =
                    "Integrates the acquisition, processing, analysis, display, and management of spatial information, using various geographic information systems (GIS), photogrammetry, and remote sensing equipment. Identifies, formulates, and solves a wide range of technical problems. Provides expertise in boundary and land surveying, subdivision, and plat creation, control surveys, and construction surveys. "
            },
            new CompetencyLevelRequirement
            {
                Id = 521,
                DescEng =
                    "Provides expertise on the impact of engineering solutions in a global, economic, environmental, and societal context. Reviews legislation, standards of practice, and case law affecting property interests, property boundaries, and boundary surveys.",
                DescFre =
                    "Fournit une expertise sur l'impact des solutions d'ingénierie dans un contexte global, économique, environnemental et sociétal. Examine la législation, les normes de pratique et la jurisprudence concernant les intérêts fonciers, les limites des propriétés et les levés de terrain."
            },
            new CompetencyLevelRequirement
            {
                Id = 522,
                DescEng =
                    "Uses Configuration Management (CM) planning and management documentation and functions. Asks questions when necessary.",
                DescFre =
                    "Utiliser la documentation et les fonctions de gestion et de planification de la gestion de la configuration (GC). Poser des questions au besoin."
            },
            new CompetencyLevelRequirement
            {
                Id = 523,
                DescEng =
                    "Uses Configuration Management (CM) for control of basic performance and physical attributes.",
                DescFre =
                    "Utiliser la gestion de la configuration (GC) pour le contrôle du rendement de base et des caractéristiques physiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 524,
                DescEng =
                    "Employs Configuration Management (CM) to revise capability; improve performance, reliability, or maintainability; extend life; reduce cost; reduce risk and liability; and correct defects. Implements changes to the system by using a standardized, systematic approach that ensures consistency.",
                DescFre =
                    "Utiliser la gestion de la configuration (GC) pour réviser les capacités, améliorer le rendement, la fiabilité ou la maintenabilité, prolonger la durée de vie, réduire les coûts, réduire les risques et la responsabilité et corriger les défectuosités. Apporter des modifications au système en utilisant une approche normalisée et systématique qui garantit la cohérence."
            },
            new CompetencyLevelRequirement
            {
                Id = 525,
                DescEng =
                    "Provides technical and administrative direction into the development and implementation of the procedures, functions, services, tools, processes, and resources required to successfully develop and support a complex system. Evaluates proposed changes in terms of their anticipated impact on the entire system. Produces documentation (e.g. requirements, design, test, and acceptance documentation) that is accurate and consistent with the actual physical design of the item.",
                DescFre =
                    "Fournir une orientation technique et administrative pour l’élaboration et la mise en œuvre des procédures, fonctions, services, outils, processus et ressources nécessaires pour développer et soutenir avec succès un système complexe. Évaluer les changements proposés du point de vue de leur incidence prévue sur tout le système. Produire de la documentation (c.-à-d. documents d’exigences, de conception, d’essais et d’acceptation) exacte et conforme à la conception physique réelle de l’élément."
            },
            new CompetencyLevelRequirement
            {
                Id = 526,
                DescEng =
                    "Produces and implements the policies, procedures, techniques, and tools that manage the Configuration Management (CM) system. Audits configuration verification to assess compliance with established performance requirements.",
                DescFre =
                    "Produire et mettre en œuvre les politiques, procédures, techniques et outils qui gèrent le système de gestion de la configuration (GC). Procéder à la vérification de la configuration pour évaluer la conformité aux exigences de rendement établies."
            },
            new CompetencyLevelRequirement
            {
                Id = 527,
                DescEng = "Understands the administrative support required for aspects of logistics in a unit.",
                DescFre = "Understands the administrative support required for aspects of logistics in a unit."
            },
            new CompetencyLevelRequirement
            {
                Id = 528,
                DescEng =
                    "Limited knowledge of the activities required to determine items required (including food and uniforms), assembling orders, aiding in processing orders, sorting merchandise, maintaining supplies, verifying inventory, and processing return materials authorizations (RMAs).",
                DescFre =
                    "Limited knowledge of the activities required to determine items required (including food and uniforms), assembling orders, aiding in processing orders, sorting merchandise, maintaining supplies, verifying inventory, and processing return materials authorizations (RMAs)."
            },
            new CompetencyLevelRequirement
            {
                Id = 529,
                DescEng =
                    "Practical knowledge of purchasing, transportation, inventory, and warehousing. Knowledge of the appropriate use of equipment, facilities, and materials needed to do certain work. Knowledge of controlling inventory levels determined by conducting physical counts and reconciling with data storage systems.",
                DescFre =
                    "Practical knowledge of purchasing, transportation, inventory, and warehousing. Knowledge of the appropriate use of equipment, facilities, and materials needed to do certain work. Knowledge of controlling inventory levels determined by conducting physical counts and reconciling with data storage systems."
            },
            new CompetencyLevelRequirement
            {
                Id = 530,
                DescEng =
                    "Advanced knowledge of purchasing, manufacturing and distribution, receiving, transfer, and dispatch of raw materials and finished goods. Knowledge of forecasting requirements and planning for the future. Knowledge of identifying complex warehouse and inventory monitoring systems, procedures, and issues.",
                DescFre =
                    "Advanced knowledge of purchasing, manufacturing and distribution, receiving, transfer, and dispatch of raw materials and finished goods. Knowledge of forecasting requirements and planning for the future. Knowledge of identifying complex warehouse and inventory monitoring systems, procedures, and issues."
            },
            new CompetencyLevelRequirement
            {
                Id = 531,
                DescEng =
                    "Expert knowledge in the development of solutions to logistical problems. Understanding the development and implementation of business process initiatives to optimize logistical operations. Expert knowledge of policies and procedures related to material handling, and shipping requirements.",
                DescFre =
                    "Expert knowledge in the development of solutions to logistical problems. Understanding the development and implementation of business process initiatives to optimize logistical operations. Expert knowledge of policies and procedures related to material handling, and shipping requirements."
            },
            new CompetencyLevelRequirement
            {
                Id = 532,
                DescEng =
                    "Basic knowledge of concepts and components in an electronic environment and how they interrelate.",
                DescFre =
                    "Connaissance de base des concepts et des composants d’un environnement électronique et de leurs interactions."
            },
            new CompetencyLevelRequirement
            {
                Id = 533,
                DescEng =
                    "Limited knowledge in analyzing basic concepts of electronics and the behaviour of electronic systems. Understands the operational function of electronic components in a practical context.",
                DescFre =
                    "Connaissances limitées en matière d’analyse des concepts de base de l’électronique et du comportement des systèmes électroniques. Comprend la fonction opérationnelle des composants électroniques dans un contexte pratique."
            },
            new CompetencyLevelRequirement
            {
                Id = 534,
                DescEng =
                    "Practical knowledge of advanced concepts and components in electronic environments, including power and heat dissipation, analogue and digital signals, time constant, amplification, logical and/or truth tables, bistable, monostable and astable, parallels or series.",
                DescFre =
                    "Connaissance pratique de concepts et de composants avancés dans les environnements électroniques, notamment la dissipation de la puissance et de la chaleur, les signaux analogiques et numériques, la constante de temps, l’amplification, les tables logiques ou tables de vérité, les états bistables, monostables et astables et les dispositions en parallèles ou en série."
            },
            new CompetencyLevelRequirement
            {
                Id = 535,
                DescEng =
                    "Advanced knowledge of electronic software program development using advanced concepts, such as variables, binary notation (bits, bytes, and words), logical structuring of software programs. Understands advanced calculations, including power rating, parallels or series, and time constant, based on parameters important in the behaviour of real circuits. Knowledge of capacity related to different electronic components.",
                DescFre =
                    "Connaissance avancée du développement de programmes logiciels électroniques utilisant des concepts avancés tels que les variables, la notation binaire (bits, octets et mots) et la structuration logique des programmes logiciels. Comprendre des calculs avancés, y compris la puissance nominale, les dispositions en parallèle ou en série et la constante de temps, en fonction de paramètres importants dans le comportement des circuits réels. Connaissance des capacités liées aux différents composants électroniques."
            },
            new CompetencyLevelRequirement
            {
                Id = 536,
                DescEng =
                    "Expert knowledge of significant concepts used in the design and construction of electronic environments and complex hardware concepts. Expertise at performing complex calculations.",
                DescFre =
                    "Connaissance approfondie des concepts importants utilisés dans la conception et la construction d’environnements électroniques et de concepts matériels complexes. Expertise dans l’exécution de calculs complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 537,
                DescEng =
                    "Participates in tours and educational experiences highlighting the workings of operation centres, their mandate, equipment, and staffing.",
                DescFre =
                    "Participates in tours and educational experiences highlighting the workings of operation centres, their mandate, equipment, and staffing."
            },
            new CompetencyLevelRequirement
            {
                Id = 538,
                DescEng =
                    "Participates in exercises or incidents using sensors and equipment with an operation centre, giving information, obtaining data, and taskings or instructions. Reads operational orders and data published by operations centres.",
                DescFre =
                    "Participates in exercises or incidents using sensors and equipment with an operation centre, giving information, obtaining data, and taskings or instructions. Reads operational orders and data published by operations centres."
            },
            new CompetencyLevelRequirement
            {
                Id = 539,
                DescEng =
                    "Plans, deploys, and tracks resources utilizing the operation center equipment. Collects and analyses data including fisheries violations, courtesy exams, the distance covered and fuel consumed during a patrol, as well as a detailed electronic report on the actual amount of time spent in support of each program. Participates in reviewing, updating, and conducting analysis, preparation and development of operational plans, exercises and standard operating procedures and prepares recommendations to the superintendent and delegates for improving performance, ensuring compliance and meeting new operational requirements. Collects and analyzes data to create and disseminate reports at the regional and national levels.",
                DescFre =
                    "Plans, deploys, and tracks resources utilizing the operation center equipment. Collects and analyses data including fisheries violations, courtesy exams, the distance covered and fuel consumed during a patrol, as well as a detailed electronic report on the actual amount of time spent in support of each program. Participates in reviewing, updating, and conducting analysis, preparation and development of operational plans, exercises and standard operating procedures and prepares recommendations to the superintendent and delegates for improving performance, ensuring compliance and meeting new operational requirements. Collects and analyzes data to create and disseminate reports at the regional and national levels."
            },
            new CompetencyLevelRequirement
            {
                Id = 540,
                DescEng =
                    "Plans, develops, and implements the operational plans of all regional resources on a 24/7 basis.  Provides technical and operational analysis, advice and briefings to regional management and commanding officers. Assists in finding solutions to complex and diversified technical and operational problems. Receives reports of marine incidents and initiates and supports incident response, activating alert networks, and coordinating with other emergency response agencies, including applying the Incident Command System (ICS).",
                DescFre =
                    "Plans, develops, and implements the operational plans of all regional resources on a 24/7 basis.  Provides technical and operational analysis, advice and briefings to regional management and commanding officers. Assists in finding solutions to complex and diversified technical and operational problems. Receives reports of marine incidents and initiates and supports incident response, activating alert networks, and coordinating with other emergency response agencies, including applying the Incident Command System (ICS)."
            },
            new CompetencyLevelRequirement
            {
                Id = 541,
                DescEng =
                    "Advises and acts as spokesperson for all fleet related issues during the planning and exercising of emergency response preparedness for Canadian Coast Guard resources. Leads activities related to program and service delivery by multi-disciplinary and multi-agency organizations. Maintains emergency preparedness and readiness, and directs initial response for regional incidents. Manages the planning, conduct, and monitoring of operational exercises to ensure compliance to Coast Guard and industry regulations. Evaluates Regional Operations Centres (ROC) performance. Advises and reports to senior management on incident response situations.",
                DescFre =
                    "Advises and acts as spokesperson for all fleet related issues during the planning and exercising of emergency response preparedness for Canadian Coast Guard resources. Leads activities related to program and service delivery by multi-disciplinary and multi-agency organizations. Maintains emergency preparedness and readiness, and directs initial response for regional incidents. Manages the planning, conduct, and monitoring of operational exercises to ensure compliance to Coast Guard and industry regulations. Evaluates Regional Operations Centres (ROC) performance. Advises and reports to senior management on incident response situations."
            },
            new CompetencyLevelRequirement
            {
                Id = 542, DescEng = "Understands the basic engineering concepts, practices, and theories.",
                DescFre = "Comprend les concepts, les pratiques et les théories de base de l'ingénierie. "
            },
            new CompetencyLevelRequirement
            {
                Id = 543,
                DescEng =
                    "Working level understanding of the organizational and business objectives of section/specialty involved in the design/development/review/permitting, construction, maintenance, operations, or repair of, projects/sites and their potential environmental and safety impacts.",
                DescFre =
                    "Compréhension, au niveau opérationnel, des objectifs organisationnels et opérationnels de la section ou de la spécialité concernée par la conception, l'élaboration, l'examen ou l'autorisation, la construction, l'entretien, l'exploitation ou la réparation des projets ou des sites et de leurs incidences potentielles sur l'environnement et la sécurité."
            },
            new CompetencyLevelRequirement
            {
                Id = 544,
                DescEng =
                    "Practical understanding of concepts, practices, and theories used in the engineering specialty areas of technological, logistical, and material resources of a production system with an emphasis on efficiency, productivity, and quality.",
                DescFre =
                    "Compréhension pratique des concepts, des pratiques et des théories utilisés dans les domaines de spécialité de l'ingénierie des ressources technologiques, logistiques et matérielles d'un système de production, l'accent étant mis sur l'efficacité, la productivité et la qualité."
            },
            new CompetencyLevelRequirement
            {
                Id = 545,
                DescEng =
                    "Thorough knowledge of internal organizational structure, business needs/objectives, budget, planning, legal/public relations considerations, and/or other related engineering factors. Knowledge of designing and managing complex engineering systems over their life cycles to best optimize for maximum productivity, quality, and efficiency.",
                DescFre =
                    "Connaissance approfondie de la structure organisationnelle interne, des besoins/objectifs opérationnels, du budget, de la planification, des considérations juridiques/de relations publiques et/ou d'autres facteurs techniques connexes. Connaissance de la conception et de la gestion de systèmes d'ingénierie complexes tout au long de leur cycle de vie pour optimiser au mieux la productivité, la qualité et l'efficacité maximales."
            },
            new CompetencyLevelRequirement
            {
                Id = 546,
                DescEng =
                    "Expert level of understanding of the application of advanced analytical methods in the engineering discipline. Expertise in the evaluation of a ship's performance during trials, alongside and at sea, and change designs to meet national and international standards.",
                DescFre =
                    "Niveau expert de compréhension de l'application des méthodes analytiques avancées dans la discipline du génie. Expertise dans l'évaluation de la performance d'un navire lors d'essais, en mer et en mer, et dans la modification de sa conception pour répondre aux normes nationales et internationales. "
            },
            new CompetencyLevelRequirement
            {
                Id = 547,
                DescEng =
                    "Basic knowledge of vessel structural design, drawing and modeling, and rules and regulations for construction and classification.",
                DescFre =
                    "Basic knowledge of vessel structural design, drawing and modeling, and rules and regulations for construction and classification."
            },
            new CompetencyLevelRequirement
            {
                Id = 548,
                DescEng =
                    "Knowledge of preliminary design stages including all factors like safety, strength of structure, hydrodynamics, and ship arrangement.",
                DescFre =
                    "Knowledge of preliminary design stages including all factors like safety, strength of structure, hydrodynamics, and ship arrangement."
            },
            new CompetencyLevelRequirement
            {
                Id = 549,
                DescEng =
                    "Intermediate knowledge of basic and applied research, design, development, design evaluation, and calculations during all stages of the life of a marine vessel. Formulation of safety regulations and damage control rules, and the approval and certification of ship designs to meet statutory and non-statutory requirements.",
                DescFre =
                    "Intermediate knowledge of basic and applied research, design, development, design evaluation, and calculations during all stages of the life of a marine vessel. Formulation of safety regulations and damage control rules, and the approval and certification of ship designs to meet statutory and non-statutory requirements."
            },
            new CompetencyLevelRequirement
            {
                Id = 550,
                DescEng =
                    "Advanced knowledge of research elements to predict the performance of a marine vessel including static stability (intact and damaged), dynamic stability, resistance, powering, hull development, structural analysis, green water modelling, and slamming analysis. Cutting edge knowledge of detailed designing, construction, trials, operation and maintenance, launching and dry-docking activities.",
                DescFre =
                    "Advanced knowledge of research elements to predict the performance of a marine vessel including static stability (intact and damaged), dynamic stability, resistance, powering, hull development, structural analysis, green water modelling, and slamming analysis. Cutting edge knowledge of detailed designing, construction, trials, operation and maintenance, launching and dry-docking activities."
            },
            new CompetencyLevelRequirement
            {
                Id = 551,
                DescEng =
                    "Expert knowledge and experience in economic, environmentally sound and seaworthy ship building design.",
                DescFre =
                    "Expert knowledge and experience in economic, environmentally sound and seaworthy ship building design."
            },
            new CompetencyLevelRequirement
            {
                Id = 552,
                DescEng =
                    "Basic knowledge of computer fundamentals and understand computer applications. Understanding of architectural principles, specifications, and models.",
                DescFre =
                    "Connaissances de base en informatique et compréhension des applications informatiques. Compréhension des principes architecturaux, des spécifications et des modèles."
            },
            new CompetencyLevelRequirement
            {
                Id = 553,
                DescEng =
                    "Limited knowledge of determining the needs of the user and designing a product that meets the requirements effectively within economic and technological constraints and the creation of basic models based upon specifications.",
                DescFre =
                    "Connaissance limitée de la détermination des besoins de l'utilisateur et de la conception d'un produit qui répond efficacement aux exigences dans le respect des contraintes économiques et technologiques et de la création de modèles de base basés sur des spécifications."
            },
            new CompetencyLevelRequirement
            {
                Id = 554,
                DescEng =
                    "Practical knowledge of the capabilities and programming models of a computer and the structure and behavior of electronic circuits and digital logic circuits. Knowledge of a variety of analytical techniques to solve problems and adjusting work procedures for maximum efficiency. Knowledge of the production of analytic and candidate design models to be used for further analysis (e.g. telecommunications, networks).",
                DescFre =
                    "Connaissance pratique des capacités et des modèles de programmation d'un ordinateur ainsi que de la structure et du comportement des circuits électroniques et des circuits logiques numériques. Connaissance d'une variété de techniques analytiques pour résoudre des problèmes et ajuster les procédures de travail pour une efficacité maximale. Connaissance de la production de modèles analytiques et de modèles de conception candidats à utiliser pour des analyses plus poussées (p. ex. télécommunications, réseaux)."
            },
            new CompetencyLevelRequirement
            {
                Id = 555,
                DescEng =
                    "Advanced knowledge of detailed analyses of a computer's organization to optimize performance-based products in a cost-efficient manner. Knowledge of complex circuits and electronic design automation (EDA) systems such as application-specific integrated circuits, microprocessors, and programmable logic devices. Significant knowledge of new requirements and makes design recommendations. Understands validation processes after implementation. Knowledge of metadata models at the enterprise level, information models, and the interoperability model.",
                DescFre =
                    "Connaissance approfondie des analyses détaillées de l'organisation d'un ordinateur afin d'optimiser les produits basés sur la performance d'une manière rentable. Connaissance des circuits complexes et des systèmes d'automatisation de la conception électronique (EDA) tels que les circuits intégrés, les microprocesseurs et les dispositifs logiques programmables spécifiques aux applications. Connaissance approfondie des nouvelles exigences et formulation de recommandations de conception. Comprend les processus de validation après la mise en œuvre. Connaissance des modèles de métadonnées au niveau de l'entreprise, des modèles d'information et du modèle d'interopérabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 556,
                DescEng =
                    "Expert knowledge in the optimization of the entire architectural process including instruction set design, functional organization, logic design, and implementation. Expert understanding of how to use and implement newest computer technologies. Expertise in how architecture relates to the organization's vision, how new business fits in the current business lines, the integration of business and technology, and relates government priorities to target architectures. Understands Treasury Board standards (e.g. ISO, WC3 Quality standards) and governance issues.",
                DescFre =
                    "Connaissances expertes dans l'optimisation de l'ensemble du processus architectural, y compris la conception du jeu d'instructions, l'organisation fonctionnelle, la conception logique et la mise en œuvre. Compréhension experte de la façon d'utiliser et de mettre en œuvre les technologies informatiques les plus récentes. Expertise sur la façon dont l'architecture est liée à la vision de l'organisation, la façon dont les nouvelles activités s'intègrent aux secteurs d'activité actuels, l'intégration des activités et de la technologie, et le lien entre les priorités gouvernementales et les architectures cibles. Comprend les normes du Conseil du Trésor (p. ex. normes de qualité ISO, WC3) et les questions de gouvernance."
            },
            new CompetencyLevelRequirement
            {
                Id = 557,
                DescEng =
                    "Applies engineering sciences to assist in the design of engineering/electrical projects. Solves or assists in solving defined problems in drafting an engineering project proposal. Makes recommendations for decisions on technical engineering/electrical matters.",
                DescFre =
                    "Applique les sciences de l'ingénierie pour aider à la conception de projets d'ingénierie/électricité. Résout ou aide à résoudre des problèmes définis lors de la rédaction d'une proposition de projet d'ingénierie. Fait des recommandations pour la prise de décisions sur des questions techniques d'ingénierie/électricité."
            },
            new CompetencyLevelRequirement
            {
                Id = 558,
                DescEng =
                    "Applies engineering sciences to moderately complex services of creative work as consultation, investigation, evaluation, and design of engineering/electrical projects. Provides drawing input and reviews. Researches, collects and/or analyzes information/data which contributes to engineering/electrical decisions.",
                DescFre =
                    "Applique les sciences de l'ingénierie à des services modérément complexes de travail créatif comme la consultation, l'investigation, l'évaluation et la conception de projets d'ingénierie/électricité. Fournit des contributions et des examens de dessins. Recherche, collecte et/ou analyse des informations/données qui contribuent aux décisions en matière d'ingénierie/électricité."
            },
            new CompetencyLevelRequirement
            {
                Id = 559,
                DescEng =
                    "Creates engineering/electrical designs and/or project/program specifications to meet desired compliance with engineering/electrical principles, standards, statutes, codes, regulations, and design. Defines problems, conducts research, plans methods, and identifies resources. Provides technical analysis.",
                DescFre =
                    "Crée des conceptions techniques/électriques et/ou des spécifications de projets/programmes pour répondre à la conformité souhaitée aux principes, normes, statuts, codes, règlements et conception techniques/électriques. Définit les problèmes, mène des recherches, planifie les méthodes et identifie les ressources. Fournir une analyse technique."
            },
            new CompetencyLevelRequirement
            {
                Id = 560,
                DescEng =
                    "Approves complex or new engineering/technical designs and/or project/program specifications to meet desired compliance with principles, standards, codes, designs, and statutes. Addresses conflicting design constraints, when and where applicable.",
                DescFre =
                    "Approuve les conceptions techniques complexes ou nouvelles et/ou les spécifications de projets/programmes afin d'assurer la conformité souhaitée aux principes, normes, codes, conceptions et statuts. Traite les contraintes de conception contradictoires, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 561,
                DescEng =
                    "Approves final proposals for large scale engineering and/or program areas. Represents the Canadian Coast Guard as an expert in engineering/electrical review and design. Ensures that client relationships are pro-actively developed by continually improving the level of service provided in accordance with the provision of service agreement and industry standard practices.",
                DescFre =
                    "Approuve les propositions finales pour les domaines d'ingénierie et/ou de programmes à grande échelle. Représente la Garde côtière canadienne en tant qu'expert en ingénierie/électricité et en conception. S'assure que les relations avec les clients sont développées de manière proactive en améliorant continuellement le niveau de service fourni conformément à l'accord de service et aux pratiques standard de l'industrie."
            },
            new CompetencyLevelRequirement
            {
                Id = 562, DescEng = "Controls display in drawings. Create basic drawings.",
                DescFre = "Controls display in drawings. Create basic drawings."
            },
            new CompetencyLevelRequirement
            {
                Id = 563,
                DescEng =
                    "Creates AutoCAD drawing files. Saves AutoCAD drawing files in proper format. Operates the AutoCAD visual reference commands including: Zoom extent, drawing LIMITS, status bar, GRID display, and PAN real time. Executes line commands including: format, units setup, LINE command, coordinates, interactive input method, SNAP option, and world space.",
                DescFre =
                    "Creates AutoCAD drawing files. Saves AutoCAD drawing files in proper format. Operates the AutoCAD visual reference commands including: Zoom extent, drawing LIMITS, status bar, GRID display, and PAN real time. Executes line commands including: format, units setup, LINE command, coordinates, interactive input method, SNAP option, and world space."
            },
            new CompetencyLevelRequirement
            {
                Id = 564,
                DescEng =
                    "Uses circle commands. Defines positions using the basic entry methods. Uses different options to draw 3D basic ribbons. Recognizes the steps of executing pull down menus. Executes the steps to apply 3D Modelling panels. Identifies options for 3D modelling pull down menus. Draws 2D solids and 3D faces. Draws edges. Explores different methods to add/edit materials to 3D drawings. Drafts moderate-to-complex 2D drawings, charts, schedules. Prepares as-built drawings based on field red-line markups. Develops designs and layouts requiring theoretical and practical design knowledge in a specialized field.",
                DescFre =
                    "Uses circle commands. Defines positions using the basic entry methods. Uses different options to draw 3D basic ribbons. Recognizes the steps of executing pull down menus. Executes the steps to apply 3D Modelling panels. Identifies options for 3D modelling pull down menus. Draws 2D solids and 3D faces. Draws edges. Explores different methods to add/edit materials to 3D drawings. Drafts moderate-to-complex 2D drawings, charts, schedules. Prepares as-built drawings based on field red-line markups. Develops designs and layouts requiring theoretical and practical design knowledge in a specialized field."
            },
            new CompetencyLevelRequirement
            {
                Id = 565,
                DescEng =
                    "Applies the thickness command at command prompt with different values or modify general properties of an object. Executes the 'Elev' command at command prompt with different values. Identifies different styles including: display of edges and shading (visual styles) in the viewport. Draws basic 3D surfaces. Categorizes points and spot lights.",
                DescFre =
                    "Applies the thickness command at command prompt with different values or modify general properties of an object. Executes the 'Elev' command at command prompt with different values. Identifies different styles including: display of edges and shading (visual styles) in the viewport. Draws basic 3D surfaces. Categorizes points and spot lights."
            },
            new CompetencyLevelRequirement
            {
                Id = 566,
                DescEng =
                    "Develops Surfaces. Creates 3D solid or surfaces in the space between several cross sections. Builds surface networks. Creates a blend surface between two existing surfaces. Creates 2D or 'flattened' representations of all 3D objects in the current view using 'flatshot' command. Explains render command. Recognizes environmental features. Assures that work complies with the accuracy level and time constraints required for the assignment. Potentially directs work for a small number of drafters, providing guidance and instruction on work methods, and checks finished work.Ability to meet safety requirements and attend site visits.",
                DescFre =
                    "Develops Surfaces.Creates 3D solid or surfaces in the space between several cross sections.Builds surface networks.Creates a blend surface between two existing surfaces.Creates 2D or 'flattened' representations of all 3D objects in the current view using 'flatshot' command. Explains render command. Recognizes environmental features. Assures that work complies with the accuracy level and time constraints required for the assignment. Potentially directs work for a small number of drafters, providing guidance and instruction on work methods, and checks finished work. Ability to meet safety requirements and attend site visits."
            },
            new CompetencyLevelRequirement
            {
                Id = 567,
                DescEng =
                    "Applies basic level software specifications or design techniques and programming concepts using one or more programming languages and/or methodologies. Tests, documents, and ensures production assurance and with guidance.",
                DescFre =
                    "Applique des spécifications ou des techniques de conception de logiciels de niveau de base et des concepts de programmation en utilisant un ou plusieurs langages et/ou méthodologies de programmation. Teste, documente et assure l'assurance de la production et avec des orientations."
            },
            new CompetencyLevelRequirement
            {
                Id = 568,
                DescEng =
                    "Applies one or more programming languages. Writes or adapts software modules for testing and integration. Understands and employs basic development methods and standards. Tests/debugs program modules. Uses a testing tool and prepares basic test cases. Prepares operational documentation and uses appropriate tools and technologies for developing information technology (IT) systems and services that are barrier-free and accessible.",
                DescFre =
                    "Applique un ou plusieurs langages de programmation. Écrit ou adapte des modules logiciels pour les tester et les intégrer. Comprend et utilise des méthodes et des normes de développement de base. Teste/débogue des modules de programmes. Utilise un outil de test et prépare des cas de test de base. Prépare la documentation opérationnelle et utilise les outils et technologies appropriés pour développer des systèmes de technologie de l'information (TI) et des services accessibles et sans obstacles."
            },
            new CompetencyLevelRequirement
            {
                Id = 569,
                DescEng =
                    "Works in several programming environments with comfort in various hardware and software interfaces. Writes original multi-module/complex programs or applies reusable modules. Designs, tests, and integrates software modules and resolves programming errors using various debugging tools and techniques. Provides support, guidance, and production assurance for common problems. Conducts impact analyses for proposed changes to or problems with the system. Prepares technical documentation (e.g. user guides, technical specifications). Undertakes routine analysis and works with designers and analysts to clarify and improve specifications or to identify alternative programming solutions.",
                DescFre =
                    "Fonctionne dans plusieurs environnements de programmation avec aisance dans diverses interfaces matérielles et logicielles. Écrit des programmes originaux multi-modules/complexes ou applique des modules réutilisables. Conçoit, teste et intègre des modules logiciels et résout les erreurs de programmation en utilisant divers outils et techniques de débogage. Fournir un soutien, des conseils et une assurance de production pour les problèmes courants. Effectue des analyses d'impact pour les changements proposés ou les problèmes liés au système. Prépare la documentation technique (par exemple, les guides d'utilisation, les spécifications techniques). Effectue des analyses de routine et travaille avec des concepteurs et des analystes pour clarifier et améliorer les spécifications ou pour identifier des solutions de programmation alternatives."
            },
            new CompetencyLevelRequirement
            {
                Id = 570,
                DescEng =
                    "Manages software construction, testing, infrastructure, configuration, a wide range of system development methodologies, and operating standards on behalf of the Canadian Coast Guard. Analyzes how a change would affect multiple applications and users. Makes recommendations/decisions in application and program design, standards, and program enhancements, including those related to privacy, accessibility for persons with disabilities, usability and inter-operability. Debugs very complex or urgent problems. Analyzes and models business functions, processes, and information flow within or between systems. Provides guidance/mentors on programming practices and techniques to individuals.",
                DescFre =
                    "Gère la construction, les tests, l'infrastructure, la configuration des logiciels, un large éventail de méthodologies de développement de systèmes et les normes d'exploitation au nom de la Garde côtière canadienne. Analyse la manière dont un changement affecterait de multiples applications et utilisateurs. Formule des recommandations/décisions concernant la conception des applications et des programmes, les normes et les améliorations des programmes, y compris celles liées à la confidentialité, à l'accessibilité pour les personnes ayant des incapacités, à la convivialité et à l'interopérabilité. Débogage de problèmes très complexes ou urgents. Analyse et modélise les fonctions, les processus et les flux d'informations au sein des systèmes ou entre eux. Fournit des conseils/mentors sur les pratiques et techniques de programmation aux individus."
            },
            new CompetencyLevelRequirement
            {
                Id = 571,
                DescEng =
                    "Provides effective strategic direction to enterprise-wide application design. Guides and oversees multiple-concurrent software construction projects. Works with users at all levels to define system requirements and specify appropriate system environments to meet operational needs and system requirements. Presents software construction disciplines to peers in public forums. Develops policy and standards for software construction on behalf of the Coast Guard.",
                DescFre =
                    "Fournit une orientation stratégique efficace pour la conception d'applications à l'échelle de l'entreprise. Guide et supervise de multiples projets de construction de logiciels simultanés. Travaille avec les utilisateurs à tous les niveaux pour définir les exigences du système et spécifier les environnements système appropriés pour répondre aux besoins opérationnels et aux exigences du système. Présente les disciplines de construction de logiciels à ses pairs dans des forums publics. Élabore des politiques et des normes pour la construction de logiciels au nom de la Garde côtière."
            },
            new CompetencyLevelRequirement
            {
                Id = 572,
                DescEng =
                    "Operates the platform at a basic level under supervision, according to standards for the platform.",
                DescFre =
                    "Exploite la plate-forme à un niveau de base sous supervision, selon les normes de la plate-forme."
            },
            new CompetencyLevelRequirement
            {
                Id = 573,
                DescEng =
                    "Operates the platform using technology and concepts that relate to each other, and with other environments. Troubleshoots basic physical or software problems. Applies the standards, including those related to privacy, accessibility for persons with disabilities, usability, and inter-operability.",
                DescFre =
                    "Exploite la plate-forme en utilisant des technologies et des concepts qui sont en relation les uns avec les autres et avec d'autres environnements. Dépanne les problèmes physiques ou logiciels de base. Applique les normes, notamment celles relatives à la protection de la vie privée, à l'accessibilité pour les personnes ayant des incapacités, à la convivialité et à l'interopérabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 574,
                DescEng =
                    "Participates in daily operations (e.g. monitoring operations of the platform). Uses performance data collection tools and techniques. Installs software and hardware on the platform. Solves routine, typical hardware and software problems. Uses diagnostic tools to solve complex problems.",
                DescFre =
                    "Participe aux opérations quotidiennes (par exemple, surveiller les opérations de la plate-forme). Utilise des outils et des techniques de collecte de données sur les performances. Installe des logiciels et du matériel sur la plate-forme. Résout les problèmes routiniers, typiques du matériel et des logiciels. Utilise des outils de diagnostic pour résoudre des problèmes complexes."
            },
            new CompetencyLevelRequirement
            {
                Id = 575,
                DescEng =
                    "Contributes to high-level architecture. Evaluates/pilots new technologies, assesses the results, identifies how they integrate with the platform, and implements them. Carries out performance measurement and capacity planning. Incorporates business requirements such as high availability, redundancy, and disaster recovery into platform design. Resolves complex problems. Develops and monitors/enforces standards and procedures for new technology configuration and implementation, including those related to accessibility for persons with disabilities. Mentors/guides individuals and cross-functional teams.",
                DescFre =
                    "Contribue à l'architecture de haut niveau. Évalue/pilote les nouvelles technologies, évalue les résultats, identifie la manière dont elles s'intègrent à la plate-forme et les met en œuvre. Effectue la mesure des performances et la planification des capacités. Intègre les exigences opérationnelles telles que la haute disponibilité, la redondance et la reprise après sinistre dans la conception de la plateforme. Résout les problèmes complexes. Élabore et surveille/met à exécution des normes et des procédures pour la configuration et la mise en œuvre de nouvelles technologies, y compris celles liées à l'accessibilité pour les personnes ayant des incapacités. Encadre et guide les personnes et les équipes interfonctionnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 576,
                DescEng =
                    "Advices on platform principles, technology, government-wide technology initiatives, and technological trends. Provides effective strategic direction to enterprise-wide platform design and initiatives. Develops enterprise-wide multi-disciplinary architectural and design documents. Resolves complex problems and recommends capacity and performance improvements. Conducts procurement for platform hardware and services. Sets standards and technology direction for the platform, including those related to accessibility for persons with disabilities. Leads the development of people in the infrastructure domain.",
                DescFre =
                    "Conseils sur les principes des plates-formes, la technologie, les initiatives technologiques à l'échelle du gouvernement et les tendances technologiques. Fournit une orientation stratégique efficace pour la conception et les initiatives de plate-forme à l'échelle de l'entreprise. Élabore des documents d'architecture et de conception pluridisciplinaires à l'échelle de l'entreprise. Résout des problèmes complexes et recommande des améliorations de capacité et de performance. Effectue les achats de matériel et de services pour la plate-forme. Établit les normes et l'orientation technologique de la plate-forme, y compris celles relatives à l'accessibilité pour les personnes ayant une invalidité. Dirige le développement des personnes dans le domaine de l'infrastructure."
            },
            new CompetencyLevelRequirement
            {
                Id = 577,
                DescEng =
                    "Employs elements of the security standards related to information technology (IT) with assistance.",
                DescFre =
                    "Emploie avec assistance des éléments des normes de sécurité liées aux technologies de l'information (TI)."
            },
            new CompetencyLevelRequirement
            {
                Id = 578,
                DescEng =
                    "Applies concepts of information technology (IT) security and its application to computer systems architecture.",
                DescFre =
                    "Applique les concepts de sécurité des technologies de l'information (TI) et leur application à l'architecture des systèmes informatiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 579,
                DescEng =
                    "Executes security test plans. Deals with low impact threats. Protects integrity of system data at an operational level. Performs security certifications. Provides advice on disaster recovery planning. Participates in disaster recovery tests. Recommends security safeguards. Executes standards.",
                DescFre =
                    "Exécute les plans de test de sécurité. Traite les menaces à faible impact. Protège l'intégrité des données du système à un niveau opérationnel. Effectue des certifications de sécurité. Fournit des conseils sur la planification de la récupération après sinistre. Participe aux tests de reprise après sinistre. Recommande des mesures de sécurité. Exécute les normes."
            },
            new CompetencyLevelRequirement
            {
                Id = 580,
                DescEng =
                    "Conducts risk assessments and security safeguards. Deals with threats and serious incidents. Deals with intrusions at a high threat level.",
                DescFre =
                    "Effectue des évaluations des risques et des mesures de sécurité. Traite les menaces et les incidents graves. Traite les intrusions à haut niveau de menace."
            },
            new CompetencyLevelRequirement
            {
                Id = 581,
                DescEng =
                    "Interprets regulations, policies, and standards related to information technology (IT) security. Leads risk and security safeguards assessments. Mitigates threats and serious security incidents at the enterprise level. Consults on security issues and recommends corporate strategies. Leads the development of enterprise policies and standards.",
                DescFre =
                    "Interprète les règlements, politiques et normes relatifs à la sécurité des technologies de l'information (TI). Dirige les évaluations des risques et des mesures de sécurité. Atténue les menaces et les incidents de sécurité graves au niveau de l'entreprise. Consulte sur les questions de sécurité et recommande des stratégies corporatives. Dirige l'élaboration de politiques et de normes d'entreprise."
            },
            new CompetencyLevelRequirement
            {
                Id = 582,
                DescEng =
                    "Employs service management processes and concepts (e.g. incident management, change management, release management) with assistance.",
                DescFre =
                    "Emploie des processus et des concepts de gestion des services (par exemple, gestion des incidents, gestion des changements, gestion des versions) avec assistance."
            },
            new CompetencyLevelRequirement
            {
                Id = 583,
                DescEng =
                    "Follows a process in problem management, change management, or configuration management. Provides information technology (IT) help desk support services. Gathers information from end-users to determine the nature of problems and resolves them. Adheres to service level agreements (SLAs) and escalates problems. Performs initial evaluations of problems and routes, when and where applicable.",
                DescFre =
                    "Suit un processus de gestion des problèmes, de gestion des changements ou de gestion de la configuration. Fournit des services d'assistance en matière de technologies de l'information (TI). Recueille des informations auprès des utilisateurs finaux afin de déterminer la nature des problèmes et de les résoudre. Respecte les accords sur les niveaux de service (ANS) et fait remonter les problèmes. Effectue des évaluations initiales des problèmes et les achemine, le cas échéant."
            },
            new CompetencyLevelRequirement
            {
                Id = 584,
                DescEng =
                    "Installs, configures, troubleshoots, and supports application software. Analyzes, evaluates, and diagnoses technical problems and proposes solutions. Manages process ensuring it is followed (e.g. change, problem, testing, costing, backup and recovery, quality assurance releases). Schedules releases after ensuring absence of conflicts. Guides others and implements changes to processes.",
                DescFre =
                    "Installe, configure, dépanne et prend en charge les logiciels d'application. Analyse, évalue et diagnostique les problèmes techniques et propose des solutions. Gère le processus en veillant à ce qu'il soit suivi (par exemple, changement, problème, test, calcul des coûts, sauvegarde et récupération, versions d'assurance qualité). Planifie les versions après s'être assuré de l'absence de conflits. Guide les autres et mets en œuvre les changements apportés aux processus."
            },
            new CompetencyLevelRequirement
            {
                Id = 585,
                DescEng =
                    "Manages the provision of help desk services and problem resolution. Analyzes problem trends and makes recommendations. Develops service management processes. Writes/negotiates service level agreements (SLAs) for operational and internal agreements. Establishes and monitors service standards.",
                DescFre =
                    "Gère la fourniture de services d'assistance et la résolution des problèmes. Analyse les tendances des problèmes et fait des recommandations. Développe les processus de gestion des services. Rédige/négocie des accords sur les niveaux de service (ANS) pour les accords opérationnels et internes. Établit et surveille les normes de service."
            },
            new CompetencyLevelRequirement
            {
                Id = 586,
                DescEng =
                    "Negotiates, develops, implements, and manages service level agreements (SLAs). Develops service management standards, practices, and policies. Provides guidelines for service management (e.g. recommends changes based upon results of a customer satisfaction survey). Recommends continual improvement in service management strategy and processes.",
                DescFre =
                    "Négocie, développe, met en œuvre et gère les accords sur les niveaux de service (ANS). Élabore des normes, des pratiques et des politiques de gestion des services. Fournit des lignes directrices pour la gestion des services (par exemple, recommande des changements sur la base des résultats d'une enquête de satisfaction des clients). Recommande l'amélioration continue de la stratégie et des processus de gestion des services."
            },
            new CompetencyLevelRequirement
            {
                Id = 587,
                DescEng =
                    "Applies basic testing terminology, practices, and procedures to tasks related to testing a system's effectiveness.",
                DescFre =
                    "Applique la terminologie, les pratiques et les procédures de test de base aux tâches liées à l'évaluation de l'efficacité d'un système."
            },
            new CompetencyLevelRequirement
            {
                Id = 588,
                DescEng =
                    "Conducts unit testing using via approved testing tools and established standards for testing. Executes test scripts. Reports test results.",
                DescFre =
                    "Effectue des tests unitaires en utilisant des outils de test approuvés et des normes de test établies. Exécute des scripts de test. Rapporte les résultats des tests."
            },
            new CompetencyLevelRequirement
            {
                Id = 589,
                DescEng =
                    "Prepares test cases/scripts. Carries out complex testing/validation (e.g. volume testing, integration testing). Troubleshoots and resolves issues. Applies standards for testing, including a methodology and test plan to address accessibility for persons with disabilities, copyright, privacy, usability, and inter-operability.",
                DescFre =
                    "Prépare les tests/scripts. Effectue des tests/validations complexes (par exemple, tests de volume, tests d'intégration). Dépanne et résout les problèmes. Applique des normes de test, y compris une méthodologie et un plan de test pour aborder les questions d'accessibilité pour les personnes ayant une incapacité, de droits d'auteur, de respect de la vie privée, de convivialité et d'interopérabilité."
            },
            new CompetencyLevelRequirement
            {
                Id = 590,
                DescEng =
                    "Conducts application testing and complex series test scenarios. Prepares test plans and strategies. Researches and tests testing tools and makes recommendations. Develops test practices. Implements and monitors standards for testing. Guides application stakeholders in testing methods and tools.",
                DescFre =
                    "Effectue des tests d'application et des scénarios de tests en série complexes. Prépare des plans et des stratégies de test. Effectue des recherches et des tests sur les outils de test et formule des recommandations. Développe des pratiques de test. Mets en œuvre et surveille les normes de test. Guide les parties prenantes de l'application dans les méthodes et les outils de test."
            },
            new CompetencyLevelRequirement
            {
                Id = 591,
                DescEng =
                    "Manages integration testing. Sets standards for cycle testing. Designs and implements organizational testing methodologies and test plans. Develops test standards, best practices, and policies.",
                DescFre =
                    "Gère les tests d'intégration. Établit des normes pour les tests de cycle. Conçoit et met en œuvre des méthodologies de test organisationnel et des plans de test. Élabore des normes de test, des meilleures pratiques et des politiques."
            },
            new CompetencyLevelRequirement
            {
                Id = 592,
                DescEng =
                    "Manipulates database information, using logical design concepts, and levels of database security. Applies various database structures (e.g. relational vs. network) in basic design (e.g. diagrams, schemas, models). Addresses minor performance issues (e.g. distribution of data, size definitions).",
                DescFre =
                    "Manipule les informations des bases de données, en utilisant des concepts de conception logique et des niveaux de sécurité des bases de données. Applique diverses structures de base de données (par exemple, relationnelle ou réseau) dans la conception de base (par exemple, diagrammes, schémas, modèles). Résoudre des problèmes mineurs de performance (par exemple, la distribution des données, les définitions de taille)."
            },
            new CompetencyLevelRequirement
            {
                Id = 593,
                DescEng =
                    "Manages a single database management system (DBMS), its components and how they relate to each other. Codes/tests basic database access modules (e.g. stored procedures). Troubleshoots, at a basic level, to understand database problems and identifies where to direct it (e.g. basic database accessibility). Recognizes the importance of database basic recovery and, with guidance, performs backup and recovery. Performs data population, debugging, and testing. Conducts basic impact analysis for database change management.",
                DescFre =
                    "Gère un système de gestion de base de données (SGBD) unique, ses composants et leurs relations entre eux. code/teste les modules d'accès de base aux bases de données (par exemple, les procédures stockées). Dépanne, à un niveau élémentaire, pour comprendre les problèmes de la base de données et identifie où la diriger (par exemple, l'accessibilité de base de la base de données). Reconnaît l'importance de la récupération de base de données et, avec des conseils, effectue la sauvegarde et la récupération. Effectue la population de données, le débogage et les tests. Effectue une analyse d'impact de base pour la gestion des modifications de la base de données."
            },
            new CompetencyLevelRequirement
            {
                Id = 594,
                DescEng =
                    "Manages single database management systems (DBMS) and its relevant operating systems, applications business rules, and its dependencies with other applications, databases and/or business partners in daily tasks. Applies a wide range of concepts to the corporate/vendor environment (e.g. database security and/or individual profiles).Develops, codes, tests, and reviews complex database access modules. Solves problems that impact on the business or service, resolves data integrity issues and implements data integrity safeguards, and uses diagnostic and monitoring tools to prevent problems/enhance performance and availability. Conducts general impact analysis on database change management.",
                DescFre =
                    "Gère les systèmes de gestion de base de données (SGBD) uniques et leurs systèmes d'exploitation pertinents, les règles de gestion des applications et leurs dépendances avec d'autres applications, bases de données et/ou partenaires opérationnels dans les tâches quotidiennes. Applique un large éventail de concepts à l'environnement de l'entreprise ou du fournisseur (par exemple, la sécurité des bases de données et/ou les profils individuels). Développe, code, teste et examine des modules complexes d'accès aux bases de données. Résout les problèmes qui ont un impact sur les activités ou les services, résout les problèmes d'intégrité des données et met en œuvre des mesures de protection de l'intégrité des données, et utilise des outils de diagnostic et de surveillance pour prévenir les problèmes/améliorer les performances et la disponibilité. Effectue une analyse générale de l'impact sur la gestion des modifications des bases de données."
            },
            new CompetencyLevelRequirement
            {
                Id = 595,
                DescEng =
                    "Manages multiple database management systems (DBMS). Develops logical models incorporating business requirements such as high availability, redundancy and disaster recovery into the logical/physical database design. Researches, pilots, evaluates new technologies and standards, and identifies how they will integrate with the corporate network, and recommends strategies. Solves unusual problems or problems with a significant impact on the business. Deals with major and/or multiple application groups. Creates or reviews certification testing. Develops standards and procedures for implementing new database technology. Mentors people and provides input/guidance to cross-functional teams.",
                DescFre =
                    "Gère plusieurs systèmes de gestion de bases de données (SGBD). Développe des modèles logiques incorporant des exigences opérationnelles telles que la haute disponibilité, la redondance et la reprise après sinistre dans la conception logique/physique des bases de données. Effectue des recherches, pilote, évalue les nouvelles technologies et normes, et identifie comment elles s'intégreront au réseau de l'entreprise, et recommande des stratégies. Résout les problèmes inhabituels ou ayant un impact important sur l'entreprise. Traite des groupes d'applications majeurs et/ou multiples. Crée ou révise des tests de certification. Élabore des normes et des procédures pour la mise en œuvre de nouvelles technologies de bases de données. Encadre les personnes et fournit une contribution/orientation aux équipes interfonctionnelles."
            },
            new CompetencyLevelRequirement
            {
                Id = 596,
                DescEng =
                    "Manages data management, data stewardship, government-wide data management initiatives, and trends in data management and how they can be applied on behalf of the Canadian Coast Guard. Provides effective strategic direction to enterprise-wide data management. Develops enterprise-wide multi-disciplinary architectural documents translating business data requirements into topographical format. Develops business cases for enterprise-wide data management initiatives as a direct response to business drivers. Guides and oversees multiple-concurrent data management systems. Conducts procurement for data management solutions and related services. Develops strategies, policy, and standards for corporate data management and contributes to governmental working groups.",
                DescFre =
                    "Gère la gestion des données, l'intendance des données, les initiatives de gestion des données à l'échelle du gouvernement et les tendances en matière de gestion des données et la façon dont elles peuvent être appliquées au nom de la Garde côtière canadienne. Fournit une orientation stratégique efficace pour la gestion des données à l'échelle de l'entreprise. Elabore des documents d'architecture multidisciplinaires à l'échelle de l'entreprise en traduisant les besoins en données opérationnelles en format topographique. Élabore des analyses de rentabilisation pour les initiatives de gestion des données à l'échelle de l'entreprise en réponse directe aux facteurs opérationnels. Guide et supervise des systèmes de gestion de données multiples et simultanées. Effectue des achats pour des solutions de gestion de données et des services connexes. Développe des stratégies, des politiques et des normes pour la gestion des données d'entreprise et contribue aux groupes de travail gouvernementaux."
            },
            new CompetencyLevelRequirement
            {
                Id = 597,
                DescEng =
                    "Basic knowledge of ship or land based marine electronic devices commonly used in the Coast Guard.",
                DescFre =
                    "Connaissance de base des appareils électroniques marins utilisés couramment par la Garde côtière, à bord des navires ou à terre."
            },
            new CompetencyLevelRequirement
            {
                Id = 598,
                DescEng =
                    "Limited knowledge of the function, installation and connection requirements of commonly installed marine electronic equipment. Understands how to install, adjust, or maintain electronics communication equipment, including sound, sonar, security, navigation, and surveillance systems. Understands technical manuals and written procedures.",
                DescFre =
                    "Connaissance limitée des exigences en matière de fonctionnement, d’installation et de connexion des équipements électroniques marins couramment installés. Comprendre comment installer, régler ou entretenir des équipements de communication électroniques, y compris les systèmes de sonorisation, les systèmes sonar, les systèmes de sécurité, de navigation et de surveillance. Comprendre les manuels techniques et les procédures écrites."
            },
            new CompetencyLevelRequirement
            {
                Id = 599,
                DescEng =
                    "Practical knowledge of generic procedures for programming electronic equipment in accordance with industry practice. Understands the procedures for commissioning and replacement of electronic equipment. Understands the selection considerations, maintenance, and troubleshooting of electronic equipment.",
                DescFre =
                    "Connaissance pratique des procédures génériques de programmation des équipements électroniques conformément aux pratiques de l’industrie. Comprendre les procédures de mise en service et de remplacement des équipements électroniques. Comprendre les questions de sélection, d’entretien et de dépannage des équipements électroniques."
            },
            new CompetencyLevelRequirement
            {
                Id = 600,
                DescEng =
                    "Advanced knowledge of procedures for programming, commissioning, replacement, and troubleshooting of marine electronic equipment. Understands equipment specifications and marine electronic equipment selection considerations.",
                DescFre =
                    "Connaissance avancée des procédures de programmation, de mise en service, de remplacement et de dépannage des équipements électroniques marins. Comprendre les spécifications des équipements et les questions relatives au choix des équipements électroniques maritimes."
            },
            new CompetencyLevelRequirement
            {
                Id = 601,
                DescEng =
                    "Expert knowledge in identifying complex problems and reviewing related information to develop and evaluate options and implement solutions. ",
                DescFre =
                    "Connaissance approfondie de la définition de problèmes complexes et de l’examen d’information connexe pour élaborer et évaluer des options et mettre en œuvre des solutions."
            }
        };
    }
}