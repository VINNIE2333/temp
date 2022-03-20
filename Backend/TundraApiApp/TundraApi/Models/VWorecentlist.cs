﻿using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VWorecentlist
    {
        public string WoNum { get; set; } = null!;
        public string? WoType { get; set; }
        public string? PmNum { get; set; }
        public string? ProcNum { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? TargetDate { get; set; }
        public DateTime? CompDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public string? Priority { get; set; }
        public decimal? StatusCode { get; set; }
        public string? Status { get; set; }
        public decimal? Duration { get; set; }
        public decimal Downtime { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public decimal AssignedHours { get; set; }
        public decimal EstCost { get; set; }
        public decimal EstHours { get; set; }
        public decimal EstLabor { get; set; }
        public decimal EstMaterial { get; set; }
        public decimal EstTools { get; set; }
        public decimal EstService { get; set; }
        public decimal ActHours { get; set; }
        public decimal ActLabor { get; set; }
        public decimal ActMaterial { get; set; }
        public decimal ActTools { get; set; }
        public decimal ActService { get; set; }
        public string? Requester { get; set; }
        public string? Contact { get; set; }
        public string? ContactPhone { get; set; }
        public string? Department { get; set; }
        public string? Manager { get; set; }
        public string? Craft { get; set; }
        public string? Employee { get; set; }
        public string? Crew { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Equipment { get; set; }
        public string? EquipmentDesc { get; set; }
        public string? Eqaddress1 { get; set; }
        public string? Eqaddress2 { get; set; }
        public string? Eqoperator { get; set; }
        public string? Room { get; set; }
        public string? Request { get; set; }
        public string? CompCode { get; set; }
        public string? CompRemark { get; set; }
        public decimal Inactive { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public string? FailureCode1 { get; set; }
        public string? FailureCode2 { get; set; }
        public string? FailureCode3 { get; set; }
        public string? ParentWo { get; set; }
        public string? ProjectId { get; set; }
        public string? Phase { get; set; }
        public string? ClientCode { get; set; }
        public decimal Chargeback { get; set; }
        public decimal Locked { get; set; }
        public DateTime? PostDate { get; set; }
        public string? Note1 { get; set; }
        public string? Note2 { get; set; }
        public string? Note3 { get; set; }
        public string? Note4 { get; set; }
        public string? Note5 { get; set; }
        public string? Note6 { get; set; }
        public string? Note7 { get; set; }
        public string? Note8 { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? PdmNum { get; set; }
        public DateTime? AccessDate { get; set; }
        public string? UserId { get; set; }
        public string? RouteName { get; set; }
        public string? Wo1 { get; set; }
        public string? Wo2 { get; set; }
        public string? Wo3 { get; set; }
        public string? Wo4 { get; set; }
        public string? Wo5 { get; set; }
        public decimal? Wo6 { get; set; }
        public decimal? Wo7 { get; set; }
        public decimal? Wo8 { get; set; }
        public decimal Note9 { get; set; }
        public decimal? Note10 { get; set; }
        public string? WosubType { get; set; }
        public string? CompShortDesc { get; set; }
        public string? Customer { get; set; }
        public string? SurfLsd { get; set; }
        public string? SurfSect { get; set; }
        public string? SurfTownShip { get; set; }
        public string? SurfRange { get; set; }
        public string? Dhlsd { get; set; }
        public string? Dhsect { get; set; }
        public string? DhtownShip { get; set; }
        public string? Dhrange { get; set; }
        public string? ThirdRequester { get; set; }
        public string? FourthRequester { get; set; }
        public string? FifthRequester { get; set; }
        public decimal EstMileage { get; set; }
        public decimal ActMileage { get; set; }
    }
}
