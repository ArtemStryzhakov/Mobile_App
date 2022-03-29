using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise : ContentPage
    {
        Picker picker, picker_2;
        StackLayout st;
        Image img;
        string[] imgs;
        public Exercise()
        {
            List<string> maakonnad = new List<string>() { 
                "Ida-Virumaa", "Jõgevamaa", "Harjumaa", "Järvamaa", "Raplamaa",
                "Läänemaa", "Pärnumaa", "Viljandimaa", "Valgamaa", "Võrumaa",
                "Põlvamaa", "Tartumaa", "Lääne-Virumaa", "Hiiumaa", "Saaremaa"};
            List<string> linnad = new List<string>() {
                "Jõhvi", "Jõgeva", "Tallinn", "Paide", "Rapla",
                "Haapsalu", "Pärnu", "Viljandi", "Valga", "Võru",
                "Põlva", "Tartu", "Rakvere", "Valga", "Võru"};

            imgs = new string[] {
                "https://static.visitestonia.com/images/3657330/600_400_false_false_534c64463ee718c06869b23da5c5bb20.jpg",
                "https://content.r9cdn.net/rimg/dimg/01/48/8c7a3db3-city-31491-1696eb0153f.jpg?width=1200&height=630&crop=true",
                "https://image.shutterstock.com/image-photo/tallinn-harjumaa-estonia-europe-06072018-600w-1108455782.jpg",
                "http://limnoloogilinetutvustus.weebly.com/uploads/7/4/2/0/7420382/2496689.jpg?1352391361",
                "https://parnu.treraadio.ee/img/uploads/Rapla/Jalase_raba.png",
                "https://infoviking.ee/wp-content/uploads/2022/01/Laanemaa-vaatamisvaarsus.jpg",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""
            };

            img = new Image { Source = $"{imgs[0]}" };

            picker = new Picker
            {
                Title = "Maakonnad"
            };

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            picker_2 = new Picker
            {
                Title = "Linnad"
            };

            picker_2.SelectedIndexChanged += Picker_2_SelectedIndexChanged;

            st = new StackLayout { Children = { picker, picker_2, img} };
            //sb = new StackLayout { Children = { btn2 } };
            Content = st;

            for (int i = 0; i < maakonnad.Count; i++)
            {
                picker.Items.Add(maakonnad[i]);
                picker_2.Items.Add(linnad[i]);
            }
        }

        private void Picker_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker.SelectedIndex = picker_2.SelectedIndex;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker_2.SelectedIndex = picker.SelectedIndex;
        }
    }
}