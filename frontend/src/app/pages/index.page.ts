import { Component, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-home',
  template: `<pre>{{ data() }}</pre>`,
})
export class HomePage implements OnInit {
    data = signal<unknown | null>(null);

    async ngOnInit() {
      const res = await fetch('http://localhost:5000/weatherforecast/');
      this.data.set(await res.text()); 
  }
}
