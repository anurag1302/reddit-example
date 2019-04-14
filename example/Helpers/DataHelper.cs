using example.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace example.Helpers
{
    public static class DataHelper
    {
        public static RedditExampleModel GetRedditExampleModel()
        {
            return new RedditExampleModel
            {
                Results = new List<RedditItemViewModel>
                {
                    new RedditItemViewModel
                    {
                        Id=1,
                        Title="foo1",
                        Description="desc1",
                        Category="cat1",
                        Application="app1",
                        Tickets=0
                    },
                    new RedditItemViewModel
                    {
                        Id=2,
                        Title="foo2",
                        Description="desc2",
                        Category="cat2",
                        Application="app2",
                        Tickets=1
                    },
                    new RedditItemViewModel
                    {
                        Id=3,
                        Title="foo3",
                        Description="desc3",
                        Category="cat3",
                        Application="app3",
                        Tickets=2
                    },
                    new RedditItemViewModel
                    {
                        Id=4,
                        Title="foo4",
                        Description="desc4",
                        Category="cat4",
                        Application="app4",
                        Tickets=3
                    },
                    new RedditItemViewModel
                    {
                        Id=5,
                        Title="foo5",
                        Description="desc5",
                        Category="cat5",
                        Application="app5" +
                        "",
                        Tickets=4
                    }
                }
            };
        }

        public static List<SelectListItem> GetCategories()
        {
            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text="cat1",
                    Value="cat1"
                },
                new SelectListItem
                {
                    Text="cat2",
                    Value="cat2"
                },
                new SelectListItem
                {
                    Text="cat3",
                    Value="cat3"
                },
                new SelectListItem
                {
                    Text="cat4",
                    Value="cat4"
                },
                new SelectListItem
                {
                    Text="cat5",
                    Value="cat5"
                },
            };
        }

        public static List<SelectListItem> GetApplications()
        {
            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text="app1",
                    Value="app1"
                },
                new SelectListItem
                {
                    Text="app2",
                    Value="app2"
                },
                new SelectListItem
                {
                    Text="app3",
                    Value="app3"
                },
                new SelectListItem
                {
                    Text="app4",
                    Value="app4"
                },
                new SelectListItem
                {
                    Text="app5",
                    Value="app5"
                },
            };
        }
    }
}
