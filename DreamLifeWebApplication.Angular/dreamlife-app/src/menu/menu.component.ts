import { Component } from "@angular/core";

@Component({
    selector: 'menu-trips',
    templateUrl: './menu.component.html',
    styleUrls: ['./menu.component.css']
  })
  
  export class MenuComponent {
    public PlaceHolderIcon = require("./img/placeholder.svg");
    public CalendarIcon = require("./img/calendar-page-empty.svg");
    public ManUserIcon = require("./img/man-user.svg");
    public CrownIcon = require("./img/crown.svg");
    public CreditCardIcon = require("./img/credit-card.svg");
  }

  