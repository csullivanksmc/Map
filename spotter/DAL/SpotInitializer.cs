using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using spotter.Models;

namespace spotter.DAL
{
    public class SpotInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SpotContext>
    {
        protected override void Seed(SpotContext context)
        {
            var spots = new List<Spot>
            {
                new Spot{lat=40.45225689999999,lng=-86.1270723},
                new Spot{lat=40.0479672,lng=-86.1322524},
                new Spot{lat=39.9107272,lng=-86.2388994},
                new Spot{lat=39.9220246,lng=-86.2223944},
                new Spot{lat=39.8927069,lng=-86.2141299},
                new Spot{lat=39.9073707,lng=-86.22197779999999},
                new Spot{lat=40.03042600000001,lng=-85.84284199999999},
                new Spot{lat=39.9153553,lng=-86.06655359999999},
                new Spot{lat=39.9546491,lng=-86.2422428},
                new Spot{lat=40.0417282,lng=-86.1282634},
                new Spot{lat=39.811414,lng=-86.1560901},
                new Spot{lat=39.8399234,lng=-86.1491224},
                new Spot{lat=39.80743409999999,lng=-86.1562615},
                new Spot{lat=40.002108,lng=-86.129966},
                new Spot{lat=39.9994355,lng=-86.129431},
                new Spot{lat=40.0479672,lng=-86.1322524},
                new Spot{lat=39.806843,lng=-86.1560446},
                new Spot{lat=39.8076166,lng=-86.1573312},
                new Spot{lat=39.8246639,lng=-86.15277890000002},
                new Spot{lat=39.800108,lng=-86.156543},
                new Spot{lat=39.9189678,lng=-86.111159},
                new Spot{lat=39.848306,lng=-86.126514},
                new Spot{lat=40.0460878,lng=-86.01536899999999},
                new Spot{lat=40.0397109,lng=-86.002647},
                new Spot{lat=39.852091,lng=-86.15803319999999},
                new Spot{lat=39.8645672,lng=-86.1569552},
                new Spot{lat=40.0085331,lng=-86.1265581},
                new Spot{lat=39.848322,lng=-86.12467},
                new Spot{lat=40.0363209,lng=-85.9922722},
                new Spot{lat=39.8284847,lng=-86.15619149999999},
                new Spot{lat=39.9236069,lng=-86.099177},
                new Spot{lat=39.929378,lng=-86.102729},
                new Spot{lat=39.9242877,lng=-86.1099921}
            };

            string[][] imageSeed = new string[][]
            {
                new string[] {"http://68.media.tumblr.com/115411f78f7734e3cd09e2afc2023703/tumblr_inline_ooxp0dwjzu1uwsat2_500.jpg", "http://68.media.tumblr.com/8e2ba9b604e1430769f20c7a9d050cdf/tumblr_inline_ooxopaS3JU1uwsat2_500.jpg", "http://68.media.tumblr.com/d3d26bffe5653307748c6438bdcba62c/tumblr_inline_ooxorqz8zg1uwsat2_500.jpg"},
                new string[] { "http://68.media.tumblr.com/926ccbca883888eb50c4ac2f75742196/tumblr_inline_oood98MRx71uwsat2_500.jpg", "http://68.media.tumblr.com/c69453804b687b6cd4f768965cfd4567/tumblr_inline_oood8hUrdS1uwsat2_500.jpg", "http://68.media.tumblr.com/47a226f6693211dacfc99b2d19123640/tumblr_inline_oood6aG4eS1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/60765594bd4cc0502ffd01fcbd82cc38/tumblr_inline_ooj5g5fLVK1uwsat2_500.jpg", "http://68.media.tumblr.com/edfc8cc666a07bfd1ac28794cdea52de/tumblr_inline_ooj5evfQuc1uwsat2_500.jpg", "http://68.media.tumblr.com/9297295c2e7d3c6b1bbbf7b3ad2e3a2d/tumblr_inline_ooj5ddimCF1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/bb7d1ec8a57ad96fe1803f35f5de5069/tumblr_inline_ooj58olRIB1uwsat2_500.jpg", "http://68.media.tumblr.com/08cbc5136bdecd18bbdfff8187457034/tumblr_inline_ooj56lVJxK1uwsat2_500.jpg", "http://68.media.tumblr.com/84f61cbab3595887ccde4ee8432b9b53/tumblr_inline_ooj57qBp3P1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/aebd57b05eae42954a7062d841ec9d48/tumblr_inline_oofg7bxXas1uwsat2_500.jpg", "http://68.media.tumblr.com/218e06469e6a78deb28c996351804300/tumblr_inline_oofg42VCmr1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/9ee8ee1d48c9842275d8b29ac81995d8/tumblr_inline_oofg1fFaUd1uwsat2_500.jpg", "http://68.media.tumblr.com/df7c842b3876e060cbe9a186173b7b20/tumblr_inline_ooffsc8YLg1uwsat2_500.jpg", "http://68.media.tumblr.com/071547d59ca6c114cc9e29090bf500ac/tumblr_inline_oofftpj7ic1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/2511bda77381531a27bd726f01541a58/tumblr_inline_oo9tqdex0Q1uwsat2_500.jpg", "http://68.media.tumblr.com/c2738c6fab2d4ba6d12e3f0be159cdad/tumblr_inline_oo9tq1oI5z1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/d4689bacff0de4d8f0f8ed753d967020/tumblr_inline_oo5u6eMeth1uwsat2_500.jpg", "http://68.media.tumblr.com/a66e8d111e77521099b0d090591d0d8d/tumblr_inline_oo5u7aB8Tq1uwsat2_500.jpg", "http://68.media.tumblr.com/3d6df48d1ab865eb2a78e445e70f9d4d/tumblr_inline_oo5u80Y1RV1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/597ecea6d77c0e17e9bbb132aa7902ab/tumblr_inline_oo0dgb3HoO1uwsat2_500.jpg", "http://68.media.tumblr.com/6a0b5185efc34075bd932a8063bde4d4/tumblr_inline_oo0dgxVWFk1uwsat2_500.jpg", "http://68.media.tumblr.com/51dbecd7aef9482612e4f1c1c895d9f7/tumblr_inline_oo0dhbg2mG1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/42a18a7ffcc16c4f29b0b2effc01ae13/tumblr_inline_onv17zLCwR1uwsat2_500.jpg", "http://68.media.tumblr.com/e30a17667712e1fa68eaffa7b48dbc80/tumblr_inline_onv18tZqdN1uwsat2_500.jpg", "http://68.media.tumblr.com/5d6e8207562fb337896d44c75013840c/tumblr_inline_onv168gaVG1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/d9a62ec53804a2f14b26c34df75d626a/tumblr_inline_oni4hcXyDx1uwsat2_500.jpg", "http://68.media.tumblr.com/2ed29ac18e7c79059aa5da75bc42d218/tumblr_inline_oni4huzQUt1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/9f2843a3c580e60b91c3579e793a3075/tumblr_inline_ong94gWEsW1uwsat2_500.jpg", "http://68.media.tumblr.com/91221a5984fe7491e325226831b6dde0/tumblr_inline_ong93zddtF1uwsat2_500.jpg", "http://68.media.tumblr.com/aabd92f53ab20be31073fa6acc36e234/tumblr_inline_ong93aBCEg1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/6ad5eab3223168d4231ca87b231dfc96/tumblr_inline_oneew54i7T1uwsat2_500.jpg", "http://68.media.tumblr.com/fb4e9e8cee093aa3c0c0c193c0cf477b/tumblr_inline_oneevlk9901uwsat2_500.jpg", "http://68.media.tumblr.com/47f49e7e05748bf1dee6a7da9973c81e/tumblr_inline_oneeuylh121uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/a41275c18c3035743485bd9ee5458e34/tumblr_inline_on39ueJF3T1uwsat2_500.jpg", "http://68.media.tumblr.com/3574e4274f6531297afc729d6a3590de/tumblr_inline_on39uy2XNf1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/664d2f3b809375be845aa13ce9240744/tumblr_inline_on39moj65H1uwsat2_500.jpg", "http://68.media.tumblr.com/52e465e6aefc060c2502ce0ff5b5362b/tumblr_inline_on39loTAdh1uwsat2_500.jpg", "http://68.media.tumblr.com/089c9dbfd0d7d962e5e80bd2933b65f0/tumblr_inline_on39m355Uh1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/77f74e1465835fa66fe9c8e1f12bee40/tumblr_inline_omu03wfF9e1uwsat2_500.jpg", "http://68.media.tumblr.com/e2cd2bddab2a2a2a5f71803100f6cf43/tumblr_inline_omu0521g5E1uwsat2_500.jpg", "http://68.media.tumblr.com/3a18b9a48aa47cc555eb5fdb6ed035ea/tumblr_inline_omu0682RpW1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/6d7f8ee05fa32fb6b4e5d3c89695b400/tumblr_inline_oms5w9BDeF1uwsat2_500.jpg", "http://68.media.tumblr.com/a885b2b6898fbe3c622a63d310935cbb/tumblr_inline_oms5wvCivi1uwsat2_500.jpg", "http://68.media.tumblr.com/ec4ab5a0b96de5c56d4f08e84f6e2a64/tumblr_inline_oms5xcRlKX1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/cd0a45728b951d2451f5f8160c4e597b/tumblr_inline_oms5n0Ce4v1uwsat2_500.jpg", "http://68.media.tumblr.com/19a3c857d400e4689d4bbeeab06a0ef9/tumblr_inline_oms5meuqa21uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/a36e3e4f0f48f833f50d139b285b7a18/tumblr_inline_omogshA5Xc1uwsat2_500.jpg", "http://68.media.tumblr.com/17187d43d2877b2f51b35437d0823707/tumblr_inline_omogpyZK4G1uwsat2_500.jpg", "http://68.media.tumblr.com/83b74b072fd793ccb0ecc11826a36579/tumblr_inline_omogqgCwd61uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/345863fd7cb7b33b3bebba3426a753e4/tumblr_inline_omogjn7LPm1uwsat2_500.jpg", "http://68.media.tumblr.com/08b9d3b096daa41c44109d4d36f17b0a/tumblr_inline_omogihy1tD1uwsat2_500.jpg", "http://68.media.tumblr.com/73a3ab1ecddbdaaac00528f81acdef65/tumblr_inline_omogizn1Ta1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/1ac28701ba1cb73bd4f5abc031faec8c/tumblr_inline_omdf8riIL81uwsat2_500.jpg", "http://68.media.tumblr.com/5030f6302f34b722526c2cea43c66b67/tumblr_inline_omdf3pMrdK1uwsat2_500.jpg", "http://68.media.tumblr.com/d9627b6b3a764ee8d278c629a1879521/tumblr_inline_omdf18Cv9g1uwsat2_500.jpg", "http://68.media.tumblr.com/1f9a8bcc9924ca8b47dcfa420e969126/tumblr_inline_omdf2gUTSJ1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/0510ba13574567d8b38e43025f6c96a5/tumblr_inline_om45clMFyd1uwsat2_500.jpg", "http://68.media.tumblr.com/da85abc5d672963b528656543031d640/tumblr_inline_om45e2ZBzg1uwsat2_500.jpg", "http://68.media.tumblr.com/9dfb5cef7694b02174129868d3e90181/tumblr_inline_om45ahDgnS1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/4e1560dc986d9927fc6e2406f3249add/tumblr_inline_om455ecSjb1uwsat2_500.jpg", "http://68.media.tumblr.com/baa0764178df3e57e8c4ccd1fea00ff9/tumblr_inline_om454smNdj1uwsat2_500.jpg", "http://68.media.tumblr.com/b16b63e2d64641eed62a55f68895f649/tumblr_inline_om454cms1F1uwsat2_500.jpg", "http://68.media.tumblr.com/92afea2dd92f244ecc1022b686bfaacd/tumblr_inline_om453d0Uoc1uwsat2_500.jpg", "http://68.media.tumblr.com/43db2ba2a0b992f2f831fe53808c99e8/tumblr_inline_om450ytbyG1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/830a1f79b69ad699bbb802e7d8c20ae3/tumblr_inline_olwjj0TYqN1uwsat2_500.jpg", "http://68.media.tumblr.com/1ceb4dd8b9a70906dff8be9bfbc9d50b/tumblr_inline_olwjhcMFBj1uwsat2_500.jpg", "http://68.media.tumblr.com/bdd90dd16ed952995148b41542f05271/tumblr_inline_olwjfxZNIf1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/c778da9417bc93c239734d30ec2521f2/tumblr_inline_olwiyfHCGs1uwsat2_500.jpg", "http://68.media.tumblr.com/e11b513a31d7e4f9d9c85c1b266d54d1/tumblr_inline_olwix3ajti1uwsat2_500.jpg", "http://68.media.tumblr.com/ff0b3e442c5b290db62fa551c5dd7caf/tumblr_inline_olwivkVDGa1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/4441f6527c6f77ac1a52f11be29b2de3/tumblr_inline_ollgkiYdzf1uwsat2_500.jpg", "http://68.media.tumblr.com/b3fd60b02dfec04dd6faf87c69ea01b9/tumblr_inline_ollgeqhLHO1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/597e37a45ba4a5faa253b07ba4e6ff31/tumblr_inline_ollg4t0fPg1uwsat2_500.jpg", "http://68.media.tumblr.com/a099f25f86bb2ea2ef052fd805079e1d/tumblr_inline_ollg3xlv7D1uwsat2_500.jpg", "http://68.media.tumblr.com/0d900dc786ef1cc750355fb9af2432ad/tumblr_inline_ollg3e5vZE1uwsat2_500.jpg", "http://68.media.tumblr.com/17db8f1bbe12c8784c818ba682cb4c2f/tumblr_inline_ol8qveI6VF1uwsat2_500.jpg", "http://68.media.tumblr.com/6910440887a8c04d53ba0a053f57ae65/tumblr_inline_ol8qw2NI371uwsat2_500.jpg", "http://68.media.tumblr.com/a37194d262f59a57ab9797338da5993e/tumblr_inline_ol8quo8xZJ1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/24bc80224f510359b2e3494f72f90f7f/tumblr_inline_ol8qlkaQMD1uwsat2_500.jpg", "http://68.media.tumblr.com/2d9e4d6efbe563ef9afd9c4d6b35a89f/tumblr_inline_ol8qktNzss1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/2f6e17fa83505e68a5f3ae6c6571fa07/tumblr_inline_okzkqo0JX01uwsat2_500.jpg", "http://68.media.tumblr.com/6bd31a08d23ed103bdef5e87c82c4a22/tumblr_inline_okzfwkPbMm1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/c10320abc039730b3848f4cc5b71aa1e/tumblr_inline_okzfq5aJXc1uwsat2_500.jpg", "http://68.media.tumblr.com/7d45a5092a19ca4b3f9eb4f0716a0f10/tumblr_inline_okzfp18TTC1uwsat2_500.jpg", "http://68.media.tumblr.com/f3f523048d83f509db430bf62c70fc41/tumblr_inline_okzfmxGKGR1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/c0abf0d298151aa0e4498ce407e20a2a/tumblr_inline_okxka21CKA1uwsat2_500.jpg", "http://68.media.tumblr.com/af916a0f0012ce04a8cfd417cf4b51c2/tumblr_inline_okxk8ikOH01uwsat2_500.jpg", "http://68.media.tumblr.com/94a8b07356d9795776f8403f86b23625/tumblr_inline_okxk7cl4ey1uwsat2_500.jpg", "http://68.media.tumblr.com/26fda2ad6b85aa882198fdd9a362c5f7/tumblr_inline_okxjvvDmmq1uwsat2_500.jpg", "http://68.media.tumblr.com/a871a0573dbf718c9ae68560486bc957/tumblr_inline_okxjyaOz0D1uwsat2_500.jpg", "http://68.media.tumblr.com/e36e2ad1581d8c827d7c483777c49ee2/tumblr_inline_okxjuun1LH1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/606895f6537cd89873a7335bf51b7f29/tumblr_inline_okxiw7Jv6a1uwsat2_500.jpg", "http://68.media.tumblr.com/0cd16cf06ec164dd8ecf548f26d1e3bd/tumblr_inline_okxiuhUciN1uwsat2_500.jpg" },
                new string[] { "http://68.media.tumblr.com/606895f6537cd89873a7335bf51b7f29/tumblr_inline_okxiw7Jv6a1uwsat2_500.jpg", "http://68.media.tumblr.com/0cd16cf06ec164dd8ecf548f26d1e3bd/tumblr_inline_okxiuhUciN1uwsat2_500.jpg" }
            };
            //int starthere = 0;

            //foreach (Spot currentspot in spots)
            //{
            //    while (spots.Count > starthere + 1)
            //    {
            //        currentspot.imagePaths = string.Join(",", imageSeed[starthere]);
            //        starthere += 1;
            //    }
            //}


            //spots.ForEach(s => s.imagePaths = string.Join(",", imageSeed[0]));
            spots.ForEach(s => context.Spots.Add(s));
           
            context.SaveChanges();
        }
    }
}
   