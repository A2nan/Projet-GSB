﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_GSB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NerdsUnitedEntities : DbContext
    {
        public NerdsUnitedEntities()
            : base("name=NerdsUnitedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<FAMILLE> FAMILLE { get; set; }
        public virtual DbSet<fichefrais> fichefrais { get; set; }
        public virtual DbSet<FraisForfait> FraisForfait { get; set; }
        public virtual DbSet<Laboratoire> Laboratoire { get; set; }
        public virtual DbSet<LigneFraisForfait> LigneFraisForfait { get; set; }
        public virtual DbSet<LigneFraisHorsForfait> LigneFraisHorsForfait { get; set; }
        public virtual DbSet<MEDECIN> MEDECIN { get; set; }
        public virtual DbSet<MEDICAMENT> MEDICAMENT { get; set; }
        public virtual DbSet<MOTIF> MOTIF { get; set; }
        public virtual DbSet<OFFRIR> OFFRIR { get; set; }
        public virtual DbSet<RAPPORT> RAPPORT { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Secteur> Secteur { get; set; }
        public virtual DbSet<SPECIALITE> SPECIALITE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Visiteur> Visiteur { get; set; }
    }
}
