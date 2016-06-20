using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Show : Title
    {
        List<Episode> episodes = new List<Episode>();

        public Show()
        {

        }

        public double? overrideRating(List<Episode> episodes)
        {
            return null;
        }

        public TimeSpan addDurations(List<Episode> episodes)
        {
            TimeSpan totalDuration = new TimeSpan(0, 0, 0);
            foreach (Episode episode in episodes)
            {
                TimeSpan episodeDuration = TimeSpan.Parse(episode.duration);
                totalDuration = totalDuration + episodeDuration;
            }

            return totalDuration;
        }
        public override string ToString()
        {
            TimeSpan totalDuration = new TimeSpan(0, 0, 0);
            string show = String.Format("{0}: {1}, {2} episodes", name, totalDuration, episodes.Count);
            return show;
        }
    }
}
