import { BreakpointObserver, BreakpointState } from '@angular/cdk/layout';
import { Component, EventEmitter, Output, Input } from '@angular/core';
import { MatDrawerMode } from '@angular/material/sidenav';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss']
})
export class SidenavComponent {
  @Input() isOpen!: boolean;
  @Output() isOpenChange = new EventEmitter<boolean>();
  @Output() toggleSidenav = new EventEmitter();
  mode: MatDrawerMode = 'side';

  constructor(private router: Router, private breakpointObserver: BreakpointObserver) { }

  ngOnInit() {
    this.breakpointObserver.observe(['(max-width: 550px)']).subscribe((state: BreakpointState) => {
      if (state.matches) {
        this.mode = 'over';
        this.isOpen = false;
      } else {
        this.mode = 'side';
        this.isOpen = false;
      }
    });
  }

  onDashboardClick() {
    this.router.navigate(['/dashboard']);
  }
}
