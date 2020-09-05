import React, { Component } from "react";
import "./Footer.css";
import tiennghi from "../Images/sclass_tiennghi.png";

export class Footer extends Component {
  static displayName = Footer.name;
  render() {
    return (
      <div className="footnav">
        <nav>
          <ul>
            <div>
              <li>
                <img src={tiennghi} alt="banggiaxe" />
                Bảng giá xe
                <a href="#">&gt;</a>
              </li>
            </div>
            <div>
              <li>
                <img src={tiennghi} alt="lienhe" />
                Liên hệ
                <a href="#">&gt;</a>
              </li>
            </div>
            <div>
              <li>
                {" "}
                <img src={tiennghi} alt="timdaily" />
                Tìm đại lý
                <a href="#">&gt;</a>
              </li>
            </div>
            <div>
              <li>
                <img src={tiennghi} alt="laithuxe" />
                Lái thử xe
                <a href="#">&gt;</a>
              </li>
            </div>
          </ul>
        </nav>
      </div>
    );
  }
}
