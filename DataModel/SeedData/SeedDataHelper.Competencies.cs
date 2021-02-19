using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        private async Task Competencies()
        {
            if (await _db.Competencies.AnyAsync()) return;

            using var transaction = await _db.Database.BeginTransactionAsync();
            await _db.Competencies.AddRangeAsync(new List<Competency>()
            {
                new Competency
                {
                    Id = 1, NameEng = "Organizational Knowledge", NameFre = "Connaissance de l'organisation",
                    DescEng =
                        "Knowledge of the Canadian Coast Guard organization, partners, and relationships with Fisheries and Oceans Canada (DFO), and other internal and external stakeholders.",
                    DescFre =
                        "Connaissance de l’organisation de la Garde côtière canadienne, de ses partenaires et des relations avec le ministère des Pêches et des Océans (MPO) et d’autres intervenants internes et externes."
                },
                new Competency
                {
                    Id = 2, NameEng = "Program Knowledge and Application",
                    NameFre = "Connaissance et application du programme",
                    DescEng =
                        "Knowledge of the programs the Canadian Coast Guard manages and supports. Understands the services and delivery of program mandates:  Search and Rescue (SAR), Icebreaking (IB), Aids to Navigation (AtoN), Environmental Response (ER), Conservation and Protection (DFO C&P), Oceanography (DFO Science) and Fisheries Research (DFO Science).",
                    DescFre =
                        "Connaissance des programmes que la Garde côtière canadienne gère et soutient. Comprend les services et l'exécution des mandats des programmes :  Recherche et sauvetage (SAR), Déglaçage, Aides à la navigation (AIDNAV), Intervention environnementale (IE), Conservation et protection (C&P du MPO), Océanographie (Sciences du MPO) et Recherche halieutique (Sciences du MPO)."
                },
                new Competency
                {
                    Id = 3, NameEng = "Administrative Knowledge", NameFre = "Connaissances en administration",
                    DescEng =
                        "Understanding of administrative procedures and processes in one or more area of responsibility.",
                    DescFre =
                        "Compréhension des procédures et processus administratifs dans un ou plusieurs domaines de responsabilité."
                },
                new Competency
                {
                    Id = 4, NameEng = "Incident Command System (ICS) Knowledge",
                    NameFre = "Connaissance des systèmes de commandement des incidents (SCI)",
                    DescEng =
                        "Knowledge of the Incident Command System (ICS), its functions, role, and reporting structures. Knowledge of procedures and processes involved in an emergency response.",
                    DescFre =
                        "Connaissance du Système de commandement du lieu de l'incident (SCI), de ses fonctions, de son rôle et de ses structures hiérarchiques. Connaissance des procédures et des processus d'intervention en cas d'urgence."
                },
                new Competency
                {
                    Id = 5, NameEng = "Seagoing Personnel Management",
                    NameFre = "Connaissance de la gestion du personnel navigant",
                    DescEng =
                        "Knowledge of policies and directives on the management and administration of workforce management (HR) issues affecting seagoing personnel.",
                    DescFre =
                        "Connaissance des politiques et directives relatives à la gestion et à l'administration des questions de gestion des effectifs (RH) touchant le personnel navigant."
                },
                new Competency
                {
                    Id = 6, NameEng = "Maritime Security (MSOC) Knowledge",
                    NameFre = "Connaissance du Centre des opérations de la sûreté maritime (COSM)",
                    DescEng =
                        "Knowledge of the coastal marine domain factors such as meteorology, shipping patterns, and security resources. Knowledge of the coastal security nets, its players, authorities, and roles. Knowledge of agency interoperabilities.",
                    DescFre =
                        "Connaissance des facteurs du domaine maritime côtier tels que la météorologie, les modèles de transport maritime et les ressources de sécurité. Connaissance des filets de sécurité côtiers, de leurs parties concernées, de leurs autorités et de leurs rôles. Connaissance de l'interopérabilité des agences."
                },
                new Competency
                {
                    Id = 7, NameEng = "Knowledge of Systems Approach to Training",
                    NameFre = "Connaissance de l’approche systémique en formation",
                    DescEng =
                        "Knowledge of the step by step process of analysis, design, development, implementation, and evaluation in the course of delivering training. May also be referred to as Instructional Systems Design, or ISD.",
                    DescFre =
                        "Connaissance de chaque étape du processus d’analyse, de conception, de développement, de mise en œuvre et d’évaluation dans le cadre de la prestation de la formation. On peut également parler de conception de matériel pédagogique."
                },
                new Competency
                {
                    Id = 8, NameEng = "Knowledge of Specialized Fields",
                    NameFre = "Connaissance des domaines spécialisés",
                    DescEng =
                        "Knowledge of specialized fields, including concepts, theories, principles, methods, techniques, and practices. Such knowledge can be acquired through formal education, experience, specialized or on-the-job training, self-education, or a combination.",
                    DescFre =
                        "Connaissance de domaines spécialisés, y compris les concepts, théories, principes, méthodes, techniques et pratiques. Ces connaissances peuvent être acquises par le biais de l'éducation formelle, de l'expérience, de la formation spécialisée ou en cours d'emploi, de l'auto-éducation ou d'une combinaison des deux."
                },
                new Competency
                {
                    Id = 9, NameEng = "Project/Program Management", NameFre = "Gestion de projet et de programme",
                    DescEng =
                        "Manages a project or program while respecting procedures, operations, policies, and legislation, including inter-relationships with other departments, agencies, or the private sector. Project management involves effectively participating and/or integrating all aspects of a given finite project, ensuring that work progresses towards achieving goals and objectives. Program management involves effectively managing an ongoing activity line.",
                    DescFre =
                        "Gérer un projet ou un programme tout en respectant les procédures, les opérations, les politiques et les lois, notamment sur le plan des relations avec d’autres ministères, d’autres organismes ou le secteur privé. La gestion de projet suppose une participation efficace ou l’intégration de tous les aspects d’un projet fini donné, en veillant à ce que le travail progresse vers la réalisation de buts et d’objectifs. La gestion de programme consiste à gérer efficacement un secteur d’activité permanent."
                },
                new Competency
                {
                    Id = 10, NameEng = "Planning and Prioritizing",
                    NameFre = "Planification et établissement des priorités",
                    DescEng =
                        "Integrates various ideas, intentions, and information to form effective goals, objectives, timelines, action plans, and solutions.",
                    DescFre =
                        "Intégrer diverses idées, intentions et informations pour former des buts, des objectifs, des calendriers, des plans d’action et des solutions efficaces."
                },
                new Competency
                {
                    Id = 11, NameEng = "Procurement and Purchasing", NameFre = "Approvisionnement et achats",
                    DescEng =
                        "Manages the process of selecting vendors, establishing payment terms, strategic vetting, selection, the negotiation of contracts, and actual purchasing of goods.",
                    DescFre =
                        "Gérer le processus de sélection des fournisseurs, d’établissement des modalités de paiement, d’examen stratégique, de sélection, de négociation des contrats et d’achat des marchandises."
                },
                new Competency
                {
                    Id = 12, NameEng = "Workforce Management (HR) for Specialists",
                    NameFre = "Gestion de la main-d'œuvre (RH) pour les spécialistes",
                    DescEng =
                        "Plans, organizes, controls, and evaluates the operations of workforce management and personnel units. Develops and implements policies, programs, and procedures regarding workforce planning, recruitment, training, wellness, and career development.",
                    DescFre =
                        "Planifier, organiser, contrôler et évaluer les opérations des unités de gestion des effectifs et du personnel. Élaborer et mettre en œuvre des politiques, des programmes et des procédures concernant la planification des effectifs, le recrutement, la formation, le bien-être et le perfectionnement professionnel."
                },
                new Competency
                {
                    Id = 13, NameEng = "Financial Management for Specialists",
                    NameFre = "Gestion financière pour les spécialistes",
                    DescEng =
                        "Applies required financial procedures and tracking in order to manage public funds in an appropriate manner.",
                    DescFre =
                        "Applique les procédures et le suivi financiers nécessaires pour gérer les fonds publics de manière appropriée."
                },
                new Competency
                {
                    Id = 14, NameEng = "Communications for Specialists",
                    NameFre = "Communications pour les spécialistes",
                    DescEng =
                        "Encompasses written, oral, visual, and digital communication in an organizational context, as a specialty. Focuses on the study of information and the ways it is planned, created, managed, distributed, and consumed within the Canadian Coast Guard.",
                    DescFre =
                        "Comprend la communication écrite, orale, visuelle et numérique dans un contexte organisationnel, en tant que spécialité. Se concentre sur l'étude de l'information et sur la façon dont elle est planifiée, créée, gérée, distribuée et consommée au sein de la Garde côtière canadienne."
                },
                new Competency
                {
                    Id = 15, NameEng = "Real Property and Facilities Management",
                    NameFre = "Biens immobiliers et gestion des installations",
                    DescEng = "Manages real property and facilities management activities on a whole-life basis.",
                    DescFre =
                        "Gère les activités de gestion des biens immobiliers et des installations sur toute leur durée de vie."
                },
                new Competency
                {
                    Id = 16, NameEng = "Business Analysis", NameFre = "Analyse d'affaires",
                    DescEng =
                        "Establishes and enables processes in an organizational context, by defining needs and recommending solutions that deliver value to Canadian Coast Guard stakeholders.",
                    DescFre =
                        "Établit et facilite les processus dans un contexte organisationnel, en définissant les besoins et en recommandant des solutions qui apportent de la valeur aux intervenants. "
                },
                new Competency
                {
                    Id = 17, NameEng = "Support Services", NameFre = "Services de soutien",
                    DescEng =
                        "Provides a high standard of service to Canadian Coast Guard members and other stakeholders.",
                    DescFre =
                        "Fournir un service de haute qualité aux membres de la Garde côtière canadienne et aux autres intervenants."
                },
                new Competency
                {
                    Id = 18, NameEng = "Workforce Management (HR) for Supervisors/Managers",
                    NameFre = "Gestion de l’effectif (RH) pour les superviseurs et les gestionnaires",
                    DescEng =
                        "Manages unit or units workforce planning, recruitment, organizational design, classification issues, training and development, employment equity, official languages issues, performance management/labour relations, compensation issues, and rewards/recognition items.",
                    DescFre =
                        "Gérer la planification des effectifs de l’unité ou des unités, le recrutement, la conception organisationnelle, les questions de classification, la formation et le perfectionnement, l’équité en matière d’emploi, les questions de langues officielles, la gestion du rendement et les relations de travail, les questions de rémunération et les mesures de récompense et reconnaissance."
                },
                new Competency
                {
                    Id = 19, NameEng = "Financial Management for Supervisors/Managers",
                    NameFre = "Gestion financière pour les superviseurs/gestionnaires",
                    DescEng =
                        "Applies the rules, policies, regulations, and procedures of the Financial Administration Act as they apply to the Canadian Coast Guard as well as the organization's financial assets and management procedures (including related procurement rules) such as: financial authority level and approval process, financial accounting procedures, public accountability, budgeting, projecting, monitoring, reporting, financial auditing, etc.",
                    DescFre =
                        "Appliquer les règles, les politiques, les règlements et les procédures de la Loi sur la gestion des finances publiques qui s’appliquent à la Garde côtière canadienne ainsi que les procédures de gestion des actifs financiers et de l’organisation (y compris les règles de passation de marchés connexes) telles que le niveau de pouvoir financier et le processus d’approbation, les procédures de comptabilité financière, l’obligation de rendre des comptes au public, la budgétisation, la projection, la surveillance, la présentation de rapports, la vérification financière, etc."
                },
                new Competency
                {
                    Id = 20, NameEng = "Hotel Services Management", NameFre = "Gestion des services hôteliers",
                    DescEng =
                        "Consults with the chief cook in preparing menus and the economical use of provisions. Consults with the steward on all matters pertaining to accommodation, sanitation, and laundry facilities. Establishes requirements and procedures for the requisition, receipt, storage, and distribution of supplies. Collaborates with officers of the engine room department in the loading and moving of stores, supplies, and provisions.",
                    DescFre =
                        "Consulte le chef cuisinier pour la préparation des menus et l'utilisation économique des provisions. Consulte le steward sur toutes les questions relatives à l'hébergement, aux installations sanitaires et aux buanderies. Établit les exigences et les procédures pour la réquisition, la réception, le stockage et la distribution des fournitures. Collabore avec les officiers du service des machines pour le chargement et le déplacement des magasins, des fournitures et des provisions."
                },
                new Competency
                {
                    Id = 21, NameEng = "Maritime Security Operations Centre (MSOC)",
                    NameFre = "Centre des opérations de la sûreté maritime (COSM)",
                    DescEng =
                        "Analyzes and gathers information to produce intelligence-driven products in collaboration with interdepartmental partners. Compiles data and information gathered from surveillance activities, intelligence investigations, security events, or incidents.",
                    DescFre =
                        "Analyse et rassemble les informations pour produire des produits axés sur le renseignement en collaboration avec des partenaires interministériels. Compile les données et les informations recueillies lors d'activités de surveillance, d'enquêtes en matière de renseignement, d'événements de sûreté ou d'incidents."
                },
                new Competency
                {
                    Id = 22, NameEng = "Quality Assurance (QA)", NameFre = "Assurance de la qualité (AQ)",
                    DescEng =
                        "Plans and carries out systematic activities implemented within the quality management system.",
                    DescFre =
                        "Planifier et réaliser des activités systématiques mises en œuvre dans le cadre du système de gestion de la qualité."
                },
                new Competency
                {
                    Id = 23, NameEng = "Materiel Management", NameFre = "Gestion du matériel",
                    DescEng =
                        "Classifies materiel according to Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal.",
                    DescFre =
                        "Classifie le matériel selon les directives de la Garde côtière canadienne et des Services publics et Approvisionnement Canada (SPAC). Assure le suivi du matériel pendant la réception, l'entreposage, la distribution et l'élimination."
                },
                new Competency
                {
                    Id = 24, NameEng = "Exercise Planning", NameFre = "Planification d'exercices",
                    DescEng =
                        "Plans and develops exercises (simulations of an emergency situation), which includes validating exercise plans, developing member skills, testing them during exercises, and testing established procedures. It includes a visual overview of the exercise, tracks related hours/cost of exercise, assigns responsibilities and logistical tasks.",
                    DescFre =
                        "Planifie et développe des exercices (simulations d'une situation d'urgence), ce qui inclut la validation des plans d'exercices, le développement des compétences des membres, leur mise à l'épreuve lors des exercices et la mise à l'épreuve des procédures établies. Il comprend une vue d'ensemble visuelle de l'exercice, le suivi des heures/coûts de l'exercice, l'attribution des responsabilités et des tâches logistiques. "
                },
                new Competency
                {
                    Id = 25, NameEng = "Adult Teaching", NameFre = "Enseignement aux adultes",
                    DescEng =
                        "Teaching or instructing adults in systematic and sustained self-educating activities so that they may gain new forms of knowledge, skills, attitudes, or values. This includes various forms of specific and generic instruction as required by the Canadian Coast Guard with an emphasis on the needs of adults and the results orientation of the organization.",
                    DescFre =
                        "Enseigner ou instruire des adultes dans des activités d'auto-éducation systématiques et soutenues afin qu'ils puissent acquérir de nouvelles formes de connaissances, de compétences, d'attitudes ou de valeurs. Cela comprend diverses formes d'enseignement spécifique et générique, comme l'exige la Garde côtière canadienne, en mettant l'accent sur les besoins des adultes et l'orientation de l'organisation vers les résultats."
                },
                new Competency
                {
                    Id = 26, NameEng = "Demonstrating Integrity and Respect",
                    NameFre = "Faire preuve d'intégrité et de respect",
                    DescEng =
                        "Honours commitments and consistently strives to act in the public interest by ensuring that public trust and the law are not violated, while aasync Tasking conflicts of interest and maintaining political and interpersonal neutrality.",
                    DescFre =
                        "Respecter ses engagements et s’efforcer de toujours agir dans l’intérêt public en s’assurant de ne pas trahir la confiance du public, en évitant les conflits d’intérêts et en conservant une neutralité politique et interpersonnelle."
                },
                new Competency
                {
                    Id = 27, NameEng = "Thinking Things Through", NameFre = "Mener une réflexion approfondie",
                    DescEng =
                        "Plans and adjusts work based on a thorough understanding of the Canadian Coast Guard's priorities. Obtains relevant information, considers all facts, and exercises sound judgement to formulate an opinion and/or make a decision. Analyzes situations and seeks feedback to learn from mistakes.",
                    DescFre =
                        "Planifier et adapter le travail en fonction d’une compréhension approfondie des priorités de la Garde côtière canadienne. Obtenir des informations pertinentes, examiner tous les faits et faire preuve de discernement pour formuler une opinion et/ou prendre une décision. Analyser les situations et chercher à obtenir une rétroaction afin d’apprendre de ses erreurs."
                },
                new Competency
                {
                    Id = 28, NameEng = "Working Effectively With Others",
                    NameFre = "Travailler efficacement avec les autres",
                    DescEng =
                        "Works cooperatively in order to achieve results. Works positively as part of a team and manages internal conflict. Identifies opportunities to work together within the organization to improve team dynamics and develop relationships. Seeks and builds internal/external alliances, collaborations, and partnerships to advance the Canadian Coast Guard's mandate.",
                    DescFre =
                        "Travailler en coopération afin d’obtenir des résultats. Travailler en ayant une attitude positive en tant que membre d’une équipe et gérer les conflits internes. Cibler les possibilités de travailler ensemble au sein de l’organisation pour améliorer la dynamique d’équipe et solidifier les relations. Chercher et établir des alliances, des collaborations et des partenariats internes et externes pour faire progresser la réalisation du mandat de la Garde côtière canadienne."
                },
                new Competency
                {
                    Id = 33, NameEng = "Showing Initiative and Being Action Oriented",
                    NameFre = "Faire preuve d’initiative et être orienté vers l’action",
                    DescEng =
                        "Embraces change and actively looks for opportunities to learn and develop professionally and personally. Translates direction into concrete work activities. Identifies opportunities or issues, and takes action to enhance organizational results, without being prompted by others.",
                    DescFre =
                        "Être ouvert au changement et rechercher activement des possibilités d’apprentissage et de perfectionnement professionnel et personnel. Transposer les orientations en activités de travail concrètes. Cerner les occasions ou les questions et prendre des mesures pour améliorer les résultats organisationnels de sa propre initiative."
                },
                new Competency
                {
                    Id = 34, NameEng = "Apply Safety Considerations",
                    NameFre = "Considérations relatives à la sécurité",
                    DescEng =
                        "Promotes workplace safety. Follows safety guidelines, procedures, and regulations. Reacts safely and appropriately during emergencies. Integrates health and safety considerations in planning, response, and reviews.",
                    DescFre =
                        "Promouvoir la sécurité sur le lieu de travail. Respecter les directives, les procédures et les règlements de sécurité. Réagir de manière sûre et appropriée en cas d’urgence. Intégrer les considérations de santé et de sécurité dans la planification, l’intervention et les examens."
                },
                new Competency
                {
                    Id = 36, NameEng = "Leadership", NameFre = "Leadership",
                    DescEng =
                        "Attracts and mobilizes members and colleagues towards a shared vision and purpose in the best interests of the Canadian Coast Guard and the public it serves. Motivates project members, sets achievable objectives, maintains a positive outlook, takes responsibility, makes decisions, and provides constructive feedback.",
                    DescFre =
                        "Attirer et mobiliser les membres et les collègues vers l’atteinte d’une vision et d’un objectif communs dans l’intérêt supérieur de la Garde côtière canadienne et du public qu’elle sert. Motiver les membres des projets, fixer des objectifs réalisables, maintenir une attitude positive, prendre des responsabilités, prendre des décisions et donner de la rétroaction constructive."
                },
                new Competency
                {
                    Id = 37, NameEng = "Canadian Coast Guard Cultural Awareness",
                    NameFre = "Connaissance de la culture de la Garde côtière canadienne",
                    DescEng =
                        "The extent that members believe in the mission, mandate, and values of the Coast Guard and project that commitment through their actions and attitudes towards the organization and its stakeholders. Employee statements and deportment reflect a natural enthusiasm for the Coast Guard, what it does, and how it is viewed by the public.",
                    DescFre =
                        "Mesure dans laquelle les membres croient en la mission, au mandat et aux valeurs de la Garde côtière et projettent cet engagement par leurs actions et leur attitude envers l’organisation et ses parties prenantes. Les déclarations et le comportement des employés reflètent un enthousiasme naturel pour la Garde côtière, ses activités et la façon dont elle est perçue par le public."
                },
                new Competency
                {
                    Id = 38, NameEng = "Marine Domain Awareness Knowledge",
                    NameFre = "Connaissances sur la sensibilisation au domaine marin",
                    DescEng =
                        "Having true and timely information about everything on, under, related to, adjacent to, or bordering a sea, ocean, or other navigable waterway. This includes all related activities, infrastructure, shipping, vessels, cartography, and natural phenomena. For marine security, it includes being aware of anything in the marine domain that could threaten Canada's national security.",
                    DescFre =
                        "Disposer d'informations vraies et à jour sur tout ce qui se trouve sur, sous, en dessous, en relation avec, à proximité ou en bordure d'une mer, d'un océan ou d'un autre cours d'eau navigable. Cela comprend toutes les activités connexes, l'infrastructure, le transport maritime, les navires, la cartographie et les phénomènes naturels. En ce qui concerne la sécurité maritime, il s'agit d'être au courant de tout ce qui, dans le domaine maritime, pourrait menacer la sécurité nationale du Canada."
                },
                new Competency
                {
                    Id = 39, NameEng = "Canal Lock Knowledge", NameFre = "Connaissance de Canal Lock",
                    DescEng =
                        "Knowledge of all facets of the uses of, management, and maintenance of lock operation in the Canadian maritime domain.",
                    DescFre =
                        "Knowledge of all facets of the uses of, management, and maintenance of lock operation in the Canadian maritime domain."
                },
                new Competency
                {
                    Id = 40, NameEng = "Operations and Maintenance.", NameFre = "Exploitation et maintenance",
                    DescEng =
                        "Performs general labourer duties, building, vessel and grounds maintenance tasks, and transports materials and equipment.",
                    DescFre =
                        "Exécute des tâches de manœuvre générale, des tâches d'entretien des bâtiments, des navires et des terrains, et transporte des matériaux et des équipements."
                },
                new Competency
                {
                    Id = 41, NameEng = "Heavy Machinery Operation", NameFre = "Opération de machinerie lourde",
                    DescEng =
                        "Drives or controls construction equipment including bulldozers, forklifts, back hoes, dump trucks, cargo trucks, and hydraulic truck cranes. Operated to assist in the construction of structures including bridges, roads, and buildings, vessels and Coast Guard structures, equipment, or facilities.",
                    DescFre =
                        "Drives or controls construction equipment including bulldozers, forklifts, back hoes, dump trucks, cargo trucks, and hydraulic truck cranes. Operated to assist in the construction of structures including bridges, roads, and buildings, vessels and Coast Guard structures, equipment, or facilities."
                },
                new Competency
                {
                    Id = 42, NameEng = "Carpentry", NameFre = "La menuiserie",
                    DescEng =
                        "Applies skills of cutting, shaping, and installing building materials during the construction of buildings, ships, concrete formwork, and other physical structures, including rough and fine work.",
                    DescFre =
                        "Applique des compétences de coupe, de façonnage et d'installation de matériaux de construction lors de la construction de bâtiments, de navires, de coffrages en béton et d'autres structures physiques, y compris le travail grossier et le travail de précision."
                },
                new Competency
                {
                    Id = 43, NameEng = "Electrical Review, Decision Making, and Analysis",
                    NameFre = "Examen électrique, prise de décision et analyse",
                    DescEng =
                        "Ability to use effective approaches with available facts, constraints, and anticipated consequences in marine electrical systems.",
                    DescFre =
                        "Ability to use effective approaches with available facts, constraints, and anticipated consequences in marine electrical systems."
                },
                new Competency
                {
                    Id = 44, NameEng = "Heavy Machinery Maintenance", NameFre = "Maintenance de machinerie lourde",
                    DescEng = "Repairs, troubleshoots, adjusts, overhauls, and maintains mobile heavy-duty equipment.",
                    DescFre = "Repairs, troubleshoots, adjusts, overhauls, and maintains mobile heavy-duty equipment."
                },
                new Competency
                {
                    Id = 45, NameEng = "Automotive Service", NameFre = "Service automobile",
                    DescEng =
                        "Performs preventative maintenance, diagnoses problems, and repairs vehicle systems including engines, vehicle management, hybrids, steering, braking, tires, wheels, drivetrains, suspension, electrical, electronics, heating, ventilation and air conditioning (HVAC), restraints, trim, and accessories of automotive vehicles and light trucks.",
                    DescFre =
                        "Performs preventative maintenance, diagnoses problems, and repairs vehicle systems including engines, vehicle management, hybrids, steering, braking, tires, wheels, drivetrains, suspension, electrical, electronics, heating, ventilation and air conditioning (HVAC), restraints, trim, and accessories of automotive vehicles and light trucks."
                },
                new Competency
                {
                    Id = 46, NameEng = "Painting and Decorating", NameFre = "Peinture et décoration",
                    DescEng =
                        "Prepares and applies paint or any organic/inorganic coating when applied in the same manner as paints.",
                    DescFre =
                        "Prepares and applies paint or any organic/inorganic coating when applied in the same manner as paints."
                },
                new Competency
                {
                    Id = 47, NameEng = "Acts and Regulations Knowledge",
                    NameFre = "Connaissance des lois et règlements",
                    DescEng =
                        "An understanding of the acts and regulations pertinent to operational programs, including their affective clauses, sources, authorities, and impacts on a given program or programs in the Canadian Coast Guard.",
                    DescFre =
                        "Compréhension des lois et règlements pertinents aux programmes opérationnels, y compris leurs clauses affectives, leurs sources, leurs pouvoirs et leurs répercussions sur un ou des programmes donnés de la Garde côtière canadienne."
                },
                new Competency
                {
                    Id = 48, NameEng = "Diving Operations Knowledge",
                    NameFre = "Connaissance des opérations de plongée",
                    DescEng =
                        "Diving knowledge required to work safely in a hostile environment through proper organization and planning.",
                    DescFre =
                        "Connaissances en plongée requises pour travailler en toute sécurité dans un environnement hostile grâce à une organisation et une planification appropriées."
                },
                new Competency
                {
                    Id = 49, NameEng = "Rigging and Lifting", NameFre = "Montage et levage",
                    DescEng =
                        "Executes load-lifting, towing, storing, deployment operations on cargo, nets, and equipment with proper adherence to Occupational Health and Safety (OHS) requirements, signaling and communication protocols with diligent care for equipment.",
                    DescFre =
                        "Executes load-lifting, towing, storing, deployment operations on cargo, nets, and equipment with proper adherence to Occupational Health and Safety (OHS) requirements, signaling and communication protocols with diligent care for equipment."
                },
                new Competency
                {
                    Id = 50, NameEng = "Technical Maintenance of Diving Equipment",
                    NameFre = "Entretien technique de l’équipement de plongée",
                    DescEng =
                        "Repairs and conducts preventative maintenance of diving equipment. Maintains dive computers and instruments in accordance with all manufacturer's recommendations and owner's manuals.",
                    DescFre =
                        "Repairs and conducts preventative maintenance of diving equipment. Maintains dive computers and instruments in accordance with all manufacturer's recommendations and owner's manuals."
                },
                new Competency
                {
                    Id = 51, NameEng = "Diving Supervision", NameFre = "Supervision de la plongée",
                    DescEng =
                        "Supervision of a dive team using Compressed Air Breathing Apparatus (CABA) or Light Weight Surface Supply (LWSS) equipment to a depth of less than or equal to 45 metres.",
                    DescFre =
                        "Supervision of a dive team using Compressed Air Breathing Apparatus (CABA) or Light Weight Surface Supply (LWSS) equipment to a depth of less than or equal to 45 metres."
                },
                new Competency
                {
                    Id = 52, NameEng = "Small Boats, Helicopters, Barges, Tackle Operations",
                    NameFre = "Petites embarcations/hélicoptère/barge/dispositifs de levage",
                    DescEng =
                        "Practices seamanship in areas such as vessel maintenance, steering, lookout, the use and maintenance of small vessels, helicopter procedures, and tackle use, stowage, and maintenance.",
                    DescFre =
                        "Practices seamanship in areas such as vessel maintenance, steering, lookout, the use and maintenance of small vessels, helicopter procedures, and tackle use, stowage, and maintenance."
                },
                new Competency
                {
                    Id = 53, NameEng = "Life Cycle Asset Management", NameFre = "Gestion du cycle de vie des biens",
                    DescEng =
                        "Employs an integrated approach to optimizing the life cycle of the Canadian Coast Guard’s assets beginning at conceptual design, continuing through shut down, and decommissioning/disposal.",
                    DescFre =
                        "Employer une approche intégrée pour optimiser le cycle de vie des actifs de la Garde côtière canadienne, depuis la conception, en passant par l’arrêt, la mise hors service et l’élimination."
                },
                new Competency
                {
                    Id = 54, NameEng = "Troubleshooting", NameFre = "Dépannage",
                    DescEng =
                        "Employs a systematic approach to problems in order to find and correct issues with Canadian Coast Guard assets (e.g. land based, sea based, structural, electronic, etc.).",
                    DescFre =
                        "Employer une méthode systématique pour aborder les problèmes afin de trouver et de corriger les problèmes liés aux actifs de la Garde côtière canadienne (par exemple, les actifs terrestres, maritimes, structurels, électroniques)."
                },
                new Competency
                {
                    Id = 55, NameEng = "Problem Solving", NameFre = "Résolution de problèmes",
                    DescEng =
                        "Defines a problem while determining the cause of the problem and identifying, prioritizing, and selecting alternatives for a solution.",
                    DescFre =
                        "Définit un problème tout en déterminant la cause du problème et en identifiant, priorisant et sélectionnant des solutions de rechange."
                },
                new Competency
                {
                    Id = 56, NameEng = "Dietary Need, Menu Planning, Food Preparation, and Sanitation Knowledge",
                    NameFre =
                        "Connaissances sur les besoins alimentaires, la planification des menus, la préparation des aliments et l'assainissement",
                    DescEng =
                        "Knowledge to create menus that meet the dietary needs of the ships' crews. The focus is on assuring that the menu meets dietary and nutritional needs and food preferences, that food is prepared and stored in a safe and sanitary fashion, and that food preparation areas are kept clean.",
                    DescFre =
                        "Des connaissances pour créer des menus qui répondent aux besoins alimentaires des équipages des navires. L'accent est mis sur l'assurance que le menu répond aux besoins alimentaires et nutritionnels et aux préférences alimentaires, que les aliments sont préparés et entreposés de façon sécuritaire et hygiénique et que les aires de préparation des aliments sont maintenues propres."
                },
                new Competency
                {
                    Id = 57, NameEng = "Inventory Management Systems Knowledge",
                    NameFre = "Connaissance des systèmes de gestion des stocks",
                    DescEng = "Understands processes to track materiel during receipt, storage, issue, and disposal.",
                    DescFre = "Understands processes to track materiel during receipt, storage, issue, and disposal."
                },
                new Competency
                {
                    Id = 58, NameEng = "Galley Operations and Food Production",
                    NameFre = "Exploitation des cuisines et production alimentaire",
                    DescEng =
                        "Conducts and manages all food preparation including salads, meals, snacks, desserts, and beverages by following menus, recipes, and nutritional guidelines in a safe and clean fashion.",
                    DescFre =
                        "Conducts and manages all food preparation including salads, meals, snacks, desserts, and beverages by following menus, recipes, and nutritional guidelines in a safe and clean fashion."
                },
                new Competency
                {
                    Id = 59, NameEng = "Search and Rescue (SAR) Knowledge",
                    NameFre = "Connaissances en recherche et sauvetage (SAR)",
                    DescEng =
                        "Knowledge of the coastal and national search and rescue safety nets, the authorities, stakeholders, roles and relationships, and how they all work together in incidents and scenarios. This includes Canadian Coast Guard assets at sea and ashore (Marine Communications and Traffic Services [MCTS], the Regional Operations Centre [ROC], the Joint Rescue Co-ordination Centre [JRCC]), the Canadian Coast Guard Auxiliary, other government departments (Transport Canada, Royal Canadian Mounted Police, Department of National Defence), industry, and the public.",
                    DescFre =
                        "Knowledge of the coastal and national search and rescue safety nets, the authorities, stakeholders, roles and relationships, and how they all work together in incidents and scenarios. This includes Canadian Coast Guard assets at sea and ashore (Marine Communications and Traffic Services [MCTS], the Regional Operations Centre [ROC], the Joint Rescue Co-ordination Centre [JRCC]), the Canadian Coast Guard Auxiliary, other government departments (Transport Canada, Royal Canadian Mounted Police, Department of National Defence), industry, and the public."
                },
                new Competency
                {
                    Id = 60, NameEng = "Search and Rescue (SAR)", NameFre = "Recherche et sauvetage (SAR)",
                    DescEng =
                        "Leads the maritime component of the federal SAR system in the provision of search and rescue services to Canadian mariners and to others in need of humanitarian aid, including the coordination of SAR operations on the water for the provision of aid to persons, ships, or other craft which are, or are feared to be, in distress or imminent danger.",
                    DescFre =
                        "Leads the maritime component of the federal SAR system in the provision of search and rescue services to Canadian mariners and to others in need of humanitarian aid, including the coordination of SAR operations on the water for the provision of aid to persons, ships, or other craft which are, or are feared to be, in distress or imminent danger."
                },
                new Competency
                {
                    Id = 61, NameEng = "Bridge Watchkeeping Duties", NameFre = "Tâches de quart à la passerelle",
                    DescEng =
                        "Performs helm's person seamanship duties on the bridge of a vessel using bridge steering and propulsion equipment while slipping, underway, and/or docking. Performs duties of a lookout while ship is underway.",
                    DescFre =
                        "Performs helm's person seamanship duties on the bridge of a vessel using bridge steering and propulsion equipment while slipping, underway, and/or docking. Performs duties of a lookout while ship is underway."
                },
                new Competency
                {
                    Id = 62, NameEng = "Marine Engine Mechanical Knowledge",
                    NameFre = "Connaissances en mécanique des moteurs marins",
                    DescEng =
                        "Knowledge of mechanical tools and instruments, inspection, repair, maintenance of marine engines, electrical systems, transmissions, and auxiliary systems components.",
                    DescFre =
                        "Knowledge of mechanical tools and instruments, inspection, repair, maintenance of marine engines, electrical systems, transmissions, and auxiliary systems components."
                },
                new Competency
                {
                    Id = 63, NameEng = "Engineering Watchkeeping Duties", NameFre = "Tâches de veille technique",
                    DescEng =
                        "Operates and services main propulsion and auxiliary machinery while in use or required for use. Identifies issues, obtains relevant information, relates and compares data from different sources, and identifies alternate solutions.",
                    DescFre =
                        "Operates and services main propulsion and auxiliary machinery while in use or required for use. Identifies issues, obtains relevant information, relates and compares data from different sources, and identifies alternate solutions."
                },
                new Competency
                {
                    Id = 64, NameEng = "Deck Management Knowledge", NameFre = "Connaissance de la gestion du pont",
                    DescEng =
                        "The management of a deck watch to ensure safe rigging, lifting, tackle, small craft, helicopter, and cargo loading operations.",
                    DescFre =
                        "La gestion d'un quart à la passerelle pour assurer la sécurité des opérations d'amarrage, de levage, d'accastillage, d'embarcation, d'hélicoptère et de chargement de la cargaison."
                },
                new Competency
                {
                    Id = 65, NameEng = "Fishing Officer Knowledge", NameFre = "Connaissances des agents des pêches",
                    DescEng =
                        "The body of experiential knowledge including environmental, resource-based, ecosystem, fishing practices, fishing communities and livelihoods, governance and markets, and their dynamic relationships.",
                    DescFre =
                        "L'ensemble des connaissances expérientielles, y compris l'environnement, les ressources, l'écosystème, les pratiques de pêche, les communautés de pêcheurs et leurs moyens de subsistance, la gouvernance et les marchés, et leurs relations dynamiques."
                },
                new Competency
                {
                    Id = 66, NameEng = "Engineering/Electrical Knowledge and Principles",
                    NameFre = "Connaissances et principes en matière d'ingénierie et d'électricité",
                    DescEng =
                        "Understands concepts, practices, and theories involved in the development/review/construction, maintenance, operations, or repair of, projects/sites and their potential environmental, and safety impacts.",
                    DescFre =
                        "Comprend les concepts, les pratiques et les théories qui interviennent dans l'élaboration, l'examen, la construction, l'entretien, l'exploitation ou la réparation des projets ou des sites, ainsi que leurs répercussions potentielles sur l'environnement et la sécurité."
                },
                new Competency
                {
                    Id = 67, NameEng = "Engineering/Electrical Equipment Standard Operating Procedures Knowledge",
                    NameFre =
                        "Connaissance des procédures d'utilisation normalisées de l'ingénierie et de l'équipement électrique",
                    DescEng =
                        "Understands steps and safety regulations in preparing equipment for operation, operating equipment, monitoring, and conducting running maintenance.",
                    DescFre =
                        "Comprend les étapes et les règles de sécurité dans la préparation de l'équipement pour l'opération, l'opération de l'équipement, la surveillance et l'exécution de l'entretien courant."
                },
                new Competency
                {
                    Id = 68, NameEng = "Operations Knowledge", NameFre = "Connaissance des opérations",
                    DescEng =
                        "Knowledge of systems for proper scheduling and tracking of ships' activities to ensure of the best use of the available resources for regular program delivery, as well as during emergency situations.",
                    DescFre =
                        "Knowledge of systems for proper scheduling and tracking of ships' activities to ensure of the best use of the available resources for regular program delivery, as well as during emergency situations."
                },
                new Competency
                {
                    Id = 69, NameEng = "Navigational Equipment Standard Operating Procedures Knowledge",
                    NameFre = "Procédures d'utilisation normalisées de l'équipement de navigation Connaissances",
                    DescEng =
                        "Knowledge of the steps and safety regulations in preparing equipment for operation, operating equipment, and monitoring.",
                    DescFre =
                        "Knowledge of the steps and safety regulations in preparing equipment for operation, operating equipment, and monitoring."
                },
                new Competency
                {
                    Id = 70, NameEng = "Environmental Response (ER) Knowledge",
                    NameFre = "Connaissances en matière d'intervention environnementale (IE)",
                    DescEng =
                        "Knowledge of the ER program mandate, roles, and responsibilities. Knowledge of ER operations, priorities, issues, stakeholders, policies, practices, and procedures. Knowledge of capabilities, duties, and technical skills of the ER team. Knowledge of marine clients and partners as they relate to the ER program.",
                    DescFre =
                        "Connaissance du mandat, des rôles et des responsabilités du programme d'IE. Connaissance des opérations, des priorités, des enjeux, des intervenants, des politiques, des pratiques et des procédures d'IE. Connaissance des capacités, des tâches et des compétences techniques de l'équipe d'urgence. Connaissance des clients et des partenaires du secteur maritime en ce qui a trait au programme d'IE."
                },
                new Competency
                {
                    Id = 71, NameEng = "Icebreaking (IB) Knowledge",
                    NameFre = "Connaissances en matière de déglaçage (IB)",
                    DescEng =
                        "Knowledge of procedures and processes involved in icebreaking operations coordination. Knowledge of area of responsibility (AOR) characteristics. Knowledge of operational electronics programs related to the IB program (Icebreaking Operations Data Information System [IODIS], Vessel Traffic Management Information System [INNAV], and Google Earth). Knowledge of the various standard operating procedures (SOPs) and standing operational guidelines.",
                    DescFre =
                        "Connaissance des procédures et des processus impliqués dans la coordination des opérations de déglaçage. Connaissance des caractéristiques de la zone de responsabilité (ZR). Connaissance des programmes d'électronique opérationnelle liés au programme de l'IB (Système d'information sur les données des opérations de déglaçage [SIDOD], Système d'information sur la gestion du trafic maritime [SIGTM], et Exact Earth). Connaissance des diverses procédures opératoires normalisées (PON) et des lignes directrices opérationnelles permanentes."
                },
                new Competency
                {
                    Id = 72, NameEng = "Marine Engineering Systems Operations and Maintenance",
                    NameFre = "Exploitation et maintenance des systèmes de génie maritime",
                    DescEng =
                        "Conducts all operations and maintenance activities on shipboard engineering equipment. This includes start up, shut down, monitoring, planning, and reporting functions.",
                    DescFre =
                        "Conduit toutes les activités d'exploitation et de maintenance des équipements techniques de bord. Cela comprend les fonctions de démarrage, d'arrêt, de surveillance, de planification et de compte rendu."
                },
                new Competency
                {
                    Id = 73, NameEng = "Electrical Operations and Maintenance",
                    NameFre = "Conception technique et analyse",
                    DescEng = "Operates and maintains shipboard electrical systems and equipment.",
                    DescFre = "Operates and maintains shipboard electrical systems and equipment."
                },
                new Competency
                {
                    Id = 74, NameEng = "Bridge Management", NameFre = "Gestion des ressources de pont",
                    DescEng =
                        "The management of a bridge watch to con vessels confidently and safely under various conditions and be able to make a more effective contribution to the bridge team during ship maneuvering in all conditions. Elements include navigation, radar, plotting, vessel handling, emergency management, collision avoidance, and watchkeeping protocols.",
                    DescFre =
                        "The management of a bridge watch to con vessels confidently and safely under various conditions and be able to make a more effective contribution to the bridge team during ship maneuvering in all conditions. Elements include navigation, radar, plotting, vessel handling, emergency management, collision avoidance, and watchkeeping protocols."
                },
                new Competency
                {
                    Id = 75, NameEng = "Materiel Management (Logistics)", NameFre = "Gestion du matériel (logistique)",
                    DescEng =
                        "Classifies materiel according to the Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal with regards to the provisioning of Coast Guard vessels.",
                    DescFre =
                        "Classifies materiel according to the Canadian Coast Guard and Public Services and Procurement Canada (PSPC) directives. Tracks materiel during receipt, storage, issue, and disposal with regards to the provisioning of Coast Guard vessels."
                },
                new Competency
                {
                    Id = 76, NameEng = "Logistics for Supervisors/Managers",
                    NameFre = "Logistique pour les superviseurs/gestionnaires",
                    DescEng =
                        "Plans, implements, and controls processes for the efficient and effective transportation, storage, use, and disposal of project or program specific goods at operational facilities.",
                    DescFre =
                        "Plans, implements, and controls processes for the efficient and effective transportation, storage, use, and disposal of project or program specific goods at operational facilities."
                },
                new Competency
                {
                    Id = 77, NameEng = "Aids to Navigation (AtoN)", NameFre = "Aides à la navigation (AtoN)",
                    DescEng =
                        "Delivers the AtoN program’s provision of visual and aural aids to navigation, electronic positioning systems such as the differential global positioning system (DGPS), and navigation safety information. These services involve, among others, analyzing, planning, and coordinating functions.",
                    DescFre =
                        "Delivers the AtoN program’s provision of visual and aural aids to navigation, electronic positioning systems such as the differential global positioning system (DGPS), and navigation safety information. These services involve, among others, analyzing, planning, and coordinating functions."
                },
                new Competency
                {
                    Id = 78, NameEng = "Research and Analysis", NameFre = "Recherche et analyse",
                    DescEng =
                        "Researches and analyzes qualitative and quantitative information (oral and written), such as data, policies, procedures, legislation, project/program specifications, client documents, legal documentation, databanks, and any other information sources.",
                    DescFre =
                        "Recherche et analyse d'informations qualitatives et quantitatives (orales et écrites), telles que des données, des politiques, des procédures, des lois, des spécifications de projets/programmes, des documents de clients, des documents juridiques, des banques de données et toute autre source d'information."
                },
                new Competency
                {
                    Id = 79, NameEng = "Engineering Review, Decision Making, and Analysis",
                    NameFre = "Examen technique, prise de décision et analyse",
                    DescEng =
                        "Uses effective approaches with available facts, constraints, and anticipated consequences in marine engineering systems.",
                    DescFre =
                        "Utilise des approches efficaces avec les faits disponibles, les contraintes et les conséquences prévues dans les systèmes de génie maritime."
                },
                new Competency
                {
                    Id = 80, NameEng = "Engineering Design and Analysis", NameFre = "Conception technique et analyse",
                    DescEng =
                        "Identifies, develops, and analyzes the installation process of engineering designs and/or specifications. Plans, identifies, and modifies methods and resources.",
                    DescFre =
                        "Identifies, develops, and analyzes the installation process of engineering designs and/or specifications. Plans, identifies, and modifies methods and resources."
                },
                new Competency
                {
                    Id = 81, NameEng = "Library Sciences Management", NameFre = "Gestion des services de bibliothèque",
                    DescEng =
                        "Applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries, including the collection, organization, preservation, dissemination of information resources, and the political economy of information.",
                    DescFre =
                        "Applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries, including the collection, organization, preservation, dissemination of information resources, and the political economy of information."
                },
                new Competency
                {
                    Id = 82, NameEng = "Health Science Knowledge", NameFre = "Connaissances en sciences de la santé",
                    DescEng =
                        "Knowledge related to nursing including anatomy, physiology, pathophysiology, psychopathology, pharmacology, microbiology, epidemiology, genetics, immunology, and nutrition.",
                    DescFre =
                        "Connaissances liées aux soins infirmiers, notamment en anatomie, physiologie, physiologie, physiopathologie, psychopathologie, pharmacologie, microbiologie, épidémiologie, génétique, immunologie et nutrition."
                },
                new Competency
                {
                    Id = 83, NameEng = "Health Care Services", NameFre = "Services de soins de santé",
                    DescEng =
                        "Provides support and services in order to meet the needs of clients, in light of relevant situational, and contextual realities, in accordance with established theories and frameworks relevant to health and well-being.",
                    DescFre =
                        "Provides support and services in order to meet the needs of clients, in light of relevant situational, and contextual realities, in accordance with established theories and frameworks relevant to health and well-being."
                },
                new Competency
                {
                    Id = 84, NameEng = "Ethical Practice in Health Services",
                    NameFre = "Pratique éthique dans les services de santé",
                    DescEng =
                        "Practices health care with honesty, integrity, and respect in all professional interactions.",
                    DescFre =
                        "Practices health care with honesty, integrity, and respect in all professional interactions."
                },
                new Competency
                {
                    Id = 85, NameEng = "Materiel and Supply Chain Management",
                    NameFre = "Gestion du matériel et de la chaîne d'approvisionnement",
                    DescEng =
                        "Manages the flow of goods and services, including the movement and storage of raw materials, of work-in-process inventory, and of finished goods from point of origin to point of consumption.",
                    DescFre =
                        "Manages the flow of goods and services, including the movement and storage of raw materials, of work-in-process inventory, and of finished goods from point of origin to point of consumption."
                },
                new Competency
                {
                    Id = 86, NameEng = "Physical Education", NameFre = "Éducation physique",
                    DescEng =
                        "Physical Education: Develops students' physical competence and knowledge of movement and safety, and their ability to use these to perform in a wide range of activities associated with the development of an active and healthy lifestyle.",
                    DescFre =
                        "Développe les compétences physiques et les connaissances des élèves en matière de mouvement et de sécurité, ainsi que leur capacité à les utiliser pour effectuer un large éventail d'activités associées au développement d'un mode de vie actif et sain."
                },
                new Competency
                {
                    Id = 87, NameEng = "Forklift Operations", NameFre = "Utilisation de chariots élévateurs à fourche",
                    DescEng =
                        "Operates various classes of counterbalance forklift trucks in a manner that protects both operator safety and the safety of others in the workplace.",
                    DescFre =
                        "Operates various classes of counterbalance forklift trucks in a manner that protects both operator safety and the safety of others in the workplace."
                },
                new Competency
                {
                    Id = 88, NameEng = "Lightkeeper Observation Services",
                    NameFre = "Services d'observation des gardiens de phare",
                    DescEng =
                        "Reports observed phenomenon to mariners and the organization. Operates equipment to collect, store, transmit, and interpret data relating to the marine environment or the atmosphere.",
                    DescFre =
                        "Reports observed phenomenon to mariners and the organization. Operates equipment to collect, store, transmit, and interpret data relating to the marine environment or the atmosphere."
                },
                new Competency
                {
                    Id = 89, NameEng = "Operate and Maintain Lighthouse (LI) Equipment",
                    NameFre = "Exploitation et entretien d’équipement du phare (LI)",
                    DescEng =
                        "Manages the full spectrum of lighthouse equipment operation and maintenance under the department's responsibility.",
                    DescFre =
                        "Manages the full spectrum of lighthouse equipment operation and maintenance under the department's responsibility."
                },
                new Competency
                {
                    Id = 90, NameEng = "Sensory Equipment Knowledge",
                    NameFre = "Connaissance des équipements sensoriels",
                    DescEng =
                        "Knowledge of operational equipment and surveillance circuits available in the Canadian Coast Guard such as radars, radios, satellite gear, cameras, tracking systems, search systems, plotters, etc.",
                    DescFre =
                        "Connaissance des équipements opérationnels et des circuits de surveillance disponibles au sein de la Garde côtière canadienne tels que les radars, les radios, les équipements satellites, les caméras, les systèmes de suivi, les systèmes de recherche, les traceurs, etc."
                },
                new Competency
                {
                    Id = 91, NameEng = "Tool Care, Use and Maintenance",
                    NameFre = "Entretien, utilisation et maintenance des outils",
                    DescEng =
                        "Using basic hand held, power, precision stationary or portable tools and precision measuring tools. Performing the required care and maintenance in accordance with established schedules and programs.",
                    DescFre =
                        "Using basic hand held, power, precision stationary or portable tools and precision measuring tools. Performing the required care and maintenance in accordance with established schedules and programs."
                },
                new Competency
                {
                    Id = 92, NameEng = "Welding", NameFre = "Soudage",
                    DescEng =
                        "Welds metals using manual, semi-automatic, and automatic arc welding equipment. Plans drawings and blueprints. Fabricates, assembles, and welds to make products via the use of hand tools.",
                    DescFre =
                        "Soude les métaux à l'aide d'un équipement de soudage à l'arc manuel, semi-automatique et automatique. Planifie les dessins et les plans. Fabrique, assemble et soude pour fabriquer des produits à l'aide d'outils manuels."
                },
                new Competency
                {
                    Id = 93, NameEng = "Aids to Navigation (AtoN) Knowledge",
                    NameFre = "Connaissances en matière d'aides à la navigation (AtoN)",
                    DescEng =
                        "Knowledge of the Canadian Coast Guard's navigational aid network, their locations, operation, and maintenance, which includes a range of lights, lighthouses, buoys, beacons, and differential global positioning systems (DGPS). Knowledge of waterways management (WM) which includes a knowledge of the types, locations, and monitoring of the available water depths (Avadepth) program and river structures, when and where applicable.",
                    DescFre =
                        "Connaissance du réseau d'aide à la navigation de la Garde côtière canadienne, de son emplacement, de son fonctionnement et de son entretien, ce qui comprend une gamme de feux, de phares, de bouées, de balises et de systèmes de positionnement mondial différentiel (DGPS). Connaissance de la gestion des voies navigables (GC), ce qui comprend la connaissance des types, des emplacements et de la surveillance des profondeurs d'eau disponibles (profondeur d'Avadepth) et des structures des rivières, le cas échéant."
                },
                new Competency
                {
                    Id = 94, NameEng = "Electrical/Electronic Review, Decision Making and Analysis",
                    NameFre = "Examen, prise de décision et analyse électriques et électroniques",
                    DescEng =
                        "Uses effective approaches with available facts, constraints, and anticipated consequences in marine electrical systems.",
                    DescFre =
                        "Utiliser des approches efficaces en utilisant les faits disponibles, les contraintes et les conséquences prévues dans les systèmes électriques marins."
                },
                new Competency
                {
                    Id = 95, NameEng = "Radio Wave Propagation and Antennas Knowledge",
                    NameFre = "Connaissance de la propagation des ondes radioélectriques et des antennes",
                    DescEng =
                        "Knowledge of types of electromagnetic signal designed to carry information through the air over relatively long distances and how antennas send and/or receive electromagnetic radio waves.",
                    DescFre =
                        "Connaissance des types de signaux électromagnétiques conçus pour transporter de l’information dans l’air sur des distances relativement longues et de la manière dont les antennes envoient et/ou reçoivent des ondes radioélectriques."
                },
                new Competency
                {
                    Id = 96, NameEng = "Electrical Installing and Maintaining",
                    NameFre = "Installation et entretien électrique",
                    DescEng =
                        "Installs, repairs, and maintains wiring, switches, conduits, circuit breakers, lighting, and other equipment in buildings and other structures.",
                    DescFre =
                        "Installs, repairs, and maintains wiring, switches, conduits, circuit breakers, lighting, and other equipment in buildings and other structures."
                },
                new Competency
                {
                    Id = 97, NameEng = "Refrigeration and Air Conditioning Operation, Installing and Maintenance",
                    NameFre =
                        "Fonctionnement, installation et entretien des systèmes de réfrigération et de climatisation",
                    DescEng = "Repairing, installing and troubleshooting refrigeration systems.",
                    DescFre = "Repairing, installing and troubleshooting refrigeration systems."
                },
                new Competency
                {
                    Id = 98, NameEng = "Strategic Resource Management, Internal Control, and Integrated Planning Cycle",
                    NameFre = "Gestion stratégique des ressources, contrôle interne et cycle de planification intégrée",
                    DescEng =
                        "Applies the interconnected structures and processes of government, such as the functions and accountability of departments in the executive branch relating to resource allocation, the integrated budgetary planning cycle, and the control of these resources.",
                    DescFre =
                        "Applique les structures et les processus interconnectés du gouvernement, tels que les fonctions et la responsabilité des départements de la branche exécutive en matière d'allocation des ressources, le cycle de planification budgétaire intégrée et le contrôle de ces ressources."
                },
                new Competency
                {
                    Id = 99, NameEng = "Expenditure, Cost Accounting, and Statutory Reporting",
                    NameFre = "Dépenses, comptabilisation des coûts et rapport statutaire",
                    DescEng =
                        "Supports the appropriate collection, measurement, accumulation, analysis, interpretation, and communication of cost information. Assists clients in determining program and activity costs and changes.",
                    DescFre =
                        "Permet la collecte, la mesure, l'accumulation, l'analyse, l'interprétation et la communication appropriées des informations sur les coûts. Aide les clients à déterminer les coûts et les changements des programmes et des activités."
                },
                new Competency
                {
                    Id = 100, NameEng = "Indigenous Negotiation", NameFre = "Négociation indigène",
                    DescEng =
                        "Consults and negotiates with disparate Indigenous bands to articulate sound and consistent strategic approaches that satify and align with the priorities of Governement of Canada and the bands.",
                    DescFre =
                        "Consulte et négocie avec des bandes autochtones disparates afin d'articuler des approches stratégiques solides et cohérentes qui satisfont et s'alignent sur les priorités du gouvernement du Canada et des bandes."
                },
                new Competency
                {
                    Id = 101, NameEng = "Technical Inspection", NameFre = "Inspection technique",
                    DescEng =
                        "Inspects, evaluates, standardizes, and plans inspections and evaluations of skilled ship construction activities.",
                    DescFre =
                        "Inspects, evaluates, standardizes, and plans inspections and evaluations of skilled ship construction activities."
                },
                new Competency
                {
                    Id = 102, NameEng = "Vessel of Concern Knowledge", NameFre = "Connaissance du navire en cause",
                    DescEng =
                        "An understanding of the Oceans Protection Plan mandate concerning the management of wrecked and abandoned vessels, inclusive of the plan aimed to protect Canada's marine environment.",
                    DescFre =
                        "An understanding of the Oceans Protection Plan mandate concerning the management of wrecked and abandoned vessels, inclusive of the plan aimed to protect Canada's marine environment."
                },
                new Competency
                {
                    Id = 103, NameEng = "Icebreaking (IB)", NameFre = "Déglaçage",
                    DescEng =
                        "Receives, analyzes, and answers requests for icebreaking assistance. Coordinates icebreaker positioning and tasking’s. Monitors effectiveness of operational solutions and adapts accordingly. Communicates information to management, clients and partners. Prepares ice routes suggestion and information package for the clients and industry. Ice bulleting, marine information and warning. Prepares complete information presentation regarding the icebreaking program for morning briefings to senior management.",
                    DescFre =
                        "Receives, analyzes, and answers requests for icebreaking assistance. Coordinates icebreaker positioning and tasking’s. Monitors effectiveness of operational solutions and adapts accordingly. Communicates information to management, clients and partners. Prepares ice routes suggestion and information package for the clients and industry. Ice bulleting, marine information and warning. Prepares complete information presentation regarding the icebreaking program for morning briefings to senior management."
                },
                new Competency
                {
                    Id = 104, NameEng = "Vessel of Concern", NameFre = "Navire en cause",
                    DescEng =
                        "Maintains an inventory of wrecked and abandoned vessels, addresses irresponsible vessel management by prohibiting vessel abandonment, strengthening owner responsibility (including costs for cleanup and removal), and participates in the management of removal of such vessels.",
                    DescFre =
                        "Maintains an inventory of wrecked and abandoned vessels, addresses irresponsible vessel management by prohibiting vessel abandonment, strengthening owner responsibility (including costs for cleanup and removal), and participates in the management of removal of such vessels."
                },
                new Competency
                {
                    Id = 105, NameEng = "Organizational Communications", NameFre = "Communications organisationnelles",
                    DescEng =
                        "Encompasses written, oral, visual, and digital communication (including within a workplace context). Focuses on the study of information and the ways it is created, managed, distributed, and consumed within the CCG.",
                    DescFre =
                        "Encompasses written, oral, visual, and digital communication (including within a workplace context). Focuses on the study of information and the ways it is created, managed, distributed, and consumed within the CCG."
                },
                new Competency
                {
                    Id = 106, NameEng = "Environmental Response (ER)", NameFre = "Intervention environnementale (IE)",
                    DescEng =
                        "Manages a marine pollution response, from assessment to cost recovery. Apply legislative power properly. Understands, choose and applies properly the different CCG roles in an ER incident. Conducts overall and on-water response to a marine pollutant. Establishes and/or use a command structure appropriate to the incident. Uses the formal processes within the command structure. Compiles and assesses information gathered from a variety of sources.",
                    DescFre =
                        "Manages a marine pollution response, from assessment to cost recovery. Apply legislative power properly. Understands, choose and applies properly the different CCG roles in an ER incident. Conducts overall and on-water response to a marine pollutant. Establishes and/or use a command structure appropriate to the incident. Uses the formal processes within the command structure. Compiles and assesses information gathered from a variety of sources."
                },
                new Competency
                {
                    Id = 107, NameEng = "Hydraulic Engineering Knowledge",
                    NameFre = "Connaissances en génie hydraulique",
                    DescEng =
                        "Knowledge of the application of the principles of fluid mechanics related to the collection, storage, control, transport, regulation, measurement, and use of water.",
                    DescFre =
                        "Connaissance de l'application des principes de la mécanique des fluides liés à la collecte, au stockage, au contrôle, au transport, à la régulation, à la mesure et à l'utilisation de l'eau."
                },
                new Competency
                {
                    Id = 108, NameEng = "Electrical/Electronic Design and Analysis",
                    NameFre = "Conception et analyse électriques et électroniques",
                    DescEng =
                        "Electrical system design and analysis comprises of drafting a specification documentation, schematics, and wiring diagrams.",
                    DescFre =
                        "La conception et l’analyse des systèmes électriques comprennent la rédaction de documents de spécification, de schémas et de schémas de câblage."
                },
                new Competency
                {
                    Id = 109, NameEng = "Geomatics", NameFre = "La géomatique",
                    DescEng =
                        "Gathers, stores, processes, and delivers geographic or spatially referenced information.",
                    DescFre =
                        "Collecte, stockage, traitement et diffusion d'informations géographiques ou à référence spatiale."
                },
                new Competency
                {
                    Id = 110, NameEng = "Configuration Management (CM)", NameFre = "Gestion de la configuration (GC)",
                    DescEng =
                        "A systems engineering process for establishing and maintaining consistency of a product's performance, functional, and physical attributes with its requirements, design, and operational information throughout its life.",
                    DescFre =
                        "Processus d’ingénierie des systèmes servant à établir et à maintenir l’uniformité des caractéristiques physiques, de fonctionnement et de rendement d’un produit par rapport à ses exigences et aux renseignements sur sa conception et son fonctionnement, et ce pendant toute sa durée utile."
                },
                new Competency
                {
                    Id = 111, NameEng = "Warehousing Knowledge", NameFre = "Connaissance de l'entreposage",
                    DescEng =
                        "Knowledge of the process of planning, implementing, and controlling procedures for the efficient and effective transportation and storage of goods, facilities, or personnel.",
                    DescFre =
                        "Knowledge of the process of planning, implementing, and controlling procedures for the efficient and effective transportation and storage of goods, facilities, or personnel."
                },
                new Competency
                {
                    Id = 112, NameEng = "Electronic Principles and Circuits Knowledge",
                    NameFre = "Connaissance des principes d’électronique et des circuits électroniques",
                    DescEng =
                        "Concepts and operational function of components that underpin the understanding of how electronic environments are developed, assembled, and tested.",
                    DescFre =
                        "Concepts et fonction opérationnelle des composants qui sous-tendent la compréhension de la manière dont les environnements électroniques sont conçus, assemblés et testés."
                },
                new Competency
                {
                    Id = 113, NameEng = "Operation Centre Management", NameFre = "Gestion du centre d'opérations",
                    DescEng =
                        "Monitors and operates systems to schedule and track ships' activities to ensure the best use of available resources for regular program delivery, including emergency situations.",
                    DescFre =
                        "Monitors and operates systems to schedule and track ships' activities to ensure the best use of available resources for regular program delivery, including emergency situations."
                },
                new Competency
                {
                    Id = 114, NameEng = "Engineering Shipbuilding Knowledge",
                    NameFre = "Connaissances en génie de la construction navale",
                    DescEng =
                        "Knowledge of the components of marine engineering manufacturing process, from supply chain to assembly line operations. best optimized for maximum productivity, quality, and efficiency.",
                    DescFre =
                        "Connaissance des composantes du processus de fabrication du génie maritime, le cas échéant, de la chaîne d'approvisionnement aux opérations de la chaîne d'assemblage, qui sont optimisées pour une productivité, une qualité et une efficacité maximales."
                },
                new Competency
                {
                    Id = 115, NameEng = "Naval Architecture Knowledge",
                    NameFre = "Connaissance de l'architecture navale",
                    DescEng =
                        "The discipline dealing with the design, construction, maintenance, and operation of marine vessels and structures.",
                    DescFre =
                        "The discipline dealing with the design, construction, maintenance, and operation of marine vessels and structures."
                },
                new Competency
                {
                    Id = 116, NameEng = "Computer Architecture Knowledge",
                    NameFre = "Connaissances en architecture informatique",
                    DescEng =
                        "The rules and methods that describe the functionality, organization, and implementation of computer systems.",
                    DescFre =
                        "Les règles et les méthodes qui décrivent la fonctionnalité, l'organisation et la mise en œuvre des systèmes informatiques et de leurs cadres."
                },
                new Competency
                {
                    Id = 117, NameEng = "Engineering/Electrical Design, Review, and Analysis",
                    NameFre = "Ingénierie / Conception électrique, examen et analyse",
                    DescEng =
                        "Identifies, develops, and analyzes the installation process of engineering designs and/or specifications. Plans, identifies, and modifies methods and resources.",
                    DescFre =
                        "Identifie, développe et analyse le processus d'installation des conceptions et/ou spécifications techniques. Planifie, identifie et modifie les méthodes et les ressources."
                },
                new Competency
                {
                    Id = 118, NameEng = "Computer Aided Design and Drafting (CADD)",
                    NameFre = "Conception et dessin assistés par ordinateur (CADD)",
                    DescEng =
                        "Subfield of engineering which deals with the design and drafting of objects and materials through the use of specialized software that visualizes designs as modular 3D computer models. Used for creating the 3D models complete with detailed documentation such as dimensions, materials used, and even details the design process.",
                    DescFre =
                        "Subfield of engineering which deals with the design and drafting of objects and materials through the use of specialized software that visualizes designs as modular 3D computer models. Used for creating the 3D models complete with detailed documentation such as dimensions, materials used, and even details the design process."
                },
                new Competency
                {
                    Id = 119, NameEng = "Application Development/Support and Maintenance",
                    NameFre = "Développement, soutien et entretien des applications",
                    DescEng =
                        "Designs, defines, constructs, enhances, supports, and maintains application software on one or more application platforms.",
                    DescFre =
                        "Conçoit, définit, construit, améliore, soutient et entretient des logiciels d'application sur une ou plusieurs plateformes d'application."
                },
                new Competency
                {
                    Id = 120, NameEng = "Infrastructure/Platforms", NameFre = "Infrastructure / Plateformes",
                    DescEng =
                        "Supports the enterprise computing infrastructure (e.g. enterprise servers, client server, storage devices and systems, hardware, and software) in the provision, management, storage, operation, scheduling, support, and maintenance of the infrastructure.",
                    DescFre =
                        "Soutient l'infrastructure informatique de l'entreprise (par exemple, les serveurs d'entreprise, le serveur client, les dispositifs et systèmes de stockage, le matériel et les logiciels) dans la fourniture, la gestion, le stockage, l'exploitation, la planification, le soutien et la maintenance de l'infrastructure."
                },
                new Competency
                {
                    Id = 121, NameEng = "Security/Information and Application Protection",
                    NameFre = "Sécurité / Protection des informations et des applications",
                    DescEng =
                        "Ensures technical and organizational safeguards to protect the continuity of infrastructure services by the implementation of information technology (IT) security principles, methods, practices, policies, and tools that are used in securing IT resources. This includes information and operations security, physical security, business continuity/disaster recovery planning, methods to deal with security breaches, and security assessment in a technical environment.",
                    DescFre =
                        "Veille à la mise en place de mesures techniques et organisationnelles pour protéger la continuité des services d'infrastructure par la mise en œuvre des principes, méthodes, pratiques, politiques et outils de sécurité des technologies de l'information (TI) utilisés pour sécuriser les ressources informatiques. Cela comprend la sécurité des informations et des opérations, la sécurité physique, la planification de la continuité des activités/reprise après sinistre, les méthodes pour traiter les infractions à la sécurité et l'évaluation de la sécurité dans un environnement technique."
                },
                new Competency
                {
                    Id = 122, NameEng = "Service Management Processes", NameFre = "Processus de gestion des services",
                    DescEng =
                        "Implements methods, practices, and policies governing the design, development, and use of information technology (IT) support processes designed to keep the IT environment functioning efficiently, effectively, and securely.",
                    DescFre =
                        "Met en œuvre des méthodes, des pratiques et des politiques régissant la conception, le développement et l'utilisation des processus de soutien des technologies de l'information (TI) conçus pour maintenir le fonctionnement efficace, effectif et sûr de l'environnement informatique."
                },
                new Competency
                {
                    Id = 123, NameEng = "Testing", NameFre = "Tests",
                    DescEng =
                        "Tests software and/or hardware using a systematic approach (i.e. the orderly progression of testing in which software elements, hardware elements or both are combined and tested until the entire system has been integrated).",
                    DescFre =
                        "Tests de logiciels et/ou de matériel en utilisant une approche systématique (c'est-à-dire la progression ordonnée des tests dans laquelle les éléments logiciels, les éléments matériels ou les deux sont combinés et testés jusqu'à ce que le système entier ait été intégré)."
                },
                new Competency
                {
                    Id = 124, NameEng = "Database Design and Management",
                    NameFre = "Conception et gestion de bases de données",
                    DescEng =
                        "Applies the methods, practices, and policies that are used in the design and the management of databases in the public sector context.",
                    DescFre =
                        "Applique les méthodes, pratiques et politiques utilisées dans la conception et la gestion des bases de données dans le contexte du secteur public."
                },
                new Competency
                {
                    Id = 125, NameEng = "Ship or Land-Based Marine Electronic Equipment/Information Systems Knowledge",
                    NameFre =
                        "Connaissance des équipements électroniques et des systèmes d’information maritimes embarqués ou terrestres",
                    DescEng =
                        "Knowledge of electronic devices designed for use in, or support of, the marine environment.",
                    DescFre =
                        "Connaissance des dispositifs électroniques conçus pour être utilisés dans l’environnement marin ou en appui à celui-ci."
                }
            });
            await Save<Competency>();
            await transaction.CommitAsync();
        }
    }
}