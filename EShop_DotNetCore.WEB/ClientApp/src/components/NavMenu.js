import React, { Component } from "react";
import logo from "../Images/mercedeslogo.svg";
import {
  Collapse,
  Container,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  NavItem,
  NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";
import "./NavMenu.css";

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor(props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true,
    };
  }

  toggleNavbar() {
    this.setState({
      collapsed: !this.state.collapsed,
    });
  }
  render() {
    return (
      <header className="header">
        <div className="header1">
          <div className="headline">
            <div className="logo">
              <img src={logo} alt={logo} />
            </div>
            <div className="slogan">
              <h3>Mercedes-Benz</h3>
              <h4>The best or nothing.</h4>
            </div>
          </div>
          <hr />
          <nav>
            <ul>
              <li>
                <a href="#">
                  <i className="fa fa-car"></i> Các dòng xe
                </a>
              </li>
              <li>
                <a href="#">Dịch vụ, phụ tùng và phụ kiện </a>
              </li>
              <li>
                <a href="#">Mua xe Mercedes-Benz </a>
              </li>
              <li>
                <a href="#">Thế giới Mercedes </a>
              </li>
              <li>
                <a href="#">Mercedes-Benz Việt Nam </a>
              </li>
            </ul>
          </nav>

          <div className="navb">
            <ul id="navbarr">
              <li>
                <a href="#" id="home">
                  Tổng quan
                </a>
              </li>
              <li>
                <a href="#">Thiết kế</a>
              </li>
              <li>
                <a href="#">Tiện nghi</a>
              </li>
              <li>
                <a href="#">An toàn</a>
              </li>
              <li>
                <a href="#">Thông số</a>
              </li>
              <li>
                <a href="#">Ưu đãi và dịch vụ</a>
              </li>
            </ul>
          </div>

          <section className="nav-left">
            <ul>
              <li>
                <h1 id="title">Tổng quan</h1>
              </li>
              <li>
                <a href="#" id="home1">
                  <i className="far fa-dot-circle"></i>
                  <span className="text-link">Điểm nổi bật của xe</span>
                </a>
              </li>

              <li>
                <a href="#">
                  <i className="far fa-dot-circle"></i>
                  <span className="text-link">Thiết kế</span>
                </a>
              </li>

              <li>
                <a href="#">
                  <i className="far fa-dot-circle"></i>
                  <span className="text-link">Tiện nghi</span>
                </a>
              </li>

              <li>
                <a href="#">
                  <i className="far fa-dot-circle"></i>
                  <span className="text-link">An toàn</span>
                </a>
              </li>

              <li>
                <a href="#">
                  <i className="far fa-dot-circle"></i>
                  <span className="text-link">Thông số</span>
                </a>
              </li>

              <li>
                <a href="#">
                  <i className="far fa-dot-circle"></i>
                  <span className="text-link">Cấu hình xe</span>
                </a>
              </li>
            </ul>
          </section>

          <section className="nav-right">
            <div id="list-1">
              <li className="list-nav-right">
                <a href="#">
                  <i className="fas fa-search-location"></i>
                  <span className="txt1">Tìm đại lí</span>
                </a>
              </li>
            </div>

            <div id="list-2">
              <li className="list-nav-right">
                <a href="#">
                  <i className="fas fa-spinner"></i>
                  <span className="txt2">Lái thử xe</span>
                </a>
              </li>
            </div>

            <div id="list-3">
              <li className="list-nav-right">
                <a href="#">
                  <i className="fas fa-phone"></i>
                  <span className="txt3">Nhận tư vấn</span>
                </a>
              </li>
            </div>

            <div id="list-4">
              <li className="list-nav-right">
                <a href="#">
                  <i className="fas fa-envelope"></i>
                  <span className="txt4">Chat</span>
                </a>
              </li>
            </div>
          </section>
        </div>
        <div className="introduce">
          <p className="p1a">Xe S-className Saloon.</p>
          <p>Cảm nhận tinh hoa công nghệ</p>
        </div>
      </header>
    );
  }
}
