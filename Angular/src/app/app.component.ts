import { Component, OnInit } from '@angular/core';
import { Message, MessageService } from './message.service';
import { Observable } from 'rxjs/Observable';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  count = 1;
  value;
  constructor(public messageService: MessageService) { }
  ngOnInit() {
    this.loadMessages()
  }

  loadMessages() {
    this.messageService.getMessages().subscribe(
      data => {
        this.value = data;
      }
    )
  }
  onEnter(value: string) {
    let message = {};
    message['message'] = value;
    message['id'] = this.count++;
    this.messageService.postMessage(message).subscribe(data => {
      this.loadMessages()
    })
  }
}
