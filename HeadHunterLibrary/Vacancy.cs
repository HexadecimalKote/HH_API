namespace HeadHunterLibrary
{
    struct Vacancy
    {
        string id,
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

            salary_from = obj?.salary?.from ?? " ";
            salary_to = obj?.salary?.to ?? " ";

            employer_name = obj.employer.name;

            if (obj.address != null)
                address = obj.address.city + " " + obj.address.street + " " + obj.address.building;
            else
                address = " ";

            info = obj?.description ?? " ";
        }
    }
}