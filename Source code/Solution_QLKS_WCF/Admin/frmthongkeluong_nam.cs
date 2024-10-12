﻿using Admin.BUS;
using Admin.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmthongkeluong_nam : Form
    {
        TcpClient tcpclient;
        Thread t1;
        frmSystem frm;
        int nam;
        bool kt = false;

        public frmthongkeluong_nam(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmthongkeluong_nam_Load(object sender, EventArgs e)
        {
            numeryear.Value = DateTime.Now.Year;
            reportViewer1.Visible = false;
            DataSet_luong.EnforceConstraints = false;
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
            BUS_Login.DAO.themsocket(frm.user.Trim());
            t1 = new Thread(() =>
            {
                while (true)
                {
                    Stream stream = tcpclient.GetStream();
                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);
                    writer.AutoFlush = true;
                    String content = reader.ReadLine();
                    if (content == "dangxuat")
                    {
                        Invoke(new Action(() =>
                        {
                            this.Close();
                        }));
                    }
                    else
                    {
                        if (content == "nhapdichvu")
                        {
                            Invoke(new Action(() =>
                            {
                                if (kt)
                                {
                                    thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                    reportViewer1.RefreshReport();
                                }
                            }));
                        }
                        else
                        {
                            if (content == "tinhluong")
                            {
                                Invoke(new Action(() =>
                                {
                                    if (kt)
                                    {
                                        thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                        reportViewer1.RefreshReport();
                                    }
                                }));
                            }
                            else
                            {
                                if (content == "xoaluong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        if (kt)
                                        {
                                            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                            reportViewer1.RefreshReport();
                                        }
                                    }));
                                }
                                else
                                {
                                    if (content == "capnhapluong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            if (kt)
                                            {
                                                thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                reportViewer1.RefreshReport();
                                            }
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoanv")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                if (kt)
                                                {
                                                    thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                    reportViewer1.RefreshReport();
                                                }
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "capnhapnv")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    if (kt)
                                                    {
                                                        thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                        reportViewer1.RefreshReport();
                                                    }
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "xoadonvi")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        if (kt)
                                                        {
                                                            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                            reportViewer1.RefreshReport();
                                                        }
                                                    }));
                                                }
                                                else
                                                {
                                                    if (content == "xoaloaiphong")
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            if (kt)
                                                            {
                                                                thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                reportViewer1.RefreshReport();
                                                            }
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content == "sualoaiphong")
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                if (kt)
                                                                {
                                                                    thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                    reportViewer1.RefreshReport();
                                                                }
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content == "xoaphong")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                    {
                                                                        thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                        reportViewer1.RefreshReport();
                                                                    }
                                                                }));
                                                            }
                                                            else
                                                            {
                                                                if (content == "suaphong")
                                                                {
                                                                    Invoke(new Action(() =>
                                                                    {
                                                                        if (kt)
                                                                        {
                                                                            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                            reportViewer1.RefreshReport();
                                                                        }
                                                                    }));
                                                                }
                                                                else
                                                                {
                                                                    if (content == "xoadichvu")
                                                                    {
                                                                        Invoke(new Action(() =>
                                                                        {
                                                                            if (kt)
                                                                            {
                                                                                thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                reportViewer1.RefreshReport();
                                                                            }
                                                                        }));
                                                                    }
                                                                    else
                                                                    {
                                                                        if (content == "suadichvu")
                                                                        {
                                                                            Invoke(new Action(() =>
                                                                            {
                                                                                if (kt)
                                                                                {
                                                                                    thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                    reportViewer1.RefreshReport();
                                                                                }
                                                                            }));
                                                                        }
                                                                        else
                                                                        {
                                                                            if (content == "xoakhachhang")
                                                                            {
                                                                                Invoke(new Action(() =>
                                                                                {
                                                                                    if (kt)
                                                                                    {
                                                                                        thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                        reportViewer1.RefreshReport();
                                                                                    }
                                                                                }));
                                                                            }
                                                                            else
                                                                            {
                                                                                if (content.Contains("thuephongkc"))
                                                                                {
                                                                                    Invoke(new Action(() =>
                                                                                    {
                                                                                        if (kt)
                                                                                        {
                                                                                            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                            reportViewer1.RefreshReport();
                                                                                        }
                                                                                    }));
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (content.Contains("thuephongkm"))
                                                                                    {
                                                                                        Invoke(new Action(() =>
                                                                                        {
                                                                                            if (kt)
                                                                                            {
                                                                                                thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                reportViewer1.RefreshReport();
                                                                                            }
                                                                                        }));
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (content == "chuyenphong")
                                                                                        {
                                                                                            Invoke(new Action(() =>
                                                                                            {
                                                                                                if (kt)
                                                                                                {
                                                                                                    thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                    reportViewer1.RefreshReport();
                                                                                                }
                                                                                            }));
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (content.Contains("goidv"))
                                                                                            {
                                                                                                Invoke(new Action(() =>
                                                                                                {
                                                                                                    if (kt)
                                                                                                    {
                                                                                                        thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                        reportViewer1.RefreshReport();
                                                                                                    }
                                                                                                }));
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (content.Contains("capnhapdvhd"))
                                                                                                {
                                                                                                    Invoke(new Action(() =>
                                                                                                    {
                                                                                                        if (kt)
                                                                                                        {
                                                                                                            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                            reportViewer1.RefreshReport();
                                                                                                        }
                                                                                                    }));
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (content.Contains("xoadvhd"))
                                                                                                    {
                                                                                                        Invoke(new Action(() =>
                                                                                                        {
                                                                                                            if (kt)
                                                                                                            {
                                                                                                                thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                                reportViewer1.RefreshReport();
                                                                                                            }
                                                                                                        }));
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (content.Contains("huyhd"))
                                                                                                        {
                                                                                                            Invoke(new Action(() =>
                                                                                                            {
                                                                                                                if (kt)
                                                                                                                {
                                                                                                                    thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                                    reportViewer1.RefreshReport();
                                                                                                                }
                                                                                                            }));
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (content.Contains("thanhtoan"))
                                                                                                            {
                                                                                                                Invoke(new Action(() =>
                                                                                                                {
                                                                                                                    if (kt)
                                                                                                                    {
                                                                                                                        thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                                        reportViewer1.RefreshReport();
                                                                                                                    }
                                                                                                                }));
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (content.Contains("themnv"))
                                                                                                                {
                                                                                                                    Invoke(new Action(() =>
                                                                                                                    {
                                                                                                                        if (kt)
                                                                                                                        {
                                                                                                                            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                                            reportViewer1.RefreshReport();
                                                                                                                        }
                                                                                                                    }));
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (content.Contains("capnhapnv"))
                                                                                                                    {
                                                                                                                        Invoke(new Action(() =>
                                                                                                                        {
                                                                                                                            if (kt)
                                                                                                                            {
                                                                                                                                thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);
                                                                                                                                reportViewer1.RefreshReport();
                                                                                                                            }
                                                                                                                        }));
                                                                                                                    }
                                                                                                                }    
                                                                                                            }    
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
            t1.Start();
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            kt = true;
            nam = (int)numeryear.Value;
            thongkeluongnamBindingSource.DataSource = Program.qlks.thongkeluong_nam(nam);

            this.reportViewer1.RefreshReport();
        }

        private void frmthongkeluong_nam_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}