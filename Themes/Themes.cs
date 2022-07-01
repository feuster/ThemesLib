using System.Drawing;

namespace Feuster
{
    public class Themes
    {
        #region Declarations
        //private static bool[] Darkmode = Enumerable.Repeat(false, Indices+1).ToArray();

        public class Theme
        {
            /// <summary>
            /// Theme Name consisting of the Name combined with the internal Id
            /// </summary>
            private string _Name = String.Empty;
            public string Name
            {
                get => this._Name;
                internal set => this._Name = value;
            }

            /// <summary>
            /// Theme internal Id
            /// </summary>
            public int Id { get; internal set; }

            /// <summary>
            /// Switch whether to use the regular color scheme or darkmode color scheme (inverted regular scheme)
            /// </summary>
            private bool _DarkMode = false;
            public bool DarkMode
            {
                get => _DarkMode;
                set => _DarkMode = value;
            }

            /// <summary>
            /// Available colors in the actual theme
            /// </summary>
            public int ColorCount { get; internal set; }

            /// <summary>
            /// List of colors for the regular color scheme
            /// </summary>           
            public Color[] ColorList { get; internal set; } = null!;

            /// <summary>
            /// Get a single color by index depending on the actual DarkMode setting
            /// </summary>
            /// <param name="Index"></param>
            /// <returns>Color</returns>
            public Color GetColor(int Index)
            {
                if (Index >= ColorCount)
                    Index = ColorCount - 1;
                if (Index < 0)
                    Index = 0;

                if (this.DarkMode)
                {
                    //Reverse the regular Colorscheme to get the darkest colors first
                    Color[] ColorListDark = (Color[])ColorList.Clone();
                    Array.Reverse(ColorListDark);
                    return ColorListDark[Index];
                }
                else
                    return ColorList[Index];
            }
        }

        #endregion

        #region Theme List
        /// <summary>
        /// List of all themes
        /// </summary>
        // make sure to build the colors in a theme starting from the lightest colors going up to the darkest color
        public static Theme[] ThemeList = new Theme[128]{
            new Theme() {
                Name = "Granite 1",
                Id = 1,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xA5, 0xDE, 0xF1),
                    Color.FromArgb(0x70, 0xAF, 0xCE),
                    Color.FromArgb(0x3A, 0x7B, 0x99)
                }
            },
            new Theme() {
                Name = "Lagoon 2",
                Id = 2,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xFD, 0xD0, 0x37),
                    Color.FromArgb(0x12, 0xAD, 0xC1),
                    Color.FromArgb(0x02, 0x95, 0xA9)
                }
            },
            new Theme() {
                Name = "Modernist 3",
                Id = 3,
                DarkMode = true,
                ColorCount = 3,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x1F, 0x26, 0x33),
                    Color.FromArgb(0x4E, 0x33, 0xFF)
                }
            },
            new Theme() {
                Name = "Modernist 4",
                Id = 4,
                DarkMode = false,
                ColorCount = 3,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x33, 0x26, 0x1F),
                    Color.FromArgb(0xFF, 0x33, 0x4E)
                }
            },
            new Theme() {
                Name = "Confetti 5",
                Id = 5,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x9B, 0xA4, 0xC9),
                    Color.FromArgb(0xFB, 0x46, 0x53),
                    Color.FromArgb(0x17, 0x18, 0x1C)
                }
            },
            new Theme() {
                Name = "Confetti 6",
                Id = 6,
                DarkMode = false,
                ColorCount = 6,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x62, 0xCE, 0x9D),
                    Color.FromArgb(0x3C, 0x89, 0xC7),
                    Color.FromArgb(0xE5, 0xBC, 0x18),
                    Color.FromArgb(0xE5, 0x6E, 0x24),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Confetti 7",
                Id = 7,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xA7, 0x63, 0xF6),
                    Color.FromArgb(0x69, 0x57, 0xE7),
                    Color.FromArgb(0x3A, 0x2D, 0x80)
                }
            },
            new Theme() {
                Name = "Dribble Shot 8",
                Id = 8,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF5, 0xF7, 0xFB),
                    Color.FromArgb(0x3D, 0xCF, 0xC2),
                    Color.FromArgb(0x03, 0x65, 0xD1),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Dribble Shot 9",
                Id = 9,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF7, 0xF7, 0xF7),
                    Color.FromArgb(0xDE, 0xF8, 0x87),
                    Color.FromArgb(0x6F, 0xDA, 0xE8),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Dribble Shot 10",
                Id = 10,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEC, 0xEC, 0xEA),
                    Color.FromArgb(0xF8, 0x55, 0x00),
                    Color.FromArgb(0x14, 0x3E, 0xFD),
                    Color.FromArgb(0x2A, 0x27, 0x28)
                }
            },
            new Theme() {
                Name = "Dribble Shot 11",
                Id = 11,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF5, 0xF5, 0xF5),
                    Color.FromArgb(0x55, 0xAB, 0x83),
                    Color.FromArgb(0xF0, 0x49, 0x24),
                    Color.FromArgb(0x03, 0x03, 0x03)
                }
            },
            new Theme() {
                Name = "Dribble Shot 12",
                Id = 12,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF4, 0xF8, 0xFB),
                    Color.FromArgb(0x1A, 0x9D, 0xFD),
                    Color.FromArgb(0x2F, 0x9B, 0xA4),
                    Color.FromArgb(0x0D, 0x0D, 0x0D)
                }
            },
            new Theme() {
                Name = "Blue 13",
                Id = 13,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFf),
                    Color.FromArgb(0xF6, 0xF7, 0xFC),
                    Color.FromArgb(0x6D, 0x81, 0xFE),
                    Color.FromArgb(0x23, 0x31, 0x4C)
                }
            },
            new Theme() {
                Name = "Orange 14",
                Id = 14,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xFA, 0xFA, 0xFA),
                    Color.FromArgb(0xFF, 0x95, 0x75),
                    Color.FromArgb(0x19, 0x06, 0x00)
                }
            },
            new Theme() {
                Name = "Green 15",
                Id = 15,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xF9, 0xFA, 0xFC),
                    Color.FromArgb(0x42, 0xC3, 0xA7),
                    Color.FromArgb(0x18, 0x27, 0x48)
                }
            },
            new Theme() {
                Name = "Blue 16",
                Id = 16,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xEF, 0xF4, 0xF7),
                    Color.FromArgb(0x39, 0xA2, 0xDB),
                    Color.FromArgb(0x07, 0x39, 0x44)
                }
            },
            new Theme() {
                Name = "Red 17",
                Id = 17,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xFB, 0xFB, 0xFB),
                    Color.FromArgb(0xF5, 0x47, 0x48),
                    Color.FromArgb(0x19, 0x01, 0x01)
                }
            },
            new Theme() {
                Name = "Holographic",
                Id = 18,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xED, 0xFF, 0x08),
                    Color.FromArgb(0xA8, 0xFE, 0x39),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Purple 19",
                Id = 19,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xE3, 0xE3, 0xE3),
                    Color.FromArgb(0x9A, 0x6A, 0xFF),
                    Color.FromArgb(0x1E, 0x20, 0x29)
                }
            },
            new Theme() {
                Name = "Space Pink 20",
                Id = 20,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xFF, 0x83, 0xCD),
                    Color.FromArgb(0x8B, 0xBA, 0xE9),
                    Color.FromArgb(0x17, 0x11, 0x20)
                }
            },
            new Theme() {
                Name = "Grey 21",
                Id = 21,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xF2, 0xF2, 0xF2),
                    Color.FromArgb(0xD6, 0xD6, 0xD6),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Lime 22",
                Id = 22,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xE0, 0xFF, 0x00),
                    Color.FromArgb(0xE3, 0xE3, 0xE3),
                    Color.FromArgb(0x1E, 0x20, 0x29)
                }
            },
            new Theme() {
                Name = "Multi 23",
                Id = 23,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xE5, 0xFB, 0xFD),
                    Color.FromArgb(0xE1, 0xF8, 0xF0),
                    Color.FromArgb(0x33, 0xBB, 0x91),
                    Color.FromArgb(0x2B, 0xCB, 0xE3),
                    Color.FromArgb(0x1E, 0x20, 0x29)
                }
            },
            new Theme() {
                Name = "Red 24",
                Id = 24,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0x19, 0x02, 0x07),
                    Color.FromArgb(0x5A, 0x08, 0x2D),
                    Color.FromArgb(0x9D, 0x0B, 0x28),
                    Color.FromArgb(0xFF, 0x00, 0x4D)
                 }
            },
            new Theme() {
                Name = "Brown 25",
                Id = 25,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xA8, 0x00),
                    Color.FromArgb(0x9D, 0x5A, 0x0B),
                    Color.FromArgb(0x5A, 0x39, 0x08),
                    Color.FromArgb(0x1F, 0x31, 0x01)
                }
            },
            new Theme() {
                Name = "Blue 26",
                Id = 26,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0x90, 0xB8, 0xF8),
                    Color.FromArgb(0x5F, 0x85, 0xDB),
                    Color.FromArgb(0x35, 0x39, 0x41),
                    Color.FromArgb(0x26, 0x28, 0x2B)
                }
            },
            new Theme() {
                Name = "Blue 27",
                Id = 27,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF4, 0xFC, 0xFE),
                    Color.FromArgb(0x0E, 0xA2, 0xF6),
                    Color.FromArgb(0x3D, 0x3A, 0x50),
                    Color.FromArgb(0x30, 0x30, 0x41)
                }
            },
            new Theme() {
                Name = "Green 28",
                Id = 28,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF7, 0xF7, 0xF7),
                    Color.FromArgb(0x0E, 0xF6, 0xBE),
                    Color.FromArgb(0x3A, 0x50, 0x4B),
                    Color.FromArgb(0x1E, 0x25, 0x28)
                }
            },
            new Theme() {
                Name = "Purple 29",
                Id = 29,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xE3, 0xA2, 0xEE),
                    Color.FromArgb(0xAC, 0x5F, 0xDB),
                    Color.FromArgb(0x3C, 0x35, 0x41),
                    Color.FromArgb(0x29, 0x26, 0x2B)
                }
            },
            new Theme() {
                Name = "Yellow 30",
                Id = 30,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEE, 0xEE, 0xEE),
                    Color.FromArgb(0xF6, 0xC9, 0x0E),
                    Color.FromArgb(0x3A, 0x47, 0x50),
                    Color.FromArgb(0x25, 0x2C, 0x33)
                }
            },
            new Theme() {
                Name = "Multi 31",
                Id = 31,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFE, 0xFD),
                    Color.FromArgb(0xFD, 0x76, 0xCB),
                    Color.FromArgb(0xFF, 0xAC, 0x30),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Multi 32",
                Id = 32,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xA1, 0xA7, 0xC8),
                    Color.FromArgb(0x24, 0xF9, 0xF9),
                    Color.FromArgb(0x6B, 0x9F, 0xED)
                }
            },
            new Theme() {
                Name = "Green 33",
                Id = 33,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xC0, 0xF7, 0xB7),
                    Color.FromArgb(0x5A, 0xC9, 0x94),
                    Color.FromArgb(0x12, 0x41, 0x43),
                    Color.FromArgb(0x14, 0x1B, 0x29)
                }
            },
            new Theme() {
                Name = "Brown 34",
                Id = 34,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x82, 0x52, 0x60),
                    Color.FromArgb(0x67, 0x3D, 0x4D),
                    Color.FromArgb(0x11, 0x0D, 0x0E)
                }
            },
            new Theme() {
                Name = "Multi 35",
                Id = 35,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x2E, 0xE0, 0x9A),
                    Color.FromArgb(0xEF, 0x84, 0xF5),
                    Color.FromArgb(0x15, 0x26, 0x5C)
                }
            },
            new Theme() {
                Name = "Multi 36",
                Id = 36,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xF6, 0xF6, 0xF6),
                    Color.FromArgb(0x6C, 0xC1, 0x64),
                    Color.FromArgb(0xFF, 0x55, 0x45),
                    Color.FromArgb(0x69, 0xBC, 0xEC),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Multi 37",
                Id = 37,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x7E, 0xE7, 0xD6),
                    Color.FromArgb(0xF9, 0xF4, 0x50),
                    Color.FromArgb(0xC1, 0xBF, 0xFA),
                    Color.FromArgb(0x1D, 0x1D, 0x1D)
                }
            },
            new Theme() {
                Name = "Blue 38",
                Id = 38,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xC5, 0xC7, 0xD3),
                    Color.FromArgb(0x00, 0xC0, 0xF7),
                    Color.FromArgb(0x55, 0x3A, 0xFC),
                    Color.FromArgb(0x2A, 0x32, 0x56)
                }
            },
            new Theme() {
                Name = "Blue 39",
                Id = 39,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xE5, 0xF8, 0xFC),
                    Color.FromArgb(0xD2, 0xD5, 0xDE),
                    Color.FromArgb(0x16, 0x9B, 0xD6),
                    Color.FromArgb(0x3F, 0x46, 0x85),
                    Color.FromArgb(0x1F, 0x21, 0x2A)
                }
            },
            new Theme() {
                Name = "Blue 40",
                Id = 40,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xE3, 0xE8, 0xED),
                    Color.FromArgb(0x13, 0x8F, 0xFF),
                    Color.FromArgb(0x86, 0xA2, 0xB9),
                    Color.FromArgb(0x15, 0x2C, 0x5B)
                }
            },
            new Theme() {
                Name = "Multi 41",
                Id = 41,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xF8, 0xF6),
                    Color.FromArgb(0xDD, 0xD5, 0xFC),
                    Color.FromArgb(0x13, 0x8F, 0xFF),
                    Color.FromArgb(0x86, 0xA2, 0xB9),
                    Color.FromArgb(0x15, 0x2C, 0x5B)
                }
            },
            new Theme() {
                Name = "Green 42",
                Id = 42,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xED, 0xF5, 0xE0),
                    Color.FromArgb(0x8D, 0xE4, 0xAF),
                    Color.FromArgb(0x5C, 0xDB, 0x94),
                    Color.FromArgb(0x38, 0x95, 0x83),
                    Color.FromArgb(0x05, 0x38, 0x6B)
                }
            },
            new Theme() {
                Name = "Multi 43",
                Id = 43,
                DarkMode = true,
                ColorCount = 7,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xF5, 0x4F, 0x74),
                    Color.FromArgb(0x99, 0x72, 0x84),
                    Color.FromArgb(0x3E, 0x3E, 0xB3),
                    Color.FromArgb(0x56, 0x3D, 0x67),
                    Color.FromArgb(0x24, 0x25, 0x82),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Multi 44",
                Id = 44,
                DarkMode = false,
                ColorCount = 7,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xE8, 0xA8, 0x7C),
                    Color.FromArgb(0x85, 0xCD, 0xCA),
                    Color.FromArgb(0xD9, 0x76, 0x94),
                    Color.FromArgb(0xE2, 0x7D, 0x5F),
                    Color.FromArgb(0x40, 0xB3, 0xA2),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Grey 45",
                Id = 45,
                DarkMode = true,
                ColorCount = 7,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xB0, 0xA2, 0x95),
                    Color.FromArgb(0x93, 0x8E, 0x94),
                    Color.FromArgb(0x73, 0x95, 0xAE),
                    Color.FromArgb(0x55, 0x7A, 0x95),
                    Color.FromArgb(0x5D, 0x5C, 0x61),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Green 46",
                Id = 46,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xC5, 0xC6, 0xC8),
                    Color.FromArgb(0x66, 0xFC, 0xF1),
                    Color.FromArgb(0x46, 0xA2, 0x9F),
                    Color.FromArgb(0x20, 0x28, 0x33),
                    Color.FromArgb(0x0B, 0x0C, 0x10)
                }
            },
            new Theme() {
                Name = "Red 47",
                Id = 47,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xE3, 0xE2, 0xDE),
                    Color.FromArgb(0xE3, 0xAF, 0xBC),
                    Color.FromArgb(0xEE, 0x4C, 0x7D),
                    Color.FromArgb(0x9B, 0x17, 0x50),
                    Color.FromArgb(0x5D, 0x00, 0x1D)
                }
            },
            new Theme() {
                Name = "Multi 48",
                Id = 48,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xEF, 0xE1, 0xBA),
                    Color.FromArgb(0xC5, 0xCB, 0xE3),
                    Color.FromArgb(0xD7, 0x99, 0x22),
                    Color.FromArgb(0xED, 0x3B, 0x17),
                    Color.FromArgb(0x40, 0x56, 0xA1)
                }
            },
            new Theme() {
                Name = "Green 49",
                Id = 49,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xCA, 0xFA, 0xFE),
                    Color.FromArgb(0x40, 0xEE, 0xE5),
                    Color.FromArgb(0x96, 0xCA, 0xEF),
                    Color.FromArgb(0x55, 0xBD, 0xCA),
                    Color.FromArgb(0xFC, 0x44, 0x44)
                }
            },
            new Theme() {
                Name = "Dark Neon 50",
                Id = 50,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEE, 0xED, 0xF0),
                    Color.FromArgb(0xCB, 0x69, 0xC1),
                    Color.FromArgb(0x6C, 0x72, 0xCB),
                    Color.FromArgb(0x17, 0x18, 0x1F)
                }
            },
            new Theme() {
                Name = "Commerce 51",
                Id = 51,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xFA, 0xFC, 0xFE),
                    Color.FromArgb(0x57, 0xBE, 0x6C),
                    Color.FromArgb(0x10, 0x10, 0x10)
                }
            },
            new Theme() {
                Name = "Blue 52",
                Id = 52,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xF8, 0xF8, 0xFA),
                    Color.FromArgb(0x34, 0x56, 0xFF),
                    Color.FromArgb(0x07, 0x09, 0x28)
                }
            },
            new Theme() {
                Name = "Black&White 53",
                Id = 53,
                DarkMode = false,
                ColorCount = 3,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xE8, 0xE8, 0xEA),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Orange 54",
                Id = 54,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xFA, 0xFA, 0xFB),
                    Color.FromArgb(0xFD, 0x79, 0x4F),
                    Color.FromArgb(0x13, 0x13, 0x13)
                }
            },
            new Theme() {
                Name = "Pastel 55",
                Id = 55,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0x40, 0x8A, 0x8B),
                    Color.FromArgb(0xF3, 0xC6, 0xC0),
                    Color.FromArgb(0xA5, 0x6F, 0x65),
                    Color.FromArgb(0x32, 0x2D, 0x2A)
                }
            },
            new Theme() {
                Name = "Moss 56",
                Id = 56,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0x00, 0xE0, 0xC8),
                    Color.FromArgb(0x00, 0x93, 0x93),
                    Color.FromArgb(0x01, 0x61, 0x70)
                }
            },
            new Theme() {
                Name = "Cabana 57",
                Id = 57,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xD9, 0x60),
                    Color.FromArgb(0xD7, 0x41, 0x5D),
                    Color.FromArgb(0x20, 0x95, 0xF2),
                    Color.FromArgb(0x23, 0x6A, 0xD6)
                }
            },
            new Theme() {
                Name = "Multi 58",
                Id = 58,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xCA, 0xD7, 0xD9),
                    Color.FromArgb(0x41, 0xBE, 0xD4),
                    Color.FromArgb(0x07, 0x89, 0xA4),
                    Color.FromArgb(0xF1, 0xC3, 0x6D),
                    Color.FromArgb(0x25, 0x42, 0x43)
                }
            },
            new Theme() {
                Name = "Brown 59",
                Id = 59,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xF5, 0xCB, 0x63),
                    Color.FromArgb(0xFE, 0xAA, 0x42),
                    Color.FromArgb(0xC4, 0x84, 0x83),
                    Color.FromArgb(0x7C, 0x6B, 0x7E),
                    Color.FromArgb(0x30, 0x40, 0x4F)
                }
            },
            new Theme() {
                Name = "Green 60",
                Id = 60,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xC3, 0xDD, 0xDE),
                    Color.FromArgb(0xA5, 0xD1, 0xD4),
                    Color.FromArgb(0x78, 0xA8, 0xAC),
                    Color.FromArgb(0x2F, 0x77, 0x73),
                    Color.FromArgb(0xFE, 0xB6, 0x00)
                }
            },
            new Theme() {
                Name = "Brown 61",
                Id = 61,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xF3, 0xF3, 0xF3),
                    Color.FromArgb(0xD9, 0xB6, 0xAA),
                    Color.FromArgb(0xFA, 0xA9, 0x71),
                    Color.FromArgb(0xE6, 0x76, 0x69),
                    Color.FromArgb(0x85, 0x4C, 0x62)
                }
            },
            new Theme() {
                Name = "Brown 62",
                Id = 62,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xEE, 0xEE, 0xDD),
                    Color.FromArgb(0xED, 0xD9, 0xBB),
                    Color.FromArgb(0xCA, 0xBC, 0x9D),
                    Color.FromArgb(0xDC, 0x96, 0x66),
                    Color.FromArgb(0x4D, 0x30, 0x14)
                }
            },
            new Theme() {
                Name = "Candle 63",
                Id = 63,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xC1, 0xB9, 0xAE),
                    Color.FromArgb(0xFC, 0xC6, 0x66),
                    Color.FromArgb(0xFA, 0x8D, 0x70),
                    Color.FromArgb(0x73, 0x60, 0x7C)
                }
            },
            new Theme() {
                Name = "Green 64",
                Id = 64,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFB, 0xFB, 0xF3),
                    Color.FromArgb(0xD7, 0xCF, 0xFE),
                    Color.FromArgb(0xC8, 0xF4, 0xC3),
                    Color.FromArgb(0x0B, 0xAB, 0x7B)
                }
            },
            new Theme() {
                Name = "Multi 65",
                Id = 65,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xE9, 0xED, 0xF1),
                    Color.FromArgb(0xFF, 0xD8, 0x41),
                    Color.FromArgb(0x3D, 0x73, 0xDD),
                    Color.FromArgb(0x0E, 0x20, 0x45)
                }
            },
            new Theme() {
                Name = "Multi 66",
                Id = 66,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFC, 0xEE, 0xE3),
                    Color.FromArgb(0xF8, 0xF1, 0xFF),
                    Color.FromArgb(0xCC, 0xF9, 0xF2),
                    Color.FromArgb(0x86, 0x49, 0xFC)
                }
            },
            new Theme() {
                Name = "Grey 67",
                Id = 67,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xED, 0xEE, 0xF2),
                    Color.FromArgb(0xFA, 0x5D, 0x3A),
                    Color.FromArgb(0x4A, 0x4B, 0x4F),
                    Color.FromArgb(0x40, 0x40, 0x41)
                }
            },
            new Theme() {
                Name = "Grey 68",
                Id = 68,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF6, 0xF6, 0xF6),
                    Color.FromArgb(0xDC, 0xE6, 0xFF),
                    Color.FromArgb(0xCD, 0xD0, 0xD9),
                    Color.FromArgb(0xFF, 0x7A, 0x5B)
                }
            },
            new Theme() {
                Name = "Multi 69",
                Id = 69,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xDA, 0xDA),
                    Color.FromArgb(0xC6, 0xE6, 0xFF),
                    Color.FromArgb(0xFF, 0x9A, 0x0D),
                    Color.FromArgb(0x78, 0x6E, 0xF9)
                }
            },
            new Theme() {
                Name = "Grey 70",
                Id = 70,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xE5, 0xE2, 0xDB),
                    Color.FromArgb(0xDE, 0xE9, 0xE5),
                    Color.FromArgb(0xFF, 0xD4, 0x81),
                    Color.FromArgb(0x11, 0x11, 0x11)
                }
            },
            new Theme() {
                Name = "Grey 71",
                Id = 71,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF1, 0xF2, 0xED),
                    Color.FromArgb(0xD5, 0xDF, 0xE8),
                    Color.FromArgb(0x56, 0x75, 0x6D),
                    Color.FromArgb(0x2F, 0x2F, 0x2F)
                }
            },
            new Theme() {
                Name = "Multi 72",
                Id = 72,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0x9B, 0x92),
                    Color.FromArgb(0xFF, 0x70, 0x66),
                    Color.FromArgb(0x55, 0xAF, 0xDC),
                    Color.FromArgb(0x21, 0x74, 0xB4),
                    Color.FromArgb(0x2A, 0x36, 0x5D)
                }
            },
            new Theme() {
                Name = "Multi 73",
                Id = 73,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xF6, 0xF5, 0xEE),
                    Color.FromArgb(0xFB, 0xEB, 0x45),
                    Color.FromArgb(0xD0, 0xD0, 0xD0),
                    Color.FromArgb(0xEA, 0xB4, 0xE3),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Grey 74",
                Id = 74,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xF8, 0xF3, 0xED),
                    Color.FromArgb(0xF6, 0xF5, 0xEE),
                    Color.FromArgb(0xD0, 0xD0, 0xD0),
                    Color.FromArgb(0xCA, 0x97, 0x5E),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Blue 75",
                Id = 75,
                DarkMode = false,
                ColorCount = 7,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xE1, 0xF0, 0xF9),
                    Color.FromArgb(0xD3, 0xF8, 0xFB),
                    Color.FromArgb(0x00, 0xCF, 0xDE),
                    Color.FromArgb(0x1D, 0x3C, 0xD0),
                    Color.FromArgb(0x01, 0x24, 0x5E),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Gotham 76",
                Id = 76,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEA, 0xEB, 0xED),
                    Color.FromArgb(0xC2, 0x7D, 0xFC),
                    Color.FromArgb(0x6E, 0x5D, 0xCF),
                    Color.FromArgb(0x24, 0x3B, 0x67)
                }
            },
            new Theme() {
                Name = "Tangerine 77",
                Id = 77,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xD1, 0x81),
                    Color.FromArgb(0xFF, 0xAB, 0x41),
                    Color.FromArgb(0xFF, 0x92, 0x01),
                    Color.FromArgb(0xFF, 0x6D, 0x00)
                }
            },
            new Theme() {
                Name = "Grove 78",
                Id = 78,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xE9, 0xEB, 0xED),
                    Color.FromArgb(0xAE, 0xD3, 0x6C),
                    Color.FromArgb(0x69, 0xAB, 0x3D),
                    Color.FromArgb(0x29, 0x5D, 0x09)
                }
            },
            new Theme() {
                Name = "Embers 79",
                Id = 79,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0x96, 0x77),
                    Color.FromArgb(0xF5, 0x47, 0x68),
                    Color.FromArgb(0x97, 0x40, 0x63),
                    Color.FromArgb(0x41, 0x43, 0x6A)
                }
            },
            new Theme() {
                Name = "Sunset 80",
                Id = 80,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0x75, 0x82),
                    Color.FromArgb(0xC5, 0x6D, 0x86),
                    Color.FromArgb(0x72, 0x5A, 0x7A),
                    Color.FromArgb(0x35, 0x5C, 0x7D)
                }
            },
            new Theme() {
                Name = "Blue 81",
                Id = 81,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xD9, 0xEF, 0xF7),
                    Color.FromArgb(0x9B, 0xBB, 0xFC),
                    Color.FromArgb(0xF9, 0xCE, 0x69),
                    Color.FromArgb(0x47, 0x41, 0xA6)
                }
            },
            new Theme() {
                Name = "Green 82",
                Id = 82,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEA, 0xF9, 0xE7),
                    Color.FromArgb(0xC0, 0xE6, 0xBA),
                    Color.FromArgb(0x4C, 0xA7, 0x71),
                    Color.FromArgb(0x01, 0x32, 0x37)
                }
            },
            new Theme() {
                Name = "Red 83",
                Id = 83,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF6, 0xE8, 0xDF),
                    Color.FromArgb(0xFE, 0xAE, 0x96),
                    Color.FromArgb(0xFE, 0x97, 0x9C),
                    Color.FromArgb(0x01, 0x32, 0x37)
                }
            },
            new Theme() {
                Name = "Multi 84",
                Id = 84,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFC, 0xDC, 0x73),
                    Color.FromArgb(0xE7, 0x62, 0x86),
                    Color.FromArgb(0x4F, 0xAD, 0xC0),
                    Color.FromArgb(0x19, 0x39, 0x48)
                }
            },
            new Theme() {
                Name = "Blue 85",
                Id = 85,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0x60, 0xCB, 0xFF),
                    Color.FromArgb(0x36, 0x64, 0xF4),
                    Color.FromArgb(0xE8, 0x53, 0x53),
                    Color.FromArgb(0x25, 0x25, 0x25)
                }
            },
            new Theme() {
                Name = "Multi 86",
                Id = 86,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF8, 0xB0, 0x97),
                    Color.FromArgb(0x77, 0xAC, 0xB7),
                    Color.FromArgb(0x3F, 0xC4, 0x95),
                    Color.FromArgb(0x1A, 0x1A, 0x1A)
                }
            },
            new Theme() {
                Name = "Multi  87",
                Id = 87,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xC2, 0xE7, 0xC9),
                    Color.FromArgb(0xF2, 0xAC, 0x20),
                    Color.FromArgb(0x42, 0x65, 0xD6),
                    Color.FromArgb(0x29, 0x38, 0x55)
                }
            },
            new Theme() {
                Name = "Blue Gradient 88",
                Id = 88,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x3A, 0xB5, 0xE2),
                    Color.FromArgb(0x33, 0x9C, 0xC7),
                    Color.FromArgb(0x2C, 0x84, 0xAB),
                    Color.FromArgb(0x25, 0x6B, 0x90),
                    Color.FromArgb(0x1F, 0x53, 0x74),
                    Color.FromArgb(0x18, 0x3A, 0x59),
                    Color.FromArgb(0x11, 0x22, 0x3D),
                    Color.FromArgb(0x0A, 0x09, 0x22)
                }
            },
            new Theme() {
                Name = "Purple Gradient 89",
                Id = 89,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0xB5, 0x3A, 0xE2),
                    Color.FromArgb(0x9C, 0x33, 0xC7),
                    Color.FromArgb(0x84, 0x2C, 0xAB),
                    Color.FromArgb(0x6B, 0x25, 0x90),
                    Color.FromArgb(0x53, 0x1F, 0x74),
                    Color.FromArgb(0x3A, 0x18, 0x59),
                    Color.FromArgb(0x22, 0x11, 0x3D),
                    Color.FromArgb(0x09, 0x0A, 0x22)
                }
            },
            new Theme() {
                Name = "Lime Gradient 90",
                Id = 90,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0xB5, 0xE2, 0x3A),
                    Color.FromArgb(0x9C, 0xC7, 0x33),
                    Color.FromArgb(0x84, 0xAB, 0x2C),
                    Color.FromArgb(0x6B, 0x90, 0x25),
                    Color.FromArgb(0x53, 0x74, 0x1F),
                    Color.FromArgb(0x3A, 0x59, 0x18),
                    Color.FromArgb(0x22, 0x3D, 0x11),
                    Color.FromArgb(0x09, 0x22, 0x0A)
                }
            },
            new Theme() {
                Name = "Yellow Gradient 91",
                Id = 91,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0xE2, 0xB5, 0x3A),
                    Color.FromArgb(0xC7, 0x9C, 0x33),
                    Color.FromArgb(0xAB, 0x84, 0x2C),
                    Color.FromArgb(0x90, 0x6B, 0x25),
                    Color.FromArgb(0x74, 0x53, 0x1F),
                    Color.FromArgb(0x59, 0x3A, 0x18),
                    Color.FromArgb(0x3D, 0x22, 0x11),
                    Color.FromArgb(0x22, 0x09, 0x0A)
                }
            },
            new Theme() {
                Name = "Purple Gradient 92",
                Id = 92,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0xE2, 0x3A, 0xB5),
                    Color.FromArgb(0xC7, 0x33, 0x9C),
                    Color.FromArgb(0xAB, 0x2C, 0x84),
                    Color.FromArgb(0x90, 0x25, 0x6B),
                    Color.FromArgb(0x74, 0x1F, 0x53),
                    Color.FromArgb(0x59, 0x18, 0x3A),
                    Color.FromArgb(0x3D, 0x11, 0x22),
                    Color.FromArgb(0x22, 0x0A, 0x09)
                }
            },
            new Theme() {
                Name = "Red Gradient 93",
                Id = 93,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0xE3, 0x41, 0x3B),
                    Color.FromArgb(0xC7, 0x39, 0x34),
                    Color.FromArgb(0xAC, 0x31, 0x2D),
                    Color.FromArgb(0x90, 0x29, 0x26),
                    Color.FromArgb(0x74, 0x21, 0x1E),
                    Color.FromArgb(0x58, 0x19, 0x17),
                    Color.FromArgb(0x3D, 0x11, 0x10),
                    Color.FromArgb(0x21, 0x09, 0x09)
                }
            },
            new Theme() {
                Name = "Green Gradient 94",
                Id = 94,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x41, 0xE3, 0x3B),
                    Color.FromArgb(0x39, 0xC7, 0x34),
                    Color.FromArgb(0x31, 0xAC, 0x2D),
                    Color.FromArgb(0x29, 0x90, 0x26),
                    Color.FromArgb(0x21, 0x74, 0x1E),
                    Color.FromArgb(0x19, 0x58, 0x17),
                    Color.FromArgb(0x11, 0x3D, 0x10),
                    Color.FromArgb(0x09, 0x21, 0x09)
                }
            },
            new Theme() {
                Name = "Blue Gradient 95",
                Id = 95,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x3B, 0x41, 0xE3),
                    Color.FromArgb(0x34, 0x39, 0xC7),
                    Color.FromArgb(0x2D, 0x31, 0xAC),
                    Color.FromArgb(0x26, 0x29, 0x90),
                    Color.FromArgb(0x1E, 0x21, 0x74),
                    Color.FromArgb(0x17, 0x19, 0x58),
                    Color.FromArgb(0x10, 0x11, 0x3D),
                    Color.FromArgb(0x09, 0x09, 0x21)
                }
            },
            new Theme() {
                Name = "Green Gradient 96",
                Id = 96,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x3B, 0xE3, 0x3B),
                    Color.FromArgb(0x34, 0xC7, 0x36),
                    Color.FromArgb(0x2D, 0xAC, 0x30),
                    Color.FromArgb(0x26, 0x90, 0x2B),
                    Color.FromArgb(0x1E, 0x74, 0x26),
                    Color.FromArgb(0x17, 0x58, 0x21),
                    Color.FromArgb(0x10, 0x3D, 0x1B),
                    Color.FromArgb(0x09, 0x21, 0x16)
                }
            },
            new Theme() {
                Name = "Grey Gradient 97",
                Id = 97,
                DarkMode = true,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0xFE, 0xFE, 0xFE),
                    Color.FromArgb(0xDA, 0xDA, 0xDA),
                    Color.FromArgb(0xB6, 0xB6, 0xB6),
                    Color.FromArgb(0x92, 0x92, 0x92),
                    Color.FromArgb(0x6D, 0x6D, 0x6D),
                    Color.FromArgb(0x49, 0x49, 0x49),
                    Color.FromArgb(0x25, 0x25, 0x25),
                    Color.FromArgb(0x01, 0x01, 0x01)
                }
            },
            new Theme() {
                Name = "Green Blue Gradient 98",
                Id = 98,
                DarkMode = false,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x07, 0xCF, 0x00),
                    Color.FromArgb(0x0A, 0xB1, 0x1E),
                    Color.FromArgb(0x0D, 0x94, 0x3B),
                    Color.FromArgb(0x10, 0x76, 0x59),
                    Color.FromArgb(0x13, 0x59, 0x76),
                    Color.FromArgb(0x16, 0x3B, 0x94),
                    Color.FromArgb(0x19, 0x1E, 0xB1),
                    Color.FromArgb(0x1C, 0x00, 0xCF)
                }
            },
            new Theme() {
                Name = "Green Red Gradient 99",
                Id = 99,
                DarkMode = false,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x07, 0xCF, 0x00),
                    Color.FromArgb(0x24, 0xB1, 0x04),
                    Color.FromArgb(0x40, 0x94, 0x08),
                    Color.FromArgb(0x5D, 0x76, 0x0C),
                    Color.FromArgb(0x79, 0x59, 0x10),
                    Color.FromArgb(0x96, 0x3B, 0x14),
                    Color.FromArgb(0xB2, 0x1E, 0x18),
                    Color.FromArgb(0xCF, 0x00, 0x1C)
                }
            },
            new Theme() {
                Name = "Blue Red Gradient 100",
                Id = 100,
                DarkMode = false,
                ColorCount = 8,
                ColorList = new Color[] {
                    Color.FromArgb(0x1C, 0x00, 0xCF),
                    Color.FromArgb(0x36, 0x00, 0xB5),
                    Color.FromArgb(0x4F, 0x00, 0x9C),
                    Color.FromArgb(0x69, 0x00, 0x82),
                    Color.FromArgb(0x82, 0x00, 0x69),
                    Color.FromArgb(0x9C, 0x00, 0x4F),
                    Color.FromArgb(0xB5, 0x00, 0x36),
                    Color.FromArgb(0xCF, 0x00, 0x1C)
                }
            },
            new Theme() {
                Name = "Ocean 101",
                Id = 101,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEE, 0xD8, 0xCB),
                    Color.FromArgb(0x4A, 0xB4, 0xDE),
                    Color.FromArgb(0x3B, 0x8A, 0xC3),
                    Color.FromArgb(0x34, 0x5E, 0xA8)
                }
            },
            new Theme() {
                Name = "Petals 102",
                Id = 102,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF0, 0xD7, 0x94),
                    Color.FromArgb(0xFF, 0xBA, 0xC4),
                    Color.FromArgb(0xFF, 0xA1, 0x97),
                    Color.FromArgb(0xFA, 0xBD, 0x70)
                }
            },
            new Theme() {
                Name = "Sailing 103",
                Id = 103,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xE9, 0xEE, 0xF2),
                    Color.FromArgb(0x78, 0xA6, 0xC8),
                    Color.FromArgb(0x32, 0x67, 0x89),
                    Color.FromArgb(0xE6, 0x5C, 0x4F)
                }
            },
            new Theme() {
                Name = "Multi 104",
                Id = 104,
                DarkMode = false,
                ColorCount = 5,
                ColorList = new Color[] {
                    Color.FromArgb(0xF8, 0xED, 0x6D),
                    Color.FromArgb(0xEF, 0x88, 0x5D),
                    Color.FromArgb(0xB7, 0x3A, 0x5C),
                    Color.FromArgb(0x6B, 0x2D, 0x70),
                    Color.FromArgb(0x3B, 0xA6, 0xBA)
                }
            },
            new Theme() {
                Name = "Haze 105",
                Id = 105,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xC8, 0xCE, 0xFF),
                    Color.FromArgb(0x84, 0xB7, 0xFE),
                    Color.FromArgb(0x25, 0x8B, 0xD6),
                    Color.FromArgb(0x0F, 0x6B, 0xAC)
                }
            },
            new Theme() {
                Name = "Periwinkle 106",
                Id = 106,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xAE, 0xED, 0xE2),
                    Color.FromArgb(0xA3, 0xDC, 0xEF),
                    Color.FromArgb(0xA2, 0xB9, 0xED),
                    Color.FromArgb(0x9A, 0x9C, 0xE9)
                }
            },
            new Theme() {
                Name = "Slate 107",
                Id = 107,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xEA, 0xEB, 0xED),
                    Color.FromArgb(0x98, 0xDA, 0xD9),
                    Color.FromArgb(0x58, 0x82, 0x91),
                    Color.FromArgb(0x2E, 0x42, 0x4D)
                }
            },
            new Theme() {
                Name = "Orange 108",
                Id = 108,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xF1, 0xED, 0xE5),
                    Color.FromArgb(0xE4, 0x60, 0x36),
                    Color.FromArgb(0x00, 0x00, 0x00)
                }
            },
            new Theme() {
                Name = "Multi 109",
                Id = 109,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF3, 0xEC, 0xE4),
                    Color.FromArgb(0xED, 0x70, 0x61),
                    Color.FromArgb(0x56, 0x9E, 0x34),
                    Color.FromArgb(0x50, 0x5D, 0x7D)
                }
            },
            new Theme() {
                Name = "Grey 110",
                Id = 110,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xFF, 0xFF, 0xFF),
                    Color.FromArgb(0xDF, 0xDF, 0xDF),
                    Color.FromArgb(0xAA, 0xAA, 0xAA),
                    Color.FromArgb(0xFC, 0x57, 0x23)
                }
            },
            new Theme() {
                Name = "Gold 111",
                Id = 111,
                DarkMode = false,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xE5, 0xE2, 0xDB),
                    Color.FromArgb(0xDE, 0xE9, 0xE5),
                    Color.FromArgb(0xFF, 0xD4, 0x81),
                    Color.FromArgb(0x11, 0x11, 0x11)
                }
            },
            new Theme() {
                Name = "Blue 112",
                Id = 112,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF3, 0xEC, 0xDE),
                    Color.FromArgb(0xEC, 0xDC, 0xF4),
                    Color.FromArgb(0x1E, 0x56, 0xC3),
                    Color.FromArgb(0x27, 0x29, 0x32)
                }
            },
            new Theme() {
                Name = "Neon 113",
                Id = 113,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0xF7, 0xF8, 0xF6),
                    Color.FromArgb(0xD3, 0xDD, 0xDA),
                    Color.FromArgb(0xD7, 0xF2, 0x66),
                    Color.FromArgb(0x15, 0x15, 0x14)
                }
            },
            new Theme() {
                Name = "Multi 114",
                Id = 114,
                DarkMode = true,
                ColorCount = 4,
                ColorList = new Color[] {
                    Color.FromArgb(0x8E, 0xC9, 0x7B),
                    Color.FromArgb(0xF7, 0x91, 0x93),
                    Color.FromArgb(0x24, 0x6B, 0xFD),
                    Color.FromArgb(0x23, 0x19, 0x34)
                }
            },
            new Theme() {
                Name = "Gradient 115",
                Id = 115,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x53, 0xC0, 0xEE), Color.FromArgb(0x52, 0x33, 0xCE), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 116",
                Id = 116,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x8E, 0xEE, 0x53), Color.FromArgb(0x33, 0x55, 0xCE), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 117",
                Id = 117,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0xEE, 0xC3, 0x53), Color.FromArgb(0xEE, 0x53, 0x53), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 118",
                Id = 118,
                DarkMode = true,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x01, 0x95, 0xB9), Color.FromArgb(0x0C, 0x3E, 0x58), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 119",
                Id = 119,
                DarkMode = true,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x00, 0x4E, 0x92), Color.FromArgb(0x00, 0x04, 0x28), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 120",
                Id = 120,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0xBD, 0xC3, 0xC7), Color.FromArgb(0x2C, 0x3E, 0x50), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 121",
                Id = 121,
                DarkMode = true,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x00, 0x4E, 0xB2), Color.FromArgb(0x00, 0x04, 0x72), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 122",
                Id = 122,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x6D, 0xD5, 0xFA), Color.FromArgb(0x29, 0x80, 0xB9), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 123",
                Id = 123,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x34, 0xE8, 0x9E), Color.FromArgb(0x0F, 0x34, 0x43), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 124",
                Id = 124,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0xEA, 0xEC, 0xC6), Color.FromArgb(0x2B, 0xC0, 0xE4), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 125",
                Id = 125,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0xEA, 0x52, 0xF8), Color.FromArgb(0x00, 0x66, 0xFF), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 126",
                Id = 126,
                DarkMode = false,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0xFF, 0xE0, 0x00), Color.FromArgb(0x79, 0x9F, 0x0C), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 127",
                Id = 127,
                DarkMode = true,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0x43, 0xC6, 0xAC), Color.FromArgb(0x19, 0x16, 0x54), 8).ColorList
            },
            new Theme() {
                Name = "Gradient 128",
                Id = 128,
                DarkMode = true,
                ColorCount = 8,
                ColorList = GetThemeByGradient(Color.FromArgb(0xFC, 0xF6, 0xCF), Color.FromArgb(0xFF, 0x88, 0x6A), 8).ColorList
            }
        };
        #endregion

        #region Functions
        /// <summary>
        /// Get a Theme by its Id
        /// </summary>
        /// <param name="Id">Theme Id Number</param>
        /// <returns>Theme or on error first default Theme</returns>
        public static Theme GetThemeById(int Id)
        {
            Theme? theme = null;
            if (Id < 1)
                Id = 1;
            if (Id > ThemeList.Length)
                Id = ThemeList.Length;
            foreach (Theme _theme in ThemeList)
            {
                if (_theme.Id == Id)
                {
                    theme = _theme;
                    break;
                }
            }
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                theme = ThemeList[0];
#endif
            }
            return theme;
        }

        /// <summary>
        ///  Get a Theme by its Name
        /// </summary>
        /// <param name="Name">Theme Name String</param>
        /// <returns>Theme or on error first default Theme</returns>
        public static Theme GetThemeByName(string Name)
        {
            Theme? theme = null;
            foreach (Theme _theme in ThemeList)
            {
                if (_theme.Name == Name)
                {
                    theme = _theme;
                    break;
                }
            }
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                theme = ThemeList[0];
                theme.DarkMode = false;
#endif
            }
            return theme;
        }

        /// <summary>
        /// Get a single Color from a Theme by its Name, DarkMode setting and the index in the color list
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="ColorIndex"></param>
        /// <param name="DarkMode"></param>
        /// <returns>Color value</returns>
        /// <exception cref="Exception">Theme is null</exception>
        internal static Color GetThemeColor(Theme theme, int ColorIndex, bool DarkMode)
        {
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                if (DarkMode)
                    return Color.Black;
                else
                    return Color.White;
#endif
            }
            theme.DarkMode = DarkMode;
            return theme.GetColor(ColorIndex);
        }

        /// <summary>
        /// Get a single Color from a Theme by its Name, DarkMode setting and the index in the color list
        /// </summary>
        /// <param name="ThemeName">Theme Name String</param>
        /// <param name="ColorIndex">Color Index starting at 0</param>
        /// <param name="DarkMode">DarkMode setting</param>
        /// <returns>Requested Color value or in error case black/white depending on DarkMode setting</returns>
        /// <exception cref="Exception">Theme is null</exception>
        public static Color GetThemeColor(string ThemeName, int ColorIndex, bool DarkMode)
        {
            Theme? theme = GetThemeByName(ThemeName);
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                if (DarkMode)
                    return Color.Black;
                else
                    return Color.White;
#endif
            }
            return GetThemeColor(theme, ColorIndex, DarkMode);
        }

        /// <summary>
        /// Get a single Color from a Theme by its Name, DarkMode setting and the index in the color list
        /// </summary>
        /// <param name="ThemeId"></param>
        /// <param name="ColorIndex">Color Index starting at 0</param>
        /// <param name="DarkMode">DarkMode setting</param>
        /// <returns>Requested Color value or in error case black/white depending on DarkMode setting</returns>
        /// <exception cref="Exception">Theme is null</exception>
        public static Color GetThemeColor(int ThemeId, int ColorIndex, bool DarkMode)
        {
            Theme? theme = GetThemeById(ThemeId);
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                if (DarkMode)
                    return Color.Black;
                else
                    return Color.White;
#endif
            }
            return GetThemeColor(theme, ColorIndex, DarkMode);
        }

        /// <summary>
        /// Get a single Color from a Theme by its Id and the index in the color list
        /// using the active DarkMode setting
        /// </summary>
        /// <param name="ThemeId"></param>
        /// <param name="ColorIndex">Color Index starting at 0</param>
        /// <returns>Requested Color value or in error case black/white depending on DarkMode setting</returns>
        public static Color GetThemeColor(int ThemeId, int ColorIndex)
        {
            return GetThemeColor(ThemeId, ColorIndex, GetThemeById(ThemeId).DarkMode);
        }

        /// <summary>
        /// Get a single Color from a Theme by its Name and the index in the color list
        /// using the active DarkMode setting
        /// </summary>
        /// <param name="ThemeName">Theme Name String</param>
        /// <param name="ColorIndex">Color Index starting at 0</param>
        /// <returns>Requested Color value or in error case black/white depending on DarkMode setting</returns>
        public static Color GetThemeColor(string ThemeName, int ColorIndex)
        {
            Theme? theme = GetThemeByName(ThemeName);
            if (theme == null)
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                return GetThemeColor(1, 0, false);
#endif
            else
                return GetThemeColor(ThemeName, ColorIndex, theme.DarkMode);
        }

        /// <summary>
        /// Get the Color count from a Theme by its Name
        /// </summary>
        /// <param name="ThemeName">Theme Name String</param>
        /// <returns>Number of available Colors</returns>
        /// <exception cref="Exception">Theme is null</exception>
        public static int GetThemeColorCount(string ThemeName)
        {
            Theme? theme = GetThemeByName(ThemeName);
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                return -1;
#endif
            }
            return theme.ColorCount;
        }

        /// <summary>
        /// Get the Color count from a Theme by its Id
        /// </summary>
        /// <param name="ThemeId">Theme Id</param>
        /// <returns>Number of available Colors</returns>
        /// <exception cref="Exception">Theme is null</exception>
        public static int GetThemeColorCount(int ThemeId)
        {
            Theme? theme = GetThemeById(ThemeId);
            if (theme == null)
            {
#if DEBUG
                throw new Exception("Exception: Theme is null");
#else
                return -1;
#endif
            }
            return theme.ColorCount;
        }

        /// <summary>
        /// List all available Themes by Name
        /// </summary>
        /// <param name="SortAtoZ">list alphabetically sorted</param>
        /// <param name="ColorCount">include color count of the theme</param>
        /// <returns>String list with Theme names</returns>
        public static List<string> GetThemeNames(bool SortAtoZ = true, bool ShowColorCount = true)
        {
            List<string> list = new List<string>();
            foreach (Theme theme in ThemeList)
            {
                if (ShowColorCount)
                    list.Add(theme.Name + " [" + theme.ColorCount.ToString() + "]");
                else
                    list.Add(theme.Name);
            }
            if (SortAtoZ)
                list.Sort((x, y) => string.Compare(x, y));
            return list;
        }

        /// <summary>
        /// List all available Themes by Name and by their Color Count
        /// </summary>
        /// <param name="ColorCount">Color count which is needed to show the theme in the list</param>
        /// <param name="ColorCountAsMin">List also themes which have more Colors than the given count</param>
        /// <param name="SortAtoZ">list alphabetically sorted</param>
        /// <param name="ColorCount">include color count of the theme</param>
        /// <returns>String list with Theme names</returns>
        public static List<string> GetThemeNamesByColorCount(int ColorCount, bool ColorCountAsMin = false, bool SortAtoZ = true, bool ShowColorCount = true)
        {
            List<string> list = new List<string>();
            foreach (Theme theme in ThemeList)
            {
                if ((theme.ColorCount == ColorCount && !ColorCountAsMin) || (theme.ColorCount >= ColorCount && ColorCountAsMin))
                {
                    if (ShowColorCount)
                        list.Add(theme.Name + " [" + theme.ColorCount.ToString() + "]");
                    else
                        list.Add(theme.Name);
                }
            }
            if (SortAtoZ)
                list.Sort((x, y) => string.Compare(x, y));
            return list;
        }

        /// <summary>
        /// Generate a theme by 2 gradient colors
        /// </summary>
        /// <param name="Start">Start Color of Gradient</param>
        /// <param name="End">End Color of Gradient</param>
        /// <param name="ColorCount">Color count between 2 to 8 colors</param>
        /// <param name="Name">optional Name for the generated theme</param>
        /// <returns>Theme</returns>
        public static Theme GetThemeByGradient(Color Start, Color End, int ColorCount, string Name = "GradientTheme 1")
        {
            //allow only between 2 and 8 theme colors
            if (ColorCount < 2)
                ColorCount = 2;
            if (ColorCount > 8)
                ColorCount = 8;

            //create temporary color list starting with the start color
            List<Color> GradientColors = new List<Color>(ColorCount);
            GradientColors.Add(Start);
            for (int i = 1; i < ColorCount - 1; i++)
            {
                GradientColors.Add(Color.Black);
            }

            //get RGB values of start and end color and calculate step size
            double SA = Start.A;
            double SR = Start.R;
            double SG = Start.G;
            double SB = Start.B;
            double EA = End.A;
            double ER = End.R;
            double EG = End.G;
            double EB = End.B;
            double StepA = Math.Abs(SA - EA) / (ColorCount - 1);
            double StepR = Math.Abs(SR - ER) / (ColorCount - 1);
            double StepG = Math.Abs(SG - EG) / (ColorCount - 1);
            double StepB = Math.Abs(SB - EB) / (ColorCount - 1);

            //fill color list with gradient colors
            for (int i = 1; i < ColorCount - 1; i++)
            {
                if (EA > SA)
                    EA -= StepA;
                else
                    EA += StepA;
                if (ER > SR)
                    ER -= StepR;
                else
                    ER += StepR;
                if (EG > SG)
                    EG -= StepG;
                else
                    EG += StepG;
                if (EB > SB)
                    EB -= StepB;
                else
                    EB += StepB;
                GradientColors[ColorCount - i - 1] = Color.FromArgb((byte)EA, (byte)ER, (byte)EG, (byte)EB);
            }

            //add end color as last color
            GradientColors.Add(End);

            //return theme with gradient colors
            return new Theme()
            {
                Name = Name,
                Id = 1,
                DarkMode = false,
                ColorCount = ColorCount,
                ColorList = GradientColors.ToArray()
            };
        }

        /// <summary>
        /// Generate a theme by 3 gradient colors
        /// </summary>
        /// <param name="Start">Start Color of Gradient</param>
        /// <param name="Center">Center Color of Gradient</param>
        /// <param name="End">End Color of Gradient</param>
        /// <param name="Name">optional Name for the generated theme</param>
        /// <returns>Theme</returns>
        public static Theme GetThemeByGradient(Color Start, Color Center, Color End, string Name = "GradientTheme 1")
        {
            //create temporary color list starting with the start color
            List<Color> GradientColors = new List<Color>(7);
            GradientColors.Add(Start);
            for (int i = 1; i < 6; i++)
            {
                GradientColors.Add(Color.Black);
            }

            //get RGB values of start and center color and calculate step size
            double SA = Start.A;
            double SR = Start.R;
            double SG = Start.G;
            double SB = Start.B;
            double EA = Center.A;
            double ER = Center.R;
            double EG = Center.G;
            double EB = Center.B;
            double StepA = Math.Abs(SA - EA) / 3;
            double StepR = Math.Abs(SR - ER) / 3;
            double StepG = Math.Abs(SG - EG) / 3;
            double StepB = Math.Abs(SB - EB) / 3;

            //fill color list with gradient colors
            for (int i = 1; i < 3; i++)
            {
                if (EA > SA)
                    EA -= StepA;
                else
                    EA += StepA;
                if (ER > SR)
                    ER -= StepR;
                else
                    ER += StepR;
                if (EG > SG)
                    EG -= StepG;
                else
                    EG += StepG;
                if (EB > SB)
                    EB -= StepB;
                else
                    EB += StepB;
                GradientColors[3 - i] = Color.FromArgb((byte)EA, (byte)ER, (byte)EG, (byte)EB);
            }

            //add center color
            GradientColors[3] = Center;

            //get RGB values of center and end color and calculate step size
            SA = Center.A;
            SR = Center.R;
            SG = Center.G;
            SB = Center.B;
            EA = End.A;
            ER = End.R;
            EG = End.G;
            EB = End.B;
            StepA = Math.Abs(SA - EA) / 3;
            StepR = Math.Abs(SR - ER) / 3;
            StepG = Math.Abs(SG - EG) / 3;
            StepB = Math.Abs(SB - EB) / 3;

            //fill color list with gradient colors
            for (int i = 3; i < 6; i++)
            {
                if (EA > SA)
                    EA -= StepA;
                else
                    EA += StepA;
                if (ER > SR)
                    ER -= StepR;
                else
                    ER += StepR;
                if (EG > SG)
                    EG -= StepG;
                else
                    EG += StepG;
                if (EB > SB)
                    EB -= StepB;
                else
                    EB += StepB;
                GradientColors[8 - i] = Color.FromArgb((byte)EA, (byte)ER, (byte)EG, (byte)EB);
            }

            //add end color as last color
            GradientColors.Add(End);

            //return theme with gradient colors
            return new Theme()
            {
                Name = Name,
                Id = 1,
                DarkMode = false,
                ColorCount = 7,
                ColorList = GradientColors.ToArray()
            };
        }

        #endregion
    }
}
