using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork.Context;
using DataAccess.Concrete.EntityFrameWork.Repository;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //RentACarContext context = new RentACarContext();
            _carService = new CarManager(new EfCarDal());
            _colorService = new ColorManager(new EfColorDal());
            _brandService = new BrandManager(new EfBrandDal());
            _rentalService = new RentalManager(new EfRentalDal());
           

        }
        readonly IRentalService _rentalService;
        readonly ICarService _carService;
        readonly IColorService _colorService;
        readonly IBrandService _brandService;
        //DataGridViewButtonColumn rent;
        //DataGridViewButtonColumn receive;


       // Car _selectedCar;
        List<Car> cars;

        List<CarDetailDto> carsDto;

        void LoadCars()
        {

            dgwAllCars.DataSource = null;
            dgwAllCars.Rows.Clear();
            dgwAllCars.Columns.Clear();

            cars = _carService.GetAll().Data;
            carsDto = _carService.GetCarDetails().Data.ToList();
            
            dgwAllCars.DataSource = carsDto;
            dgwAllCars.Columns[0].Visible = false;
            
        }

        private void CreateColumnButton()
        {
            DataGridViewButtonColumn rent = new DataGridViewButtonColumn();
            
            rent.HeaderText = "Rent";
            rent.Text = "Rent";
            rent.Name = "Rent";
            rent.UseColumnTextForButtonValue = true;
            rent.FlatStyle = FlatStyle.Popup;
            rent.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGreen;

            DataGridViewButtonColumn receive = new DataGridViewButtonColumn();
            receive.HeaderText = "Receive";
            receive.Text = "Receive";
            receive.Name = "Receive";
            receive.UseColumnTextForButtonValue = true;
            receive.FlatStyle = FlatStyle.Popup;
            receive.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGreen;

            //Butonu table (kolon) olarak ekliyoruz
            dgwAllCars.Columns.Add(rent);
            dgwAllCars.Columns.Add(receive);
        }

        private void CheckRentVisible(List<CarDetailDto> data)
        {
            int i = 0;
            foreach (var item in data)
            {

                var result = _rentalService.IsNotRented(item.Id);
                if (result.Success)
                {
                    dgwAllCars.Rows[i].Cells["Rent"].Style.BackColor = System.Drawing.Color.PaleGreen;
                    dgwAllCars.Rows[i].Cells["Rent"].Value = 1;
                    dgwAllCars.Rows[i].Cells["Receive"].Style.BackColor = System.Drawing.Color.Orange;
                    dgwAllCars.Rows[i].Cells["Receive"].Value = 0;

                    i += 1;

                }
                else
                {
                    dgwAllCars.Rows[i].Cells["Rent"].Style.BackColor = System.Drawing.Color.Orange;
                    dgwAllCars.Rows[i].Cells["Rent"].Value = 0;
                    dgwAllCars.Rows[i].Cells["Receive"].Style.BackColor = System.Drawing.Color.PaleGreen;
                    dgwAllCars.Rows[i].Cells["Receive"].Value = 1;
                    i += 1;
                }


            }
        }

        void LoadColors()
        {
            List<Entities.Concrete.Color> colors = _colorService.GetAll().Data.ToList();

            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "ColorName";
            comboBox1.DataSource = colors;
            comboBox1.SelectedIndex = -1;

            cbxColorAdd.ValueMember = "Id";
            cbxColorAdd.DisplayMember = "ColorName";
            cbxColorAdd.DataSource = colors;
            cbxColorAdd.SelectedIndex = -1;

            cbxColorUpdate.ValueMember = "Id";
            cbxColorUpdate.DisplayMember = "ColorName";
            cbxColorUpdate.DataSource = colors;
            cbxColorUpdate.SelectedIndex = -1;


        }

        void LoadBrands()
        {
            List<Brand> brands = _brandService.GetAll().Data.ToList();

            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "BrandName";
            comboBox2.DataSource = brands;
            comboBox2.SelectedIndex = -1;


            cbxBrandAdd.ValueMember = "Id";
            cbxBrandAdd.DisplayMember = "BrandName";
            cbxBrandAdd.DataSource = brands;
            cbxBrandAdd.SelectedIndex = -1;


            cbxBrandUpdate.ValueMember = "Id";
            cbxBrandUpdate.DisplayMember = "BrandName";
            cbxBrandUpdate.DataSource = brands;
            cbxBrandUpdate.SelectedIndex = -1;

        }

        void GetCarDetailsByColorId(int colorId)
        {
            var result = _carService.GetCarDetailsByColorId(colorId).Data.ToList();
            dgwAllCars.DataSource = result;
            CheckRentVisible(result);
        }

        void GetCarDetailsByBrandId(int brandId)
        {
            var result = _carService.GetCarDetailsByBrandId(brandId).Data.ToList();
            dgwAllCars.DataSource = result;
            CheckRentVisible(result);

        }

        //void ShowCount() => lblCarsCount.Content = lvCars.Items.Count;

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCars();
            LoadBrands();
            LoadColors();
            CreateColumnButton();
            CheckRentVisible(carsDto);



        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            // Do something here
            var result = comboBox1.SelectedIndex;
            var result2 = comboBox1.SelectedValue;
            int x = Convert.ToInt32(comboBox1.SelectedValue);
            GetCarDetailsByColorId((int)comboBox1.SelectedValue);


        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            // Do something here
            var result = comboBox2.SelectedIndex;
            var result2 = comboBox2.SelectedValue;
            int x = Convert.ToInt32(comboBox2.SelectedValue);
            GetCarDetailsByBrandId((int)comboBox2.SelectedValue);
        }

        private void dgwAllCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwAllCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (dgwAllCars.Columns.Count - 2))//check whether is it button column or not.....
            {
                MessageBox.Show("Success");
            }
        }

        private void btnClrFilter_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            LoadCars();
            CreateColumnButton();
            CheckRentVisible(carsDto);

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtDailyPriceAdd.Text, out decimal dailyprice);
            int.TryParse(txtModelYearAdd.Text, out int modelYear);

            Car car = new Car
            {
                BrandId = (int)cbxBrandAdd.SelectedValue,
                ColorId = (int)cbxColorAdd.SelectedValue,
                DailyPrice = dailyprice,
                ModelYear = modelYear.ToString(),
                Descriptions = txtCarDetailsAdd.Text,
                
            };
            var result = _carService.Add(car);
            if (result.Success)
            {

                MessageBox.Show("Ekleme işlemi başarılı");
                LoadCars();
                
                ClearInsertField();
            }
            else
            {
                MessageBox.Show("Ekleme işlemi başarısız",result.Message,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        void ClearUpdateField()
        {
            txtDailyPriceUpdate.Text = null;
            txtCarDetailsUpdate.Text = null;
            txtModelYearUpdate.Text = null;
            
        }
        void ClearInsertField()
        {
            txtDailyPriceAdd.Text = null;
            txtCarDetailsAdd.Text = null;
            txtModelYearAdd.Text = null;
        }
    }
}