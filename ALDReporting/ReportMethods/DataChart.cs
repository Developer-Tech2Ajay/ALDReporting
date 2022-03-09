using System;
using System.Data;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace ALDReporting.ReportMethods
{
    public class DataChart
    {
        private readonly DataTable _dtForGraph;
        private readonly DataTable _dtForGraphCondition;
        private readonly int _parameterBatchSelect;

        public DataChart() { }

        public DataChart(Chart chartProcess, DataTable dtForGraph, DataTable dtForGraphCondition, int parameterBatchSelect)
        {
            _dtForGraph = (dtForGraph).Copy();
            _dtForGraphCondition = dtForGraphCondition;
            _parameterBatchSelect = parameterBatchSelect;
            try
            {
                //Remove unwanted column
                RemoveNotReqiredColumn();
                var maxY2Values = "0.00E+0";
                chartProcess.Series.Clear();
                chartProcess.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;


                foreach (DataColumn dc in _dtForGraph.Columns)
                {
                    if (dc.ColumnName != "ProcessDate")
                    {
                        chartProcess.Series.Add(dc.ColumnName);
                        chartProcess.Series[dc.ColumnName].ChartType = SeriesChartType.Spline;
                        foreach (DataRow item in _dtForGraph.Rows)
                        {
                            var x = Convert.ToString(item["ProcessDate"]).Split(' ')[1];
                            var y = Convert.ToString(item[dc.ColumnName]);

                            if (y != "0.00E+0")
                                maxY2Values = y;
                            DataPoint point = new DataPoint();
                            point.SetValueXY(x, y);
                            point.ToolTip = string.Format("{0}, {1}", Convert.ToString(item["ProcessDate"]), y);
                            chartProcess.Series[dc.ColumnName].Points.Add(point);
                        }
                    }

                }

                chartProcess.ChartAreas[0].AxisY2.LabelStyle.Format = "0.00E+0";
                chartProcess.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chartProcess.ChartAreas[0].AxisX.LabelStyle.Interval = 2;
                chartProcess.ChartAreas[0].AxisX.Title = StaticValues.ProcessChart_xAxis;
                chartProcess.ChartAreas[0].AxisY.Title = StaticValues.ProcessChart_yAxis;
                chartProcess.ChartAreas[0].AxisY2.Title = StaticValues.ProcessChart_y2Axis;

                chartProcess.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                chartProcess.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

                chartProcess.Series[0].YAxisType = AxisType.Secondary;
                for (int i = 0; i < chartProcess.Series.Count(); i++)
                    chartProcess.Series[i].BorderWidth = 3;
                chartProcess.Legends["Legend1"].Docking = Docking.Bottom;
                chartProcess.DataSource = dtForGraph;
                chartProcess.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private DataTable RemoveNotReqiredColumn()
        {
            if (_dtForGraph.Columns["SrNo"] != null)
                _dtForGraph.Columns.Remove("SrNo");
            if (_dtForGraph.Columns["ProfileStatus"] != null)
                _dtForGraph.Columns.Remove("ProfileStatus");
            string strPressUnitSelect = Convert.ToString(_dtForGraphCondition.Rows[0]["Press_Unit_Select"]).ToLower();
            if (strPressUnitSelect == StaticValues.PressUnitSelect_mBar)
            {
                if (_dtForGraph.Columns["PressTorr"] != null)
                    _dtForGraph.Columns.Remove("PressTorr");
                if (_dtForGraph.Columns["PressPa"] != null)
                    _dtForGraph.Columns.Remove("PressPa");
            }
            else if (strPressUnitSelect == StaticValues.PressUnitSelect_pa)
            {
                if (_dtForGraph.Columns["PressmBar"] != null)
                    _dtForGraph.Columns.Remove("PressmBar");
                if (_dtForGraph.Columns["PressTorr"] != null)
                    _dtForGraph.Columns.Remove("PressTorr");
            }
            else if (strPressUnitSelect == StaticValues.PressUnitSelect_Torr)
            {
                if (_dtForGraph.Columns["PressmBar"] != null)
                    _dtForGraph.Columns.Remove("PressmBar");
                if (_dtForGraph.Columns["PressPa"] != null)
                    _dtForGraph.Columns.Remove("PressPa");
            }
            if (_dtForGraph.Columns["EventName"] != null)
                _dtForGraph.Columns.Remove("EventName");
            for (int i = _parameterBatchSelect; i < StaticValues.MaxTC_Select; i++)
            {
                if (_dtForGraph.Columns["Control" + (i + 1)] != null)
                    _dtForGraph.Columns.Remove("Control" + (i + 1));
            }
            return _dtForGraph;
        }
    }
}
