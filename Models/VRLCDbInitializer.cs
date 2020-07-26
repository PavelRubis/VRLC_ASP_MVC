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
            db.Services.Add(new Service() { Name = "Заключение сделок", Description = "<p>В современном мире ежедневно совершается огромное количество сделок.Быть уверенным на все 100,что при заключении,изменении,расторжении договора Ваши права и интересы не будут нарушены - невозможно.</p> <h3> Услуги адвоката по договорному праву:</h3> <p> -обширная юридическая консультация,связанная с договорным правом;</p> <p> -правовой анализ имеющихся документов;</p> <p> -экспертиза договора / соглашения на соответствие с действующим законодательством РФ;</p> " });

            db.Videos.Add(new Video() { Name = "Rick Astley - Never Gonna Give You Up (Video)", Url= "https://www.youtube.com/embed/dQw4w9WgXcQ", UploadDate=new DateTime(2020,4,1,20,28,0) });

            db.Videos.Add(new Video() { Name = "Oliver Tree - I'm Gone [Official Music Video]", Url = "https://www.youtube.com/watch?v=BLSRufOAHTQ", UploadDate = new DateTime(2020, 3, 6, 14, 38, 0) });

            db.SaveChanges();

            base.Seed(db);
        }
    }
}