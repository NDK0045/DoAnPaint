using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using DoAnPaint.Utils;
using DoAnPaint.Model;



namespace DoAnPaint.Presenter
{

    /// Interface xử lý yêu cầu thao tác dữ liệu từ người dùng

    interface PresenterDraw
    {
 
        /// Phương thức vẽ một hình lên graphic g
  
        /// <param name="g"></param>
        void getDrawing(Graphics g);


        /// Phương thức xử lý hạ chuột từ người dùng

        /// <param name="p"></param>
        void onClickMouseDown(Point p);


        /// Phương thức xử di chuyển chuột từ người dùng

        /// <param name="p"></param>
        void onClickMouseMove(Point p);

        /// Phương thức xử thả chuột từ người dùng
 
        void onClickMouseUp();


        /// Phương thức gọi vẽ đường thẳng

        void onClickDrawLine();


        /// Phương thức gọi vẽ hình chữ nhật

        void onClickDrawRectangle();

    
        /// Phương thức gọi vẽ hình ellipse
  
        void onClickDrawEllipse();


        /// Phương thức gọi vẽ đường cong

        void onClickDrawBezier();

 
        /// Phương thức gọi vẽ polygon
 
        void onClickDrawPolygon();


        /// Phương thức gọi vẽ pen

        void onClickDrawPen();


        /// Phương thức gọi vẽ xóa

        void onClickDrawEraser();


        /// Phương thức xử lý chuột phải từ người dùng
 
        /// <param name="mouse"></param>
        void onClickStopDrawing(MouseButtons mouse);

    }
}
