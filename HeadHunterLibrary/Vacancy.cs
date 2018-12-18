namespace HeadHunterLibrary
{
    public struct Vacancy
    {
        public readonly string id,
                               name,
                               salary_from,
                               salary_to,
                               employer_name,
                               address,
                               info;

        public Vacancy(dynamic obj)
        {
            id = obj.id;
            name = obj.name;

            if (obj.salary != null)
            {
                salary_from = obj.salary.from == null ? "-" : obj.salary.from;
                salary_to = obj.salary.to == null ? "-" : obj.salary.to;
            } else
            {
                salary_from = "-";
                salary_to = "-";
            }

            employer_name = obj.employer.name;

            if (obj.address != null)
                address = obj.address.city + " " + obj.address.street + " " + obj.address.building;
            else
                address = "-";

            if (obj.alternate_url != null)
                info = obj.alternate_url;
            else
                info = "-";
        }
    }
}