using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSiteASP.Models
{
    public class VRLCDbInitializer: DropCreateDatabaseAlways<VRLCContext>
    {
        protected override void Seed(VRLCContext db)
        {
            db.Persons.Add(new Person() { PhotoName= "#", Surname = "Рубис", Name = "Владимир", MiddleName = "Сергеевич", Job = "Генеральный директор", Description = "Генеральный директор ООО ВРЮЦ Владимир Сергеевич Рубис и т.д и т.п. (из бд)" });
            db.Persons.Add(new Person() { PhotoName = "~/images/RubisDV.png", Surname = "Рубис", Name = "Дмитрий", MiddleName = "Владимирович", Job = "Основатель", Description = "Основатель ООО ВРЮЦ Дмитрий Владимирович Рубис и т.д и т.п. (из бд)" });

            db.Services.Add(new Service() { Name = "Заключение сделок", Description = "<p>В современном мире ежедневно совершается огромное количество сделок.Быть уверенным на все 100,что при заключении,изменении,расторжении договора Ваши права и интересы не будут нарушены - невозможно.</p> <h3> Услуги адвоката по договорному праву:</h3> <p> -обширная юридическая консультация,связанная с договорным правом;</p> <p> -правовой анализ имеющихся документов;</p> <p> -экспертиза договора / соглашения на соответствие с действующим законодательством РФ;</p> " });

            db.SaveChanges();

            base.Seed(db);
        }
    }
}