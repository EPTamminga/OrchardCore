/// <reference types="Cypress" />

import { agency } from '../../support/objects';

describe('Agency Tests', function() {
    it('Setup Agency tenant', function() {
        cy.login();
        cy.createTenant(agency);
        cy.gotoTenantSetup(agency);
        cy.setupSite(agency);
    });

    it('Displays Agency title properly', function() {
        cy.visit(agency.prefix);
        cy.get('.navbar-brand').should('contain.text', agency.name);
    });
});
