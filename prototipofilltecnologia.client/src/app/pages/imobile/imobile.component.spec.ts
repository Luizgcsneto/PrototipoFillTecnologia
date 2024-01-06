import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImobileComponent } from './imobile.component';

describe('ImobileComponent', () => {
  let component: ImobileComponent;
  let fixture: ComponentFixture<ImobileComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ImobileComponent]
    });
    fixture = TestBed.createComponent(ImobileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
