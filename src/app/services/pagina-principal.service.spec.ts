import { TestBed } from '@angular/core/testing';

import { PaginaPrincipalService } from './pagina-principal.service';

describe('PaginaPrincipalServiceService', () => {
  let service: PaginaPrincipalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PaginaPrincipalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
