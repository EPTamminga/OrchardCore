/// <reference types="Cypress" />

import { creds } from '../../support/objects';
describe('Setup SaaS', function() {
    it('Successfully setup the SaaS default tenant', function() {
        cy.visit('/');
        cy.setupSite({
            name: 'Orchard SaaS',
            setupRecipe: 'SaaS',
            ...creds
        });
    });

    //todo check title and menu maybe ?
});
