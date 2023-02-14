using System.Reflection.PortableExecutable;
using Willies_Portfolio_2023.Models;

namespace Willies_Portfolio_2023.Data
{
    public class AppDbSeeder
    {
        static public void Seeddata(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                var Preview = "_preview";
                var HQ = "_HQ";

                if (!context.Stills.Any())
                {
                    context.Stills.AddRange(new List<Still>()
                    {
                        
                        new Still()
                        {
                            ImagePreview = "vanern" + Preview,
                            ImageHighQuality = "vanern" + HQ,
                            Title = "vanern"
                        },
                        new Still()
                        {
                            ImagePreview = "spiralstairs" + Preview,
                            ImageHighQuality = "spiralstairs" + HQ,
                            Title = "spiralstairs"
                        },
                        new Still()
                        {
                            ImagePreview = "bridge" + Preview,
                            ImageHighQuality = "bridge" + HQ,
                            Title = "bridge"
                        },
                        new Still()
                        {
                            ImagePreview = "umbrellafire" + Preview,
                            ImageHighQuality = "umbrellafire" + HQ,
                            Title = "umbrellafire"
                        },
                        new Still()
                        {
                            ImagePreview = "crane" + Preview,
                            ImageHighQuality = "crane" + HQ,
                            Title = "crane"
                        },
                        new Still()
                        {
                            ImagePreview = "ida1" + Preview,
                            ImageHighQuality = "ida1" + HQ,
                            Title = "ida1"
                        },
                        new Still()
                        {
                            ImagePreview = "porche" + Preview,
                            ImageHighQuality = "porche" + HQ,
                            Title = "porche"
                        },
                        new Still()
                        {
                            ImagePreview = "wall" + Preview,
                            ImageHighQuality = "wall" + HQ,
                            Title = "wall"
                        },
                        new Still()
                        {
                            ImagePreview = "madeira" + Preview,
                            ImageHighQuality = "madeira" + HQ,
                            Title = "madeira"
                        },
                        new Still()
                        {
                            ImagePreview = "bird" + Preview,
                            ImageHighQuality = "bird" + HQ,
                            Title = "bird"
                        },
                        new Still()
                        {
                            ImagePreview = "birkenau" + Preview,
                            ImageHighQuality = "birkenau" + HQ,
                            Title = "birkenau"
                        },
                        new Still()
                        {
                            ImagePreview = "suit" + Preview,
                            ImageHighQuality = "suit" + HQ,
                            Title = "suit"
                        },
                        new Still()
                        {
                            ImagePreview = "vintage" + Preview,
                            ImageHighQuality = "vintage" + HQ,
                            Title = "vintage"
                        },
                        new Still()
                        {
                            ImagePreview = "volvo" + Preview,
                            ImageHighQuality = "volvo" + HQ,
                            Title = "volvo"
                        },
                        new Still()
                        {
                            ImagePreview = "lo" + Preview,
                            ImageHighQuality = "lo" + HQ,
                            Title = "lo"
                        },
                        new Still()
                        {
                            ImagePreview = "pinkbirds" + Preview,
                            ImageHighQuality = "pinkbirds" + HQ,
                            Title = "pinkbirds"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Films.Any())
                {
                    context.Films.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            FilmPreview = "Galaxy" + Preview,
                            Header = "Unreal Engine 5 Animation",
                            Title = "MS Galaxy New Year Special",
                            FilmMain = "https://www-ccv.adobe.io/v1/player/ccv/RZDJKNu-s8x/embed?api_key=behance1&bgcolor=%000000"
                        },
                        new Film()
                        {
                            FilmPreview = "Mike" + Preview,
                            Header = "Personal Project",
                            Title = "Mike is having a bad day",
                            FilmMain = "https://www-ccv.adobe.io/v1/player/ccv/HNr8MwgNfcT/embed?api_key=behance1&bgcolor=%000000"
                        },
                        new Film()
                        {
                            FilmPreview = "Mary" + Preview,
                            Header = "Cover Video",
                            Title = "The Wind Cries Mary",
                            FilmMain = "https://www-ccv.adobe.io/v1/player/ccv/4eFaysepa-6/embed?api_key=behance1&bgcolor=%000000"
                        },
                        new Film()
                        {
                            FilmPreview = "Kildebjerg" + Preview,
                            Header = "Short promo for Kildebjerg",
                            Title = "Kildebjerg Ry Erhvervshus ",
                            FilmMain = "https://www-ccv.adobe.io/v1/player/ccv/5m-mtewmmui/embed?api_key=behance1&bgcolor=%000000"
                        },
                        new Film()
                        {
                            FilmPreview = "Tempel" + Preview,
                            Header = "Freelance Project",
                            Title = "Tempel teaser Aftermovie",
                            FilmMain = "https://www-ccv.adobe.io/v1/player/ccv/779nP2kBCNo/embed?api_key=behance1&bgcolor=%000000"
                        },
                        new Film()
                        {
                            FilmPreview = "2014" + Preview,
                            Header = "All the best from 2012-2014",
                            Title = "Demoreel 2014",
                            FilmMain = "https://www-ccv.adobe.io/v1/player/ccv/U6i7oIsHzI5/embed?api_key=behance1&bgcolor=%000000"
                        },


                    });
                    context.SaveChanges();
                }
                if (!context.NetProjects.Any())
                {
                    context.NetProjects.AddRange(new List<NetProject>()
                    {
                        new NetProject()
                        {
                            Title = "Doodle",
                            DescriptionHeader = "Front End Developer • UI Designer",
                            Description = "Service website concept for a guitar learning platform available on IOS and Android.",
                            TitleImage = "doodlemain",
                            NetProjectBreakdownSections= new List<NetProjectBreakdownSection>()
                            {
                                new NetProjectBreakdownSection()
                                {
                                    Header = "Design and functionality",
                                    Title = "Front Page",
                                    DescriptionHeader = "A straight forward Design",
                                    BreakdownImage = "doodlebreakdown1.0.gif",
                                    BreakdownSecondaryImage = "",
                                    NetProjectDescriptions = new List<NetProjectDescription>()
                                    {
                                        new NetProjectDescription()
                                        {
                                            Content = "When designing the Front-end it was important to spark interest with the user right away."
                                        },
                                        new NetProjectDescription()
                                        {
                                            Content = "A quick overview at first glance and an easy way to navigate to download the app was important. I therefore decided to add two download buttons and a simple but quick introduction on the front page."
                                        },
                                            }
                                },
                                new NetProjectBreakdownSection()
                                {
                                    Header = "UI & COMPONENTS.",
                                    Title = "Feedback",
                                    DescriptionHeader = "Good feedback on popup components",
                                    BreakdownImage = "doodlebreakdown2.0.png",
                                    BreakdownSecondaryImage = "",
                                    NetProjectDescriptions = new List<NetProjectDescription>()
                                    {
                                        new NetProjectDescription()
                                        {
                                            Content = "I implemented a component that stays on top of the active page when interacting with certain buttons."
                                        },
                                        new NetProjectDescription()
                                        {
                                            Content = "It served two purposes, firstly it made it easier for user orientation. And added a very quick way to abort or get back to the previous page without redirecting. "
                                        },
                                        new NetProjectDescription()
                                        {
                                            Content = "Secondly it made the user experience more fun by items responding well to input, on:hover events and clicks. It adds a lot to the “fun” element when things respond well!"
                                        },
                                    }
                                },
                                new NetProjectBreakdownSection()
                                {
                                    Header = "FAQ",
                                    Title = "Customer Experience",
                                    DescriptionHeader = "Support FAQ",
                                    BreakdownImage = "doodlebreakdown3.0.png",
                                    BreakdownSecondaryImage = "doodlebreakdown1.1",
                                    NetProjectDescriptions = new List<NetProjectDescription>()
                                    {
                                        new NetProjectDescription()
                                        {
                                            Content = "Troubleshooting. A stable and reliable FAQ forum was monumental for CX since we want the user to stay on the platform as long as possible."
                                        },
                                        new NetProjectDescription()
                                        {
                                            Content = "The FAQ is therefore easily accessible on the site with all the most common categories layed out nicely in a clickable menu. "
                                        },
                                        new NetProjectDescription()
                                        {
                                            Content = "The importance of customer longevity "
                                        },
                                    }
                                },
                            }
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
