import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  constructor(private https: HttpClient) { }

  ngOnInit(): void {
    // this.https.get('https://localhost:5001/api/departments').subscribe({
    //   next: response => console.log(response)

    // })
  }
  title = 'client';
}
