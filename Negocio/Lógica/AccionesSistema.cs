using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Lógica;
using Negocio.Manejo_de_datos;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using Negocio.Properties;
using DevComponents.DotNetBar;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using DevComponents.DotNetBar.Controls;

namespace Negocio.Lógica
{
    public class AccionesSistema
    {
        #region Atributos
        private static long id_sucursal = 0;
        private static long id_permisos = 0;
        private static long id_usuario = 0;
        public static long Id_usuario { get { return id_usuario; } set { id_usuario = value; } }
        public static long Id_sucursal { get { return id_sucursal; } set { id_sucursal = value; } }
        public static long Id_permisos
        {
            get { return id_permisos; }
            set { id_permisos = value; }
        }

        #endregion

        #region Propiedades

        #endregion

        #region Acciones
        public static String addSeparadoresLong(long n)
        {
            String retorno = n + "";
            for (int i = 3; i < retorno.Length - (i - 3) / 3; i += 3)
            {
                String p1 = retorno.Substring(0, retorno.Length - (i + (i - 3) / 3));
                String p2 = retorno.Substring(retorno.Length - (i + (i - 3) / 3), (i + (i - 3) / 3));
                retorno = p1 + "." + p2;
            }
            return retorno;

        }
        public static String addSpaces(String str, int max)
        {
            if (str.Length >= max)
                str= str.Substring(0, max-1);
            for (int i = str.Length; i < max; i++)
                str += " ";
            return str;
        }

        public static String addSpaces(long lng, int max)
        {

            String str = lng.ToString();
            if (str.Length >= max)
            {
                str = "";
                for (int i = 1; i <= max - 1; i++)
                    str += "9";
            }

            return addSpaces(str, max);
        }

        public static String addSpacesPrice(long lng, int max)
        {

            String str = addSeparadoresLong(lng);
            if (str.Length >= max)
            {
                long nmb = 0;
                for (int i = 0; i < lng.ToString().Length; i++)
                    nmb += Convert.ToInt64(Math.Round(9*Math.Pow(10, i)));
                String s = addSeparadoresLong(nmb);
                str = s.Substring(s.Length - (max - 1), max - 1);
            }

            return "$" + str;
        }
        public static List<string> SelectSexo()
        {
            List<string> lst = new List<string>();
            lst.Add("Hombre");
            lst.Add("Mujer");
            lst.Add("Otro");
            lst.Add("Prefiere no especificarlo");
            return lst;
        }
        public static object ObtenerValorSelecion(DataGridViewX sender, int column)
        {
            if (sender.SelectedRows.Count == 1)
            {
                try
                {
                    return sender.CurrentRow.Cells[column].Value;
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else if (sender.SelectedCells.Count >= 1)
            {
                return ObtenerValorSelecionCelda(sender, column);
            }
            else
            {
                MessageBox.Show("Selección Incorrecta", "Business Optimizer");
            }
            return 0;

        }
        static object ObtenerValorSelecionCelda(DataGridViewX sender, int column)
        {
            int Row = sender.SelectedCells[0].RowIndex;
            try
            {
                return sender[column, Row].Value.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); };
            return 0;

        }
        public static void RemoverSelecion(DataGridViewX sender)
        {
            try
            {
                if (sender.SelectedRows.Count == 1)
                {
                    sender.Rows.Remove(sender.CurrentRow);
                }
                else if (sender.SelectedCells.Count >= 1)
                    sender.Rows.Remove(sender.Rows[sender.SelectedCells[0].RowIndex]);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public static void DialogoImagen(string pTitulo, PictureBox pbImagen)
        {
            OpenFileDialog OpenMedia = new OpenFileDialog();
            OpenMedia.InitialDirectory = Environment.SpecialFolder.CommonMusic.ToString();
            OpenMedia.FileName = "";
            OpenMedia.Title = "Business Optimizer - "+pTitulo;
            OpenMedia.Multiselect = false;
            OpenMedia.Filter = "Archivo de Imagen (*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG;)|*.GIF;*.BMP;*.JPEG;*.PNG;*.TIF;*.TIFF;*.JPG";
            if (OpenMedia.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(OpenMedia.FileName);
                pbImagen.Tag = OpenMedia.FileName;
            }
        }
        public static void ShowToast(string texto, Control control)
        {
            ToastNotification.Show(control.Parent,
                        texto, null,
                        2000,
                        eToastGlowColor.Blue,
                        eToastPosition.BottomCenter);
        }
        public static bool TagIsNull(object tag)
        {
            try
            {
                string tg = tag.ToString();
                return false;
            }
            catch
            {
                return true;
            }
        }
        public static Byte[] ConvertirImagen(Image value)
        {
            MemoryStream MemS = new MemoryStream();
            value.Save(MemS, ImageFormat.Png);
            return MemS.GetBuffer();
        }
        public static Image ObtenerImagen(object value)
        {
            Byte[] DatosImg = (Byte[])value;
            MemoryStream MemS = new MemoryStream(DatosImg);
            return Image.FromStream(MemS);
        }
        public static Image CropToCircle(Image srcImage, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            }
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
        }
        public static void CropImage(Image pic, PictureBox pbImage)
        {
            int s = (pic.Height < pic.Width ? pic.Height : pic.Width);
            int x = (pic.Width == s ? 0 : (pic.Width - s) / 2);
            int y = (pic.Height == s ? 0 : (pic.Height - s) / 2);
            Rectangle section = new Rectangle(new Point(x, y), new Size(s, s));
            Image bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(pic, 0, 0, section, GraphicsUnit.Pixel);
            pbImage.Image = CropToCircle(bmp, Color.Transparent);

        }
        public static void ShowToolTimInvaide(string text, Control sender)
        {
            Balloon ball = new Balloon();
            ball.Style = eBallonStyle.Balloon;
            ball.CaptionText = "Error de validación";
            ball.Text = "\t" + text;
            ball.AlertAnimation = eAlertAnimation.TopToBottom;
            ball.Font = new Font("Segoe UI Light", 8F);
            ball.CaptionFont = new Font("Segoe UI Light", 10F);
            ball.AutoResize();
            ball.AutoClose = true;
            ball.AutoCloseTimeOut = 4;
            ball.BackColor = Color.FromArgb(0, 102, 204);
            ball.ForeColor = Color.White;
            ball.CaptionColor = Color.WhiteSmoke;
            ball.BorderColor = Color.White;

            ball.Owner = GetFormParent(sender);
            ball.Show(sender, false);

        }
        public static Form GetFormParent(Control sender)
        {
            Control retorno = sender;
            while (true)
            {
                try
                {
                    Form temp = (Form)retorno;
                    break;
                }
                catch { }
                try
                {
                    retorno = retorno.Parent;
                }
                catch
                {
                    break;
                }
            }
            return (Form)retorno;
        }
        #endregion
    }
}
