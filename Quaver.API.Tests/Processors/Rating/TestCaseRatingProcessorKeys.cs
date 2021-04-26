using System.Collections.Generic;
using System.Linq;
using Quaver.API.Enums;
using Quaver.API.Maps;
using Quaver.API.Maps.AutoMod;
using Quaver.API.Maps.AutoMod.Issues.Audio;
using Quaver.API.Maps.AutoMod.Issues.Autoplay;
using Quaver.API.Maps.AutoMod.Issues.Background;
using Quaver.API.Maps.AutoMod.Issues.HitObjects;
using Quaver.API.Maps.AutoMod.Issues.Map;
using Quaver.API.Maps.AutoMod.Issues.Mapset;
using Quaver.API.Maps.AutoMod.Issues.Metadata;
using Quaver.API.Maps.AutoMod.Issues.ScrollVelocities;
using Quaver.API.Maps.AutoMod.Issues.TimingPoints;
using Xunit;
using Quaver.API.Maps.Processors.Rating;
using Xunit.Abstractions;

namespace Quaver.API.Tests.Processors.Rating
{
    public class TestCaseRatingProcessorKeys
    {
        [Fact]
        public void CalculateRatingWhenFailedItShouldReturnZero()
        {
            var ratingProcessorKey = new RatingProcessorKeys(20);
            var rating =  ratingProcessorKey.CalculateRating(10, true);
            Assert.Equal(0, rating);  
        }

        [Fact]
        public void CalculateRatingWhenPassItShouldReturnValueGreaterThanZero()
        {
            var ratingProcessorKey = new RatingProcessorKeys(20);
            var rating = ratingProcessorKey.CalculateRating(10, false);
            Assert.True(rating > 0);
            ////Assert.Equal(2.2577379940315284E-05, rating);

        
        }

        [Fact]
        public void GetAccuracyFromRatingShouldReturnValue()
        {
            var ratingProcessorKey = new RatingProcessorKeys(20);
            var rating = ratingProcessorKey.GetAccuracyFromRating(10);
            Assert.True(rating > 0);
        }
    }
}
