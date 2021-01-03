import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Alumni App';

  users: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
   this.getUsers();
  }

  getUsers() {
    this.http.get('https://localhost:5001/api/appUsers/').subscribe(Response =>{
     this.users = Response;
   }, error => {
     console.log(error);
   })
  }
}
