using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<Competency> Competencies = new List<Competency>()
        {
            new Competency
            {
                Id = 1, NameEng = "Organizational Knowledge", NameFre = "Connaissances organisationnelles",
                DescEng = "Knowledge of the Canadian Coast Guard organization, its partners, and relationships with the Department of Fisheries and Oceans (DFO) and other internal and external stakeholders.",
                DescFre = "Connaissance de l'organisation de la Garde côtière canadienne, de ses partenaires et des relations avec le ministère des pêches et océans (MPO) et d'autres intervenants internes et externes.",
                Active = 1
            },
            new Competency
            {
                Id = 2, NameEng = "Program Knowledge and Application", NameFre = "Connaissance et application du programme",
                DescEng = "Knowledge of the programs the Canadian Coast Guard manages and supports. Understands the services and delivery of program mandates:  Search and Rescue (SAR), Icebreaking (IB), Aids to Navigation (AtoN), Environmental Response (ER), Conservation and Protection (DFO C&P), Oceanography (DFO Science) and Fisheries Research (DFO Science).",
                DescFre = "Connaissance des programmes que la Garde côtière canadienne gère et soutient. Comprend les services et l'exécution des mandats des programmes :  Recherche et sauvetage (SAR), Déglaçage, Aides à la navigation (AIDNAV), Intervention environnementale (IE), Conservation et protection (C&P du MPO), Océanographie (Sciences du MPO) et Recherche halieutique (Sciences du MPO).",
                Active = 1
            },
            new Competency
            {
                Id = 3, NameEng = "Administrative Knowledge", NameFre = "Connaissances en administration",
                DescEng = "Understanding of administrative procedures and processes in one or more area of responsibility.",
                DescFre = "Compréhension des procédures et processus administratifs dans un ou plusieurs domaines de responsabilité.",
                Active = 1
            },
            new Competency
            {
                Id = 4, NameEng = "Incident Command System (ICS) Knowledge", NameFre = "Connaissance des systèmes de commandement des incidents (SCI)",
                DescEng = "Knowledge of the Incident Command System (ICS), its functions, role, and reporting structures. Knowledge of procedures and processes involved in an emergency response.",
                DescFre = "Connaissance du Système de commandement du lieu de l'incident (SCI), de ses fonctions, de son rôle et de ses structures hiérarchiques. Connaissance des procédures et des processus d'intervention en cas d'urgence.",
                Active = 1
            },
            new Competency
            {
                Id = 5, NameEng = "Seagoing Personnel Management Knowledge", NameFre = "Connaissance de la gestion du personnel navigant",
                DescEng = "Knowledge of policies and directives on the management and administration of workforce management (HR) issues affecting seagoing personnel.",
                DescFre = "Connaissance des politiques et directives relatives à la gestion et à l'administration des questions de gestion des effectifs (RH) touchant le personnel navigant.",
                Active = 1
            },
            new Competency
            {
                Id = 6, NameEng = "Maritime Security (MSOC) Knowledge", NameFre = "Connaissance du Centre des opérations de la sûreté maritime (COSM)",
                DescEng = "Knowledge of the coastal marine domain factors such as meteorology, shipping patterns, and security resources. Knowledge of the coastal security nets, its players, authorities, and roles. Knowledge of agency interoperabilities.",
                DescFre = "Connaissance des facteurs du domaine maritime côtier tels que la météorologie, les modèles de transport maritime et les ressources de sécurité. Connaissance des filets de sécurité côtiers, de leurs parties concernées, de leurs autorités et de leurs rôles. Connaissance de l'interopérabilité des agences.",
                Active = 1
            },
            new Competency
            {
                Id = 7, NameEng = "Knowledge of Systems Approach to Training", NameFre = "Connaissance de l'approche systémique de la formation",
                DescEng = "Knowledge of the step by step process of analysis, design, development, implementation, and evaluation in the course of delivering training. May also be referred to as Instructional Systems Design, or ISD.",
                DescFre = "Connaissance du processus étape par étape d'analyse, de conception, d'élaboration, de mise en œuvre et d'évaluation dans le cadre de la prestation de la formation. On peut aussi parler de conception de systèmes d'enseignement, ou DSI.",
                Active = 1
            },
            new Competency
            {
                Id = 8, NameEng = "Knowledge of Specialized Fields", NameFre = "Connaissance des domaines spécialisés",
                DescEng = "Knowledge of specialized fields, including concepts, theories, principles, methods, techniques, and practices. Such knowledge can be acquired through formal education, experience, specialized or on-the-job training, self-education, or a combination.",
                DescFre = "Connaissance de domaines spécialisés, y compris les concepts, théories, principes, méthodes, techniques et pratiques. Ces connaissances peuvent être acquises par le biais de l'éducation formelle, de l'expérience, de la formation spécialisée ou en cours d'emploi, de l'auto-éducation ou d'une combinaison des deux.",
                Active = 1
            },
            new Competency
            {
                Id = 9, NameEng = "Project/Program Management", NameFre = "Gestion de projet / programme",
                DescEng = "Program management is the management of a program or part of a programme and/or a series of projects, involving in-depth and extensive knowledge of areas such as procedures, operations, policies and other departments, agencies or the private sector, as well as specialized technical knowledge of programs. Project management involves effectively integrating and/or participating in all aspects of a finished project, ensuring that work progresses towards the achievement of goals and objectives.",
                DescFre = "La gestion de programme est la gestion d’un programme ou d’une partie d’un programme et/ou d’une série de projets, comprenant une connaissance approfondie et étendue des domaines tels que les procédures, les opérations, les politiques et la d’autres ministères, d’organismes ou du secteur privé ainsi que des connaissances techniques spécialisées en matière de programmes. La gestion de projet implique de participer et/ou d’intégrer efficacement tous les aspects d’un projet fini, en veillant à ce que les travaux progressent dans la réalisation des buts et objectifs.",
                Active = 1
            },
            new Competency
            {
                Id = 10, NameEng = "Planning and Priority Setting", NameFre = "Planification et établissement de priorités",
                DescEng = "Logically integrates various ideas, intentions and information to define goals, objectives, schedules, action plans and effective solutions.",
                DescFre = "Intègre diverses idées, intentions et informations pour former des buts, objectifs, calendriers, plans d'action et solutions efficaces.",
                Active = 1
            },
            new Competency
            {
                Id = 11, NameEng = "Procurement and Purchasing", NameFre = "Approvisionnement et achats",
                DescEng = "Ability to manage the process of selecting suppliers, establishing terms of payment, implementing strategic validation, making selections, negotiating contracts and purchasing goods.",
                DescFre = "Aptitude à gérer le processus de sélection des fournisseurs, l'établissement des conditions de paiement, de validation stratégique, de sélection, de négociation de contrats et d'achat de biens.",
                Active = 1
            },
            new Competency
            {
                Id = 12, NameEng = "Workforce Management (HR) for Specialists", NameFre = "Gestion de la main-d'œuvre (RH) pour les spécialistes",
                DescEng = "Plans, organizes, controls, and evaluates the operations of workforce management and personnel units. Develops and implements policies, programs, and procedures regarding workforce planning, recruitment, training, wellness, and career development.",
                DescFre = "Planifier, organiser, contrôler et évaluer les opérations des unités de gestion des effectifs et du personnel. Élaborer et mettre en œuvre des politiques, des programmes et des procédures concernant la planification des effectifs, le recrutement, la formation, le bien-être et le perfectionnement professionnel.",
                Active = 1
            },
            new Competency
            {
                Id = 13, NameEng = "Financial Management for Specialists", NameFre = "Gestion financière pour les spécialistes",
                DescEng = "Applies required financial procedures and tracking in order to manage public funds in an appropriate manner.",
                DescFre = "Applique les procédures et le suivi financiers nécessaires pour gérer les fonds publics de manière appropriée.",
                Active = 1
            },
            new Competency
            {
                Id = 14, NameEng = "Communications for Specialists", NameFre = "Communications pour les spécialistes",
                DescEng = "Encompasses written, oral, visual, and digital communication in an organizational context, as a specialty. Focuses on the study of information and the ways it is planned, created, managed, distributed, and consumed within the Canadian Coast Guard.",
                DescFre = "Comprend la communication écrite, orale, visuelle et numérique dans un contexte organisationnel, en tant que spécialité. Se concentre sur l'étude de l'information et sur la façon dont elle est planifiée, créée, gérée, distribuée et consommée au sein de la Garde côtière canadienne.",
                Active = 1
            },
            new Competency
            {
                Id = 15, NameEng = "Real Property and Facilities Management", NameFre = "Biens immobiliers et gestion des installations",
                DescEng = "Manages real property and facilities management activities on a whole-life basis.",
                DescFre = "Gère les activités de gestion des biens immobiliers et des installations sur toute leur durée de vie.",
                Active = 1
            },
            new Competency
            {
                Id = 16, NameEng = "Business Analysis", NameFre = "Analyse d'affaires",
                DescEng = "Establishes and enables processes in an organizational context, by defining needs and recommending solutions that deliver value to Canadian Coast Guard stakeholders.",
                DescFre = "Établit et facilite les processus dans un contexte organisationnel, en définissant les besoins et en recommandant des solutions qui apportent de la valeur aux intervenants.",
                Active = 1
            },
            new Competency
            {
                Id = 17, NameEng = "Support Services", NameFre = "Services de soutien",
                DescEng = "Provides a high standard of service to Canadian Coast Guard members and other stakeholders.",
                DescFre = "Fournit un service de haute qualité aux membres de la Garde côtière canadienne et aux autres parties prenantes.",
                Active = 1
            },
            new Competency
            {
                Id = 18, NameEng = "Workforce Management (HR) for Supervisors/Managers", NameFre = "Gestion de l’effectif (RH) pour les superviseurs et les gestionnaires",
                DescEng = "Manages unit or units workforce planning, recruitment, organizational design, classification issues, training and development, employment equity, official languages issues, performance management/labour relations, compensation issues, and rewards/recognition items.",
                DescFre = "Gérer la planification des effectifs de l’unité ou des unités, le recrutement, la conception organisationnelle, les questions de classification, la formation et le perfectionnement, l’équité en matière d’emploi, les questions de langues officielles, la gestion du rendement et les relations de travail, les questions de rémunération et les mesures de récompense et reconnaissance.",
                Active = 1
            },
            new Competency
            {
                Id = 19, NameEng = "Financial Management for Supervisors/Managers", NameFre = "Gestion financière pour les superviseurs et les gestionnaires",
                DescEng = "Applies the rules, policies, regulations, and procedures of the Financial Administration Act as they apply to the Canadian Coast Guard as well as the organization's financial assets and management procedures (including related procurement rules) such as: financial authority level and approval process, financial accounting procedures, public accountability, budgeting, projecting, monitoring, reporting, financial auditing, etc.",
                DescFre = "Applique les règles, politiques, règlements et procédures de la Loi sur I' administration financière tels qu'ils s'appliquent à la Garde côtière canadienne ainsi que les actifs financiers et les procédures de gestion de l'organisation (y compris les règles d'approvisionnement connexes) tels que : le niveau d'autorité financière et le processus d'approbation, les procédures de comptabilité financière, la responsabilité publique, la budgétisation, la projection, la surveillance, la présentation de rapports, la vérification financière, etc.",
                Active = 1
            },
            new Competency
            {
                Id = 20, NameEng = "Hotel Services Management", NameFre = "Gestion des services hôteliers",
                DescEng = "Consults with the chief cook in preparing menus and the economical use of provisions. Consults with the steward on all matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores, supplies, and provisions.",
                DescFre = "Consulte le chef cuisinier pour la préparation des menus et l'utilisation économique des provisions. Consulte le steward sur toutes les questions relatives à l'hébergement, aux installations sanitaires et aux buanderies. Établit les exigences et les procédures pour la réquisition, la réception, le stockage et la distribution des fournitures. Collabore avec les officiers du service des machines pour le chargement et le déplacement des magasins, des fournitures et des provisions.",
                Active = 1
            },
            new Competency
            {
                Id = 21, NameEng = "Maritime Security Operations Centre (MSOC)", NameFre = "Centre des opérations de la sûreté maritime (COSM)",
                DescEng = "Analyzes and gathers information to produce intelligence-driven products in collaboration with interdepartmental partners. Compiles data and information gathered from surveillance activities, intelligence investigations, security events, or incidents.",
                DescFre = "Analyse et rassemble les informations pour produire des produits axés sur le renseignement en collaboration avec des partenaires interministériels. Compile les données et les informations recueillies lors d'activités de surveillance, d'enquêtes en matière de renseignement, d'événements de sûreté ou d'incidents.",
                Active = 1
            },
            new Competency
            {
                Id = 22, NameEng = "Quality Assurance (QA)", NameFre = "Assurance de la qualité (AQ)",
                DescEng = "All planned and systematic activities implemented within the quality system that can be demonstrated to provide assurance that a product or service will meet quality requirements.",
                DescFre = "Toutes les activités planifiées et systématiques mises en œuvre dans le système de qualité qui peuvent être démontrées pour donner l’assurance qu’un produit ou un service répondra aux exigences de qualité.",
                Active = 1
            },
            new Competency
            {
                Id = 23, NameEng = "Materiel Management", NameFre = "Gestion du matériel",
                DescEng = "Classifies materiel according to Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal.",
                DescFre = "Classifie le matériel selon les directives de la Garde côtière canadienne et des Services publics et Approvisionnement Canada (SPAC). Assure le suivi du matériel pendant la réception, l'entreposage, la distribution et l'élimination.",
                Active = 1
            },
            new Competency
            {
                Id = 24, NameEng = "Exercise Planning", NameFre = "Planification d'exercices",
                DescEng = "Plans and develops exercises (simulations of an emergency situation), which includes validating exercise plans, developing member skills, testing them during exercises, and testing established procedures. It includes a visual overview of the exercise, tracks related hours/cost of exercise, assigns responsibilities and logistical tasks.",
                DescFre = "Planifie et développe des exercices (simulations d'une situation d'urgence), ce qui inclut la validation des plans d'exercices, le développement des compétences des membres, leur mise à l'épreuve lors des exercices et la mise à l'épreuve des procédures établies. Il comprend une vue d'ensemble visuelle de l'exercice, le suivi des heures/coûts de l'exercice, l'attribution des responsabilités et des tâches logistiques. ",
                Active = 1
            },
            new Competency
            {
                Id = 25, NameEng = "Adult Teaching", NameFre = "Enseignement aux adultes",
                DescEng = "Teaching or instructing adults in systematic and sustained self-educating activities so that they may gain new forms of knowledge, skills, attitudes, or values. This includes various forms of specific and generic instruction as required by the Canadian Coast Guard with an emphasis on the needs of adults and the results orientation of the organization.",
                DescFre = "Enseigner ou instruire des adultes dans des activités d'auto-éducation systématiques et soutenues afin qu'ils puissent acquérir de nouvelles formes de connaissances, de compétences, d'attitudes ou de valeurs. Cela comprend diverses formes d'enseignement spécifique et générique, comme l'exige la Garde côtière canadienne, en mettant l'accent sur les besoins des adultes et l'orientation de l'organisation vers les résultats.",
                Active = 1
            },
            new Competency
            {
                Id = 26, NameEng = "Demonstrating Integrity and Respect", NameFre = "Faire preuve d'intégrité et de respect",
                DescEng = "Honours commitments and consistently strives to act in the public interest by ensuring that public trust and the law are not violated, while avoiding conflicts of interest and maintaining political and interpersonal neutrality.",
                DescFre = "Respecter ses engagements et s'efforcer constamment d'agir dans l'intérêt public en veillant à ce que la confiance du public et la loi ne soient pas violées, tout en évitant les conflits d'intérêts et en maintenant une neutralité politique et interpersonnelle.",
                Active = 1
            },
            new Competency
            {
                Id = 27, NameEng = "Thinking Things Through", NameFre = "Réflexion approfondie",
                DescEng = "Plans and adjusts work based on a thorough understanding of the Canadian Coast Guard's priorities. Obtains relevant information, considers all facts, and exercises sound judgement to formulate an opinion and/or make a decision. Analyzes situations and seeks feedback to learn from mistakes.",
                DescFre = "Planifier et ajuster le travail en fonction d'une compréhension approfondie des priorités de la Garde côtière canadienne. Obtenir l'information pertinente, examiner tous les faits et exercer un jugement éclairé pour formuler une opinion ou prendre une décision. Analyse les situations et cherche à obtenir de la rétroaction pour tirer des leçons des erreurs.",
                Active = 1
            },
            new Competency
            {
                Id = 28, NameEng = "Working Effectively With Others", NameFre = "Travailler efficacement avec les autres",
                DescEng = "Works cooperatively in order to achieve results. Works positively as part of a team and manages internal conflict. Identifies opportunities to work together within the organization to improve team dynamics and develop relationships. Seeks and builds internal/external alliances, collaborations, and partnerships to advance the Canadian Coast Guard's mandate.",
                DescFre = "Travaille en collaboration afin d'obtenir des résultats. Travaille positivement en équipe et gère les conflits internes. Identifie les occasions de travailler ensemble au sein de l'organisation pour améliorer la dynamique d'équipe et développer les relations. Recherche et établit des alliances, des collaborations et des partenariats internes et externes pour faire progresser le mandat de la Garde côtière canadienne.",
                Active = 1
            },
            new Competency
            {
                Id = 33, NameEng = "Showing Initiative and Being Action Oriented", NameFre = "Fait preuve d'initiative et est orienté vers l'action",
                DescEng = "Embraces change and actively looks for opportunities to learn and develop professionally and personally. Translates direction into concrete work activities. Identifies opportunities or issues, and takes action to enhance organizational results, without being prompted by others.",
                DescFre = "Adopte le changement et cherche activement des occasions d'apprendre et de se perfectionner sur les plans professionnel et personnel. Traduit l'orientation en activités de travail concrètes. Cerner les possibilités ou les enjeux et prendre des mesures pour améliorer les résultats de l'organisation, sans y être incité par d'autres.",
                Active = 1
            },
            new Competency
            {
                Id = 34, NameEng = "Apply Safety Considerations", NameFre = "Intègre les considérations relatives à la sécurité",
                DescEng = "Promotes workplace safety. Follows safety guidelines, procedures, and regulations. Reacts safely and appropriately during emergencies. Integrates health and safety considerations in planning, response, and reviews.",
                DescFre = "Favorise la sécurité au travail. Suit les directives, les procédures et les règlements en matière de sécurité. Réagit de manière sûre et appropriée en cas d'urgence. Intégrer les considérations de santé et de sécurité dans la planification, l'intervention et les examens.",
                Active = 1
            },
            new Competency
            {
                Id = 36, NameEng = "Leadership", NameFre = "Leadership",
                DescEng = "Attracts and mobilizes members and colleagues towards a shared vision and purpose in the best interests of the Canadian Coast Guard and the public it serves. Motivates project members, sets achievable objectives, maintains a positive outlook, takes responsibility, makes decisions, and provides constructive feedback.",
                DescFre = "Attire et mobilise les membres et les collègues vers une vision et un but communs dans le meilleur intérêt de la Garde côtière canadienne et du public qu'elle sert. Motiver les membres du projet, fixer des objectifs réalisables, maintenir une attitude positive, prendre des responsabilités, prendre des décisions et fournir une rétroaction constructive.",
                Active = 1
            },
            new Competency
            {
                Id = 37, NameEng = "Canadian Coast Guard Culture Awareness", NameFre = "Sensibilisation à la culture de la Garde côtière canadienne",
                DescEng = "The extent that members believe in the mission, mandate, and values of the Coast Guard and project that commitment through their actions and attitudes towards the organization and its stakeholders. Employee statements and deportment reflect a natural enthusiasm for the Coast Guard, what it does, and how it is viewed by the public.",
                DescFre = "La mesure dans laquelle les membres croient en la mission, le mandat et les valeurs de la Garde côtière et projettent cet engagement par leurs actions et leurs attitudes envers l'organisation et ses intervenants. Les déclarations et la conduite des employés reflètent un enthousiasme naturel pour la Garde côtière, ce qu'elle fait et comment elle est perçue par le public.",
                Active = 1
            },
            new Competency
            {
                Id = 38, NameEng = "Marine Domain Awareness Knowledge", NameFre = "Connaissances sur la sensibilisation au domaine marin",
                DescEng = "Having true and timely information about everything on, under, related to, adjacent to, or bordering a sea, ocean, or other navigable waterway. This includes all related activities, infrastructure, shipping, vessels, cartography, and natural phenomena. For marine security, it includes being aware of anything in the marine domain that could threaten Canada's national security.",
                DescFre = "Disposer d'informations vraies et à jour sur tout ce qui se trouve sur, sous, en dessous, en relation avec, à proximité ou en bordure d'une mer, d'un océan ou d'un autre cours d'eau navigable. Cela comprend toutes les activités connexes, l'infrastructure, le transport maritime, les navires, la cartographie et les phénomènes naturels. En ce qui concerne la sécurité maritime, il s'agit d'être au courant de tout ce qui, dans le domaine maritime, pourrait menacer la sécurité nationale du Canada.",
                Active = 1
            },
            new Competency
            {
                Id = 39, NameEng = "Canal Lock Knowledge", NameFre = "Connaissance des écluses de canal",
                DescEng = "Knowledge of all facets of the uses of, management, and maintenance of lock operation in the Canadian maritime domain.",
                DescFre = "Connaissance de toutes les facettes des usages, de la gestion et des activités d’entretien de l’exploitation des écluses dans le domaine maritime canadien.",
                Active = 1
            },
            new Competency
            {
                Id = 40, NameEng = "Operations and Maintenance", NameFre = "Exploitation et maintenance",
                DescEng = "Performs general labourer duties, building, vessel and grounds maintenance tasks, and transports materials and equipment.",
                DescFre = "Exécute des tâches de manœuvre générale, des tâches d'entretien des bâtiments, des navires et des terrains, et transporte des matériaux et des équipements.",
                Active = 1
            },
            new Competency
            {
                Id = 41, NameEng = "Heavy Machinery Operation", NameFre = "Utilisation de machinerie lourde",
                DescEng = "Drives or controls construction equipment including bulldozers, forklifts, back hoes, dump trucks, cargo trucks, and hydraulic truck cranes. Operated to assist in the construction of structures including bridges, roads, and buildings, vessels and Coast Guard structures, equipment, or facilities.",
                DescFre = "Conduire ou commander des engins de chantier, notamment des bouteurs, des chariots élévateurs à fourche, des pelles rétrocaveuses, des camions à benne basculante, des camions de fret et des grues hydrauliques sur camion. Cette machinerie lourde est utilisée pour aider à la construction de structures comme les ponts, les routes, les immeubles et les navires ainsi que les structures, l’équipement et les installations de la Garde côtière.",
                Active = 1
            },
            new Competency
            {
                Id = 42, NameEng = "Carpentry", NameFre = "La menuiserie",
                DescEng = "Applies skills of cutting, shaping, and installing building materials during the construction of buildings, ships, concrete formwork, and other physical structures, including rough and fine work.",
                DescFre = "Applique des compétences de coupe, de façonnage et d'installation de matériaux de construction lors de la construction de bâtiments, de navires, de coffrages en béton et d'autres structures physiques, y compris le travail grossier et le travail de précision.",
                Active = 1
            },
            new Competency
            {
                Id = 43, NameEng = "Electrical Analysis, Decision-Making and Evaluation", NameFre = "Examen, prise de décision et analyse de l’électricité",
                DescEng = "Ability to use effective approaches with the facts, constraints and predicted consequences available for marine electrical systems.",
                DescFre = "Aptitude à utiliser des approches efficaces avec les faits, les contraintes et les conséquences prévues disponibles pour les systèmes électriques marins.",
                Active = 1
            },
            new Competency
            {
                Id = 44, NameEng = "Heavy Machinery Maintenance", NameFre = "Entretien de machinerie lourde",
                DescEng = "Repairs, troubleshoots, adjusts, overhauls, and maintains mobile heavy-duty equipment.",
                DescFre = "Assurer la réparation, le dépannage, la mise au point, la remise en état et l’entretien de la machinerie lourde mobile.",
                Active = 1
            },
            new Competency
            {
                Id = 45, NameEng = "Automotive Service", NameFre = "Entretien d’automobiles",
                DescEng = "Performs preventative maintenance, diagnoses problems, and repairs vehicle systems including engines, vehicle management, hybrids, steering, braking, tires, wheels, drivetrains, suspension, electrical, electronics, heating, ventilation and air conditioning (HVAC), restraints, trim, and accessories of automotive vehicles and light trucks.",
                DescFre = "Effectuer l’entretien préventif, détecter les problèmes et réparer les systèmes des véhicules, y compris les moteurs, la gestion des véhicules, les véhicules hybrides, la direction, le système de freinage, les pneus, les roues, la transmission, la suspension, les composants électriques et électroniques, le système de chauffage, de ventilation et de climatisation (CVC), les dispositifs de retenue, la garniture ainsi que les accessoires des véhicules automobiles et des camionnettes.",
                Active = 1
            },
            new Competency
            {
                Id = 46, NameEng = "Painting and Decorating", NameFre = "Peinture et décoration",
                DescEng = "Prepares and applies paint or any organic/inorganic coating when applied in the same manner as paints.",
                DescFre = "Préparer et appliquer la peinture ou tout autre revêtement organique ou inorganique qui s’applique de la même façon que les peintures.",
                Active = 1
            },
            new Competency
            {
                Id = 47, NameEng = "Acts and Regulations Knowledge", NameFre = "Connaissance des lois et règlements",
                DescEng = "An understanding of the acts and regulations pertinent to operational programs, including their affective clauses, sources, authorities, and impacts on a given program or programs in the Canadian Coast Guard.",
                DescFre = "Compréhension des lois et règlements pertinents aux programmes opérationnels, y compris leurs clauses affectives, leurs sources, leurs pouvoirs et leurs répercussions sur un ou des programmes donnés de la Garde côtière canadienne.",
                Active = 1
            },
            new Competency
            {
                Id = 48, NameEng = "Diving Operations Knowledge", NameFre = "Connaissance des opérations de plongée",
                DescEng = "Diving knowledge required to work safely in a hostile environment through proper organization and planning.",
                DescFre = "Connaissances en plongée requises pour travailler en toute sécurité dans un environnement hostile grâce à une organisation et une planification appropriées.",
                Active = 1
            },
            new Competency
            {
                Id = 49, NameEng = "Rigging and Lifting", NameFre = "Gréement et levage",
                DescEng = "Executes load-lifting, towing, storing, deployment operations on cargo, nets, and equipment with proper adherence to Occupational Health and Safety (OHS) requirements, signaling and communication protocols with diligent care for equipment.",
                DescFre = "Exécuter le levage de charges, le remorquage, l’entreposage ainsi que les opérations de déploiement de cargaisons, de filets et de matériel en respectant rigoureusement les exigences en matière de santé et de sécurité au travail (SST), les protocoles de signalement et de communication ainsi que l’entretien diligent de l’équipement.",
                Active = 1
            },
            new Competency
            {
                Id = 50, NameEng = "Technical Maintenance of Diving Equipment", NameFre = "Entretien technique de l’équipement de plongée",
                DescEng = "Repairs and conducts preventative maintenance of diving equipment. Maintains dive computers and instruments in accordance with all manufacturer's recommendations and owner's manuals.",
                DescFre = "Procéder à la réparation et à l’entretien préventif de l’équipement de plongée. Entretenir les ordinateurs et les instruments de plongée conformément à toutes les recommandations du fabricant et au manuel d’utilisation.",
                Active = 1
            },
            new Competency
            {
                Id = 51, NameEng = "Diving Supervision", NameFre = "Supervision de la plongée",
                DescEng = "Supervision of a dive team using Compressed Air Breathing Apparatus (CABA) or Light Weight Surface Supply (LWSS) equipment to a depth of less than or equal to 45 metres.",
                DescFre = "Superviser une équipe de plongeurs en utilisant un appareil respiratoire à air comprimé (ARAC) ou un système de plongée non autonome léger jusqu’à une profondeur maximale de 45 mètres.",
                Active = 1
            },
            new Competency
            {
                Id = 52, NameEng = "Small Boats, Helicopters, Barges, Tackle Operations", NameFre = "Opérations liées aux petites embarcations, aux hélicoptères, aux barges et à l’outillage de chargement",
                DescEng = "Practices seamanship in areas such as vessel maintenance, steering, lookout, the use and maintenance of small vessels, helicopter procedures, and tackle use, stowage, and maintenance.",
                DescFre = "Mettre en pratique le matelotage dans des domaines comme l’entretien des navires, la direction, la surveillance, l’utilisation et l’entretien de petites embarcations, les procédures relatives aux hélicoptères ainsi que l’utilisation, l’arrimage et l’entretien de l’outillage de chargement.",
                Active = 1
            },
            new Competency
            {
                Id = 53, NameEng = "Life Cycle Asset Management", NameFre = "Gestion du cycle de vie des actifs",
                DescEng = "Employs an integrated approach to optimizing the life cycle of the Canadian Coast Guard’s assets beginning at conceptual design, continuing through shut down, and decommissioning/disposal. ",
                DescFre = "Employer une approche intégrée pour optimiser le cycle de vie des actifs de la Garde côtière canadienne, depuis la conception, en passant par l’arrêt, la mise hors service et l’élimination.",
                Active = 1
            },
            new Competency
            {
                Id = 54, NameEng = "Troubleshooting", NameFre = "Dépannage",
                DescEng = "Employs a systematic approach to problems in order to find and correct issues with Canadian Coast Guard assets (e.g. land based, sea based, structural, electronic, etc.).",
                DescFre = "Emploie une approche systématique des problèmes afin de trouver et de corriger les problèmes liés aux biens de la Garde côtière canadienne (par exemple, à terre, en mer, structurels, électroniques, etc.)",
                Active = 1
            },
            new Competency
            {
                Id = 55, NameEng = "Problem Solving", NameFre = "Résolution de problème",
                DescEng = "Defining a problem, determining the cause of the problem, identifying alternative solutions, prioritizing and selecting them to find a solution, and implementing a solution.",
                DescFre = "Il s’agit de définir un problème, de déterminer la cause du problème, d’identifier des solutions de rechange, de les classer par ordre de priorité et de les choisir afin de trouver une solution, et de mettre en œuvre une solution.",
                Active = 1
            },
            new Competency
            {
                Id = 56, NameEng = "Dietary Need, Menu Planning, Food Preparation, and Sanitation Knowledge", NameFre = "Connaissances sur les besoins alimentaires, la planification des menus, la préparation des aliments et l'assainissement",
                DescEng = "Knowledge to create menus that meet the dietary needs of the ships' crews. The focus is on assuring that the menu meets dietary and nutritional needs and food preferences, that food is prepared and stored in a safe and sanitary fashion, and that food preparation areas are kept clean.",
                DescFre = "Des connaissances pour créer des menus qui répondent aux besoins alimentaires des équipages des navires. L'accent est mis sur l'assurance que le menu répond aux besoins alimentaires et nutritionnels et aux préférences alimentaires, que les aliments sont préparés et entreposés de façon sécuritaire et hygiénique et que les aires de préparation des aliments sont maintenues propres.",
                Active = 1
            },
            new Competency
            {
                Id = 57, NameEng = "Inventory Management Systems Knowledge", NameFre = "Connaissance des systèmes de gestion des stocks",
                DescEng = "Understands processes to track materiel during receipt, storage, issue, and disposal.",
                DescFre = "Comprendre les processus pour assurer le suivi du matériel lors de la réception, de l’entreposage, de la fourniture et de l’élimination.",
                Active = 1
            },
            new Competency
            {
                Id = 58, NameEng = "Galley Operations and Food Production", NameFre = "Exploitation des cuisines et production d’aliments",
                DescEng = "Conducts and manages all food preparation including salads, meals, snacks, desserts, and beverages by following menus, recipes, and nutritional guidelines in a safe and clean fashion.",
                DescFre = "Réaliser et gérer l’ensemble des activités de préparation des aliments, notamment les salades, les repas, les collations, les desserts et les boissons, en suivant les menus, les recettes et les lignes directrices en matière de nutrition de manière propre et sécuritaire.",
                Active = 1
            },
            new Competency
            {
                Id = 59, NameEng = "Search and Rescue (SAR) Knowledge", NameFre = "Connaissances en recherche et sauvetage (R-S)",
                DescEng = "Knowledge of the coastal and national search and rescue safety nets, the authorities, stakeholders, roles and relationships, and how they all work together in incidents and scenarios. This includes Canadian Coast Guard assets at sea and ashore (Marine Communications and Traffic Services [MCTS], the Regional Operations Centre [ROC], the Joint Rescue Co-ordination Centre [JRCC]), the Canadian Coast Guard Auxiliary, other government departments (Transport Canada, Royal Canadian Mounted Police, Department of National Defence), industry, and the public.",
                DescFre = "Connaissance des filets de sécurité de recherche et de sauvetage côtiers et nationaux, des autorités, des intervenants, des rôles et des relations ainsi que de la manière dont ils travaillent ensemble lors d’incidents et de scénarios. Ces connaissances comprennent les actifs en mer et sur terre de la Garde côtière canadienne (Services de communication et de trafic maritimes [SCTM], Centre des opérations régionales [COR], Centre conjoint de coordination des opérations de sauvetage [CCCOS]), la Garde côtière canadienne auxiliaire, autres ministères (Transports Canada, Gendarmerie royale du Canada, ministère de la Défense nationale), industrie et population.",
                Active = 1
            },
            new Competency
            {
                Id = 60, NameEng = "Search and Rescue (SAR)", NameFre = "Recherche et sauvetage (R-S)",
                DescEng = "Leads the maritime component of the federal SAR system in the provision of search and rescue services to Canadian mariners and to others in need of humanitarian aid, including the coordination of SAR operations on the water for the provision of aid to persons, ships, or other craft which are, or are feared to be, in distress or imminent danger.",
                DescFre = "Diriger le volet maritime du système fédéral de R-S en offrant des services de R-S aux navigateurs canadiens et à d’autres personnes qui ont besoin d’aide humanitaire et assurer la coordination des opérations de R-S sur l’eau afin d’offrir de l’aide à des personnes, à des navires ou à d’autres embarcations en détresse ou en danger imminent, ou pouvant l’être.",
                Active = 1
            },
            new Competency
            {
                Id = 61, NameEng = "Bridge Watchkeeping Duties", NameFre = "Tâches de quart à la passerelle",
                DescEng = "Performs helm's person seamanship duties on the bridge of a vessel using bridge steering and propulsion equipment while slipping, underway, and/or docking. Performs duties of a lookout while ship is underway.",
                DescFre = "Exécuter les tâches de matelotage de la personne à la barre sur la passerelle d’un navire au moyen de la barre de la passerelle et de l’équipement de propulsion en ripant, en faisant route ou en accostant. Exécuter les tâches de vigie lorsque le navire fait route.",
                Active = 1
            },
            new Competency
            {
                Id = 62, NameEng = "Marine Engine Mechanical Knowledge", NameFre = "Connaissances en mécanique des moteurs marins",
                DescEng = "Knowledge of mechanical tools and instruments, inspection, repair, maintenance of marine engines, electrical systems, transmissions, and auxiliary systems components.",
                DescFre = "Connaissance des outils et des instruments mécaniques ainsi que de l’inspection, de la réparation et de l’entretien des composants des moteurs marins, des systèmes électriques, des transmissions et des systèmes auxiliaires.",
                Active = 1
            },
            new Competency
            {
                Id = 63, NameEng = "Engineering Watchkeeping Duties", NameFre = "Tâches de quart à la salle des machines",
                DescEng = "Operates and services main propulsion and auxiliary machinery while in use or required for use. Identifies issues, obtains relevant information, relates and compares data from different sources, and identifies alternate solutions.",
                DescFre = "Faire fonctionner et entretenir les machines de propulsion principale et les machines auxiliaires lorsqu’elles sont ou doivent être utilisées. Cerner les questions, obtenir de l’information pertinente, établir un lien entre les données provenant de différentes sources et les comparer ainsi que trouver des solutions de rechange.",
                Active = 1
            },
            new Competency
            {
                Id = 64, NameEng = "Deck Management Knowledge", NameFre = "Connaissance de la gestion du pont",
                DescEng = "The management of a deck watch to ensure safe rigging, lifting, tackle, small craft, helicopter, and cargo loading operations.",
                DescFre = "La gestion d'un quart à la passerelle pour assurer la sécurité des opérations d'amarrage, de levage, d'accastillage, d'embarcation, d'hélicoptère et de chargement de la cargaison.",
                Active = 1
            },
            new Competency
            {
                Id = 65, NameEng = "Fishing Officer Knowledge", NameFre = "Connaissances des agents des pêches",
                DescEng = "The body of experiential knowledge including environmental, resource-based, ecosystem, fishing practices, fishing communities and livelihoods, governance and markets, and their dynamic relationships.",
                DescFre = "L'ensemble des connaissances expérientielles, y compris l'environnement, les ressources, l'écosystème, les pratiques de pêche, les communautés de pêcheurs et leurs moyens de subsistance, la gouvernance et les marchés, et leurs relations dynamiques.",
                Active = 1
            },
            new Competency
            {
                Id = 66, NameEng = "Engineering/Electrical Knowledge and Principles", NameFre = "Connaissances et principes en matière d'ingénierie et d'électricité",
                DescEng = "Understands concepts, practices, and theories involved in the development/review/construction, maintenance, operations, or repair of, projects/sites and their potential environmental, and safety impacts.",
                DescFre = "Comprend les concepts, les pratiques et les théories qui interviennent dans l'élaboration, l'examen, la construction, l'entretien, l'exploitation ou la réparation des projets ou des sites, ainsi que leurs répercussions potentielles sur l'environnement et la sécurité.",
                Active = 1
            },
            new Competency
            {
                Id = 67, NameEng = "Engineering/Electrical Equipment Standard Operating Procedures Knowledge", NameFre = "Connaissance des procédures d'utilisation normalisées de l'ingénierie et de l'équipement électrique",
                DescEng = "Understands steps and safety regulations in preparing equipment for operation, operating equipment, monitoring, and conducting running maintenance.",
                DescFre = "Comprend les étapes et les règles de sécurité dans la préparation de l'équipement pour l'opération, l'opération de l'équipement, la surveillance et l'exécution de l'entretien courant.",
                Active = 1
            },
            new Competency
            {
                Id = 68, NameEng = "Operations Knowledge", NameFre = "Connaissance des opérations",
                DescEng = "Knowledge of systems for proper scheduling and tracking of ships' activities to ensure of the best use of the available resources for regular program delivery, as well as during emergency situations.",
                DescFre = "Connaissance des systèmes pour l’établissement des horaires et le suivi en bonne et due forme des activités des navires, afin d’assurer la meilleure utilisation des ressources disponibles lors de la prestation régulière du programme et les situations d’urgence.",
                Active = 1
            },
            new Competency
            {
                Id = 69, NameEng = "Navigational Equipment Standard Operating Procedures Knowledge", NameFre = "Connaissance des procédures opérationnelles normalisées de l’équipement de navigation",
                DescEng = "Knowledge of the steps and safety regulations in preparing equipment for operation, operating equipment, and monitoring.",
                DescFre = "Connaissance des règlements touchant la sécurité et des étapes pour la préparation de l’équipement aux fins d’utilisation, le fonctionnement de l’équipement et la surveillance.",
                Active = 1
            },
            new Competency
            {
                Id = 70, NameEng = "Environmental Response (ER) Knowledge", NameFre = "Connaissances en matière d'intervention environnementale (IE)",
                DescEng = "Knowledge of the ER program mandate, roles, and responsibilities. Knowledge of ER operations, priorities, issues, stakeholders, policies, practices, and procedures. Knowledge of capabilities, duties, and technical skills of the ER team. Knowledge of marine clients and partners as they relate to the ER program.",
                DescFre = "Connaissance du mandat, des rôles et des responsabilités du programme d'IE. Connaissance des opérations, des priorités, des enjeux, des intervenants, des politiques, des pratiques et des procédures d'IE. Connaissance des capacités, des tâches et des compétences techniques de l'équipe d'urgence. Connaissance des clients et des partenaires du secteur maritime en ce qui a trait au programme d'IE.",
                Active = 1
            },
            new Competency
            {
                Id = 71, NameEng = "Icebreaking (IB) Knowledge", NameFre = "Connaissances en matière de déglaçage (IB)",
                DescEng = "Knowledge of procedures and processes involved in icebreaking operations coordination. Knowledge of area of responsibility (AOR) characteristics. Knowledge of operational electronics programs related to the IB program (Icebreaking Operations Data Information System [IODIS], Vessel Traffic Management Information System [INNAV], and Google Earth). Knowledge of the various standard operating procedures (SOPs) and standing operational guidelines.",
                DescFre = "Connaissance des procédures et des processus impliqués dans la coordination des opérations de déglaçage. Connaissance des caractéristiques de la zone de responsabilité (ZR). Connaissance des programmes d'électronique opérationnelle liés au programme de l'IB (Système d'information sur les données des opérations de déglaçage [SIDOD], Système d'information sur la gestion du trafic maritime [SIGTM], et Exact Earth). Connaissance des diverses procédures opératoires normalisées (PON) et des lignes directrices opérationnelles permanentes.",
                Active = 1
            },
            new Competency
            {
                Id = 72, NameEng = "Marine Engineering Systems Operations and Maintenance", NameFre = "Exploitation et maintenance des systèmes de génie maritime",
                DescEng = "Conducts all operations and maintenance activities on shipboard engineering equipment. This includes start up, shut down, monitoring, planning, and reporting functions.",
                DescFre = "Conduit toutes les activités d'exploitation et de maintenance des équipements techniques de bord. Cela comprend les fonctions de démarrage, d'arrêt, de surveillance, de planification et de compte rendu.",
                Active = 1
            },
            new Competency
            {
                Id = 73, NameEng = "Electrical Operations and Maintenance", NameFre = "Fonctionnement et entretien électriques",
                DescEng = "Operates and maintains shipboard electrical systems and equipment.",
                DescFre = "Faire fonctionner et entretenir l’équipement et les systèmes électriques embarqués.",
                Active = 1
            },
            new Competency
            {
                Id = 74, NameEng = "Bridge Management", NameFre = "Gestion de la passerelle",
                DescEng = "The management of a bridge watch to con vessels confidently and safely under various conditions and be able to make a more effective contribution to the bridge team during ship maneuvering in all conditions. Elements include navigation, radar, plotting, vessel handling, emergency management, collision avoidance, and watchkeeping protocols.",
                DescFre = "Gérer un quart à la passerelle pour assurer la conduite des navires en toute confiance et sécurité dans divers états de la mer et pour être en mesure de contribuer plus efficacement à l’équipe de la passerelle pendant la manœuvre du navire dans tous les états de la mer. Cette gestion comprend la navigation, le radar, le pointage, la manœuvre d’un navire, la gestion des urgences, l’évitement des collisions et les protocoles relatifs aux quarts.",
                Active = 1
            },
            new Competency
            {
                Id = 75, NameEng = "Materiel Management (Logistics)", NameFre = "Gestion du matériel (logistique)",
                DescEng = "Classifies materiel according to the Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal with regards to the provisioning of Coast Guard vessels.",
                DescFre = "Classer le matériel conformément aux directives de la GCC et de Services publics et Approvisionnement Canada (SPAC). Assurer le suivi du matériel lors de la réception, de l’entreposage, de la fourniture et de l’élimination en ce qui concerne l’approvisionnement des navires de la Garde côtière.",
                Active = 1
            },
            new Competency
            {
                Id = 76, NameEng = "Logistics for Supervisors/Managers", NameFre = "Logistique pour les superviseurs et les gestionnaires",
                DescEng = "Plans, implements, and controls processes for the efficient and effective transportation, storage, use, and disposal of project or program specific goods at operational facilities.",
                DescFre = "Planifier, mettre en œuvre et contrôler les processus en vue du transport, de l’entreposage, de l’utilisation et de l’élimination efficients et efficaces des marchandises propres à un projet ou à un programme aux installations opérationnelles.",
                Active = 1
            },
            new Competency
            {
                Id = 77, NameEng = "Aids to Navigation (AtoN)", NameFre = "Aides à la navigation (AIDNAV)",
                DescEng = "Delivers the AtoN program’s provision of visual and aural aids to navigation, electronic positioning systems such as the differential global positioning system (DGPS), and navigation safety information. These services involve, among others, analyzing, planning, and coordinating functions.",
                DescFre = "Fournir, dans le cadre du Programme des aides à la navigation (PAN), des aides à la navigation visuelles et sonores, des systèmes électroniques de positionnement, comme le système de localisation GPS différentiel, et de l’information sur la sécurité de la navigation. Ces services comprennent, entre autres, l’analyse, la planification et la coordination des fonctions.",
                Active = 1
            },
            new Competency
            {
                Id = 78, NameEng = "Research and Analysis", NameFre = "Recherche et analyse",
                DescEng = "Researches and analyzes qualitative and quantitative information (oral and written), such as data, policies, procedures, legislation, project/program specifications, client documents, legal documentation, databanks, and any other information sources.",
                DescFre = "Recherche et analyse d'informations qualitatives et quantitatives (orales et écrites), telles que des données, des politiques, des procédures, des lois, des spécifications de projets/programmes, des documents de clients, des documents juridiques, des banques de données et toute autre source d'information.",
                Active = 1
            },
            new Competency
            {
                Id = 79, NameEng = "Engineering Review, Decision Making, and Analysis", NameFre = "Examen technique, prise de décision et analyse",
                DescEng = "Uses effective approaches with available facts, constraints, and anticipated consequences in marine engineering systems.",
                DescFre = "Utilise des approches efficaces avec les faits disponibles, les contraintes et les conséquences prévues dans les systèmes de génie maritime.",
                Active = 1
            },
            new Competency
            {
                Id = 80, NameEng = "Engineering Design and Analysis", NameFre = "Conception technique et analyse",
                DescEng = "Identifies, develops, and analyzes the installation process of engineering designs and/or specifications. Plans, identifies, and modifies methods and resources.",
                DescFre = "Déterminer, élaborer et analyser le processus d’installation d’avant-projets ou de spécifications techniques. Planifier, déterminer et modifier les méthodes et les ressources.",
                Active = 1
            },
            new Competency
            {
                Id = 81, NameEng = "Library Sciences Management", NameFre = "Gestion de la bibliothéconomie",
                DescEng = "Applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries, including the collection, organization, preservation, dissemination of information resources, and the political economy of information.",
                DescFre = "Appliquer aux bibliothèques les pratiques, les approches et les outils de la gestion, des technologies de l’information, de l’éducation et d’autres domaines, y compris la collecte, l’organisation, la protection et la diffusion des ressources d’information ainsi que l’économie de l’information.",
                Active = 1
            },
            new Competency
            {
                Id = 82, NameEng = "Health Science Knowledge", NameFre = "Connaissances en sciences de la santé",
                DescEng = "Knowledge related to nursing including anatomy, physiology, pathophysiology, psychopathology, pharmacology, microbiology, epidemiology, genetics, immunology, and nutrition.",
                DescFre = "Connaissances liées aux soins infirmiers, notamment en anatomie, physiologie, physiologie, physiopathologie, psychopathologie, pharmacologie, microbiologie, épidémiologie, génétique, immunologie et nutrition.",
                Active = 1
            },
            new Competency
            {
                Id = 83, NameEng = "Health Care Services", NameFre = "Services de soins de santé",
                DescEng = "Provides support and services in order to meet the needs of clients, in light of relevant situational, and contextual realities, in accordance with established theories and frameworks relevant to health and well-being.",
                DescFre = "Offrir du soutien et des services afin de répondre aux besoins des clients, à la lumière des réalités situationnelles et contextuelles, conformément aux théories et aux cadres établis concernant la santé et le bien-être.",
                Active = 1
            },
            new Competency
            {
                Id = 84, NameEng = "Ethical Practice in Health Services", NameFre = "Déontologie dans les services de santé",
                DescEng = "Practices health care with honesty, integrity, and respect in all professional interactions.",
                DescFre = "Offrir des soins de santé avec honnêteté, intégrité et respect dans toutes les interactions professionnelles.",
                Active = 1
            },
            new Competency
            {
                Id = 85, NameEng = "Materiel and Supply Chain Management", NameFre = "Gestion du matériel et de la chaîne d'approvisionnement",
                DescEng = "Manages the flow of goods and services, including the movement and storage of raw materials, of work-in-process inventory, and of finished goods from point of origin to point of consumption.",
                DescFre = "Gérer la circulation des biens et services, y compris le transport et l’entreposage des matières premières, des produits en cours et des produits finis du point d’origine au point de consommation.",
                Active = 1
            },
            new Competency
            {
                Id = 86, NameEng = "Physical Education", NameFre = "Éducation physique",
                DescEng = "Develops students' physical competence and knowledge of movement and safety, and their ability to use these to perform in a wide range of activities associated with the development of an active and healthy lifestyle.",
                DescFre = "Développe les compétences physiques et les connaissances des élèves en matière de mouvement et de sécurité, ainsi que leur capacité à les utiliser pour effectuer un large éventail d'activités associées au développement d'un mode de vie actif et sain.",
                Active = 1
            },
            new Competency
            {
                Id = 87, NameEng = "Forklift Operations", NameFre = "Utilisation de chariots élévateurs à fourche",
                DescEng = "Operates various classes of counterbalance forklift trucks in a manner that protects both operator safety and the safety of others in the workplace.",
                DescFre = "Faire fonctionner diverses classes de chariots élévateurs à fourche avec contrepoids d’une manière qui assure la sécurité du conducteur et celle des autres personnes sur le lieu de travail.",
                Active = 1
            },
            new Competency
            {
                Id = 88, NameEng = "Lightkeeper Observation Services", NameFre = "Services d’observation des gardiens de phare",
                DescEng = "Reports observed phenomenon to mariners and the organization. Operates equipment to collect, store, transmit, and interpret data relating to the marine environment or the atmosphere.",
                DescFre = "Faire rapport des phénomènes observés aux navigateurs et à l’organisme. Faire fonctionner l’équipement pour recueillir, stocker, transmettre et interpréter des données liées au milieu marin ou à l’atmosphère.",
                Active = 1
            },
            new Competency
            {
                Id = 89, NameEng = "Operate and Maintain Lighthouse (LI) Equipment", NameFre = "Fonctionnement et entretien de l’équipement des phares (groupe LI)",
                DescEng = "Manages the full spectrum of lighthouse equipment operation and maintenance under the department's responsibility.",
                DescFre = "Gérer l’ensemble des activités de fonctionnement et d’entretien de l’équipement des phares qui relèvent du ministère.",
                Active = 1
            },
            new Competency
            {
                Id = 90, NameEng = "Sensory Equipment Knowledge", NameFre = "Connaissance des équipements sensoriels",
                DescEng = "Knowledge of operational equipment and surveillance circuits available in the Canadian Coast Guard such as radars, radios, satellite gear, cameras, tracking systems, search systems, plotters, etc.",
                DescFre = "Connaissance des équipements opérationnels et des circuits de surveillance disponibles au sein de la Garde côtière canadienne tels que les radars, les radios, les équipements satellites, les caméras, les systèmes de suivi, les systèmes de recherche, les traceurs, etc.",
                Active = 1
            },
            new Competency
            {
                Id = 91, NameEng = "Tool Care, Use and Maintenance", NameFre = "Soin, utilisation et entretien des outils",
                DescEng = "Using basic hand held, power, precision stationary or portable tools and precision measuring tools. Performing the required care and maintenance in accordance with established schedules and programs.",
                DescFre = "Utiliser des outils à main, de précision fixes, électriques ou portatifs de base ainsi que des instruments de mesure de précision. Procéder au soin et à l’entretien nécessaires conformément aux calendriers et aux programmes établis.",
                Active = 1
            },
            new Competency
            {
                Id = 92, NameEng = "Welding", NameFre = "Soudage",
                DescEng = "Welds metals using manual, semi-automatic, and automatic arc welding equipment. Plans drawings and blueprints. Fabricates, assembles, and welds to make products via the use of hand tools.",
                DescFre = "Soude les métaux à l'aide d'un équipement de soudage à l'arc manuel, semi-automatique et automatique. Planifie les dessins et les plans. Fabrique, assemble et soude pour fabriquer des produits à l'aide d'outils manuels.",
                Active = 1
            },
            new Competency
            {
                Id = 93, NameEng = "Aids to Navigation (AtoN) Knowledge", NameFre = "Connaissances en matière d'aides à la navigation (AtoN)",
                DescEng = "Knowledge of the Canadian Coast Guard's navigational aid network, their locations, operation, and maintenance, which includes a range of lights, lighthouses, buoys, beacons, and differential global positioning systems (DGPS). Knowledge of waterways management (WM) which includes a knowledge of the types, locations, and monitoring of the available water depths (Avadepth) program and river structures, when and where applicable.",
                DescFre = "Connaissance du réseau d'aide à la navigation de la Garde côtière canadienne, de son emplacement, de son fonctionnement et de son entretien, ce qui comprend une gamme de feux, de phares, de bouées, de balises et de systèmes de positionnement mondial différentiel (DGPS). Connaissance de la gestion des voies navigables (GC), ce qui comprend la connaissance des types, des emplacements et de la surveillance des profondeurs d'eau disponibles (profondeur d'Avadepth) et des structures des rivières, le cas échéant.",
                Active = 1
            },
            new Competency
            {
                Id = 94, NameEng = "Electrical/Electronic Review, Decision Making and Analysis", NameFre = "Examen, prise de décision et analyse en matière d'électrique/électronique",
                DescEng = "Uses effective approaches with available facts, constraints, and anticipated consequences in marine electrical systems.",
                DescFre = "Utiliser des approches efficaces en utilisant les faits disponibles, les contraintes et les conséquences prévues dans les systèmes électriques marins.",
                Active = 1
            },
            new Competency
            {
                Id = 95, NameEng = "Radio Wave Propagation and Antennas Knowledge", NameFre = "Connaissance de la propagation des ondes radioélectriques et des antennes",
                DescEng = "Knowledge of types of electromagnetic signal designed to carry information through the air over relatively long distances and how antennas send and/or receive electromagnetic radio waves.",
                DescFre = "Connaissance des types de signaux électromagnétiques conçus pour acheminer l’information dans l’air sur des distances relativement grandes et de la façon dont les antennes transmettent ou reçoivent les ondes électromagnétiques radioélectriques.",
                Active = 1
            },
            new Competency
            {
                Id = 96, NameEng = "Electrical Installing and Maintaining", NameFre = "Installations électriques et entretien",
                DescEng = "Installs, repairs, and maintains wiring, switches, conduits, circuit breakers, lighting, and other equipment in buildings and other structures.",
                DescFre = "Installer, réparer et entretenir le câblage, les commutateurs, les tubes isolants, les disjoncteurs, les appareils d’éclairage et d’autre équipement dans les immeubles et autres structures.",
                Active = 1
            },
            new Competency
            {
                Id = 97, NameEng = "Refrigeration and Air Conditioning Operation, Installing and Maintenance", NameFre = "Fonctionnement, installation et entretien des systèmes de réfrigération et de climatisation",
                DescEng = "Repairing, installing and troubleshooting refrigeration systems.",
                DescFre = "Réparer, installer et rechercher la cause des pannes des systèmes de réfrigération.",
                Active = 1
            },
            new Competency
            {
                Id = 98, NameEng = "Strategic Resource Management, Internal Control, and Integrated Planning Cycle", NameFre = "Gestion stratégique des ressources, contrôle interne et cycle de planification intégrée",
                DescEng = "Applies the interconnected structures and processes of government, such as the functions and accountability of departments in the executive branch relating to resource allocation, the integrated budgetary planning cycle, and the control of these resources.",
                DescFre = "Applique les structures et les processus interconnectés du gouvernement, tels que les fonctions et la responsabilité des départements de la branche exécutive en matière d'allocation des ressources, le cycle de planification budgétaire intégrée et le contrôle de ces ressources.",
                Active = 1
            },
            new Competency
            {
                Id = 99, NameEng = "Expenditure, Cost Accounting, and Statutory Reporting", NameFre = "Dépenses, comptabilisation des coûts et rapport statutaire",
                DescEng = "Supports the appropriate collection, measurement, accumulation, analysis, interpretation, and communication of cost information. Assists clients in determining program and activity costs and changes.",
                DescFre = "Permet la collecte, la mesure, l'accumulation, l'analyse, l'interprétation et la communication appropriées des informations sur les coûts. Aide les clients à déterminer les coûts et les changements des programmes et des activités.",
                Active = 1
            },
            new Competency
            {
                Id = 100, NameEng = "Indigenous Negotiation", NameFre = "Négociation indigène",
                DescEng = "Consults and negotiates with disparate Indigenous bands to articulate sound and consistent strategic approaches that satify and align with the priorities of Governement of Canada and the bands.",
                DescFre = "Consulte et négocie avec des bandes autochtones disparates afin d'articuler des approches stratégiques solides et cohérentes qui satisfont et s'alignent sur les priorités du gouvernement du Canada et des bandes.",
                Active = 1
            },
            new Competency
            {
                Id = 101, NameEng = "Technical Inspection", NameFre = "Inspection technique",
                DescEng = "Inspects, evaluates, standardizes, and plans inspections and evaluations of skilled ship construction activities.",
                DescFre = "Inspecter, évaluer, normaliser et planifier les inspections et les évaluations des activités spécialisées de construction navale.",
                Active = 1
            },
            new Competency
            {
                Id = 102, NameEng = "Vessel of Concern Knowledge", NameFre = "Connaissance du programme des navires préoccupants",
                DescEng = "An understanding of the Oceans Protection Plan mandate concerning the management of wrecked and abandoned vessels, inclusive of the plan aimed to protect Canada's marine environment.",
                DescFre = "Compréhension du mandat du Plan de protection des océans (PPO) en ce qui concerne la gestion des épaves et des navires abandonnés, qui comprend le plan visant à protéger le milieu marin du Canada.",
                Active = 1
            },
            new Competency
            {
                Id = 103, NameEng = "Icebreaking (IB)", NameFre = "Déglaçage",
                DescEng = "Receives, analyzes, and answers requests for icebreaking assistance. Coordinates icebreaker positioning and tasking’s. Monitors effectiveness of operational solutions and adapts accordingly. Communicates information to management, clients and partners. Prepares ice routes suggestion and information package for the clients and industry. Ice bulleting, marine information and warning. Prepares complete information presentation regarding the icebreaking program for morning briefings to senior management.",
                DescFre = "Recevoir et analyser des demandes d’aide pour le déglaçage et y répondre. Assurer la coordination du positionnement et des affectations des brise-glaces. Surveiller l’efficacité des solutions opérationnelles et s’adapter en conséquence. Communiquer des renseignements à la direction, aux clients et aux partenaires. Préparer des suggestions de routes de navigation dans les glaces ainsi que des trousses de renseignements pour les clients et l’industrie. Communiquer des bulletins sur les glaces, de l’information maritime et des avertissements. Préparer des exposés complets de renseignements sur le programme de déglaçage pour les séances d’information du matin à l’intention de la haute direction.",
                Active = 1
            },
            new Competency
            {
                Id = 104, NameEng = "Vessel of Concern", NameFre = "Programme des navires préoccupants",
                DescEng = "Maintains an inventory of wrecked and abandoned vessels, addresses irresponsible vessel management by prohibiting vessel abandonment, strengthening owner responsibility (including costs for cleanup and removal), and participates in the management of removal of such vessels.",
                DescFre = "Tenir à jour l’inventaire des épaves et navires abandonnés, remédier à la gestion irresponsable des navires en interdisant l’abandon de navires, renforcer la responsabilité des propriétaires (y compris les coûts des opérations de nettoyage et d’enlèvement) et participer à la gestion de l’enlèvement de ces navires.",
                Active = 1
            },
            new Competency
            {
                Id = 105, NameEng = "Organizational Communications", NameFre = "Communications organisationnelles",
                DescEng = "Encompasses written, oral, visual, and digital communication (including within a workplace context). Focuses on the study of information and the ways it is created, managed, distributed, and consumed within the CCG.",
                DescFre = "Englober les communications écrites, orales, visuelles et numériques (notamment en milieu de travail). Se concentrer sur l’étude du cheminement de l’information et des façons dont elle est créée, gérée, distribuée et utilisée dans la GCC.",
                Active = 1
            },
            new Competency
            {
                Id = 106, NameEng = "Environmental Response (ER)", NameFre = "Intervention environnementale (IE)",
                DescEng = "Manages a marine pollution response, from assessment to cost recovery. Apply legislative power properly. Understands, choose and applies properly the different CCG roles in an ER incident. Conducts overall and on-water response to a marine pollutant. Establishes and/or use a command structure appropriate to the incident. Uses the formal processes within the command structure. Compiles and assesses information gathered from a variety of sources.",
                DescFre = "Gérer les interventions en cas de pollution marine, de l’évaluation au recouvrement des coûts. Appliquer la compétence législative en bonne et due forme. Comprendre, sélectionner et appliquer en bonne et due forme les divers rôles de la GCC lors d’un incident nécessitant une IE. Mener les interventions globales et sur l’eau relatives à un polluant marin. Établir ou utiliser une structure de commandement qui convient à l’incident. Utiliser des processus officiels dans la structure de commandement. Compiler et évaluer les renseignements recueillis de différentes sources.",
                Active = 1
            },
            new Competency
            {
                Id = 107, NameEng = "Knowledge of Hydraulic Engineering", NameFre = "Connaissances en génie hydraulique",
                DescEng = "Knowledge of the application of fluid mechanics principles related to water collection, storage, control, transport, regulation, measurement and use.",
                DescFre = "Connaissance de l'application des principes de la mécanique des fluides liés à la collecte, au stockage, au contrôle, au transport, à la régulation, à la mesure et à l'utilisation de l'eau.",
                Active = 1
            },
            new Competency
            {
                Id = 108, NameEng = "Electrical/Electronic Design and Analysis",  NameFre = "Conception et analyse électriques et électroniques",
                DescEng = "Electrical system design and analysis comprises of drafting a specification documentation, schematics, and wiring diagrams.",
                DescFre = "Concevoir et analyser des systèmes électriques, ce qui comprend la rédaction de documents de spécifications ainsi que la préparation d’esquisses et de schémas de câblage.",
                Active = 1
            },
            new Competency
            {
                Id = 109, NameEng = "Geomatics", NameFre = "La géomatique",
                DescEng = "Gathers, stores, processes, and delivers geographic or spatially referenced information.",
                DescFre = "Collecte, stockage, traitement et diffusion d'informations géographiques ou à référence spatiale.",
                Active = 1
            },
            new Competency
            {
                Id = 110, NameEng = "Configuration Management (CM)", NameFre = "Gestion de la configuration (CM)",
                DescEng = "A systems engineering process for establishing and maintaining consistency of a product's performance, functional, and physical attributes with its requirements, design, and operational information throughout its life.",
                DescFre = "Un processus d'ingénierie des systèmes pour établir et maintenir la cohérence des performances, des attributs fonctionnels et physiques d'un produit avec ses exigences, sa conception et ses informations opérationnelles tout au long de sa vie.",
                Active = 1
            },
            new Competency
            {
                Id = 111, NameEng = "Warehousing Knowledge", NameFre = "Connaissance de l’entreposage",
                DescEng = "Knowledge of the process of planning, implementing, and controlling procedures for the efficient and effective transportation and storage of goods, facilities, or personnel.",
                DescFre = "Connaissance du processus de la planification, de la mise en œuvre et des procédures de contrôle en ce qui concerne les installations, le personnel ainsi que le transport et l’entreposage efficaces et efficients des marchandises.",
                Active = 1
            },
            new Competency
            {
                Id = 112, NameEng = "Knowledge of Electronic Principles and Circuits", NameFre = "Connaissance des principes et circuits électroniques",
                DescEng = "Concepts and operational function of components underlying the understanding of how electronic environments are developed, assembled and tested.",
                DescFre = "Concepts et fonction opérationnelle des composants qui sous-tendent la compréhension de la façon dont les environnements électroniques sont développés, assemblés et testés.",
                Active = 1
            },
            new Competency
            {
                Id = 113, NameEng = "Operation Centre Management", NameFre = "Gestion du centre d’opérations",
                DescEng = "Monitors and operates systems to schedule and track ships' activities to ensure the best use of available resources for regular program delivery, including emergency situations.",
                DescFre = "Surveiller et utiliser les systèmes pour planifier et suivre les activités des navires, et ce, afin d’assurer la meilleure utilisation possible des ressources disponibles pour la prestation régulière du programme et lors des situations d’urgence.",
                Active = 1
            },
            new Competency
            {
                Id = 114, NameEng = "Electrical and Technical Design and Analysis", NameFre = "Conception et analyse électriques et technique",
                DescEng = "Preparing, analyzing and developing specification documentation, schematics and wiring diagrams.",
                DescFre = "Rédaction, analyse et développement de la documentation de spécification, des schémas et des schémas de câblage.",
                Active = 1
            },
            new Competency
            {
                Id = 115, NameEng = "Knowledge of Shipbuilding Engineering", NameFre = "Connaissances en génie de la construction navale",
                DescEng = "The discipline involving the design, construction, maintenance and operation of vessels and marine structures.",
                DescFre = "La discipline traitant de la conception, de la construction, de l'entretien et de l'exploitation des bâtiments et des structures maritimes.",
                Active = 1
            },
            new Competency
            {
                Id = 116, NameEng = "Knowledge of IT Architecture", NameFre = "Connaissance de l'architecture informatique",
                DescEng = "The rules and methods that describe the functionality, organisation and implementation of IT systems and their frameworks.",
                DescFre = "Les règles et les méthodes qui décrivent la fonctionnalité, l'organisation et la mise en œuvre des systèmes informatiques et de leurs cadres.",
                Active = 1
            },
            new Competency
            {
                Id = 117, NameEng = "Technical Design, Analysis and Schematics", NameFre = "Conception technique, analyse et schémas",
                DescEng = "Identifies, develops, analyzes and oversees the development and installation of engineering designs and/or specifications; plans and modifies methods. Identifies and plans resource requirements.",
                DescFre = "Identifie, développe, analyse et supervise le développement et l'installation de conceptions d'ingénierie et/ou de spécifications; planifie et modifie les méthodes. Identifie et planifie les besoins en ressources.",
                Active = 1
            },
            new Competency
            {
                Id = 118, NameEng = "Computer Aided Design and Drafting (CADD)", NameFre = "Conception et dessin assistés par ordinateur (CDAO)",
                DescEng = "Knowledge of commercial Computer Aided Design (CAD) and drafting software application as used in the CCG for drafting and designing products and tools for marine operations.",
                DescFre = "Connaissance de la conception assistée par ordinateur (CAO) commerciale et de l'application logicielle de dessin telle qu'elle est utilisée à la Garde côtière canadienne pour la rédaction et la conception de produits et d'outils pour les opérations maritimes.",
                Active = 1
            },
            new Competency
            {
                Id = 119, NameEng = "Application Development/Support and Maintenance", NameFre = "Développement, soutien et entretien des applications",
                DescEng = "Designs, defines, constructs, enhances, supports, and maintains application software on one or more application platforms.",
                DescFre = "Conçoit, définit, construit, améliore, soutient et entretient des logiciels d'application sur une ou plusieurs plateformes d'application.",
                Active = 1
            },
            new Competency
            {
                Id = 120, NameEng = "Infrastructure/Platforms", NameFre = "Infrastructure / Plateformes",
                DescEng = "Supports the enterprise computing infrastructure (e.g. enterprise servers, client server, storage devices and systems, hardware, and software) in the provision, management, storage, operation, scheduling, support, and maintenance of the infrastructure.",
                DescFre = "Soutient l'infrastructure informatique de l'entreprise (par exemple, les serveurs d'entreprise, le serveur client, les dispositifs et systèmes de stockage, le matériel et les logiciels) dans la fourniture, la gestion, le stockage, l'exploitation, la planification, le soutien et la maintenance de l'infrastructure.",
                Active = 1
            },
            new Competency
            {
                Id = 121, NameEng = "Security/Information and Application Protection", NameFre = "Sécurité / Protection des informations et des applications",
                DescEng = "Ensures technical and organizational safeguards to protect the continuity of infrastructure services by the implementation of information technology (IT) security principles, methods, practices, policies, and tools that are used in securing IT resources. This includes information and operations security, physical security, business continuity/disaster recovery planning, methods to deal with security breaches, and security assessment in a technical environment.",
                DescFre = "Veille à la mise en place de mesures techniques et organisationnelles pour protéger la continuité des services d'infrastructure par la mise en œuvre des principes, méthodes, pratiques, politiques et outils de sécurité des technologies de l'information (TI) utilisés pour sécuriser les ressources informatiques. Cela comprend la sécurité des informations et des opérations, la sécurité physique, la planification de la continuité des activités/reprise après sinistre, les méthodes pour traiter les infractions à la sécurité et l'évaluation de la sécurité dans un environnement technique.",
                Active = 1
            },
            new Competency
            {
                Id = 122, NameEng = "Service Management Processes", NameFre = "Processus de gestion des services",
                DescEng = "Implements methods, practices, and policies governing the design, development, and use of information technology (IT) support processes designed to keep the IT environment functioning efficiently, effectively, and securely.",
                DescFre = "Met en œuvre des méthodes, des pratiques et des politiques régissant la conception, le développement et l'utilisation des processus de soutien des technologies de l'information (TI) conçus pour maintenir le fonctionnement efficace, effectif et sûr de l'environnement informatique.",
                Active = 1
            },
            new Competency
            {
                Id = 123, NameEng = "Testing", NameFre = "Tests",
                DescEng = "Tests software and/or hardware using a systematic approach (i.e. the orderly progression of testing in which software elements, hardware elements or both are combined and tested until the entire system has been integrated).",
                DescFre = "Tests de logiciels et/ou de matériel en utilisant une approche systématique (c'est-à-dire la progression ordonnée des tests dans laquelle les éléments logiciels, les éléments matériels ou les deux sont combinés et testés jusqu'à ce que le système entier ait été intégré).",
                Active = 1
            },
            new Competency
            {
                Id = 124, NameEng = "Database Design and Management", NameFre = "Conception et gestion de bases de données",
                DescEng = "Applies the methods, practices, and policies that are used in the design and the management of databases in the public sector context.",
                DescFre = "Applique les méthodes, pratiques et politiques utilisées dans la conception et la gestion des bases de données dans le contexte du secteur public.",
                Active = 1
            },
            new Competency
            {
                Id = 125, NameEng = "Ship or Land-Based Marine Electronic Equipment/Information Systems Knowledge", NameFre = "Connaissance du matériel électronique et des systèmes d’information maritimes embarqués ou terrestres",
                DescEng = "Knowledge of electronic devices designed for use in, or support of, the marine environment.",
                DescFre = "Connaissance des dispositifs électroniques destinés à être utilisés dans le milieu marin ou à soutenir celui-ci.",
                Active = 1
            },

            new Competency
            {
                Id = 126, NameEng = "Create Vision and Strategy", NameFre = "Créer une vision et une stratégie",
                DescEng = "Able to define the future and chart a path forward. Adept at understanding and communicating context, factoring in the economic, social, and political environment. Intellectually agile, able to leverage their deep and broad knowledge, build on diverse ideas and perspectives, and create consensus around compelling visions. Balances organizational and government-wide priorities and improve outcomes for Canada and Canadians.",
                DescFre = "Capable de définir l'avenir et de tracer la voie à suivre. Adepte de la compréhension et de la communication du contexte, en tenant compte de l'environnement économique, social et politique. Intellectuellement agile, capable de tirer parti de ses connaissances vastes et approfondies, de s'appuyer sur des idées et des perspectives diverses, et de créer un consensus autour de visions convaincantes. Concilie les priorités organisationnelles et pangouvernementales et améliore les résultats pour le Canada et les Canadiens.",
                Active = 1
            },
            new Competency
            {
                Id = 127, NameEng = "Mobilize People", NameFre = "Mobiliser les gens",
                DescEng = "Able to inspire and motivate the people they lead. Manages performance, provides constructive and respectful feedback to encourage and enable performance excellence. Leads by example, setting goals for themselves that are more demanding than those that they set for others.",
                DescFre = "Capable d'inspirer et de motiver les gens qu'ils dirigent. Gère le rendement, fournit une rétroaction constructive et respectueuse pour encourager et favoriser l'excellence du rendement. Donne l'exemple en se fixant des objectifs plus exigeants que ceux qu'il se fixe pour les autres.",
                Active = 1
            },
            new Competency
            {
                Id = 128, NameEng = "Uphold Integrity and Respect", NameFre = "Respecter l'intégrité et le respect",
                DescEng = "Exemplifies ethical practices, professionalism, and personal integrity. Creates respectful and trusting work environments where sound advice is valued. Encourages the expression of diverse opinions and perspectives, while fostering collegiality. Ability to be self-aware and seek out opportunities for personal growth.",
                DescFre = "Exemplaire des pratiques éthiques, du professionnalisme et de l'intégrité personnelle. Crée des milieux de travail respectueux et confiants où les conseils judicieux sont valorisés. Encourage l'expression d'opinions et de perspectives diverses, tout en favorisant la collégialité. Capacité d'être conscient de soi et de rechercher des occasions de croissance personnelle.",
                Active = 1
            },
            new Competency
            {
                Id = 129, NameEng = "Collaborate with Partners and Stakeholders", NameFre = "Collaborer avec les partenaires et les intervenants",
                DescEng = "Able to deliberate and be resourceful about seeking the widest possible spectrum of perspectives. Demonstrates openness and flexibility to forge consensus and improve outcomes. Brings a whole-of-government perspective to their interactions. Open to alternatives and skillful at managing expectations in negotiating solutions. Shares recognition with their teams and partners.",
                DescFre = "Capable de délibérer et de faire preuve d'ingéniosité dans la recherche du plus large éventail possible de points de vue. Faire preuve d'ouverture et de souplesse pour parvenir à un consensus et améliorer les résultats. Apporte une perspective pangouvernementale à leurs interactions. Ouvert aux solutions de rechange et habile à gérer les attentes dans la négociation de solutions. Partage sa reconnaissance avec ses équipes et ses partenaires.",
                Active = 1
            },
            new Competency
            {
                Id = 130, NameEng = "Promote Innovation and Guide Change", NameFre = "Promouvoir l'innovation et orienter le changement",
                DescEng = "Leaders have the courage and resilience to challenge convention. They create an environment that supports bold thinking, experimentation and intelligent risk taking. They use setbacks as a valuable source of insight and learning. Leaders take change in their stride, aligning and adjusting milestones and targets to maintain forward momentum.",
                DescFre = "Les dirigeants ont le courage et la résilience nécessaires pour contester les conventions. Ils créent un environnement qui favorise la pensée audacieuse, l'expérimentation et la prise de risques intelligente. Ils utilisent les revers comme une source précieuse de compréhension et d'apprentissage. Les leaders prennent le changement à la va-vite, alignant et ajustant les jalons et les objectifs pour maintenir l'élan vers l'avant.",
                Active = 1
            },
            new Competency
            {
                Id = 131, NameEng = "Achieve Results", NameFre = "Obtenir des résultats",
                DescEng = "Ability to mobilize and manage resources to deliver on the priorities of the Government of Canada, improve outcomes, and add value. Considers context, risks, and business intelligence to support high-quality and timely decisions. Anticipates, plans, monitors progress, and makes adjustments as needed. Takes personal responsibility for actions and outcomes of their decisions.",
                DescFre = "Capacité de mobiliser et de gérer les ressources pour réaliser les priorités du gouvernement du Canada, améliorer les résultats et ajouter de la valeur. Tient compte du contexte, des risques et de l'intelligence d'affaires pour appuyer des décisions de grande qualité et opportunes. Anticiper, planifier, surveiller les progrès et faire les ajustements nécessaires. Assume personnellement la responsabilité des actions et des résultats de ses décision.",
                Active = 1
            }
        };
    }
}