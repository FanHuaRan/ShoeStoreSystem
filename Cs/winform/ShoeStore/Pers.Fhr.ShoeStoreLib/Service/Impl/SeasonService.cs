﻿using Pers.Fhr.ShoeStoreLib.Entity;
using Pers.Fhr.ShoeStoreLib.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service.Impl
{
    class SeasonService : AbstractEntityBaseClass<Season, SeasonService>, ISeasonService
    {
        private SeasonService(SeasonManager seansonManager)
        {
            this.entityManager = seansonManager;
        }
        public Season FindSeasonByName(string seasonName)
        {
            SeasonManager seansonManager = this.entityManager as SeasonManager;
            return seansonManager.FindBySeasonName(seasonName);
        }
        public  SeasonService CreateSingleInstance()
        {
            if (this.instance == null)
            {
                this.instance= new SeasonService(SeasonManager.Instance);
            }
            return instance;
        }
    }
}
