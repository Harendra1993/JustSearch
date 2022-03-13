using JustSearch.Api.Models;

namespace JustSearch.Api.Data
{
    public class ItemsData
    {
        public IList<Items> items = new List<Items>
            {
                new Items() { Description = "First world war history in Deatil.", Link = "http://sample.com", Title = "First world war" },
                new Items() { Description = "How to send a man to the moon", Link = "http://moon.com", Title = "Mission moon" },
                new Items() { 
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 
                    Link = "http://ipsum.com", 
                    Title = "The standard Lorem Ipsum passage, used since the 1500s" 
                },
                new Items() {
                    Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", 
                    Link = "http://molestiae.com", 
                    Title = "Section 1.10.32 of de Finibus Bonorum et Malorum, written by Cicero in 45 BC" 
                },
                new Items() { 
                    Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?", 
                    Link = "http://who.com", 
                    Title = "1914 translation by H. Rackham" 
                },
                new Items() { 
                    Description = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.", 
                    Link = "http://maiores.com", 
                    Title = "Section 1.10.33 of \"de Finibus Bonorum et Malorum\", written by Cicero in 45 BC" 
                },
                new Items() {
                    Description = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pain.",
                    Link = "http://translation.com",
                    Title = "1914 translation by H. Rackham"
                },
                new Items() {
                    Description = "Integer vitae velit diam. Integer facilisis risus vitae nisl rhoncus scelerisque. Phasellus vitae nisi vel mi tincidunt egestas non at velit. Nam urna massa, hendrerit nec nisi non, volutpat scelerisque mi. Quisque rhoncus maximus dolor, sed volutpat enim scelerisque ac. Praesent sagittis sem in ante rhoncus lobortis ac ac elit. Aliquam dictum eleifend tellus vitae dapibus. Curabitur ut ex quis ex semper tincidunt vitae sed ex. Donec id diam mi. Praesent rutrum risus dolor, eget hendrerit enim pharetra vitae. Donec egestas fermentum lacus. Quisque malesuada elit ut nisl tempor, sed venenatis ante pulvinar. Nulla vel ex in nulla tempus tempus sit amet at lorem.",
                    Link = "http://lorem.com",
                    Title = "Integer vitae velit diam"
                },
                new Items() {
                    Description = "Phasellus sed sollicitudin leo. Aliquam ac enim a magna cursus feugiat. Vivamus at aliquet augue, quis venenatis quam. Curabitur ut elit vulputate, egestas justo condimentum, hendrerit sapien. Integer felis lorem, accumsan at bibendum at, dictum rhoncus ante. Nullam a mattis risus. Donec id rutrum nibh. In quis sagittis libero. Phasellus quis felis vel nibh semper suscipit vitae sit amet sapien.",
                    Link = "http://rutrum.com",
                    Title = "Donec id rutrum nibh."
                },
                new Items() {
                    Description = "Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ac justo lobortis, eleifend nulla et, egestas nunc. Duis interdum ac ante non tincidunt. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent sodales tortor eu nisl tempor egestas. Duis mollis pulvinar tincidunt. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Ut finibus sollicitudin venenatis. Donec sed laoreet metus, sit amet volutpat leo. Nullam pretium, est in pretium consectetur, mauris tortor condimentum nisl, ut pellentesque ligula lacus et massa. Quisque vel mi in nunc mattis varius non vitae enim. Nam lobortis porttitor lectus, egestas mollis massa congue ac. Nunc dapibus varius turpis non interdum. Pellentesque tincidunt metus sem, quis commodo diam luctus ac. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam suscipit eleifend imperdiet.",
                    Link = "http://lobortis.com",
                    Title = " Nullam suscipit eleifend imperdiet"
                },
                new Items() {
                    Description = "Phasellus eu tincidunt massa. Cras iaculis dolor et condimentum imperdiet. Proin neque mauris, tempus tempus nisl et, volutpat hendrerit mi. Suspendisse a sem nulla. Morbi nibh nisl, elementum eu luctus et, suscipit sit amet metus. Etiam tristique neque eu laoreet commodo. Phasellus ultricies bibendum velit, ac blandit purus auctor sit amet. Nullam eget nibh nisl. Aliquam purus tellus, ornare sed lectus in, pellentesque congue est. Quisque imperdiet, nibh et ultrices mattis, nisl lorem convallis eros, vitae accumsan risus tortor at diam. Duis justo velit, elementum a gravida sit amet, sagittis vel metus. Aliquam egestas magna eu efficitur pretium. Suspendisse potenti. Fusce pulvinar malesuada viverra. Donec faucibus, erat et pharetra ultrices, odio nulla commodo ante, non pretium nulla orci nec dolor.",
                    Link = "http://potenti.com",
                    Title = "Fusce pulvinar malesuada viverra."
                },
                new Items() {
                    Description = "Vestibulum semper ultricies mi vitae laoreet. Nunc nec leo dolor. Pellentesque eget placerat ligula. Donec non rhoncus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eu nibh tellus. Nunc iaculis tellus at accumsan varius. Nulla facilisi. Maecenas a pulvinar lorem. Proin rhoncus mollis cursus. Fusce tristique posuere nisl eget venenatis. Fusce egestas mattis magna, vitae tincidunt lorem finibus et. Donec suscipit mauris auctor bibendum feugiat. Integer tincidunt ultricies quam, vel vulputate erat. Etiam pretium mauris nec arcu cursus faucibus.",
                    Link = "http://vulputate.com",
                    Title = "Pellentesque eget placerat ligula."
                },
                new Items() {
                    Description = "Vivamus iaculis vulputate dui et pulvinar. In rhoncus ligula vitae ante porttitor hendrerit. Sed laoreet, justo in ullamcorper pellentesque, est dolor egestas nunc, et gravida nibh est eget odio. Phasellus eu rutrum sem. Duis quis libero turpis. Quisque feugiat id dolor quis porttitor. Quisque ornare quam sed orci rutrum posuere. Sed egestas gravida felis, eu aliquam lacus faucibus id. Proin venenatis condimentum dapibus. Maecenas consectetur volutpat ligula et imperdiet. Sed interdum dictum arcu ullamcorper consequat. Maecenas aliquam quam feugiat ipsum venenatis vehicula. Nam at arcu vitae massa congue ultrices in eu justo. Quisque metus magna, rhoncus vel ultricies sed, lacinia vel eros.",
                    Link = "http://est.com",
                    Title = "lacinia vel eros"
                },
                new Items() {
                    Description = "Quisque consectetur ligula id elit tincidunt egestas. Vivamus ultricies posuere nisl, sed euismod magna faucibus vel. Quisque ut velit fermentum, vulputate nibh eget, elementum risus. Nullam ut odio a urna volutpat imperdiet id ac erat. Aliquam nec elit lobortis magna dictum egestas ut sed dolor. Proin justo enim, varius a bibendum nec, tempor eget massa. Suspendisse interdum mauris vel turpis facilisis aliquam.",
                    Link = "http://vulputate.com",
                    Title = "Proin justo enim, varius a bibendum nec, tempor eget massa."
                },
                new Items() {
                    Description = "Suspendisse ut tortor et tellus finibus commodo sit amet vitae sapien. Ut suscipit ante id lacinia consequat. Sed cursus non nisl ac consectetur. Sed in scelerisque dolor. Pellentesque ornare ex sed nulla commodo fermentum. Aliquam erat volutpat. Integer id mi dolor. Donec non egestas nibh. Integer faucibus orci eu aliquam laoreet. Cras bibendum dignissim aliquet. Quisque eleifend urna et ex fringilla malesuada vel ut nulla. Quisque lacinia purus eu justo euismod faucibus. Nulla rutrum risus felis, eu consequat velit ultricies eget. Sed rhoncus libero turpis, at congue leo viverra egestas.",
                    Link = "http://sample.com",
                    Title = "Sed rhoncus libero turpis sample"
                },
                new Items() {
                    Description = "Fusce tempus sapien eu convallis sodales. Nunc ornare mauris sed enim viverra, id hendrerit felis consectetur. Donec ac tempor ex. Nam luctus, orci id pharetra ultricies, lacus libero feugiat velit, sed tincidunt mi sem efficitur augue. Nulla neque ante, interdum sed dui eu, luctus dapibus leo. Sed at tellus non risus aliquet scelerisque. Proin rutrum, quam vitae rutrum gravida, odio elit lobortis mauris, vitae vestibulum diam eros vel tortor.",
                    Link = "http://tellus.com",
                    Title = "Sed at tellus non risus aliquet scelerisque"
                },
                new Items() {
                    Description = "Maecenas congue magna at eros egestas, ut semper massa efficitur. Ut ut vehicula dui. Donec quis nisl tortor. Phasellus et justo et sapien viverra facilisis ac et velit. Sed nibh velit, luctus at leo in, aliquet porttitor urna. Maecenas auctor varius pharetra. Fusce eget mollis ipsum, quis pharetra elit. Morbi volutpat odio eu lectus ullamcorper, in mollis ligula auctor.",
                    Link = "http://ipsum.com",
                    Title = "Fusce eget mollis ipsum, quis pharetra elit."
                },
                new Items() {
                    Description = "Donec vel libero ut velit gravida vulputate a eu lorem. Quisque non faucibus odio. Aenean tortor lorem, vehicula commodo eros sed, facilisis euismod massa. Nulla ultrices libero eget sollicitudin imperdiet. Nulla pulvinar neque a fringilla commodo. Vestibulum ullamcorper quam sed erat vulputate eleifend. Praesent pretium tincidunt lectus, eget laoreet purus porttitor sit amet. Cras gravida tellus ante, in luctus sapien euismod quis. Phasellus porta felis erat, non semper metus consequat at. Duis in maximus mi. Nulla semper et odio nec vehicula. Sed tristique ut erat nec feugiat. Proin in lectus condimentum, placerat quam in, feugiat erat. Nulla enim erat, ornare non viverra sit amet, fermentum vitae dolor. In sagittis, sapien a pharetra porta, mauris felis tincidunt risus, eget maximus augue nisl non est.",
                    Link = "http://erat.com",
                    Title = "Sed tristique ut erat nec feugiat."
                },
                new Items() {
                    Description = "Ut accumsan sed erat ac bibendum. Mauris nec dapibus sem. Proin sit amet sagittis lacus. Maecenas a erat sapien. Sed congue, neque at feugiat interdum, velit lacus sodales felis, ac iaculis nisi erat sed magna. Vestibulum vestibulum iaculis laoreet. Vestibulum congue tincidunt lorem ac feugiat.",
                    Link = "http://tincidunt.com",
                    Title = "ac iaculis nisi erat sed magna"
                },
                new Items() {
                    Description = "Sed nec mi sit amet lectus tempus ultricies eget laoreet neque. Fusce volutpat erat tortor, id tincidunt urna consectetur nec. Integer elementum, lorem fringilla maximus tincidunt, nisi libero dictum massa, id fermentum justo neque in orci. Interdum et malesuada fames ac ante ipsum primis in faucibus. Integer malesuada lacus id nulla ullamcorper, sed commodo sapien mollis. Donec interdum diam at egestas scelerisque. Morbi sed lectus metus. Aenean dapibus turpis eu enim sodales eleifend. In varius tincidunt varius. Quisque in ipsum eget neque ullamcorper finibus nec a diam. Donec efficitur rutrum fermentum.",
                    Link = "http://quisque.com",
                    Title = "Sed nec mi sit amet lectus tempus ultricies eget laoreet neque."
                },
                new Items() {
                    Description = "Cras malesuada purus quis fringilla interdum. Phasellus luctus, sem at vestibulum tristique, lectus lorem finibus odio, non dapibus arcu nisl non magna. In consequat vitae massa vitae finibus. Phasellus ultricies nisl in velit tristique, a dignissim augue ultricies. Sed porta molestie sagittis. Proin tempor ultricies iaculis. Ut non ipsum sit amet orci cursus dictum et eget arcu.",
                    Link = "http://malesuada.com",
                    Title = "Fhasellus luctus, sem at vestibulum tristique"
                },

            };

    }
}
