using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewGeneration.Models
{
    public class PupilDbInitializer : DropCreateDatabaseIfModelChanges<PupilContext>
    {
        protected override void Seed(PupilContext context)
        {
            context.Pupils.Add(new Pupil { Surname = "Andrievskyi", Name = "Yaroslav", Birthday = new DateTime(2000, 03, 08), Phone = 0637362925});
            context.Pupils.Add(new Pupil { Surname = "Anikina", Name = "Kateryna", Birthday = new DateTime(2000, 04, 08), Phone = 0999149332 });
            context.Pupils.Add(new Pupil { Surname = "Arkusha", Name = "Oleksii", Birthday = new DateTime(2000, 03, 30), Phone = 0686508499 });

            base.Seed(context);
        }
    }

}