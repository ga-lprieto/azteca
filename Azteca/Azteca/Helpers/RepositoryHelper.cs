using Azteca.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azteca.Helpers
{
    public class RepositoryHelper
    {
        public static List<JobArea> GetJobAreas(string lang) {
            Dictionary<string, List<JobArea>> jobareas = new Dictionary<string, List<JobArea>>();

            List<JobArea> es = new List<JobArea>();
            es.Add(new JobArea { name = "Jovenes Profesionales", id = "1" });
            es.Add(new JobArea { name = "Consultoría SAP", id = "2" });
            es.Add(new JobArea { name = "Consultoría Oracle", id = "3" });
            es.Add(new JobArea { name = "Seguridad IT", id = "4" });
            es.Add(new JobArea { name = "Consultoría en Procesos", id = "5" });
            es.Add(new JobArea { name = "Programación", id = "6" });
            es.Add(new JobArea { name = "Administración de Servidores", id = "7" });
            es.Add(new JobArea { name = "RRHH", id = "8" });
            es.Add(new JobArea { name = "Administración", id = "9" });
            es.Add(new JobArea { name = "Marketing", id = "10" });
            es.Add(new JobArea { name = "Legales", id = "11" });
            es.Add(new JobArea { name = "Secretarias / Recepcionistas", id = "12" });
            es.Add(new JobArea { name = "Finanzas", id = "13" });
            es.Add(new JobArea { name = "Change Management", id = "14" });
            es.Add(new JobArea { name = "Project Management", id = "15" });
            //ADD LIST
            jobareas.Add("es", es);

            List<JobArea> en = new List<JobArea>();
            en.Add(new JobArea { name = "Young Profesionals", id = "1" });
            en.Add(new JobArea { name = "SAP consulting", id = "2" });
            en.Add(new JobArea { name = "Oracle consulting", id = "3" });
            en.Add(new JobArea { name = "IT Security", id = "4" });
            en.Add(new JobArea { name = "Process Consulting", id = "5" });
            en.Add(new JobArea { name = "Programming", id = "6" });
            en.Add(new JobArea { name = "Server Management", id = "7" });
            en.Add(new JobArea { name = "RRHH", id = "8" });
            en.Add(new JobArea { name = "Administration", id = "9" });
            en.Add(new JobArea { name = "Marketing", id = "10" });
            en.Add(new JobArea { name = "Legal", id = "11" });
            en.Add(new JobArea { name = "Secretary / Receptionist", id = "12" });
            en.Add(new JobArea { name = "Finance", id = "13" });
            en.Add(new JobArea { name = "Change Management", id = "14" });
            en.Add(new JobArea { name = "Project Management", id = "15" });
            //ADD LIST
            jobareas.Add("en", en);

            List<JobArea> pt = new List<JobArea>();
            pt.Add(new JobArea { name = "Jovens Profissionais", id = "1" });
            pt.Add(new JobArea { name = "Consultoria SAP", id = "2" });
            pt.Add(new JobArea { name = "Consultoria Oracle", id = "3" });
            pt.Add(new JobArea { name = "Segurança TI", id = "4" });
            pt.Add(new JobArea { name = "Consultoria em Processos", id = "5" });
            pt.Add(new JobArea { name = "Programação", id = "6" });
            pt.Add(new JobArea { name = "Administração de Servidores", id = "7" });
            pt.Add(new JobArea { name = "HR", id = "8" });
            pt.Add(new JobArea { name = "Administração", id = "9" });
            pt.Add(new JobArea { name = "Marketing", id = "10" });
            pt.Add(new JobArea { name = "Legal", id = "11" });
            pt.Add(new JobArea { name = "Secretária / Recepcionista", id = "12" });
            pt.Add(new JobArea { name = "Finançãs", id = "13" });
            pt.Add(new JobArea { name = "Change Management", id = "14" });
            pt.Add(new JobArea { name = "Project Management", id = "15" });
            //ADD LIST
            jobareas.Add("pt", pt);

            return jobareas[lang];
        }

        public static SelectList GetAvailability(string lang) {
            Dictionary<string, SelectList> d = new Dictionary<string, SelectList>();
            
            string[] es = { "Full-time - 8 horas", "Part-time - 6 horas","Pasantia - 4 horas" };
            d.Add("es", new SelectList(es));

            string[] en = { "Full-time - 8 hours", "Part-time - 6 hours", "Internship - 4 hours" };
            d.Add("en", new SelectList(en));

            string[] pt = { "Full-time - 8 horas", "Part-time - 6 horas", "Estágio - 4 horas" };
            d.Add("pt", new SelectList(pt));

            return d[lang];
        }

        public static SelectList GetHowTo(string lang)
        {
            Dictionary<string, SelectList> d = new Dictionary<string, SelectList>();

            string[] es = { "Publicidad", "Reporte de analistas", "Artículos o noticias", "Eventos", "Empleado de Grupo Assa", "Recomendación", "WebLinks", "Búsqueda en Internet", "Redes Sociales", "Portal de empleos", "Bolsa de trabajo", "Otros" };
            d.Add("es", new SelectList(es));

            string[] en = { "Marketing", "Analyst report", "News or articles", "Events", "gA employee", "Recommendation", "WebLinks", "Internet search", "Social network", "Job portal", "Job bank", "Other" };
            d.Add("en", new SelectList(en));

            string[] pt = { "Publicidade", "Relatório de analistas", "Artigos ou notícias", "Eventos", "Empregado do Grupo ASSA", "Recomendação", "WebLinks", "Pesquisa na internet", "Redes Sociais", "Portal de emprego", "Ofertas de emprego", "Outros" };
            d.Add("pt", new SelectList(pt));

            return d[lang];
        }

        public static SelectList GetStudies(string lang){
            Dictionary<string, SelectList> d = new Dictionary<string, SelectList>();

            string[] es = { "Abogado", "Actuario", "Agrimensor", "Analista Administrativo Contable", "Analista de Computación", "Analista de Sistemas", "Analista de Sistemas de Información", "Analista de Computación Administrativa", "Analista en Informática", "Analista Programador", "Aviación Civil", "Bioingeniera", "Calígrafo Público Nacional", "Ciencas Físicas", "Computador Científico", "Contador Público", "Diseño de Indumentaria y Textil", "Diseño Gráfico", "Filosofía y Letras", "Grafoanalista", "Informática de Gestión", "Ing. Arenonáutico", "Ing. Agrónomo", "Ing. Agropecuario", "Ing. Civil", "Ing. de Telecomunicaciones", "Ing. Electromecánico", "Ing. en alimentos", "Ing. en Computación", "Ing. en Construcciones", "Ing. en Informática", "Ing. en Mant. Industrial", "Ing. en Sistemas", "Ing. en Sistemas de Información", "Ing. Geofísico", "Ing. Gerencial", "Ing. Industrial", "Ing. Mecánica", "Ing. Naval", "Ing. Nuclear", "Ing. Química", "Maestra", "Médico", "Periodismo", "Profesora", "Traductora Pública Inglés", "Lic. Adm. de Empresas", "Lic. Adm. y Sistemas", "Lic. Electrónico", "Lic. en Administración Naviera", "Lic. en Administración de Personal", "Lic. en Análisis de Sistemas", "Lic. en Comercialización", "Lic. en Comercio Exterior", "Lic. en Comercio Internacional", "Lic. en Computación Científica", "Lic. en Cs de la Computación", "Lic. en Cs. de la Comunicación", "Lic. en Derecho", "Lic. en Economía", "Lic. en Economía Empresarial", "Lic. en Enfermería", "Lic. en Exactas", "Lic. en Físicas", "Lic. en Informática", "Lic. en Marketing", "Lic. en Organización de Empresas", "Lic. en Organización de Producción", "Lic. en Organización Industrial", "Lic. en Organización Industrial", "Lic. en Psicopedagogía", "Lic. en Publicidad", "Lic. en Relaciones del Trabajo", "Lic. en Relaciones Industriales", "Lic. en Relaciones Públicas", "Lic. en Sistemas", "Lic. en Sistemas de Inf. de las Org.", "Lic. en Sistemas de Información", "Lic. en Sistemas y Computación", "Lic. en Sociología", "Lic. en Tecnol. Ind. de los Alimentos", "Lic. Organización Industrial", "Licenciado en Psicología", "Marketing Estratégico", "Programador de Sistemas", "Secretaria Ejecutiva", "Secretariado Internacional", "Técnico Analista Programador", "Técnico Electromecánico", "Técnico en Comercialización", "Técnico en Computación", "Técnico en Contabilidad y Costos", "Técnico en Sistemas de Informática", "Técnico Mecánico", "Técnico Sup. en Comercialización", "Técnico Superior en Adm. de Personal", "Técnico Superior  en Administración Rural", "Técnico Superior  en Comercio Exterior", "Técnico Superior en Publicidad", "Técnico Superior en Sistemas", "Técnico Superior  en Turismo", "Otro" };
            d.Add("es", new SelectList(es));

            string[] en = { "Actuary", "Surveyor", "Administrative Accounting Analyst", "Computation Analyst", "Systems Analyst", "Systems Information Analyst", "Analyst Administrative Computing", "Computation Analyst", "Programmer Analyst", "Civil Aviation", "Bioengineering", "National Public Calligrapher", "Physical Sciences", "Computer Scientist", "Public Accountant", "Textile Design", "Graphical Design", "Philosophy and Literature", "Graphology Analist", "Computer Software", "Engineering Aircraft", "Agronomist Engineering", "Agricultural Engineer", "Civil Engineer", "Telecommunications Engineer", "Electromechanical Engineer", "Food Eng", "Computation Engineer", "Constructions Engeneering", "Computation Engineering", "Industrial Maintenance Engeneering", "Systems Engineer", "Systems Information Engineer", "Geophysical Engineering", "Management Engeneering", "Industrial Engineering", "Mechanical Engineering", "Naval Engineering", "Nuclear Engineering", "Chemical Engineering", "Teacher", "Doctor", "Journalism", "Professor", "English Public Translator", "Bussines Administration Degree", "Administration and Systems Degree", "Electronics Degree", "Naval Administration Degree", "Personal Administration Degree", "Systems Analysis Degree", "Commercialization Degree", "Foreign Trade Degree", "International Trade Degree", "Computation Sciences Degree", "Scientific Computation Degree", "Communication Sciences Degree","Lawyer", "Law Degree", "Economics Degree", "Business Economics Degree", "Nursing Degree", "Exact Sciences Degree", "Physics Degree", "Computation Degree", "Marketing Degree", "Business Organization Degree", "Production Organization Degree", "Industrial Organization Degree", "Industrial Organization Degree", "Psychopedagogy Degree", "Publicyti Degree", "Labor Relations Degree", "Industrial Relations Degree", "Public Relation Degree", "Systems Degree", "Information Systems of the Org. Degree", "Information Systems Entreprise Degree", "Systems and Computation Degree", "Sociology Degree", "Nutritional Industrial Technology Degree", "Industrial Organization Degree", "Pychology Degree", "Strategic Marketing", "Programador de Sistemas", "Executive Secretary", "International Secretariat", "Analyst Programmer Technical ", "Electromechanical Technician", "Commercialization Technical ", "Computation Technician", "Accounting  and Cost Technical ", "Computer Systems Technician", "Mechanical Technician", "Commercialization Superior Technician", "Personnet Administration Superior Technician", "Fereing Trade Superior Technician", "Commercialization Superior Technician", "Publicity Superior Technician", "Sistems Superior Technician", "Turist Superior Technician", "Other" };
            d.Add("en", new SelectList(en));

            string[] pt = { "Advogado", "Actuário", "Agrimensor", "Analista Administrativo Contábil", "Analista de computação", "Analista de Sistemas", "Analista de Sistemas de Informação", "Analista em Computação Administrativa", "Analista em Informática", "Analista Programador", "Aviação Civil", "Bioengenharia", "Nacional Público Calígrafo ", "Ciências Físicas", "Computador Científico", "Contador Público", "Desenho de Indumentária e Textil", "Desenho Gráfico", "Filosofía e Letras", "Grafoanalista", "Informática de Gestão", "Eng Arenonáutico", "Eng. Agrônomo", "Eng. Agropecuario", "Engenheiro Civil", "Engenheiro de Telecomunicações", "Eletromecânica Engenheiro", "Eng. dealimentos", "Engenheiro de Computação", "Eng. de Construção ", "Eng. em Informática", "Eng  em Manutenção Industrial", "Engenheiro de Sistemas", "Engenheiro de Sistemas de Informação", "Engenheiro Geofísico", "Ing. Gerencial", "Engenheiro Industrial", "Engenharia Mecânica", "Naval Engineer", "Engenheiro Nuclear", "Ing. Química", "Mestra", "Médico", "Jornalismo", "Professor", "Traductora Pública de Inglês", "Graduado en Adm. de Empresas", "Graduado em Admi e Sitemas", "Graduado en Eletrônica", "Graduado en Administração de Transportes", "Graduado en Administração de Pessoal", "Graduado en Análise de Sistemas", "Graduado em Comercialização", "Graduado em Comércio Exterior", "Gracduado en Comércio Internacional", "Graduado em Computação Cientifica", "Graduado Ciência da Computação", "Graduado em Ciências da Comunicação", "Graduado em Direito", "Graduado em Economia", "Graduado em Economia Empresarial", "Graduado em Enfermaria", "Graduado em Exatas", "Graduado em Fisicas", "Graduado em Informática", "Graduado en Marketing", "Graduado em Organização de Empresas", "Graduado em Organização da Produção", "Graduado em Organização Industrial", "Graduado em Organização Industrial", "Graduado em Psicopedagogia", "Graduado em Publicidade", "Graduado em Relações de Trabalho", "Graduado Relações Industriais", "Graduado em Relações Públicas", "Graduado em Sistemas", "Graduado em Sistemas de Inf. das Org", "Graduado em Sistemas de Informação", "Graduado em Computação e Sistemas", "Graduado em Sociologia", "Graduado em Tecnol. Ind. de Alimentos", "Graduado em Organização Industrial", "Licenciado em Psicología", "Marketing Estratégico", "Systems Programmer", "Secretária Executiva", "Secretariado Internacional", "Técnico Analista Programador", "Técnico Eletromecânico", "Técnico em Comercialização", "Técnico em Computação", "Técnico e Contabilidade e Custos", "Técnico en Sistemas de Informática", "Técnico Mecânico", "Tecnico Superior em Comercialização ", "Técnico Superior em Adm. de Pessoal", "Técnico Superior em Administração Rural", "Técnico Superior  en Comércio Exterior", "Técnico Superior en Publicidade", "Técnico Superior em Sistemas", "Técnico Superior  em Turismo", "Outro" };
            d.Add("pt", new SelectList(pt));

            return d[lang];
        }

        public static List<SelectListItem> GetCountries()
        {
            List<SelectListItem> l = new List<SelectListItem>();
            foreach (CultureInfo cultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo regionInfo = new RegionInfo(cultureInfo.LCID);
                var query = l.Where(x => x.Text.Contains(regionInfo.DisplayName));
                if ( query.Count() == 0 )
                {
                    l.Add(new SelectListItem() { Text = regionInfo.DisplayName, Value = regionInfo.DisplayName });
                }
            }
            return l.OrderBy(o => o.Text).ToList();
        }

        public static SelectList GetEnglish()
        {
            string[] en = { "Elementary", "Pre-intermediate", "Intermediate", "Upper-intermediate", "Advanced", "Bilingual" };
            return new SelectList(en);

        }

        public static List<SelectListItem> GetApplyTo(string lang) {
            Dictionary<string, List<SelectListItem>> d = new Dictionary<string, List<SelectListItem>>();

            List<SelectListItem> es = new List<SelectListItem>();
            es.Add(new SelectListItem() { Text = "Argentina", Value = "AR" });
            es.Add(new SelectListItem() { Text = "Brasil", Value = "BR" });
            es.Add(new SelectListItem() { Text = "Chile", Value = "CL" });
            es.Add(new SelectListItem() { Text = "Colombia", Value = "CO" });
            es.Add(new SelectListItem() { Text = "Mexico", Value = "MX" });
            es.Add(new SelectListItem() { Text = "Otro / Todos", Value = "ALL" });
            d.Add("es", es);

            List<SelectListItem> en = new List<SelectListItem>();
            en.Add(new SelectListItem() { Text = "Argentina", Value = "AR" });
            en.Add(new SelectListItem() { Text = "Brasil", Value = "BR" });
            en.Add(new SelectListItem() { Text = "Chile", Value = "CL" });
            en.Add(new SelectListItem() { Text = "Colombia", Value = "CO" });
            en.Add(new SelectListItem() { Text = "Mexico", Value = "MX" });
            en.Add(new SelectListItem() { Text = "Other / All", Value = "ALL" });
            d.Add("en", en);

            List<SelectListItem> pt = new List<SelectListItem>();
            pt.Add(new SelectListItem() { Text = "Argentina", Value = "AR" });
            pt.Add(new SelectListItem() { Text = "Brasil", Value = "BR" });
            pt.Add(new SelectListItem() { Text = "Chile", Value = "CL" });
            pt.Add(new SelectListItem() { Text = "Colombia", Value = "CO" });
            pt.Add(new SelectListItem() { Text = "Mexico", Value = "MX" });
            pt.Add(new SelectListItem() { Text = "Outro / Todos", Value = "ALL" });
            d.Add("pt", pt);

            return d[lang];

        }
    }
}