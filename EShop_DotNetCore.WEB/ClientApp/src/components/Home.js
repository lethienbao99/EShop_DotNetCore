import React, { Component } from 'react';
import "./Home.css";
import insidesclass from "../Images/insidesclass.png"

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <section className="infor">
      <div className="detail">
        <h4>Điểm nổi bật của xe</h4>
        <hr/>
        <h2>Hãy trải nghiệm những đặc tính đầy hấp dẫn</h2>
        <p>
          S-className Sedan kết hợp thế giới làm việc và sinh sống ở mức cao nhất.
          Vật liệu , không gian nội thất và chất lượng gia công trong nội thất
          sẽ đáp ứng nhu cầu đa dạng về một chiếc xe Saloon sang trọng. Ngoài
          ra, DNA của S-className còn bao gồm việc trình diễn những cải tiến công
          nghệ chưa từng tồn tại trong bất kỳ chiếc ô tô nào.
        </p>

        <div className="divngoai">
          <div className="imgde">
            <div className="img1">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
          </div>

          <div className="img23">
            <div className="img2infor">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
            <div className="img3infor">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
          </div>
        </div>
      </div>

      <div className="detail">
        <h4>Thiết kế</h4>
        <hr/>
        <h2>Hãy thể hiện, bạn là ai. Chứ không phải, bạn có gì.</h2>
        <p>
          Bạn hãy trải nghiệm thiết kế ngoại thất và nội thất độc đáo của mẫu xe
          S-className Saloon.
        </p>

        <div className="divngoai">
          <div className="imgde">
            <div className="img1">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
            <div>
              <p className="designdetail">Về thiết kế ngoại thất</p>
            </div>
          </div>

          <div className="imgde">
            <div className="img1">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
            <div>
              <p className="designdetail">Về thiết kế nội thất</p>
            </div>
          </div>
        </div>
      </div>

      <div className="detail">
        <h4>Tiện nghi</h4>
        <hr/>
        <h2>Tiện nghi tối đa để tập trung cao độ nhất.</h2>
        <p>
          Như một vận động viên điền kinh có thể cân bằng mọi thay đổi về chuyển
          động với cơ thể mình một cách tự nhiên, hệ thống MAGIC BODY CONTROL
          với chức năng nghiêng khi vào cua sẽ tự động phản ứng với các lực gia
          tốc ở những khúc cua. Điều này và nhiều cải tiến khác sẽ biến các
          chuyến đi của hành khách trong chiếc S-className Saloon trở nên tiện nghi
          hơn.
        </p>

        <div className="divngoai">
          <div className="imgde">
            <div className="img1">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
          </div>

          <div className="comfortlist">
            <h3>Các điểm nổi bật về tiện nghi:</h3>
            <ul>
              <li>Chương trình lái xe DYNAMIC SELECT</li>
              <li>AIRMATIC</li>
              <li>MAGIC BODY CONTROL</li>
            </ul>
          </div>
        </div>
      </div>

      <div className="detail">
        <h4>An toàn</h4>
        <hr/>
        <h2>Tiện nghi thoải mái ở mức cao nhất.</h2>
        <p>
          Xe S-className Saloon nắm bắt vùng xung quanh chính xác hơn và tầm nhìn xa
          hơn. Nó có thể phản ứng nhanh hơn và do đó giảm nguy hiểm nhiều hơn
          ngay từ đầu. Trên hết, nó giảm căng thẳng cho người lái và người ngồi
          trên xe hiệu quả hơn bao giờ hết.
        </p>

        <div className="divngoai">
          <div className="safelist">
            <h3>Các điểm nổi bật về an toàn:</h3>
            <ul>
              <li>PRE-SAFE® Impulse</li>
              <li>Màn hiển thị Head-up-Display</li>
              <li>Đèn pha MULTIBEAM LED với tính năng chiếu xa ULTRA RANGE</li>
            </ul>
          </div>

          <div className="imgde">
            <div className="img1">
              <img width="100%" src={insidesclass} alt="hinh1" />
            </div>
          </div>
        </div>
      </div>
    </section>
    );
  }
}
