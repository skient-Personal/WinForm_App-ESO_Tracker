using System;
using System.Collections.Generic;
using System.Text;

namespace WinForm_App_ESO_Tracker.DAL
{
    public class DBHelper
    {
        //Class variables.
        //Table Adapters
        esoDataSetTableAdapters.qry_BarTypesTableAdapter barTypesTA = new esoDataSetTableAdapters.qry_BarTypesTableAdapter();
        esoDataSetTableAdapters.qry_SelectedBuildTableAdapter selectedBuildTA = new esoDataSetTableAdapters.qry_SelectedBuildTableAdapter();
        esoDataSetTableAdapters.tbl_AlliancesTableAdapter alliancesTA = new esoDataSetTableAdapters.tbl_AlliancesTableAdapter();
        esoDataSetTableAdapters.tbl_BuildCpSetupTableAdapter buildCpSetupTA = new esoDataSetTableAdapters.tbl_BuildCpSetupTableAdapter();
        esoDataSetTableAdapters.tbl_BuildGearSetupTableAdapter buildGearSetupTA = new esoDataSetTableAdapters.tbl_BuildGearSetupTableAdapter();
        esoDataSetTableAdapters.tbl_BuildsTableAdapter buildsTA = new esoDataSetTableAdapters.tbl_BuildsTableAdapter();
        esoDataSetTableAdapters.tbl_CharactersTableAdapter charactersTA = new esoDataSetTableAdapters.tbl_CharactersTableAdapter();
        esoDataSetTableAdapters.tbl_CharacterAssignmentsTableAdapter characterAssignmentsTA = new esoDataSetTableAdapters.tbl_CharacterAssignmentsTableAdapter();
        esoDataSetTableAdapters.tbl_ClassesTableAdapter classesTA = new esoDataSetTableAdapters.tbl_ClassesTableAdapter();
        esoDataSetTableAdapters.tbl_FoodBevRecipiesTableAdapter foodBevRecipiesTA = new esoDataSetTableAdapters.tbl_FoodBevRecipiesTableAdapter();
        esoDataSetTableAdapters.tbl_GearTableAdapter gearTableTA = new esoDataSetTableAdapters.tbl_GearTableAdapter();
        esoDataSetTableAdapters.tbl_GearEnchantmentsTableAdapter gearEnchantmentsTA = new esoDataSetTableAdapters.tbl_GearEnchantmentsTableAdapter();
        esoDataSetTableAdapters.tbl_GearSetsTableAdapter gearSetsTA = new esoDataSetTableAdapters.tbl_GearSetsTableAdapter();
        esoDataSetTableAdapters.tbl_GearTraitsTableAdapter gearTraitsTA = new esoDataSetTableAdapters.tbl_GearTraitsTableAdapter();
        esoDataSetTableAdapters.tbl_GearTypeTableAdapter gearTypeTA = new esoDataSetTableAdapters.tbl_GearTypeTableAdapter();
        esoDataSetTableAdapters.tbl_IngredientEffectsTableAdapter ingredientEffectsTA = new esoDataSetTableAdapters.tbl_IngredientEffectsTableAdapter();
        esoDataSetTableAdapters.tbl_IngredientsTableAdapter ingredientsTypesTA = new esoDataSetTableAdapters.tbl_IngredientsTableAdapter();
        esoDataSetTableAdapters.tbl_MundusStonesTableAdapter mundusStonesTA = new esoDataSetTableAdapters.tbl_MundusStonesTableAdapter();
        esoDataSetTableAdapters.tbl_PoisonsTableAdapter poisonsTableTA = new esoDataSetTableAdapters.tbl_PoisonsTableAdapter();
        esoDataSetTableAdapters.tbl_PotionsTableAdapter potionsTableTA = new esoDataSetTableAdapters.tbl_PotionsTableAdapter();
        esoDataSetTableAdapters.tbl_RacesTableAdapter racesTableTA = new esoDataSetTableAdapters.tbl_RacesTableAdapter();
        esoDataSetTableAdapters.tbl_RolesTableAdapter rolesTableTA = new esoDataSetTableAdapters.tbl_RolesTableAdapter();
        esoDataSetTableAdapters.tbl_SkillLinesTableAdapter skillLinesTableTA = new esoDataSetTableAdapters.tbl_SkillLinesTableAdapter();
        esoDataSetTableAdapters.tbl_SkillLineTypesTableAdapter skillLineTypesTA = new esoDataSetTableAdapters.tbl_SkillLineTypesTableAdapter();
        esoDataSetTableAdapters.tbl_SkillsTableAdapter skillsTableTA = new esoDataSetTableAdapters.tbl_SkillsTableAdapter();
        esoDataSetTableAdapters.tbl_SkillTypeTableAdapter skillTypeTA = new esoDataSetTableAdapters.tbl_SkillTypeTableAdapter();

        //Constructors
        public DBHelper() { }

        //Class methods.
        public esoDataSet Connect_DB()
        {
            esoDataSet ds = new esoDataSet();

            barTypesTA.Fill(ds.qry_BarTypes);
            selectedBuildTA.Fill(ds.qry_SelectedBuild);
            alliancesTA.Fill(ds.tbl_Alliances);
            buildCpSetupTA.Fill(ds.tbl_BuildCpSetup);
            buildGearSetupTA.Fill(ds.tbl_BuildGearSetup);
            buildsTA.Fill(ds.tbl_Builds);
            characterAssignmentsTA.Fill(ds.tbl_CharacterAssignments);
            charactersTA.Fill(ds.tbl_Characters);
            classesTA.Fill(ds.tbl_Classes);
            foodBevRecipiesTA.Fill(ds.tbl_FoodBevRecipies);
            gearTableTA.Fill(ds.tbl_Gear);
            gearEnchantmentsTA.Fill(ds.tbl_GearEnchantments);
            gearSetsTA.Fill(ds.tbl_GearSets);
            gearTraitsTA.Fill(ds.tbl_GearTraits);
            gearTypeTA.Fill(ds.tbl_GearType);
            ingredientEffectsTA.Fill(ds.tbl_IngredientEffects);
            ingredientsTypesTA.Fill(ds.tbl_Ingredients);
            mundusStonesTA.Fill(ds.tbl_MundusStones);
            poisonsTableTA.Fill(ds.tbl_Poisons);
            potionsTableTA.Fill(ds.tbl_Potions);
            racesTableTA.Fill(ds.tbl_Races);
            rolesTableTA.Fill(ds.tbl_Roles);
            skillLinesTableTA.Fill(ds.tbl_SkillLines);
            skillLineTypesTA.Fill(ds.tbl_SkillLineTypes);
            skillsTableTA.Fill(ds.tbl_Skills);
            skillTypeTA.Fill(ds.tbl_SkillType);

            return ds;
        }
    }
}
