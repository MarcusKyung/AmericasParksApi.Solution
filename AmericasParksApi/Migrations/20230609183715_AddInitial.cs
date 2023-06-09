﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmericasParksApi.Migrations
{
    public partial class AddInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateEstablished = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Area = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "DateEstablished", "Description", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "49,071.40 acres", "1919", "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.", "Maine", "Acadia", "National Park" },
                    { 2, "8,256.67 acres", "1988", "The southernmost national park is on three Samoan islands in the South Pacific. It protects coral reefs, rainforests, volcanic mountains, and white beaches. The area is also home to flying foxes, brown boobies, sea turtles, and 900 species of fish.", "American Samoa", "American Samoa", "National Park" },
                    { 3, "76,678.98 acres", "1971", "This site features more than 2,000 natural sandstone arches, with some of the most popular arches in the park being Delicate Arch, Landscape Arch and Double Arch. Millions of years of erosion have created these structures in a desert climate where the arid ground has life-sustaining biological soil crusts and potholes that serve as natural water-collecting basins. Other geologic formations include stone pinnacles, fins, and balancing rocks.", "Utah", "Arches", "National Park" },
                    { 4, "242,755.94 acres", "1978", "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies within the drainage basin of the White River, in southwestern South Dakota. They contain the largest known assemblage of late Eocene and Oligocene mammal fossils. Wildlife includes bison, bighorn sheep, black-footed ferrets, and prairie dogs.", "South Dakota", "Badlands", "National Park" },
                    { 5, "801,163.21 acres", "1944", "Named for the prominent bend in the Rio Grande along the U.S.–Mexico border, this park encompasses a large and remote part of the Chihuahuan Desert. Its main attraction is backcountry recreation in the arid Chisos Mountains and in canyons along the river. A wide variety of Cretaceous and Tertiary fossils as well as cultural artifacts of Native Americans also exist within its borders.", "Texas", "Big Bend", "National Park" },
                    { 6, "172,971.11 acres", "1980", "The central part of Biscayne Bay, this mostly underwater park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs. Threatened animals include the West Indian manatee, American crocodile, various sea turtles, and the peregrine falcon.", "Florida", "Biscayne", "National Park" },
                    { 7, "30,779.83 acres", "1999", "The park protects a quarter of the Gunnison River, which slices sheer canyon walls from dark Precambrian-era rock. The canyon features some of the steepest cliffs and oldest rock in North America, and is a popular site for river rafting and rock climbing. The deep, narrow canyon is composed of gneiss and schist, which appears black when in shadow.", "Colorado", "Black Canyon of the Gunnison", "National Park" },
                    { 8, "35,835.08 acres", "1928", "Bryce Canyon is a geological amphitheater on southern Utah's Paunsaugunt Plateau with hundreds of tall, multicolored sandstone hoodoos formed by erosion. The region was originally settled by Native Americans and later by Mormon pioneers.", "Utah", "Bryce Canyon", "National Park" },
                    { 9, "337,597.83 acres", "1964", "This landscape was eroded into a maze of canyons, buttes, and mesas by the combined efforts of the Colorado River, Green River, and their tributaries, which divide the park into three districts. The park contains thousands of rock pinnacles and arches, as well as artifacts from Ancient Pueblo peoples.", "Utah", "Canyonlands", "National Park" },
                    { 10, "241,904.50 acres", "1971", "The park's Waterpocket Fold is a 100-mile (160 km) monocline that exhibits the earth's diverse geologic layers. Other natural features include monoliths, eroded buttes, and sandstone domes, including one shaped like the United States Capitol.", "Utah", "Capitol Reef", "National Park" },
                    { 11, "46,766.45 acres", "1930", "Carlsbad Caverns has 117 caves, the longest of which is over 120 miles (190 km) long. The Big Room is almost 4,000 feet (1,200 m) long, and the caves are home to over 400,000 Mexican free-tailed bats and sixteen other species. Above ground are the Chihuahuan Desert and Rattlesnake Springs.", "New Mexico", "Carlsbad Caverns ", "National Park" },
                    { 12, "249,561.00 acres", "1980", "Five of the eight Channel Islands are protected, with half of the park's area underwater. The islands have a unique Mediterranean ecosystem originally settled by the Chumash people. They are home to over 2,000 species of land plants and animals, 145 endemic to them, including the island fox. Ferry services offer transportation to the islands from the mainland.", "California", "Channel Islands", "National Park" },
                    { 13, "26,692.60 acres", "2003", "On the Congaree River, this park is the largest portion of old-growth floodplain forest left in North America. Some of the trees are the tallest in the eastern United States. An elevated walkway called the Boardwalk Loop guides visitors through the swamp.", "South Carolina", "Congaree", "National Park" },
                    { 14, "183,224.05 acres", "1902", "Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue color and water clarity. Wizard Island and the Phantom Ship are more recent volcanic formations within the caldera. As the lake has no inlets or outlets, it is replenished only by precipitation.", "Oregon", "Crater Lake", "National Park" },
                    { 15, "32,571.89 acres", "2000", "This park along the Cuyahoga River has waterfalls, hills, trails, and exhibits on early rural living. The Ohio and Erie Canal Towpath Trail follows the Ohio and Erie Canal, where mules towed canal boats. The park has numerous historic homes, bridges, and structures, and also offers a scenic train ride.", "Ohio", "Cuyahoga Valley", "National Park" },
                    { 16, "3,408,395.63 acres", "1994", "Death Valley is the hottest, lowest, and driest place in the United States, with daytime temperatures that have exceeded 130 °F (54 °C). The park protects Badwater Basin and its vast salt flats at the lowest elevation in North America, −282 ft (−86 m),This geologic graben also protects numerous canyons, badlands, sand dunes, mountain ranges, historic mines, springs, and more than 1,000 species of plants that grow.", "California, Nevada", "Death Valley", "National Park" },
                    { 17, "4,740,911.16 acres", "1917", "Centered on Denali, the tallest and most prominent mountain in North America, the park is serviced by a single road leading to Wonder Lake, most of which can only be accessed via scheduled tour buses. Denali and other peaks of the Alaska Range are covered with long glaciers and boreal forest. Wildlife includes grizzly bears, Dall sheep, moose, caribou, and wolves.", "Alaska", "Denali", "National Park" },
                    { 18, "64,701.22 acres", "1992", "The islands of the Dry Tortugas, at the westernmost end of the Florida Keys, are the site of Fort Jefferson, a Civil War-era fort that is the largest masonry structure in the Western Hemisphere. The park is home to undisturbed coral reefs and shipwrecks, and is only accessible by plane or boat.", "Florida", "Dry Tortugas", "National Park" },
                    { 19, "1,508,938.57 acres", "1934", "The Everglades are the largest tropical wilderness in the United States. This mangrove and tropical rainforest ecosystem and marine estuary is home to 36 protected species, including the Florida panther, American crocodile, and West Indian manatee. Some areas have been drained and developed; restoration projects aim to restore the ecology.", "Florida", "Everglades", "National Park" },
                    { 20, "7,523,897.45 acres", "1980", "The country's northernmost park protects an expanse of pure wilderness in Alaska's Brooks Range and has no park facilities. The land is home to Alaska Natives who have relied on the land and caribou for 11,000 years.", "Alaska", "Gates of the Arctic", "National Park" },
                    { 21, "192.83 acres", "2018", "The Gateway Arch is a 630-foot (192 m) (both high and wide) catenary arch built in the 1960s to commemorate the Lewis and Clark Expedition, initiated by Thomas Jefferson, and the subsequent westward expansion of the country. The nearby Old Courthouse, across a greenway to the west of the arch, was the original site of the landmark Dred Scott case about slavery. An underground museum describes the arch's construction and the country's westward expansion.", "Missouri", "Gateway Arch", "National Park" },
                    { 22, "1,013,126.39 acres", "1910", "The U.S. half of Waterton-Glacier International Peace Park, this park includes 26 rapidly receding glaciers and 130 named lakes surrounded by Rocky Mountain peaks. Historic hotels and the landmark Going-to-the-Sun Road accommodate visitors. The local mountains, formed by an overthrust, expose Paleozoic fossils including trilobites, mollusks, giant ferns and dinosaurs. The park is also home to Triple Divide Peak, which forms the boundary between the watersheds of the Atlantic, Pacific, and Arctic Oceans.", "Montana", "Glacier", "National Park" },
                    { 23, "3,223,383.43 acres", "1980", "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles. When discovered in 1794 by George Vancouver, the entire bay was covered by ice, but the glaciers have since receded more than 65 miles (105 km).", "Alaska", "Glacier Bay", "National Park" },
                    { 24, "1,201,647.03 acres", "1919", "The Grand Canyon, carved by the mighty Colorado River, is 277 miles (446 km) long, up to 1 mile (1.6 km) deep, and up to 15 miles (24 km) wide. Millions of years of erosion have resulted in a massive three-tiered canyon, exposing the multicolored layers of the Colorado Plateau in mesas and canyon walls, visible from trails that descend into the canyon from the north and south rims.", "Arizona", "Grand Canyon ", "National Park" },
                    { 25, "310,044.36 acres", "1929", "Grand Teton is the tallest mountain in the scenic Teton Range. The park's historic Jackson Hole and reflective piedmont lakes teem with endemic wildlife, with a backdrop of craggy mountains that rise abruptly from the sage-covered valley below.", "Wyoming", "Grand Teton", "National Park" },
                    { 26, "77,180.00 acres", "1986", "Based around Nevada's second tallest mountain, Wheeler Peak, Great Basin National Park protects 5,000-year-old bristlecone pines, a rock glacier, and the limestone Lehman Caves. Due to its remote location, the park is home to some of the country's darkest night skies. Wildlife includes the Townsend's big-eared bat, pronghorn, and Bonneville cutthroat trout.", "Nevada", "Great Basin", "National Park" },
                    { 27, "107,345.73 acres", "2004", "The tallest sand dunes in North America, up to 750 feet (230 m) tall, were formed by deposits of the ancient Rio Grande in the San Luis Valley. Abutting a variety of grasslands, shrublands, and wetlands, the park also features alpine lakes, six 13,000-foot mountains, and old-growth forests.", "Colorado", "Great Sand Dunes", "National Park" },
                    { 28, "522,426.88 acres", "1934", "The Great Smoky Mountains, part of the Appalachian Mountains, span a wide range of elevations, making them home to over 400 vertebrate species, 100 tree species, and 5,000 plant species. Hiking is the park's main attraction, with over 800 miles (1,300 km) of trails, including 70 miles (110 km) of the Appalachian Trail. Other activities include fishing, horseback riding, and touring nearly 80 historic structures.", "North Carolina, Tennessee", "Great Smoky Mountains", "National Park" },
                    { 29, "86,367.10 acres", "1972", "This park contains Guadalupe Peak, the highest point in Texas, as well as the scenic McKittrick Canyon filled with bigtooth maples, a corner of the arid Chihuahuan Desert, and a fossilized coral reef from the Permian era.", "Texas", "Guadalupe Mountains", "National Park" },
                    { 30, "33,488.98 acres", "1961", "The Haleakalā volcano on Maui features a very large crater with numerous cinder cones, a grove of non-native trees, the Kipahulu section's scenic pools of freshwater fish, and the endemic Hawaiian goose. The park protects the greatest number of endangered species within a U.S. national park.", "Hawaii", "Haleakalā", "National Park" },
                    { 31, "344,812.18 acres", "1916", "This park on the Big Island protects the Kīlauea and Mauna Loa volcanoes, two of the world's most active geological features. Diverse ecosystems range from tropical forests at sea level to barren lava beds at more than 13,000 feet (4,000 m).", "Hawaii", "Hawaiʻi Volcanoes", "National Park" },
                    { 32, "5,554.15 acres", "1921", "Hot Springs was originally established by Congress as a federal reserve on April 20, 1832, making it the oldest area managed by the National Park Service. Natural thermal springs flow out of the Ouachita Mountains, providing opportunities for relaxation in a historic setting. Bathhouse Row preserves examples of 19th-century architecture. Hot Springs is the first national park within a city and was the smallest national park until 2018.", "Arkansas", "Hot Springs", "National Park" },
                    { 33, "15,349.08 acres", "2019", "Previously designated a national lakeshore, parts of this 20-mile (32 km) stretch of the southern shore of Lake Michigan have sandy beaches and tall dunes. The park includes grassy prairies, peat bogs, and marsh wetlands home to over 2,000 species.", "Indiana", "Indiana Dunes", "National Park" },
                    { 34, "571,790.30 acres", "1940", "The largest island in Lake Superior is a place of isolation and wilderness. Along with its many shipwrecks, waterways, and hiking trails, the park also includes over 400 smaller islands within 4.5 miles (7.2 km) of its shores. There are only 20 mammal species on the island, though the relationship between its wolf and moose populations is especially unique.", "Michigan", "Isle Royale", "National Park" },
                    { 35, "795,155.85 acres", "1994", "Covering large areas of the Colorado and Mojave Deserts and the Little San Bernardino Mountains, this desert landscape is populated by vast stands of Joshua trees. Large changes in elevation reveal various contrasting environments including bleached sand dunes, dry lakes, rugged mountains, and maze-like clusters of monzogranite monoliths.", "California", "Joshua Tree", "National Park" },
                    { 36, "3,674,529.33 acres", "1980", "This park on the Alaska Peninsula protects the Valley of Ten Thousand Smokes, an ash flow formed by the 1912 eruption of Novarupta, and the stratovolcano Mount Katmai. Over 2,000 grizzly bears come here each year to catch spawning salmon. Other wildlife includes caribou, wolves, moose, and wolverines.", "Alaska", "Katmai", "National Park" },
                    { 37, "669,650.05 acres", "1980", "Near Seward on the Kenai Peninsula, this park protects the Harding Icefield and at least 38 glaciers and fjords stemming from it. The only area accessible to the public by road is the rapidly shrinking Exit Glacier. Boat and kayak tours offer views of tidewater glaciers, whales, sea lions, and marine birds.", "Alaska", "Kenai Fjords", "National Park" },
                    { 38, "461,901.20 acres", "1940", "Home to several giant sequoia groves and the General Grant Tree, the world's second largest measured tree, this park also features part of the Kings River, sculptor of the dramatic granite canyon that is its namesake, and the San Joaquin River, as well as Boyden Cave. Although Kings Canyon National Park was designated as such in 1940, it subsumed General Grant National Park, which had been established on October 1, 1890, as the United States' fourth national park.", "California", "Kings Canyon", "National Park" },
                    { 39, "1,750,716.16 acres", "1980", "Kobuk Valley protects 61 miles (98 km) of the Kobuk River and three regions of sand dunes. Created by glaciers, the Great Kobuk, Little Kobuk, and Hunt River Sand Dunes can reach 100 feet (30 m) high and 100 °F (38 °C), and they are the largest dunes in the Arctic. Twice a year, half a million caribou migrate through the dunes and across river bluffs that expose well-preserved ice age fossils.", "Alaska", "Kobuk Valley", "National Park" },
                    { 40, "2,619,816.49 acres", "1980", "The region around Lake Clark features four active volcanoes, including Mount Redoubt, as well as an abundance of rivers, glaciers, and waterfalls. Temperate rainforests, a tundra plateau, and three mountain ranges complete the landscape.", "Alaska", "Lake Clark", "National Park" },
                    { 41, "106,589.02 acres", "1916", "Lassen Peak, the largest lava dome volcano in the world, is joined by all three other types of volcanoes in this park: shield, cinder cone, and composite. Though Lassen itself last erupted in 1915, most of the rest of the park is continuously active. Numerous hydrothermal features, including fumaroles, boiling pools, and bubbling mud pots, are heated by molten rock from beneath the peak.", "California", "Lassen Volcanic", "National Park" },
                    { 42, "72,472.87 acres", "1941", "With more than 400 miles (640 km) of passageways explored, Mammoth Cave is the world's longest known cave system. Subterranean wildlife includes eight bat species, Kentucky cave shrimp, Northern cavefish, and cave salamanders. Above ground, the park provides recreation on the Green River, 70 miles of hiking trails, and plenty of sinkholes and springs.", "Kentucky", "Mammoth Cave", "National Park" },
                    { 43, "52,485.17 acres", "1906", "This area constitutes over 4,000 archaeological sites of the Ancestral Puebloan people, who lived here and elsewhere in the Four Corners region for at least 700 years. Cliff dwellings built in the 12th and 13th centuries include Cliff Palace, which has 150 rooms and 23 kivas, and the Balcony House, with its many passages and tunnels.", "Colorado", "Mesa Verde ", "National Park" },
                    { 44, "236,381.64 acres", "1899", "Mount Rainier, an active stratovolcano, is the most prominent peak in the Cascades and is covered by 26 named glaciers including Carbon Glacier and Emmons Glacier, the longest and largest in the contiguous United States respectively. The mountain is popular for climbing, and more than half of the park is covered by subalpine and alpine forests and meadows seasonally in bloom with wildflowers. Paradise on the south slope is among the snowiest places on Earth. The Longmire visitor center is the start of the Wonderland Trail, which encircles the mountain.", "Washington", "Mount Rainier", "National Park" },
                    { 45, "7,021 acres", "2020", "The New River Gorge is the deepest river gorge east of the Mississippi River. The park primarily covers the lower gorge area around the New River Gorge Bridge, which features some of the country's best whitewater rafting. Smaller noncontiguous sections showcase the ghost town of Thurmond, the scenic Grandview vista, and Sandstone Falls. The other 65,165 acres (263.71 km2) of the redesignated national river is now a national preserve, spanning 53 mi (85 km) of the New River.", "West Virginia", "New River Gorge", "National Park" },
                    { 46, "504,780.94 acres", "1968", "The highly glaciated mountains of the North Cascades Range exhibit a spectacular and complex geologic history. Between the river valleys and high peaks there are eight diverse life zones with 75 mammal and 1,600 vascular plant species. Popular hiking and climbing areas of the Stephen Mather Wilderness include Cascade Pass, Mount Shuksan, Mount Triumph, and Eldorado Peak. Ross Lake and Lake Chelan National Recreation Areas adjoin the two segments of the park and are all administered together.", "Washington", "North Cascades", "National Park" },
                    { 47, "922,649.41 acres", "1938", "This park on the Olympic Peninsula includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the glaciated alpine peaks of the Olympic Mountains, the tallest of which is Mount Olympus. The Hoh and Quinault Rainforests are the wettest areas in the contiguous United States, with the Hoh receiving an average of almost 12 ft (3.7 m) of rain every year.", "Washington", "Olympic", "National Park" },
                    { 48, "221,390.21 acres", "1962", "This portion of the Chinle Formation has a large concentration of 225-million-year-old petrified wood. The surrounding Painted Desert features eroded cliffs of red-hued volcanic rock called bentonite. Dinosaur fossils and over 350 Native American sites are also protected in this park.", "Arizona", "Petrified Forest", "National Park" },
                    { 49, "26,685.73 acres", "2013", "Named for the eroded leftovers of a portion of an extinct volcano, the park's massive black and gold monoliths of andesite and rhyolite are a popular destination for rock climbers. Hikers have access to trails crossing the Coast Range wilderness. The park is one of the few locations where the endangered California condor can be seen in the wild. Pinnacles also supports a dense population of prairie falcons and more than 13 species of bat that populate its talus caves.", "California", "Pinnacles", "National Park" },
                    { 50, "138,999.37 acres", "1968", "This park and the co-managed state parks protect almost half of all remaining coastal redwoods, the tallest trees on earth. There are three large river systems in this very seismically active area, and 37 miles (60 km) of protected coastline reveal tide pools and seastacks. The prairie, estuary, coast, river, and forest ecosystems contain a wide variety of animal and plant species.", "California", "Redwood ", "National Park" },
                    { 51, "265,847.74 acres", "1915", "Bisected north to south by the Continental Divide, this portion of the Rockies has ecosystems varying from over 150 riparian lakes to montane and subalpine forests to treeless alpine tundra. Wildlife including elk, moose, mule deer, bighorn sheep, black bears, and cougars inhabit its igneous mountains and glacial valleys. Longs Peak, a classic Colorado fourteener, and the scenic Bear Lake are popular destinations, as well as the historic Trail Ridge Road, which reaches an elevation of more than 12,000 feet (3,700 m).", "Colorado", "Rocky Mountain", "National Park" },
                    { 52, "92,876.75 acres", "1994", "Split into the separate Rincon Mountain and Tucson Mountain districts, this park is evidence that the dry Sonoran Desert is still home to a great variety of life spanning six biotic communities. Beyond the namesake giant saguaro cacti, there are barrel cacti, chollas, and prickly pears, as well as lesser long-nosed bats, spotted owls, and javelinas.", "Arizona", "Saguaro", "National Park" },
                    { 53, "404,062.63 acres", "1890", "This park protects the Giant Forest, which boasts some of the world's largest trees, the General Sherman being the largest measured tree in the park. Other features include over 240 caves, a long segment of the Sierra Nevada including the tallest mountain in the contiguous United States, and Moro Rock, a large granite dome.", "California", "Sequoia", "National Park" },
                    { 54, "200,445.92 acres", "1935", "Shenandoah's Blue Ridge Mountains are covered by hardwood forests that teem with a wide variety of wildlife. The Skyline Drive and Appalachian Trail run the entire length of this narrow park, along with more than 500 miles (800 km) of hiking trails passing scenic overlooks and cataracts of the Shenandoah River.", "Virginia", "Shenandoah", "National Park" },
                    { 55, "70,446.89 acres", "1978", "This region that enticed and influenced President Theodore Roosevelt consists of a park of three units in the northern badlands. Besides Roosevelt's historic cabin, there are numerous scenic drives and backcountry hiking opportunities. Wildlife includes American bison, pronghorn, bighorn sheep, and wild horses.", "North Dakota", "Theodore Roosevelt", "National Park" },
                    { 56, "15,052.33 acres", "1956", "This island park on Saint John preserves pristine beaches surrounded by mangrove forests, seagrass beds, and coral reefs. It also has Taíno archaeological sites and the ruins of sugar plantations from Columbus's time.", "U.S. Virgin Islands", "Virgin Islands", "National Park" },
                    { 57, "218,222.35 acres", "1975", "This park protecting four lakes near the Canada–US border is a site for canoeing, kayaking, and fishing. The park also preserves a history populated by Ojibwe Native Americans, French fur traders called voyageurs, and gold miners. Formed by glaciers, the region features tall bluffs, rock gardens, islands, bays, and several historic buildings.", "Minnesota", "Voyageurs", "National Park" },
                    { 58, "146,344.31 acres", "2019", "Located in the mountain-ringed Tularosa Basin, White Sands consists of the southern part of a 275-square-mile (710 km2) field of white sand dunes composed of gypsum crystals—the world's largest gypsum dunefield. The park is completely within the White Sands Missile Range and is subject to closure when tests are conducted.", "New Mexico", "White Sands", "National Park" },
                    { 59, "33,970.84 acres", "1903", "Wind Cave is distinctive for its calcite fin formations called boxwork, a unique formation rarely found elsewhere, and needle-like growths called frostwork. It is one of the longest caves in the world and creates a wind as air pressure changes. Above ground is a mixed-grass prairie with animals such as bison, black-footed ferrets, and prairie dogs and ponderosa pine forests home to cougars and elk. The cave is culturally significant to the Lakota people as a creation site.", "South Dakota", "Wind Cave", "National Park" },
                    { 60, "8,323,146.48 acres", "1980", "The largest national park in the system protects the convergence of the Alaska, Chugach, Wrangell, and Saint Elias Ranges, which include many of the continent's tallest mountains and volcanoes, including the 18,008-foot Mount Saint Elias. More than a quarter of the park is covered with glaciers, including the tidewater Hubbard Glacier, piedmont Malaspina Glacier, and valley Nabesna Glacier.", "Alaska", "Wrangell–St. Elias ", "National Park" },
                    { 61, "2,219,790.71 acres", "1872", "Situated on the Yellowstone Caldera, the park has an expansive network of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, and regularly erupting geysers, the best-known being Old Faithful. The yellow-hued Grand Canyon of the Yellowstone River contains several high waterfalls, and four mountain ranges traverse the park. More than 60 mammal species including timber wolves, grizzly bears, black bears, lynxes, bison, and elk make this park one of the best wildlife viewing spots in the country.", "Wyoming, Montana, Idaho", "Yellowstone", "National Park" },
                    { 62, "761,747.50 acres", "1890", "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet (739 m) high. Three giant sequoia groves, along with a pristine wilderness in the heart of the Sierra Nevada, are home to a wide variety of rare plant and animal species.", "California", "Yosemite ", "National Park" },
                    { 63, "147,242.66 acres", "1919", "Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows. The various sandstone formations and the forks of the Virgin River create a wilderness divided into four ecosystems: desert, riparian, woodland, and coniferous forest.", "Utah", "Zion", "National Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
